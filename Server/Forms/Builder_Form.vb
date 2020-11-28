Public Class Builder_Form
    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B As New Helpers.Builder
        B.Build(New Object() {NumericUpDown1.Value, TextBox1.Text, CheckBox1.Checked, CheckBox2.Checked})
    End Sub
End Class