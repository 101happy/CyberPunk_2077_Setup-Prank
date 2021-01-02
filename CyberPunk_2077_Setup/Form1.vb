Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CheckBox1.Checked = True Then
            Dim box = New Form2()
            box.Show()
            Me.Hide()
        Else
            MessageBox.Show("To download Cyberpunk 2077 you need to accept our terms of service. Press the Accept button to download Cyberpunk 2077")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
