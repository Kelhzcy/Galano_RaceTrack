Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Race
    Public Function laps(Track As Integer)
        If Track <= 30 Then
            Form1.ProgressBar1.Maximum = 30
            Form1.ProgressBar1.Minimum = 0
            Form1.ProgressBar1.Value = Track
            Form1.Label2.Text = "The Car is at CONCRETE"
        ElseIf Track <= 90 Then
            Form1.ProgressBar1.Maximum = 30
            Form1.ProgressBar1.Value = 30
            Form1.ProgressBar2.Maximum = 90
            Form1.ProgressBar2.Value = Track
            Form1.Label2.Text = "The Car is at SAND"
        ElseIf Track <= 150 Then
            Form1.Label2.Text = "The Car is at SAND"
            Form1.ProgressBar1.Maximum = 30
            Form1.ProgressBar1.Value = 30
            Form1.ProgressBar2.Maximum = 90
            Form1.ProgressBar2.Value = 90
            Form1.ProgressBar3.Maximum = 150
            Form1.ProgressBar3.Value = Track
            Form1.Label2.Text = "The Car is at MUD"
        Else
            Form1.ProgressBar1.Maximum = 30
            Form1.ProgressBar1.Value = 30
            Form1.ProgressBar2.Maximum = 90
            Form1.ProgressBar2.Value = 90
            Form1.ProgressBar3.Maximum = 150
            Form1.ProgressBar3.Value = 150
            Form1.ProgressBar4.Maximum = 200
            Form1.ProgressBar4.Value = Track
            Form1.Label2.Text = "The Car is at ASPHALT"
        End If
    End Function

End Module
