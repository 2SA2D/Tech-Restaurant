Public Class SignUp

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'declare variables and array
        Dim readfiles = IO.File.OpenText("List.txt")
        Dim name As String = txtName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim region As String = txtRegion.Text
        Dim phone As String = txtPhone.Text
        Dim dateOfBirth As Date = CStr(DateTimePicker1.Value.Date)

        ' check if textboxes are empty
        If name <> "" And username <> "" And password <> "" And region <> "" And phone <> "" Then
            If checkNameIfFoundInFile(name, readfiles) Then
                MessageBox.Show(name & " is already registerd.", "Name is Found")
                txtName.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtRegion.Clear()
                txtPhone.Clear()
                ' close the file
                readfiles.Close()
            Else
                'close the file
                readfiles.Close()
                'check if rating is between 0 - 5
                If password.Length > 0 Or password.Length <= 16 Then
                    ' open the file to add information to it
                    Dim writefiles = IO.File.AppendText("List.txt")
                    writefiles.WriteLine(name & "," & username & "," & password & "," & region & "," & phone & "," & dateOfBirth)
                    'close the file
                    writefiles.Close()
                    ' showing message that the processing to add information was successfuly
                    MessageBox.Show(name & " " & "is registered successfully", "Confirmed")
                    ' clear textboxes
                    txtName.Clear()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtRegion.Clear()
                    txtPhone.Clear()
                    Login.Show()
                    Me.Close()
                Else
                    ' Showing message if error occures
                    MessageBox.Show("please enter the password between 8 - 16", "Invalid password")
                    ' focus to the textbox to correcting errors
                    txtPassword.Focus()
                End If
            End If
        Else
            ' Showing message if error occures
            MessageBox.Show("You didn't input any Name", "ERROR")
            ' focus to the textbox to correcting errors
            txtName.Focus()
        End If
        ' close file
        readfiles.Close()
    End Sub
    Function checkNameIfFoundInFile(ByVal user As String, ByVal readfiles As IO.StreamReader) As Boolean
        'declare variables and array
        Dim line, parts(), name As String
        ' do looping until reach the end of the file
        Do Until readfiles.EndOfStream
            line = readfiles.ReadLine
            parts = line.Split(","c)
            name = parts(0)
            If name = user Then
                ' return true if name is found
                Return True
            End If
        Loop
        'return false if not found name in the file
        Return False
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            btnSubmit.Visible = True
        Else
            btnSubmit.Visible = False
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        Index.Show()
        Me.Close()
    End Sub
End Class