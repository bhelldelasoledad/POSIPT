Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1

        If ProgressBar1.Value <= 0 Then
            Label1.Text = "Opening... 10% "
            ' Label2.Text = "10%"

        ElseIf ProgressBar1.Value <= 20 Then
            Label1.Text = "Loading... 20% "
            ' Label2.Text = "20%"

        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Initializing System... 30% "
            'Label2.Text = "30%"

        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Loading All Modules... 60% "
            ' Label2.Text = "60%"

        ElseIf ProgressBar1.Value <= 60 Then
            Label1.Text = "Integrating Database... 70% "
            'Label2.Text = "70%"

        ElseIf ProgressBar1.Value <= 80 Then
            Label1.Text = "Connecting to All Modules... 80% "
            ' Label2.Text = "80%"

        ElseIf ProgressBar1.Value <= 90 Then
            Label1.Text = "Connected to All Modules... 90% "
            ' Label2.Text = "90%"

        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Launching Application... 100% " 'Please Wait
            ' Label2.Text = "100%"

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                ' Form2.Show()
            End If
        End If
    End Sub
End Class
