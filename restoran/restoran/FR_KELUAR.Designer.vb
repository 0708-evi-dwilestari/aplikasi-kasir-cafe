<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KELUAR
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnatas = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.TXTSATUAN = New System.Windows.Forms.TextBox()
        Me.TXTBARANG = New System.Windows.Forms.TextBox()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.pnbawah = New System.Windows.Forms.Panel()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pncari = New System.Windows.Forms.Panel()
        Me.dgcari = New System.Windows.Forms.DataGridView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.pnbayar = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txttunai = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nota = New System.Drawing.Printing.PrintDocument()
        Me.pnatas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnbawah.SuspendLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pncari.SuspendLayout()
        CType(Me.dgcari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnbayar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnatas
        '
        Me.pnatas.Controls.Add(Me.GroupBox2)
        Me.pnatas.Controls.Add(Me.btnmenu)
        Me.pnatas.Controls.Add(Me.GroupBox1)
        Me.pnatas.Controls.Add(Me.btnminimize)
        Me.pnatas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnatas.Location = New System.Drawing.Point(0, 0)
        Me.pnatas.Name = "pnatas"
        Me.pnatas.Size = New System.Drawing.Size(1083, 209)
        Me.pnatas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbtotal)
        Me.GroupBox2.Location = New System.Drawing.Point(472, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 147)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Harga"
        '
        'lbtotal
        '
        Me.lbtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbtotal.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.Location = New System.Drawing.Point(6, 15)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(587, 128)
        Me.lbtotal.TabIndex = 0
        Me.lbtotal.Text = "0"
        Me.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmenu.Location = New System.Drawing.Point(1017, 12)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(54, 23)
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.Text = "X"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncari)
        Me.GroupBox1.Controls.Add(Me.TXTHARGA)
        Me.GroupBox1.Controls.Add(Me.TXTSATUAN)
        Me.GroupBox1.Controls.Add(Me.TXTBARANG)
        Me.GroupBox1.Controls.Add(Me.TXTKODE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Makanan"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(355, 31)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 2
        Me.btncari.Text = "Cari (F1)"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(95, 112)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.ReadOnly = True
        Me.TXTHARGA.Size = New System.Drawing.Size(335, 20)
        Me.TXTHARGA.TabIndex = 7
        '
        'TXTSATUAN
        '
        Me.TXTSATUAN.Location = New System.Drawing.Point(95, 86)
        Me.TXTSATUAN.Name = "TXTSATUAN"
        Me.TXTSATUAN.ReadOnly = True
        Me.TXTSATUAN.Size = New System.Drawing.Size(335, 20)
        Me.TXTSATUAN.TabIndex = 6
        '
        'TXTBARANG
        '
        Me.TXTBARANG.Location = New System.Drawing.Point(95, 59)
        Me.TXTBARANG.Name = "TXTBARANG"
        Me.TXTBARANG.ReadOnly = True
        Me.TXTBARANG.Size = New System.Drawing.Size(335, 20)
        Me.TXTBARANG.TabIndex = 5
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(95, 32)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(256, 20)
        Me.TXTKODE.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'btnminimize
        '
        Me.btnminimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimize.Location = New System.Drawing.Point(957, 12)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(54, 23)
        Me.btnminimize.TabIndex = 4
        Me.btnminimize.Text = "-"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'pnbawah
        '
        Me.pnbawah.Controls.Add(Me.btnbayar)
        Me.pnbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnbawah.Location = New System.Drawing.Point(0, 510)
        Me.pnbawah.Name = "pnbawah"
        Me.pnbawah.Size = New System.Drawing.Size(1083, 46)
        Me.pnbawah.TabIndex = 1
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(7, 11)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 0
        Me.btnbayar.Text = "Bayar (F2)"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'dgtampil
        '
        Me.dgtampil.AllowUserToAddRows = False
        Me.dgtampil.AllowUserToDeleteRows = False
        Me.dgtampil.AllowUserToResizeColumns = False
        Me.dgtampil.AllowUserToResizeRows = False
        Me.dgtampil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgtampil.BackgroundColor = System.Drawing.Color.Olive
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtampil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.BARANG, Me.STATUS, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.dgtampil.Location = New System.Drawing.Point(0, 209)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.RowHeadersVisible = False
        Me.dgtampil.Size = New System.Drawing.Size(1083, 301)
        Me.dgtampil.TabIndex = 0
        '
        'KODE
        '
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'BARANG
        '
        Me.BARANG.HeaderText = "MENU"
        Me.BARANG.Name = "BARANG"
        Me.BARANG.ReadOnly = True
        Me.BARANG.Width = 400
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'HARGA
        '
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 80
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'pncari
        '
        Me.pncari.Controls.Add(Me.dgcari)
        Me.pncari.Controls.Add(Me.btnkeluar)
        Me.pncari.Controls.Add(Me.txtcari)
        Me.pncari.Location = New System.Drawing.Point(31, 308)
        Me.pncari.Name = "pncari"
        Me.pncari.Size = New System.Drawing.Size(419, 174)
        Me.pncari.TabIndex = 3
        Me.pncari.Visible = False
        '
        'dgcari
        '
        Me.dgcari.AllowUserToAddRows = False
        Me.dgcari.AllowUserToDeleteRows = False
        Me.dgcari.AllowUserToResizeColumns = False
        Me.dgcari.AllowUserToResizeRows = False
        Me.dgcari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgcari.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgcari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcari.Location = New System.Drawing.Point(3, 31)
        Me.dgcari.Name = "dgcari"
        Me.dgcari.ReadOnly = True
        Me.dgcari.RowHeadersVisible = False
        Me.dgcari.Size = New System.Drawing.Size(413, 140)
        Me.dgcari.TabIndex = 2
        '
        'btnkeluar
        '
        Me.btnkeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnkeluar.Location = New System.Drawing.Point(336, 4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 1
        Me.btnkeluar.Text = "X"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Location = New System.Drawing.Point(3, 5)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(327, 20)
        Me.txtcari.TabIndex = 0
        '
        'pnbayar
        '
        Me.pnbayar.Controls.Add(Me.GroupBox3)
        Me.pnbayar.Location = New System.Drawing.Point(496, 308)
        Me.pnbayar.Name = "pnbayar"
        Me.pnbayar.Size = New System.Drawing.Size(515, 174)
        Me.pnbayar.TabIndex = 4
        Me.pnbayar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btntutup)
        Me.GroupBox3.Controls.Add(Me.txtkembalian)
        Me.GroupBox3.Controls.Add(Me.txttunai)
        Me.GroupBox3.Controls.Add(Me.txtbayar)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 138)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'btntutup
        '
        Me.btntutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btntutup.Location = New System.Drawing.Point(418, 26)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(52, 23)
        Me.btntutup.TabIndex = 6
        Me.btntutup.Text = "X "
        Me.btntutup.UseVisualStyleBackColor = False
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(92, 101)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.ReadOnly = True
        Me.txtkembalian.Size = New System.Drawing.Size(260, 20)
        Me.txtkembalian.TabIndex = 5
        Me.txtkembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttunai
        '
        Me.txttunai.Location = New System.Drawing.Point(92, 64)
        Me.txttunai.Name = "txttunai"
        Me.txttunai.Size = New System.Drawing.Size(260, 20)
        Me.txttunai.TabIndex = 4
        Me.txttunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(92, 27)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.ReadOnly = True
        Me.txtbayar.Size = New System.Drawing.Size(260, 20)
        Me.txtbayar.TabIndex = 3
        Me.txtbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kembalian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tunai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Bayar"
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.klik_kanan.Name = "klik_kanan"
        Me.klik_kanan.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'nota
        '
        '
        'FR_KELUAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 556)
        Me.Controls.Add(Me.pncari)
        Me.Controls.Add(Me.pnbayar)
        Me.Controls.Add(Me.pnbawah)
        Me.Controls.Add(Me.pnatas)
        Me.Controls.Add(Me.dgtampil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FR_KELUAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KELUAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnatas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnbawah.ResumeLayout(False)
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pncari.ResumeLayout(False)
        Me.pncari.PerformLayout()
        CType(Me.dgcari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnbayar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnatas As System.Windows.Forms.Panel
    Friend WithEvents pnbawah As System.Windows.Forms.Panel
    Friend WithEvents dgtampil As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents TXTSATUAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTBARANG As System.Windows.Forms.TextBox
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents pncari As System.Windows.Forms.Panel
    Friend WithEvents dgcari As System.Windows.Forms.DataGridView
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnbayar As System.Windows.Forms.Button
    Friend WithEvents pnbayar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents txttunai As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents klik_kanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nota As System.Drawing.Printing.PrintDocument
    Friend WithEvents KODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
