Imports System.Data.SqlClient

Public Class POS
    Private connectionString As String = "Server=LEHUNG;Database=taphoa;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Thiết lập DataGridView
        DVGPOS.ColumnCount = 4
        DVGPOS.Columns(0).Name = "Mã SP"
        DVGPOS.Columns(1).Name = "Số lượng"
        DVGPOS.Columns(2).Name = "Giá bán"
        DVGPOS.Columns(3).Name = "Mã NV"

        DVGPOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Thiết lập ListView để hiển thị tổng tiền
        LTONGTIEN.View = View.Details
        LTONGTIEN.Columns.Add("Tổng tiền", 200)
    End Sub

    Private Sub TXTSCAN_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTSCAN.KeyDown
        If e.KeyCode = Keys.Enter Then
            XuLyNhapSanPham()
        End If
    End Sub
    Private Sub BTNHAP_Click(sender As Object, e As EventArgs) Handles BTNHAP.Click
        XuLyNhapSanPham()
    End Sub
    Private Sub XuLyNhapSanPham()
        Dim maSP As String = TXTSCAN.Text.Trim()

        If String.IsNullOrEmpty(maSP) Then
            MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LayDuLieuSanPham(maSP)

        ' Xóa ô nhập và focus lại
        TXTSCAN.Clear()
        TXTSCAN.Focus()
    End Sub
    Private Sub LayDuLieuSanPham(MaSp As String)
        Dim query As String = "
            SELECT TOP 1 
                pnk.MaSP,
                pnk.SoLuong,
                sp.GiaBan,
                pnk.MaNV
            FROM PhieuNhapKho2 AS pnk
            INNER JOIN DanhMucSanPham2 AS sp ON pnk.MaSP = sp.MaSP
            WHERE pnk.MaSP = @MaSP
            ORDER BY pnk.NgayNhap DESC
        "

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaSP", MaSp)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim maspValue As String = reader("MaSP").ToString()
                            Dim soLuongValue As Integer = Convert.ToInt32(reader("SoLuong"))
                            Dim giaBanValue As Decimal = Convert.ToDecimal(reader("GiaBan"))
                            Dim maNVValue As String = reader("MaNV").ToString()

                            ' Kiểm tra nếu sản phẩm đã có thì cộng dồn số lượng
                            Dim found As Boolean = False
                            For Each row As DataGridViewRow In DVGPOS.Rows
                                If Not row.IsNewRow AndAlso row.Cells("Mã SP").Value IsNot Nothing AndAlso row.Cells("Mã SP").Value.ToString() = maspValue Then
                                    Dim cur As Integer = Convert.ToInt32(row.Cells("Số lượng").Value)
                                    row.Cells("Số lượng").Value = cur + soLuongValue
                                    found = True
                                    Exit For
                                End If
                            Next

                            ' Nếu chưa có thì thêm dòng mới
                            If Not found Then
                                DVGPOS.Rows.Add(maspValue, soLuongValue, giaBanValue, maNVValue)
                            End If
                        Else
                            MessageBox.Show("Không tìm thấy sản phẩm: " & MaSp, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi truy vấn hoặc kết nối SQL: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ===== Nút Thanh Toán - tính tổng tiền và hiển thị ra ListView =====
    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles BTTHANH.Click
        Dim tongTien As Decimal = 0D

        For Each row As DataGridViewRow In DVGPOS.Rows
            If Not row.IsNewRow Then
                Dim sl As Decimal = Convert.ToDecimal(row.Cells("Số lượng").Value)
                Dim gb As Decimal = Convert.ToDecimal(row.Cells("Giá bán").Value)
                tongTien += sl * gb
            End If
        Next

        ' Hiển thị tổng tiền ra ListView
        LTONGTIEN.Items.Clear()
        LTONGTIEN.Items.Add(tongTien.ToString("N0") & " VND")
    End Sub

    Private Sub BTE_Click(sender As Object, e As EventArgs) Handles BTE.Click
        Dim f As New TRANGCHU
        f.Show()
        Me.Hide()
    End Sub
End Class