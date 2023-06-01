Public Class Login
    Dim login() As String ' create array for get all information from text file

    Structure loginvar
        Dim user As String
        Dim password As String
    End Structure
    Dim loginStructure(999) As loginvar
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' fill structure
        login = IO.File.ReadAllLines("List.txt")
        For i As Integer = 0 To login.Count - 1
            Dim line As String = login(i)
            Dim parts() As String = line.Split(","c)
            loginStructure(i).user = parts(1)
            loginStructure(i).password = parts(2)
        Next


    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        checkUsernameAndPassword()

    End Sub
    Function checkUsernameAndPassword()
        Dim userInput, passwordInput As String
        userInput = txtUsername.Text
        passwordInput = txtPassword.Text
        ' to check if username and password from user are correct
        Dim valid As Boolean = False

        Dim query = From s In loginStructure
                    Where s.user = userInput And s.password = passwordInput
                    Let validLogin As Boolean = True
                    Select validLogin

        For Each q In query
            ' change valid to true if username and password are correct
            valid = q
            If q = True Then
                MenuView.Show()
                Me.Close()
            End If
        Next
        ' show message error if username and password are incorrect
        If valid = False Then
            MessageBox.Show("Invalid input data. Try Again!", "ERROR")
        End If
        Return ""
    End Function

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub


    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        SignUp.Show()
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Index.Show()
        Me.Close()
    End Sub
End Class
