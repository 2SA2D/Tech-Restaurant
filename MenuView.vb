Public Class MenuView
    Dim loginn() As String
    Structure loginvar
        Dim dat, user As String
    End Structure
    Dim loginStructure(999) As loginvar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub

    Private Sub MenuView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numberOfYears As Integer
        TextBox2.Text = Login.txtUsername.Text
        loginn = IO.File.ReadAllLines("List.txt")
        For i As Integer = 0 To loginn.Count - 1
            Dim line As String = loginn(i)
            Dim parts() As String = line.Split(","c)
            loginStructure(i).user = parts(1)
            loginStructure(i).dat = parts(5)
            If loginStructure(i).user = TextBox2.Text Then
                numberOfYears = Today.Year - CDate(loginStructure(i).dat).Year
            End If
            If numberOfYears >= 60 Or numberOfYears <= 20 Then
                RadioButton1.Checked = True
                RadioButton1.Enabled = True
            Else
                RadioButton1.Checked = False
                RadioButton1.Enabled = False

            End If
        Next


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = Payment.calculate()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        t1.Text = 1
        t2.Text = 1
        t3.Text = 1
        t4.Text = 1
        t5.Text = 1
        t6.Text = 1
        t7.Text = 1
        t8.Text = 1
        t9.Text = 1
        t10.Text = 1
        TextBox1.Text = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Payment.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub CustomerInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerInformationToolStripMenuItem.Click
        Form6.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class