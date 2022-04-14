<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_BARANG
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.TXTBARANG = New System.Windows.Forms.TextBox()
        Me.CBSATUAN = New System.Windows.Forms.ComboBox()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MENU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA SATUAN"
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(143, 9)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(100, 20)
        Me.TXTKODE.TabIndex = 4
        '
        'TXTBARANG
        '
        Me.TXTBARANG.Location = New System.Drawing.Point(143, 42)
        Me.TXTBARANG.Name = "TXTBARANG"
        Me.TXTBARANG.Size = New System.Drawing.Size(478, 20)
        Me.TXTBARANG.TabIndex = 5
        '
        'CBSATUAN
        '
        Me.CBSATUAN.FormattingEnabled = True
        Me.CBSATUAN.Items.AddRange(New Object() {"MAKANAN", "MINUMAN"})
        Me.CBSATUAN.Location = New System.Drawing.Point(143, 75)
        Me.CBSATUAN.Name = "CBSATUAN"
        Me.CBSATUAN.Size = New System.Drawing.Size(121, 21)
        Me.CBSATUAN.TabIndex = 6
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(143, 108)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.Size = New System.Drawing.Size(100, 20)
        Me.TXTHARGA.TabIndex = 7
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(143, 134)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 8
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(15, 176)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(947, 20)
        Me.TXTCARI.TabIndex = 9
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPIL.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGTAMPIL.Location = New System.Drawing.Point(16, 202)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.ReadOnly = True
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTAMPIL.Size = New System.Drawing.Size(946, 210)
        Me.DGTAMPIL.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FR_BARANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 424)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.TXTHARGA)
        Me.Controls.Add(Me.CBSATUAN)
        Me.Controls.Add(Me.TXTBARANG)
        Me.Controls.Add(Me.TXTKODE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FR_BARANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_DATA MENU"
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents TXTBARANG As System.Windows.Forms.TextBox
    Friend WithEvents CBSATUAN As System.Windows.Forms.ComboBox
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
