<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Me.TXTSCAN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DVGPOS = New System.Windows.Forms.DataGridView()
        Me.LTONGTIEN = New System.Windows.Forms.ListView()
        Me.BTTHANH = New System.Windows.Forms.Button()
        Me.BTNHAP = New System.Windows.Forms.Button()
        Me.BTE = New System.Windows.Forms.Button()
        CType(Me.DVGPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTSCAN
        '
        Me.TXTSCAN.Location = New System.Drawing.Point(93, 72)
        Me.TXTSCAN.Name = "TXTSCAN"
        Me.TXTSCAN.Size = New System.Drawing.Size(447, 22)
        Me.TXTSCAN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "POS-BÁN HÀNG "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SCAN"
        '
        'DVGPOS
        '
        Me.DVGPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGPOS.Location = New System.Drawing.Point(22, 115)
        Me.DVGPOS.Name = "DVGPOS"
        Me.DVGPOS.RowHeadersWidth = 51
        Me.DVGPOS.RowTemplate.Height = 24
        Me.DVGPOS.Size = New System.Drawing.Size(517, 334)
        Me.DVGPOS.TabIndex = 3
        '
        'LTONGTIEN
        '
        Me.LTONGTIEN.HideSelection = False
        Me.LTONGTIEN.Location = New System.Drawing.Point(566, 147)
        Me.LTONGTIEN.Name = "LTONGTIEN"
        Me.LTONGTIEN.Size = New System.Drawing.Size(222, 101)
        Me.LTONGTIEN.TabIndex = 4
        Me.LTONGTIEN.UseCompatibleStateImageBehavior = False
        '
        'BTTHANH
        '
        Me.BTTHANH.Location = New System.Drawing.Point(566, 365)
        Me.BTTHANH.Name = "BTTHANH"
        Me.BTTHANH.Size = New System.Drawing.Size(95, 64)
        Me.BTTHANH.TabIndex = 5
        Me.BTTHANH.Text = "THANH TOAN "
        Me.BTTHANH.UseVisualStyleBackColor = True
        '
        'BTNHAP
        '
        Me.BTNHAP.Location = New System.Drawing.Point(693, 365)
        Me.BTNHAP.Name = "BTNHAP"
        Me.BTNHAP.Size = New System.Drawing.Size(95, 64)
        Me.BTNHAP.TabIndex = 5
        Me.BTNHAP.Text = "NHẬP"
        Me.BTNHAP.UseVisualStyleBackColor = True
        '
        'BTE
        '
        Me.BTE.Location = New System.Drawing.Point(693, 17)
        Me.BTE.Name = "BTE"
        Me.BTE.Size = New System.Drawing.Size(98, 44)
        Me.BTE.TabIndex = 6
        Me.BTE.Text = "EXIT"
        Me.BTE.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTE)
        Me.Controls.Add(Me.BTNHAP)
        Me.Controls.Add(Me.BTTHANH)
        Me.Controls.Add(Me.LTONGTIEN)
        Me.Controls.Add(Me.DVGPOS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTSCAN)
        Me.Name = "POS"
        Me.Text = "POS"
        CType(Me.DVGPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTSCAN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DVGPOS As DataGridView
    Friend WithEvents LTONGTIEN As ListView
    Friend WithEvents BTTHANH As Button
    Friend WithEvents BTNHAP As Button
    Friend WithEvents BTE As Button
End Class
