Public Class Form2

    Dim gender, fname As String
    Dim age As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbmale.CheckedChanged
        gender = "male"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lname = txtlname
        fname = txtfname.Text
        age = txtage.Value

        If lname.Text.Equals("") Or fname.Equals("") Or age < 9 Then
            MessageBox.Show("Please fill out all fields!", "fillout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfemale.CheckedChanged
        gender = "female"
    End Sub
End Class