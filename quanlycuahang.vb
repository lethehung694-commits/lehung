
Imports System.Data.SqlClient

Public Class QUẢN_LÝ_CỦA_HÀNG
    ' Khai báo biến kết nối SQL Server
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

            sql = "SELECT * FROM dbo.CuaHang2"
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)

            DVGCUAHANG.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        TXTMACH.Clear()
        TXTTENCH.Clear()
        TXTDIACHI.Clear()
        TXTSDT.Clear()
        TXTMACH.Focus()
        TXTQUANLY.Clear()
    End Sub
    Private Sub quanycuahang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BTTHEM_Click(sender As Object, e As EventArgs) Handles BTTHEM.Click
        If TXTMACH.Text = "" Or TXTTENCH.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "INSERT INTO dbo.CuaHang2 (MaCH, TenCH, DiaChi, SDT, QuanLy) VALUES (@MaCH, @TenCH, @DiaChi, @SDT, @QuanLy)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaCH", TXTMACH.Text)
            cmd.Parameters.AddWithValue("@TenCH", TXTTENCH.Text)
            cmd.Parameters.AddWithValue("@DiaChi", TXTDIACHI.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@QuanLy", TXTQUANLY.Text)


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
        If TXTMACH.Text = "" Then
            MessageBox.Show("Vui lòng chọn cửa hàng cần sửa!")
            Return
        End If

        Try
            conn = New SqlConnection(connectionString)
            conn.Open()

            sql = "UPDATE dbo.CuaHang2 SET TenCH=@TenCH, DiaChi=@DiaChi, SDT=@SDT, QuanLy=@QuanLy WHERE MaCH=@MaCH"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@MaCH", TXTMACH.Text)
            cmd.Parameters.AddWithValue("@TenCH", TXTTENCH.Text)
            cmd.Parameters.AddWithValue("@DiaChi", TXTDIACHI.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@QuanLy", TXTQUANLY.Text)

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
        If TXTMACH.Text = "" Then
            MessageBox.Show("Vui lòng chọn cửa hàng cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa cửa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn = New SqlConnection(connectionString)
                conn.Open()

                sql = "DELETE FROM dbo.CuaHang2 WHERE MaCH=@MaCH"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaCH", TXTMACH.Text)
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

    Private Sub DVGCUAHANG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGCUAHANG.CellContentClick
        Try
            Dim i As Integer = DVGCUAHANG.CurrentRow.Index
            TXTMACH.Text = DVGCUAHANG.Item(0, i).Value.ToString()
            TXTTENCH.Text = DVGCUAHANG.Item(1, i).Value.ToString()
            TXTDIACHI.Text = DVGCUAHANG.Item(2, i).Value.ToString()
            TXTSDT.Text = DVGCUAHANG.Item(3, i).Value.ToString()
            TXTQUANLY.Text = DVGCUAHANG.Item(4, i).Value.ToString()
        Catch ex As Exception
            ' Nếu click vào vùng trống sẽ không lỗi
        End Try
    End Sub

    Private Sub BTLUU_Click(sender As Object, e As EventArgs) Handles BTLUU.Click

        If String.IsNullOrWhiteSpace(TXTMACH.Text) Then
            MessageBox.Show("Vui lòng nhập Mã cửa hàng trước khi xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTMACH.Focus()
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Câu lệnh SQL để tìm cửa hàng theo Mã CH
                sql = "SELECT * FROM CuaHang2 WHERE MaCH = @MaCH"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaCH", TXTMACH.Text)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Nếu không có dữ liệu thì thông báo
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy cửa hàng với Mã CH này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DVGCUAHANG.DataSource = Nothing
                    Else
                        ' Hiển thị dữ liệu ra DataGridView
                        DVGCUAHANG.DataSource = dt
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xuất dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New TRANGCHU
        f.Show()
        Me.Hide()
    End Sub
End Class


