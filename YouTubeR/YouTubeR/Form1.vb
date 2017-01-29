﻿Public Class Form1
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
        Process.Start(YoutubeDL, " " & ProgOptions & TextBox1.Text)
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
End Class
