<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAOCAO
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTMASV = New System.Windows.Forms.TextBox()
        Me.BTTHOAT = New System.Windows.Forms.Button()
        Me.BTNHAP = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BÁO CÁO "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(366, 381)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(404, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MASV"
        '
        'TXTMASV
        '
        Me.TXTMASV.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMASV.Location = New System.Drawing.Point(516, 54)
        Me.TXTMASV.Name = "TXTMASV"
        Me.TXTMASV.Size = New System.Drawing.Size(272, 41)
        Me.TXTMASV.TabIndex = 3
        '
        'BTTHOAT
        '
        Me.BTTHOAT.Location = New System.Drawing.Point(634, 327)
        Me.BTTHOAT.Name = "BTTHOAT"
        Me.BTTHOAT.Size = New System.Drawing.Size(153, 101)
        Me.BTTHOAT.TabIndex = 4
        Me.BTTHOAT.Text = "THOÁT"
        Me.BTTHOAT.UseVisualStyleBackColor = True
        '
        'BTNHAP
        '
        Me.BTNHAP.Location = New System.Drawing.Point(451, 327)
        Me.BTNHAP.Name = "BTNHAP"
        Me.BTNHAP.Size = New System.Drawing.Size(153, 101)
        Me.BTNHAP.TabIndex = 4
        Me.BTNHAP.Text = "NHẬP"
        Me.BTNHAP.UseVisualStyleBackColor = True
        '
        'BAOCAO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNHAP)
        Me.Controls.Add(Me.BTTHOAT)
        Me.Controls.Add(Me.TXTMASV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BAOCAO"
        Me.Text = "BAOCAO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTMASV As TextBox
    Friend WithEvents BTTHOAT As Button
    Friend WithEvents BTNHAP As Button
End Class
