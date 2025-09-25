Imports System.Data.SqlClient

Public Class kho
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim connectionString As String = "Server=LEHUNG;Database=taphoa;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    ' Đối tượng kết nối và làm việc với CSDL
    Private Sub LoadData()
        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "SELECT * FROM dbo.PhieuNhapKho2"
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)

            DVGKHO.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        TXTNGAY.Clear()
        TXTNHANVIEN.Clear()
        TXTSOLUONG.Clear()
        txtmasp.Clear()
        TXTNCC.Clear()
        TXTNGAY.Focus()

    End Sub
    Private Sub quanydanhmucsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BTNTHEM_Click(sender As Object, e As EventArgs) Handles BTNTHEM.Click
        If txtmasp.Text = "" Or TXTNHANVIEN.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "INSERT INTO dbo.PhieuNhapKho2(NgayNhap, MaNV, MaNCC, MaSP, SoLuong) VALUES (@NgayNhap, @MaNV, @MaNCC,@MaSP,@SoLuong)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@NgayNhap", TXTNGAY.Text)
            cmd.Parameters.AddWithValue("@MaNV", TXTNHANVIEN.Text)
            cmd.Parameters.AddWithValue("@MaNCC", TXTNCC.Text)
            cmd.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            cmd.Parameters.AddWithValue("@SoLuong", TXTSOLUONG.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo")

            conn.Close()
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu: " & ex.Message)
        End Try
    End Sub


    Private Sub TXTSOLUONG_TextChanged(sender As Object, e As EventArgs) Handles TXTSOLUONG.TextChanged, txtmasp.TextChanged

    End Sub

    Private Sub BTNSUA_Click(sender As Object, e As EventArgs) Handles BTNSUA.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "UPDATE dbo.PhieuNhapKho2 SET NgayNhap=@NgayNhap, MaNV=@MaNV, MaNCC=@MaNCC,SoLuong=@SoLuong, WHERE MaSP=@MaSP"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@NgayNhap", TXTNGAY.Text)
            cmd.Parameters.AddWithValue("@MaNV", TXTNHANVIEN.Text)
            cmd.Parameters.AddWithValue("@MaNCC", TXTNCC.Text)
            cmd.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            cmd.Parameters.AddWithValue("@SoLuong", TXTSOLUONG.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo")

            conn.Close()
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNXOA_Click(sender As Object, e As EventArgs) Handles BTNXOA.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Vui lòng chọn sanr phẩm cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn = New SqlConnection(connectionString)
                conn.Open()

                sql = "DELETE FROM dbo.PhieuNhapKho2 WHERE MaSP=@MaSP"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSP", txtmasp.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Xóa thành công!", "Thông báo")

                conn.Close()
                LoadData()
                ClearFields()

            Catch ex As Exception
                MessageBox.Show("Lỗi xóa dữ liệu: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub DVGKHO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGKHO.CellContentClick
        Try
            Dim i As Integer = DVGKHO.CurrentRow.Index
            TXTNGAY.Text = DVGKHO.Item(0, i).Value.ToString()
            TXTNHANVIEN.Text = DVGKHO.Item(1, i).Value.ToString()
            TXTNCC.Text = DVGKHO.Item(2, i).Value.ToString()
            txtmasp.Text = DVGKHO.Item(3, i).Value.ToString()
            TXTSOLUONG.Text = DVGKHO.Item(4, i).Value.ToString()
        Catch ex As Exception
            ' Nếu click vào vùng trống sẽ không lỗi
        End Try

    End Sub
    Private Sub BTNXUAT_Click(sender As Object, e As EventArgs) Handles BTNXUAT.Click
        If String.IsNullOrWhiteSpace(txtmasp.Text) Then
            MessageBox.Show("Vui lòng nhập Mã SẢN PHẨM trước khi xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmasp.Focus()
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Câu lệnh SQL để tìm cửa hàng theo Mã CH
                sql = "SELECT * FROM PhieuNhapKho2 WHERE MaSP = @MaSP"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSP", txtmasp.Text)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Nếu không có dữ liệu thì thông báo
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy SẢN PHẨM với Mã KH này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DVGKHO.DataSource = Nothing
                    Else
                        ' Hiển thị dữ liệu ra DataGridView
                        DVGKHO.DataSource = dt
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xuất dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VTNEXT_Click(sender As Object, e As EventArgs) Handles VTNEXT.Click
        Dim f As New TRANGCHU
        f.Show()
        Me.Hide()
    End Sub
End Class