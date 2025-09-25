<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DANGNHAP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTTAIKHOAN = New System.Windows.Forms.TextBox()
        Me.TXTMATKHAU = New System.Windows.Forms.TextBox()
        Me.BTDANGNHAP = New System.Windows.Forms.Button()
        Me.BTTHOAT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANG ĐĂNG NHẬP "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TÀI KHOẢN "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MẬT KHẨU  "
        '
        'TXTTAIKHOAN
        '
        Me.TXTTAIKHOAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTAIKHOAN.Location = New System.Drawing.Point(260, 118)
        Me.TXTTAIKHOAN.Name = "TXTTAIKHOAN"
        Me.TXTTAIKHOAN.Size = New System.Drawing.Size(445, 41)
        Me.TXTTAIKHOAN.TabIndex = 2
        '
        'TXTMATKHAU
        '
        Me.TXTMATKHAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMATKHAU.Location = New System.Drawing.Point(260, 182)
        Me.TXTMATKHAU.Name = "TXTMATKHAU"
        Me.TXTMATKHAU.Size = New System.Drawing.Size(445, 41)
        Me.TXTMATKHAU.TabIndex = 2
        '
        'BTDANGNHAP
        '
        Me.BTDANGNHAP.Location = New System.Drawing.Point(136, 321)
        Me.BTDANGNHAP.Name = "BTDANGNHAP"
        Me.BTDANGNHAP.Size = New System.Drawing.Size(195, 117)
        Me.BTDANGNHAP.TabIndex = 3
        Me.BTDANGNHAP.Text = "DANGNHAP"
        Me.BTDANGNHAP.UseVisualStyleBackColor = True
        '
        'BTTHOAT
        '
        Me.BTTHOAT.Location = New System.Drawing.Point(542, 321)
        Me.BTTHOAT.Name = "BTTHOAT"
        Me.BTTHOAT.Size = New System.Drawing.Size(191, 117)
        Me.BTTHOAT.TabIndex = 3
        Me.BTTHOAT.Text = "THOÁT"
        Me.BTTHOAT.UseVisualStyleBackColor = True
        '
        'DANGNHAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTTHOAT)
        Me.Controls.Add(Me.BTDANGNHAP)
        Me.Controls.Add(Me.TXTMATKHAU)
        Me.Controls.Add(Me.TXTTAIKHOAN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DANGNHAP"
        Me.Text = "DANGNHAP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTTAIKHOAN As TextBox
    Friend WithEvents TXTMATKHAU As TextBox
    Friend WithEvents BTDANGNHAP As Button
    Friend WithEvents BTTHOAT As Button
End Class
