<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class danhmucsanpham
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DVGDANHMUC = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTBAN = New System.Windows.Forms.TextBox()
        Me.TXTNHAP = New System.Windows.Forms.TextBox()
        Me.TXTSANPHAM = New System.Windows.Forms.TextBox()
        Me.TXTMA = New System.Windows.Forms.TextBox()
        Me.BTEXIT = New System.Windows.Forms.Button()
        Me.BTTHEM = New System.Windows.Forms.Button()
        Me.BTSUA = New System.Windows.Forms.Button()
        Me.BTXOA = New System.Windows.Forms.Button()
        Me.BTXUAT = New System.Windows.Forms.Button()
        CType(Me.DVGDANHMUC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(719, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ DANH MỤC VÀ SẢN PHẨM "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"DANH MỤC", "", "ĐỒ UỐNG ", "", "THỰC PHẨM ", "", "ĐỒ DÙNG ", "", "DƯỢC PHẨM ", ""})
        Me.ListBox1.Location = New System.Drawing.Point(25, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(123, 228)
        Me.ListBox1.TabIndex = 2
        '
        'DVGDANHMUC
        '
        Me.DVGDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDANHMUC.Location = New System.Drawing.Point(193, 72)
        Me.DVGDANHMUC.Name = "DVGDANHMUC"
        Me.DVGDANHMUC.RowHeadersWidth = 51
        Me.DVGDANHMUC.RowTemplate.Height = 24
        Me.DVGDANHMUC.Size = New System.Drawing.Size(595, 126)
        Me.DVGDANHMUC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "GIÁ BÁN "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TÊN SẢN PHẨM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(461, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "GIÁ NHẬP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MÃ "
        '
        'TXTBAN
        '
        Me.TXTBAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBAN.Location = New System.Drawing.Point(347, 212)
        Me.TXTBAN.Name = "TXTBAN"
        Me.TXTBAN.Size = New System.Drawing.Size(108, 41)
        Me.TXTBAN.TabIndex = 5
        '
        'TXTNHAP
        '
        Me.TXTNHAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNHAP.Location = New System.Drawing.Point(626, 215)
        Me.TXTNHAP.Name = "TXTNHAP"
        Me.TXTNHAP.Size = New System.Drawing.Size(162, 41)
        Me.TXTNHAP.TabIndex = 5
        '
        'TXTSANPHAM
        '
        Me.TXTSANPHAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSANPHAM.Location = New System.Drawing.Point(458, 273)
        Me.TXTSANPHAM.Name = "TXTSANPHAM"
        Me.TXTSANPHAM.Size = New System.Drawing.Size(330, 41)
        Me.TXTSANPHAM.TabIndex = 5
        '
        'TXTMA
        '
        Me.TXTMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMA.Location = New System.Drawing.Point(265, 325)
        Me.TXTMA.Name = "TXTMA"
        Me.TXTMA.Size = New System.Drawing.Size(523, 41)
        Me.TXTMA.TabIndex = 5
        '
        'BTEXIT
        '
        Me.BTEXIT.Location = New System.Drawing.Point(25, 351)
        Me.BTEXIT.Name = "BTEXIT"
        Me.BTEXIT.Size = New System.Drawing.Size(78, 70)
        Me.BTEXIT.TabIndex = 6
        Me.BTEXIT.Text = "EXIT"
        Me.BTEXIT.UseVisualStyleBackColor = True
        '
        'BTTHEM
        '
        Me.BTTHEM.Location = New System.Drawing.Point(163, 378)
        Me.BTTHEM.Name = "BTTHEM"
        Me.BTTHEM.Size = New System.Drawing.Size(117, 43)
        Me.BTTHEM.TabIndex = 6
        Me.BTTHEM.Text = "THÊM"
        Me.BTTHEM.UseVisualStyleBackColor = True
        '
        'BTSUA
        '
        Me.BTSUA.Location = New System.Drawing.Point(314, 378)
        Me.BTSUA.Name = "BTSUA"
        Me.BTSUA.Size = New System.Drawing.Size(117, 43)
        Me.BTSUA.TabIndex = 6
        Me.BTSUA.Text = "SỬA"
        Me.BTSUA.UseVisualStyleBackColor = True
        '
        'BTXOA
        '
        Me.BTXOA.Location = New System.Drawing.Point(470, 378)
        Me.BTXOA.Name = "BTXOA"
        Me.BTXOA.Size = New System.Drawing.Size(117, 43)
        Me.BTXOA.TabIndex = 6
        Me.BTXOA.Text = "XÓA "
        Me.BTXOA.UseVisualStyleBackColor = True
        '
        'BTXUAT
        '
        Me.BTXUAT.Location = New System.Drawing.Point(626, 378)
        Me.BTXUAT.Name = "BTXUAT"
        Me.BTXUAT.Size = New System.Drawing.Size(117, 43)
        Me.BTXUAT.TabIndex = 6
        Me.BTXUAT.Text = "XUẤT"
        Me.BTXUAT.UseVisualStyleBackColor = True
        '
        'danhmucsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTXUAT)
        Me.Controls.Add(Me.BTXOA)
        Me.Controls.Add(Me.BTSUA)
        Me.Controls.Add(Me.BTTHEM)
        Me.Controls.Add(Me.BTEXIT)
        Me.Controls.Add(Me.TXTMA)
        Me.Controls.Add(Me.TXTSANPHAM)
        Me.Controls.Add(Me.TXTNHAP)
        Me.Controls.Add(Me.TXTBAN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DVGDANHMUC)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "danhmucsanpham"
        Me.Text = "danhmucsanpham"
        CType(Me.DVGDANHMUC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DVGDANHMUC As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTBAN As TextBox
    Friend WithEvents TXTNHAP As TextBox
    Friend WithEvents TXTSANPHAM As TextBox
    Friend WithEvents TXTMA As TextBox
    Friend WithEvents BTEXIT As Button
    Friend WithEvents BTTHEM As Button
    Friend WithEvents BTSUA As Button
    Friend WithEvents BTXOA As Button
    Friend WithEvents BTXUAT As Button
End Class
