Imports System.Data.SqlClient

Public Class Form2
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

            sql = "SELECT * FROM dbo.KhachHang2"
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)

            DVGKHACHHANG.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        TXTMAKH.Clear()
        TXTHOTEN.Clear()
        TXTSDT.Clear()
        TXTDIEMTICHLUY.Clear()
        TXTMAKH.Focus()

    End Sub
    Private Sub quanynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BTTHEM_Click(sender As Object, e As EventArgs) Handles BTTHEM.Click
        If TXTMAKH.Text = "" Or TXTHOTEN.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "INSERT INTO dbo.KhachHang2 (Makh, HoTen, SDT, DiemTichLuy) VALUES (@MaKH, @HoTen, @SDT, @DiemTichLuy)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaKH", TXTMAKH.Text)
            cmd.Parameters.AddWithValue("@HoTen", TXTHOTEN.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@DiemTichLuy", TXTDIEMTICHLUY.Text)



            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm cửa hàng thành công!", "Thông báo")

            conn.Close()
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub BTSUA_Click(sender As Object, e As EventArgs) Handles BTSUA.Click
        If TXTMAKH.Text = "" Then
            MessageBox.Show("Vui lòng chọn cửa hàng cần sửa!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "UPDATE dbo.KhachHang2 SET HoTen=@HoTen, SDT=@SDT, DiemTichLuy=@DiemTichLuy, WHERE MaKH=@MaKH"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaKH", TXTMAKH.Text)
            cmd.Parameters.AddWithValue("@HoTen", TXTHOTEN.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@DiemTichLuy", TXTDIEMTICHLUY.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo")

            conn.Close()
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub BTXOA_Click(sender As Object, e As EventArgs) Handles BTXOA.Click
        If TXTMAKH.Text = "" Then
            MessageBox.Show("Vui lòng chọn khách hàng cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn = New SqlConnection(connectionString)
                conn.Open()

                sql = "DELETE FROM dbo.KhachHang2 WHERE MaKH=@MaKH"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaKH", TXTMAKH.Text)
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
    Private Sub DVGKHACHHANG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGKHACHHANG.CellContentClick
        Try
            Dim i As Integer = DVGKHACHHANG.CurrentRow.Index
            TXTMAKH.Text = DVGKHACHHANG.Item(0, i).Value.ToString()
            TXTHOTEN.Text = DVGKHACHHANG.Item(1, i).Value.ToString()
            TXTSDT.Text = DVGKHACHHANG.Item(2, i).Value.ToString()
            TXTDIEMTICHLUY.Text = DVGKHACHHANG.Item(3, i).Value.ToString()

        Catch ex As Exception
            ' Nếu click vào vùng trống sẽ không lỗi
        End Try
    End Sub
    Private Sub BTXUAT_Click(sender As Object, e As EventArgs) Handles BTXUAT.Click
        If String.IsNullOrWhiteSpace(TXTMAKH.Text) Then
            MessageBox.Show("Vui lòng nhập Mã KHÁCH HÀNG trước khi xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTMAKH.Focus()
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Câu lệnh SQL để tìm cửa hàng theo Mã CH
                sql = "SELECT * FROM KhachHang2 WHERE MaKH = @MaKH"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaKH", TXTMAKH.Text)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Nếu không có dữ liệu thì thông báo
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy KHÁCH HÀNG với Mã KH này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DVGKHACHHANG.DataSource = Nothing
                    Else
                        ' Hiển thị dữ liệu ra DataGridView
                        DVGKHACHHANG.DataSource = dt
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xuất dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTEXIT_Click(sender As Object, e As EventArgs) Handles BTEXIT.Click
        Dim f As New TRANGCHU
        f.Show()
        Me.Hide()
    End Sub
End Class