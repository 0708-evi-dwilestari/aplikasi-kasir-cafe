﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_LAPORAN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TAMPILNAMA = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tglmulai = New System.Windows.Forms.DateTimePicker()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btntampil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tglsampai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 137)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TAMPILNAMA)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(522, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 115)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TAMPILNAMA
        '
        Me.TAMPILNAMA.Location = New System.Drawing.Point(171, 78)
        Me.TAMPILNAMA.Name = "TAMPILNAMA"
        Me.TAMPILNAMA.Size = New System.Drawing.Size(75, 23)
        Me.TAMPILNAMA.TabIndex = 7
        Me.TAMPILNAMA.Text = "Tampil"
        Me.TAMPILNAMA.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(90, 39)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(261, 20)
        Me.txtnama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tglmulai)
        Me.GroupBox1.Controls.Add(Me.btncetak)
        Me.GroupBox1.Controls.Add(Me.btntampil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tglsampai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 115)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'tglmulai
        '
        Me.tglmulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglmulai.Location = New System.Drawing.Point(76, 24)
        Me.tglmulai.Name = "tglmulai"
        Me.tglmulai.Size = New System.Drawing.Size(116, 20)
        Me.tglmulai.TabIndex = 3
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(229, 78)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 7
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btntampil
        '
        Me.btntampil.Location = New System.Drawing.Point(145, 78)
        Me.btntampil.Name = "btntampil"
        Me.btntampil.Size = New System.Drawing.Size(75, 23)
        Me.btntampil.TabIndex = 6
        Me.btntampil.Text = "Tampil"
        Me.btntampil.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mulai TGL"
        '
        'tglsampai
        '
        Me.tglsampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglsampai.Location = New System.Drawing.Point(300, 24)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Size = New System.Drawing.Size(121, 20)
        Me.tglsampai.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sampai TGL"
        '
        'dgtampil
        '
        Me.dgtampil.AllowUserToAddRows = False
        Me.dgtampil.AllowUserToDeleteRows = False
        Me.dgtampil.AllowUserToResizeColumns = False
        Me.dgtampil.AllowUserToResizeRows = False
        Me.dgtampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtampil.Location = New System.Drawing.Point(0, 137)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.ReadOnly = True
        Me.dgtampil.RowHeadersVisible = False
        Me.dgtampil.Size = New System.Drawing.Size(984, 297)
        Me.dgtampil.TabIndex = 0
        '
        'FR_LAPORAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 434)
        Me.Controls.Add(Me.dgtampil)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FR_LAPORAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_LAPORAN"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tglmulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgtampil As System.Windows.Forms.DataGridView
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btntampil As System.Windows.Forms.Button
    Friend WithEvents tglsampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TAMPILNAMA As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
End Class
