<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kho
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
        Me.DVGKHO = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTNGAY = New System.Windows.Forms.TextBox()
        Me.TXTNHANVIEN = New System.Windows.Forms.TextBox()
        Me.TXTNCC = New System.Windows.Forms.TextBox()
        Me.TXTSOLUONG = New System.Windows.Forms.TextBox()
        Me.BTNTHEM = New System.Windows.Forms.Button()
        Me.BTNSUA = New System.Windows.Forms.Button()
        Me.BTNXOA = New System.Windows.Forms.Button()
        Me.BTNXUAT = New System.Windows.Forms.Button()
        Me.VTNEXT = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        CType(Me.DVGKHO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ KHO "
        '
        'DVGKHO
        '
        Me.DVGKHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGKHO.Location = New System.Drawing.Point(10, 80)
        Me.DVGKHO.Name = "DVGKHO"
        Me.DVGKHO.RowHeadersWidth = 51
        Me.DVGKHO.RowTemplate.Height = 24
        Me.DVGKHO.Size = New System.Drawing.Size(566, 222)
        Me.DVGKHO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(582, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NGÀY "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NHÂN VIÊN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(582, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NCC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(582, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SỐ LƯỢNG"
        '
        'TXTNGAY
        '
        Me.TXTNGAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNGAY.Location = New System.Drawing.Point(779, 80)
        Me.TXTNGAY.Name = "TXTNGAY"
        Me.TXTNGAY.Size = New System.Drawing.Size(292, 34)
        Me.TXTNGAY.TabIndex = 3
        '
        'TXTNHANVIEN
        '
        Me.TXTNHANVIEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNHANVIEN.Location = New System.Drawing.Point(779, 120)
        Me.TXTNHANVIEN.Name = "TXTNHANVIEN"
        Me.TXTNHANVIEN.Size = New System.Drawing.Size(292, 34)
        Me.TXTNHANVIEN.TabIndex = 3
        '
        'TXTNCC
        '
        Me.TXTNCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNCC.Location = New System.Drawing.Point(779, 175)
        Me.TXTNCC.Name = "TXTNCC"
        Me.TXTNCC.Size = New System.Drawing.Size(292, 34)
        Me.TXTNCC.TabIndex = 3
        '
        'TXTSOLUONG
        '
        Me.TXTSOLUONG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSOLUONG.Location = New System.Drawing.Point(779, 228)
        Me.TXTSOLUONG.Name = "TXTSOLUONG"
        Me.TXTSOLUONG.Size = New System.Drawing.Size(292, 34)
        Me.TXTSOLUONG.TabIndex = 3
        '
        'BTNTHEM
        '
        Me.BTNTHEM.Location = New System.Drawing.Point(418, 356)
        Me.BTNTHEM.Name = "BTNTHEM"
        Me.BTNTHEM.Size = New System.Drawing.Size(116, 54)
        Me.BTNTHEM.TabIndex = 4
        Me.BTNTHEM.Text = "THÊM"
        Me.BTNTHEM.UseVisualStyleBackColor = True
        '
        'BTNSUA
        '
        Me.BTNSUA.Location = New System.Drawing.Point(605, 356)
        Me.BTNSUA.Name = "BTNSUA"
        Me.BTNSUA.Size = New System.Drawing.Size(116, 54)
        Me.BTNSUA.TabIndex = 4
        Me.BTNSUA.Text = "SỬA"
        Me.BTNSUA.UseVisualStyleBackColor = True
        '
        'BTNXOA
        '
        Me.BTNXOA.Location = New System.Drawing.Point(779, 356)
        Me.BTNXOA.Name = "BTNXOA"
        Me.BTNXOA.Size = New System.Drawing.Size(116, 54)
        Me.BTNXOA.TabIndex = 4
        Me.BTNXOA.Text = "XÓA"
        Me.BTNXOA.UseVisualStyleBackColor = True
        '
        'BTNXUAT
        '
        Me.BTNXUAT.Location = New System.Drawing.Point(955, 356)
        Me.BTNXUAT.Name = "BTNXUAT"
        Me.BTNXUAT.Size = New System.Drawing.Size(116, 54)
        Me.BTNXUAT.TabIndex = 4
        Me.BTNXUAT.Text = "XUẤT"
        Me.BTNXUAT.UseVisualStyleBackColor = True
        '
        'VTNEXT
        '
        Me.VTNEXT.Location = New System.Drawing.Point(33, 356)
        Me.VTNEXT.Name = "VTNEXT"
        Me.VTNEXT.Size = New System.Drawing.Size(247, 54)
        Me.VTNEXT.TabIndex = 4
        Me.VTNEXT.Text = "EXIT"
        Me.VTNEXT.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(585, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ma SP"
        '
        'txtmasp
        '
        Me.txtmasp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasp.Location = New System.Drawing.Point(779, 270)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(292, 34)
        Me.txtmasp.TabIndex = 3
        '
        'kho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 450)
        Me.Controls.Add(Me.BTNXUAT)
        Me.Controls.Add(Me.BTNXOA)
        Me.Controls.Add(Me.BTNSUA)
        Me.Controls.Add(Me.VTNEXT)
        Me.Controls.Add(Me.BTNTHEM)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.TXTSOLUONG)
        Me.Controls.Add(Me.TXTNCC)
        Me.Controls.Add(Me.TXTNHANVIEN)
        Me.Controls.Add(Me.TXTNGAY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DVGKHO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kho"
        Me.Text = "kho"
        CType(Me.DVGKHO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DVGKHO As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTNGAY As TextBox
    Friend WithEvents TXTNHANVIEN As TextBox
    Friend WithEvents TXTNCC As TextBox
    Friend WithEvents TXTSOLUONG As TextBox
    Friend WithEvents BTNTHEM As Button
    Friend WithEvents BTNSUA As Button
    Friend WithEvents BTNXOA As Button
    Friend WithEvents BTNXUAT As Button
    Friend WithEvents VTNEXT As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmasp As TextBox
End Class
