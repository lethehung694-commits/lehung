Imports System.Data.SqlClient

Public Class TRANGCHU
    Private Sub BTCUAHANG_Click(sender As Object, e As EventArgs) Handles BTCUAHANG.Click
        Dim S As New QUẢN_LÝ_CỦA_HÀNG
        S.Show()
        Me.Hide()
    End Sub




    Private Sub BTNHANVIEN_Click(sender As Object, e As EventArgs) Handles BTNHANVIEN.Click
        Dim f As New quanlynhanvien
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New DANGNHAP
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BTKHACHHANG_Click(sender As Object, e As EventArgs) Handles BTKHACHHANG.Click
        Dim f As New Form2
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BTSANPHAM_Click(sender As Object, e As EventArgs) Handles BTSANPHAM.Click
        Dim f As New danhmucsanpham
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BTKHO_Click(sender As Object, e As EventArgs) Handles BTKHO.Click
        Dim f As New kho
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BTPOS_Click(sender As Object, e As EventArgs) Handles BTPOS.Click
        Dim f As New POS
        f.Show()
        Me.Hide()
    End Sub
End Class