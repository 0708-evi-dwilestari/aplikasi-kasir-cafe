<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_HAKAKSES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FR_HAKAKSES))
        Me.dgAdmin = New System.Windows.Forms.DataGridView()
        Me.dgAkses = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAkses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAdmin
        '
        Me.dgAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgAdmin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAdmin.Location = New System.Drawing.Point(12, 12)
        Me.dgAdmin.Name = "dgAdmin"
        Me.dgAdmin.Size = New System.Drawing.Size(240, 426)
        Me.dgAdmin.TabIndex = 0
        '
        'dgAkses
        '
        Me.dgAkses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAkses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgAkses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAkses.Location = New System.Drawing.Point(258, 12)
        Me.dgAkses.Name = "dgAkses"
        Me.dgAkses.Size = New System.Drawing.Size(503, 386)
        Me.dgAkses.TabIndex = 1
        '
        'btnsimpan
        '
        Me.btnsimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsimpan.Location = New System.Drawing.Point(686, 415)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 2
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'FR_HAKAKSES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(773, 450)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.dgAkses)
        Me.Controls.Add(Me.dgAdmin)
        Me.Name = "FR_HAKAKSES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_HAKAKSES"
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAkses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents dgAkses As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
End Class
