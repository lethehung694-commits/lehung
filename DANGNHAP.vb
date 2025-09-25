Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DANGNHAP
    Private Sub BTDANGNHAP_Click(sender As Object, e As EventArgs) Handles BTDANGNHAP.Click
        Dim user As String = TXTTAIKHOAN.Text
        Dim pass As String = TXTMATKHAU.Text


        If user = "" Or pass = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If user = "admin" And pass = "123" Then
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Mở form chính
            Dim frm As New TRANGCHU()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BTTHOAT_Click(sender As Object, e As EventArgs) Handles BTTHOAT.Click
        Application.Exit()
    End Sub
End Class