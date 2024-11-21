Public Class Form3
    Public previousForm As Form
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnnext1_Click(sender As Object, e As EventArgs) Handles btnnext1.Click
        PanelNext.Visible = True
        PanelDefault.Visible = False
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        PanelNext.Visible = False
        PanelDefault.Visible = True
    End Sub
End Class
