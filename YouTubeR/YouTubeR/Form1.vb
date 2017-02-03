Public Class Form1
    Private SDirectory As String
    Public Property Option1 As String
    Public Property Option2 As String
    Public Property ProgOptions As String
    Public Property OutputPath As String
    Public Property YoutubeDL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        YoutubeDL = "youtube-dl.exe"
        If RadioButton1.Checked = False Then
            Option1 = " -o " + "%(title)s.%(ext)s --extract-audio --audio-format mp3 "
        Else Option1 = "-o " + "%(title)s.%(ext)s "
        End If
        If RadioButton3.Checked = True Then
            Option2 = "-i "
        Else
            Option2 = "--abort-on-error "
        End If
        ProgOptions = Option1 & Option2
        Try
            Process.Start(YoutubeDL, " " & ProgOptions & TextBox1.Text)
        Catch ex As Exception
            Process.Start("https://rg3.github.io/youtube-dl/download.html")
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton1.Checked = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton4.Checked = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton3.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            SDirectory = FolderBrowserDialog1.SelectedPath
            Button1.Enabled = True
        End If

    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        If CheckBox1.Checked = True Then
            TextBox1.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub FullMoviesOnVimeoGoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullMoviesOnVimeoGoogleToolStripMenuItem.Click
        Process.Start("https://www.reddit.com/r/Fullmoviesonvimeo/")
    End Sub

    Private Sub FullMoviesOnYoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullMoviesOnYoutubeToolStripMenuItem.Click
        Process.Start("https://www.reddit.com/r/fullmoviesonyoutube/")
    End Sub

    Private Sub FullMoviesOnAnythingSlowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullMoviesOnAnythingSlowToolStripMenuItem.Click
        Process.Start("https://www.reddit.com/r/Fullmoviesonanything/")
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click
        Process.Start("Http://youtube.com")
    End Sub

    Private Sub Httpww1watchtvseriesliveorgwatchtvseriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Httpww1watchtvseriesliveorgwatchtvseriesToolStripMenuItem.Click
        Process.Start("http://ww1.watchtvserieslive.org/watch-tv-series/")
    End Sub

    Private Sub HttpsseriestopcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HttpsseriestopcomToolStripMenuItem.Click
        Process.Start("https://series-top.com/")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Process.Start("mailto:chris@madmullins.com")
    End Sub
End Class
