Public Class FR_TENTANG

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim kata_awal As String = Microsoft.VisualBasic.Left(lbjalan.Text, 1)
        Dim kata_akhir As String = Microsoft.VisualBasic.Right(lbjalan.Text, Len(lbjalan.Text) - 1)

        lbjalan.Text = kata_akhir & kata_awal

    End Sub

    Private Sub FR_TENTANG_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbjalan.Text = My.Settings.TEXT_JALAN
        Timer1.Enabled = True
    End Sub

    Private Sub lbjalan_DoubleClick(sender As Object, e As EventArgs) Handles lbjalan.DoubleClick
        Dim str As String = InputBox("Masukkan text baru", "Running text", My.Settings.TEXT_JALAN)
        My.Settings.TEXT_JALAN = str
        My.Settings.Save()
        lbjalan.Text = My.Settings.TEXT_JALAN
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.instagram.com/")
    End Sub
End Class