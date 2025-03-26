Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class Form1
    Public sec As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim countlap As Integer = 0
        sec = TextBox1.Text
        Dim rounds As Integer = sec / 201
        Dim track As Integer = sec Mod 201
        countlap += rounds
        Race.laps(track)
        Label9.Text = countlap
        Label8.Text = track
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        Label9.Text = "0"
        Label8.Text = "0"
        Label2.Text = "The Car is Ready to Go"
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
    End Sub
End Class
