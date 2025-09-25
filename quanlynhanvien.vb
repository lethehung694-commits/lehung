Imports System.Data.SqlClient

Public Class quanlynhanvien
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    ' Chuỗi kết nối SQL Server
    Dim connectionString As String = "Server=LEHUNG;Database=taphoa;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    ' Đối tượng kết nối và làm việc với CSDL
    Private Sub LoadData()
        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "SELECT * FROM dbo.NhanVien2"
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)

            DVGNHANVIEN.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        TXTMANV.Clear()
        TXTTEN.Clear()
        TXTCHUCVU.Clear()
        TXTLUONG.Clear()
        TXTMANV.Focus()
        TXTNGAYSINH.Clear()
    End Sub
    Private Sub quanynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGNHANVIEN.CellContentClick

    End Sub

    Private Sub TXTCHUCVU_TextChanged(sender As Object, e As EventArgs) Handles TXTCHUCVU.TextChanged, TXTLUONG.TextChanged

    End Sub

    Private Sub BTTHEM_Click(sender As Object, e As EventArgs) Handles BTTHEM.Click
        If TXTMANV.Text = "" Or TXTTEN.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "INSERT INTO dbo.NhanVien2 (MaNV, TenNV, ChucVu, Luong, NgaySinh) VALUES (@MaCH, @TenCH, @DiaChi, @SDT, @QuanLy)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaNV", TXTMANV.Text)
            cmd.Parameters.AddWithValue("@TenNV", TXTTEN.Text)
            cmd.Parameters.AddWithValue("@ChucVu", TXTCHUCVU.Text)
            cmd.Parameters.AddWithValue("@luong", TXTLUONG.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", TXTNGAYSINH.Text)


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
        If TXTMANV.Text = "" Then
            MessageBox.Show("Vui lòng chọn cửa hàng cần sửa!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "UPDATE dbo.NhanVien2 SET TenNV=@TenNV, ChucVu=@ChucVu, Luong=@Luong, NgaySinh=@NgaySinh WHERE MaNV=@MaNV"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaNV", TXTMANV.Text)
            cmd.Parameters.AddWithValue("@TenNV", TXTTEN.Text)
            cmd.Parameters.AddWithValue("ChucVu", TXTCHUCVU.Text)
            cmd.Parameters.AddWithValue("@Luong", TXTLUONG.Text)
            cmd.Parameters.AddWithValue("@Ngáyinh", TXTNGAYSINH.Text)

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
        If TXTMANV.Text = "" Then
            MessageBox.Show("Vui lòng chọn cửa hàng cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa cửa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn = New SqlConnection(connectionString)
                conn.Open()

                sql = "DELETE FROM dbo.NhanVien2 WHERE MaNV=@MaNV"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaNV", TXTMANV.Text)
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
    Private Sub DVGNHANVIEN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGNHANVIEN.CellContentClick
        Try
            Dim i As Integer = DVGNHANVIEN.CurrentRow.Index
            TXTMANV.Text = DVGNHANVIEN.Item(0, i).Value.ToString()
            TXTTEN.Text = DVGNHANVIEN.Item(1, i).Value.ToString()
            TXTCHUCVU.Text = DVGNHANVIEN.Item(2, i).Value.ToString()
            TXTLUONG.Text = DVGNHANVIEN.Item(3, i).Value.ToString()
            TXTNGAYSINH.Text = DVGNHANVIEN.Item(4, i).Value.ToString()
        Catch ex As Exception
            ' Nếu click vào vùng trống sẽ không lỗi
        End Try
    End Sub

    Private Sub BTXUAT_Click(sender As Object, e As EventArgs) Handles BTXUAT.Click
        If String.IsNullOrWhiteSpace(TXTMANV.Text) Then
            MessageBox.Show("Vui lòng nhập Mã cửa hàng trước khi xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTMANV.Focus()
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Câu lệnh SQL để tìm cửa hàng theo Mã CH
                sql = "SELECT * FROM NhanVien2 WHERE MaNV = @MaNV"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaNV", TXTMANV.Text)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Nếu không có dữ liệu thì thông báo
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy cửa hàng với Mã NV này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DVGNHANVIEN.DataSource = Nothing
                    Else
                        ' Hiển thị dữ liệu ra DataGridView
                        DVGNHANVIEN.DataSource = dt
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