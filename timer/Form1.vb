Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label1.Text = 0
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Label1.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 950
        If Label1.Text = 0 Then
            Label1.Text = Val(Label1.Text) + 1
        Else
            Label1.Text = Val(Label1.Text) + 1
        End If
        If Label1.Text = 60 Then
            Label2.Text = Val(Label2.Text) + 1
            label1.text = 0
        End If
        If Label2.Text = 60 Then
            Label3.Text = Val(Label3.Text) + 1
            Label2.Text = 0
        End If
    End Sub
End Class
