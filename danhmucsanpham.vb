Imports System.Data.SqlClient

Public Class danhmucsanpham
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

            sql = "SELECT * FROM dbo.DanhMucSanPham2"
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)

            DVGDANHMUC.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        TXTMA.Clear()
        TXTBAN.Clear()
        TXTNHAP.Clear()
        TXTSANPHAM.Clear()
        TXTMA.Focus()

    End Sub
    Private Sub quanydanhmucsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BTTHEM_Click(sender As Object, e As EventArgs) Handles BTTHEM.Click
        If TXTMA.Text = "" Or TXTSANPHAM.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "INSERT INTO dbo.DanhMucSanPham2 (MaSP, TenSp, GiaBan, GiaNhap) VALUES (@MaSP, @TenSP, @GiaNhap, @GiaBan)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaSP", TXTMA.Text)
            cmd.Parameters.AddWithValue("@TenSP", TXTSANPHAM.Text)
            cmd.Parameters.AddWithValue("@GiaNhap", TXTNHAP.Text)
            cmd.Parameters.AddWithValue("GiaBan", TXTBAN.Text)



            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo")

            conn.Close()
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub BTSUA_Click(sender As Object, e As EventArgs) Handles BTSUA.Click
        If TXTMA.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "UPDATE dbo.DanhMucSanPham2 SET TeSP=@TenSP, GiaNhap=@GiaNhap, GiaBan=@GiaBan, WHERE MaSP=@MaSP"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaSP", TXTMA.Text)
            cmd.Parameters.AddWithValue("@TenSP", TXTSANPHAM.Text)
            cmd.Parameters.AddWithValue("@GiaNhap", TXTNHAP.Text)
            cmd.Parameters.AddWithValue("@GiaBan", TXTBAN.Text)


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
        If TXTMA.Text = "" Then
            MessageBox.Show("Vui lòng chọn sanr phẩm cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn = New SqlConnection(connectionString)
                conn.Open()

                sql = "DELETE FROM dbo.DanhMucSanPham2 WHERE MaSP=@MaSP"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSP", TXTMA.Text)
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
    Private Sub DVGDANHMUC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGDANHMUC.CellContentClick
        Try
            Dim i As Integer = DVGDANHMUC.CurrentRow.Index
            TXTMA.Text = DVGDANHMUC.Item(0, i).Value.ToString()
            TXTSANPHAM.Text = DVGDANHMUC.Item(1, i).Value.ToString()
            TXTNHAP.Text = DVGDANHMUC.Item(2, i).Value.ToString()
            TXTBAN.Text = DVGDANHMUC.Item(3, i).Value.ToString()

        Catch ex As Exception
            ' Nếu click vào vùng trống sẽ không lỗi
        End Try
    End Sub
    Private Sub BTXUAT_Click(sender As Object, e As EventArgs) Handles BTXUAT.Click
        If String.IsNullOrWhiteSpace(TXTMA.Text) Then
            MessageBox.Show("Vui lòng nhập Mã SẢN PHẨM trước khi xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTMA.Focus()
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Câu lệnh SQL để tìm cửa hàng theo Mã CH
                sql = "SELECT * FROM DanhMucSanPham2 WHERE MaSP = @MaSP"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSP", TXTMA.Text)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Nếu không có dữ liệu thì thông báo
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy SẢN PHẨM với Mã KH này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DVGDANHMUC.DataSource = Nothing
                    Else
                        ' Hiển thị dữ liệu ra DataGridView
                        DVGDANHMUC.DataSource = dt
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