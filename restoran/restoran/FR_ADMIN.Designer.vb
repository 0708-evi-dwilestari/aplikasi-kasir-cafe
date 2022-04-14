<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_ADMIN
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.lbnik = New System.Windows.Forms.Label()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.txtpass2 = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.lbnama)
        Me.GroupBox1.Controls.Add(Me.lbnik)
        Me.GroupBox1.Controls.Add(Me.cbtype)
        Me.GroupBox1.Controls.Add(Me.txtpass2)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User Admin"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(169, 225)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 12
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Location = New System.Drawing.Point(166, 69)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(38, 13)
        Me.lbnama.TabIndex = 11
        Me.lbnama.Text = "NAMA"
        '
        'lbnik
        '
        Me.lbnik.AutoSize = True
        Me.lbnik.Location = New System.Drawing.Point(166, 37)
        Me.lbnik.Name = "lbnik"
        Me.lbnik.Size = New System.Drawing.Size(25, 13)
        Me.lbnik.TabIndex = 10
        Me.lbnik.Text = "NIK"
        '
        'cbtype
        '
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"ADMIN", "MANAJER", "KASIR"})
        Me.cbtype.Location = New System.Drawing.Point(169, 193)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(121, 21)
        Me.cbtype.TabIndex = 9
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(169, 161)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Size = New System.Drawing.Size(379, 20)
        Me.txtpass2.TabIndex = 8
        Me.txtpass2.UseSystemPasswordChar = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(169, 129)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(379, 20)
        Me.txtpass.TabIndex = 7
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(169, 97)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(379, 20)
        Me.txtuser.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RE PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'FR_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 290)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FR_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents lbnik As System.Windows.Forms.Label
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
