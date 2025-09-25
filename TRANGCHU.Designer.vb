<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TRANGCHU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTCUAHANG = New System.Windows.Forms.Button()
        Me.BTNHANVIEN = New System.Windows.Forms.Button()
        Me.BTKHACHHANG = New System.Windows.Forms.Button()
        Me.BTSANPHAM = New System.Windows.Forms.Button()
        Me.BTKHO = New System.Windows.Forms.Button()
        Me.BTPOS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANG CHỦ"
        '
        'BTCUAHANG
        '
        Me.BTCUAHANG.Location = New System.Drawing.Point(43, 109)
        Me.BTCUAHANG.Name = "BTCUAHANG"
        Me.BTCUAHANG.Size = New System.Drawing.Size(142, 121)
        Me.BTCUAHANG.TabIndex = 1
        Me.BTCUAHANG.Text = "QUẢN LÝ CỬA HÀNG "
        Me.BTCUAHANG.UseVisualStyleBackColor = True
        '
        'BTNHANVIEN
        '
        Me.BTNHANVIEN.Location = New System.Drawing.Point(332, 109)
        Me.BTNHANVIEN.Name = "BTNHANVIEN"
        Me.BTNHANVIEN.Size = New System.Drawing.Size(142, 121)
        Me.BTNHANVIEN.TabIndex = 1
        Me.BTNHANVIEN.Text = "QUẢN KÝ NHÂN VIÊN"
        Me.BTNHANVIEN.UseVisualStyleBackColor = True
        '
        'BTKHACHHANG
        '
        Me.BTKHACHHANG.Location = New System.Drawing.Point(617, 109)
        Me.BTKHACHHANG.Name = "BTKHACHHANG"
        Me.BTKHACHHANG.Size = New System.Drawing.Size(142, 121)
        Me.BTKHACHHANG.TabIndex = 1
        Me.BTKHACHHANG.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.BTKHACHHANG.UseVisualStyleBackColor = True
        '
        'BTSANPHAM
        '
        Me.BTSANPHAM.Location = New System.Drawing.Point(617, 257)
        Me.BTSANPHAM.Name = "BTSANPHAM"
        Me.BTSANPHAM.Size = New System.Drawing.Size(142, 121)
        Me.BTSANPHAM.TabIndex = 1
        Me.BTSANPHAM.Text = "SẢN PHẨM"
        Me.BTSANPHAM.UseVisualStyleBackColor = True
        '
        'BTKHO
        '
        Me.BTKHO.Location = New System.Drawing.Point(43, 257)
        Me.BTKHO.Name = "BTKHO"
        Me.BTKHO.Size = New System.Drawing.Size(142, 121)
        Me.BTKHO.TabIndex = 1
        Me.BTKHO.Text = "KHO"
        Me.BTKHO.UseVisualStyleBackColor = True
        '
        'BTPOS
        '
        Me.BTPOS.Location = New System.Drawing.Point(332, 257)
        Me.BTPOS.Name = "BTPOS"
        Me.BTPOS.Size = New System.Drawing.Size(142, 121)
        Me.BTPOS.TabIndex = 1
        Me.BTPOS.Text = "POS-BÁN HÀNG"
        Me.BTPOS.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TRANGCHU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTPOS)
        Me.Controls.Add(Me.BTSANPHAM)
        Me.Controls.Add(Me.BTKHO)
        Me.Controls.Add(Me.BTKHACHHANG)
        Me.Controls.Add(Me.BTNHANVIEN)
        Me.Controls.Add(Me.BTCUAHANG)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TRANGCHU"
        Me.Text = "TRANGCHU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTCUAHANG As Button
    Friend WithEvents BTNHANVIEN As Button
    Friend WithEvents BTKHACHHANG As Button
    Friend WithEvents BTSANPHAM As Button
    Friend WithEvents BTKHO As Button
    Friend WithEvents BTPOS As Button
    Friend WithEvents Button1 As Button
End Class
