Public Class Form6
    Structure personalDet
        Dim name As String
        Dim username As String
        Dim password As String
        Dim region As String
        Dim phone As String
        Dim dat As String
    End Structure
    ' variables and arrays
    Dim personalDetail() As String
    Dim PD(10) As personalDet 'PD = personal Detail 
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' read from files
        personalDetail = IO.File.ReadAllLines("List.txt")
        ' arrays to split data
        Dim partsPD() As String
        Dim linePD As String
        'looping to fill arrays 
        For i As Integer = 0 To personalDetail.Count - 1
            linePD = personalDetail(i)
            partsPD = linePD.Split(","c)
            PD(i).name = partsPD(0)
            PD(i).username = partsPD(1)
            PD(i).password = partsPD(2)
            PD(i).region = partsPD(3)
            PD(i).phone = partsPD(4)
            PD(i).dat = partsPD(5)
        Next
        ' to find information by ID of employee
        Dim n As String = MenuView.TextBox2.Text
        Dim queryID = From s In PD
                      Where s.username = n
                      Select s.name, s.username, s.password, s.region, s.phone, s.dat

        DGVInformation.DataSource = queryID.ToList
        DGVInformation.Columns("name").HeaderText = "Name"
        DGVInformation.Columns("username").HeaderText = "Username"
        DGVInformation.Columns("password").HeaderText = "Password"
        DGVInformation.Columns("region").HeaderText = "Region"
        DGVInformation.Columns("phone").HeaderText = "phone"
        DGVInformation.Columns("dat").HeaderText = "Date of Birth"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        MenuView.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class