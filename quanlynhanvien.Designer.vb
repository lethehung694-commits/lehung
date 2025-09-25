<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlynhanvien
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
        Me.DVGNHANVIEN = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTMANV = New System.Windows.Forms.TextBox()
        Me.TXTNGAYSINH = New System.Windows.Forms.TextBox()
        Me.TXTTEN = New System.Windows.Forms.TextBox()
        Me.TXTCHUCVU = New System.Windows.Forms.TextBox()
        Me.BTTHEM = New System.Windows.Forms.Button()
        Me.BTSUA = New System.Windows.Forms.Button()
        Me.BTXOA = New System.Windows.Forms.Button()
        Me.BTXUAT = New System.Windows.Forms.Button()
        Me.BTEXIT = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTLUONG = New System.Windows.Forms.TextBox()
        CType(Me.DVGNHANVIEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ NHÂN VIÊN "
        '
        'DVGNHANVIEN
        '
        Me.DVGNHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGNHANVIEN.Location = New System.Drawing.Point(20, 63)
        Me.DVGNHANVIEN.Name = "DVGNHANVIEN"
        Me.DVGNHANVIEN.RowHeadersWidth = 51
        Me.DVGNHANVIEN.RowTemplate.Height = 24
        Me.DVGNHANVIEN.Size = New System.Drawing.Size(768, 180)
        Me.DVGNHANVIEN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MÃ NV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NGÀY SINH "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 36)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "HỌ TÊN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 36)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "CHỨC VỤ "
        '
        'TXTMANV
        '
        Me.TXTMANV.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMANV.Location = New System.Drawing.Point(231, 260)
        Me.TXTMANV.Name = "TXTMANV"
        Me.TXTMANV.Size = New System.Drawing.Size(183, 41)
        Me.TXTMANV.TabIndex = 3
        '
        'TXTNGAYSINH
        '
        Me.TXTNGAYSINH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNGAYSINH.Location = New System.Drawing.Point(231, 320)
        Me.TXTNGAYSINH.Name = "TXTNGAYSINH"
        Me.TXTNGAYSINH.Size = New System.Drawing.Size(183, 41)
        Me.TXTNGAYSINH.TabIndex = 3
        '
        'TXTTEN
        '
        Me.TXTTEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTEN.Location = New System.Drawing.Point(638, 260)
        Me.TXTTEN.Name = "TXTTEN"
        Me.TXTTEN.Size = New System.Drawing.Size(159, 41)
        Me.TXTTEN.TabIndex = 3
        '
        'TXTCHUCVU
        '
        Me.TXTCHUCVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCHUCVU.Location = New System.Drawing.Point(638, 317)
        Me.TXTCHUCVU.Name = "TXTCHUCVU"
        Me.TXTCHUCVU.Size = New System.Drawing.Size(159, 41)
        Me.TXTCHUCVU.TabIndex = 3
        '
        'BTTHEM
        '
        Me.BTTHEM.Location = New System.Drawing.Point(20, 389)
        Me.BTTHEM.Name = "BTTHEM"
        Me.BTTHEM.Size = New System.Drawing.Size(78, 49)
        Me.BTTHEM.TabIndex = 4
        Me.BTTHEM.Text = "THÊM"
        Me.BTTHEM.UseVisualStyleBackColor = True
        '
        'BTSUA
        '
        Me.BTSUA.Location = New System.Drawing.Point(132, 389)
        Me.BTSUA.Name = "BTSUA"
        Me.BTSUA.Size = New System.Drawing.Size(78, 49)
        Me.BTSUA.TabIndex = 4
        Me.BTSUA.Text = "SỬA"
        Me.BTSUA.UseVisualStyleBackColor = True
        '
        'BTXOA
        '
        Me.BTXOA.Location = New System.Drawing.Point(231, 389)
        Me.BTXOA.Name = "BTXOA"
        Me.BTXOA.Size = New System.Drawing.Size(78, 49)
        Me.BTXOA.TabIndex = 4
        Me.BTXOA.Text = "XÓA "
        Me.BTXOA.UseVisualStyleBackColor = True
        '
        'BTXUAT
        '
        Me.BTXUAT.Location = New System.Drawing.Point(327, 389)
        Me.BTXUAT.Name = "BTXUAT"
        Me.BTXUAT.Size = New System.Drawing.Size(78, 49)
        Me.BTXUAT.TabIndex = 4
        Me.BTXUAT.Text = "XUẤT "
        Me.BTXUAT.UseVisualStyleBackColor = True
        '
        'BTEXIT
        '
        Me.BTEXIT.Location = New System.Drawing.Point(719, 2)
        Me.BTEXIT.Name = "BTEXIT"
        Me.BTEXIT.Size = New System.Drawing.Size(78, 49)
        Me.BTEXIT.TabIndex = 4
        Me.BTEXIT.Text = "EXIT"
        Me.BTEXIT.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "LƯƠNG"
        '
        'TXTLUONG
        '
        Me.TXTLUONG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLUONG.Location = New System.Drawing.Point(638, 377)
        Me.TXTLUONG.Name = "TXTLUONG"
        Me.TXTLUONG.Size = New System.Drawing.Size(159, 41)
        Me.TXTLUONG.TabIndex = 3
        '
        'quanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTEXIT)
        Me.Controls.Add(Me.BTXUAT)
        Me.Controls.Add(Me.BTXOA)
        Me.Controls.Add(Me.BTSUA)
        Me.Controls.Add(Me.BTTHEM)
        Me.Controls.Add(Me.TXTLUONG)
        Me.Controls.Add(Me.TXTCHUCVU)
        Me.Controls.Add(Me.TXTTEN)
        Me.Controls.Add(Me.TXTNGAYSINH)
        Me.Controls.Add(Me.TXTMANV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DVGNHANVIEN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "quanlynhanvien"
        Me.Text = "quanlynhanvien"
        CType(Me.DVGNHANVIEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DVGNHANVIEN As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTMANV As TextBox
    Friend WithEvents TXTNGAYSINH As TextBox
    Friend WithEvents TXTTEN As TextBox
    Friend WithEvents TXTCHUCVU As TextBox
    Friend WithEvents BTTHEM As Button
    Friend WithEvents BTSUA As Button
    Friend WithEvents BTXOA As Button
    Friend WithEvents BTXUAT As Button
    Friend WithEvents BTEXIT As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTLUONG As TextBox
End Class
