Public Class Done
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim text As String = "In document_PrintPage method."
        Dim dashes As String = "---------------------------------------------------------------------------------------------------------"
        Dim header As String = ("Item" & "                         " & "QTY" & "                         " & "Price")
        Dim l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13 As String
        l1 = (MenuView.CheckBox1.Text & "                  " & MenuView.t1.Text & "                  " & MenuView.p1.Text)
        l2 = (MenuView.CheckBox2.Text & "                  " & MenuView.t2.Text & "                  " & MenuView.p2.Text)
        l3 = (MenuView.CheckBox3.Text & "                  " & MenuView.t3.Text & "                  " & MenuView.p3.Text)
        l4 = (MenuView.CheckBox4.Text & "                  " & MenuView.t4.Text & "                  " & MenuView.p4.Text)
        l5 = (MenuView.CheckBox5.Text & "                  " & MenuView.t5.Text & "                  " & MenuView.p5.Text)
        l6 = (MenuView.CheckBox6.Text & "                  " & MenuView.t6.Text & "                  " & MenuView.p6.Text)
        l7 = (MenuView.CheckBox7.Text & "                  " & MenuView.t7.Text & "                  " & MenuView.p7.Text)
        l8 = (MenuView.CheckBox8.Text & "                  " & MenuView.t8.Text & "                  " & MenuView.p8.Text)
        l9 = (MenuView.CheckBox9.Text & "                  " & MenuView.t9.Text & "                  " & MenuView.p9.Text)
        l10 = (MenuView.CheckBox10.Text & "                  " & MenuView.t10.Text & "                  " & MenuView.p10.Text)
        l11 = ("Total:" & MenuView.TextBox1.Text)
        l12 = ("Username:" & MenuView.TextBox2.Text)
        l13 = ("Address:" & Payment.txtaddress.Text)
        Dim printFont As New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular)
        e.Graphics.DrawString(dashes, printFont, System.Drawing.Brushes.Black, 10, 50)
        e.Graphics.DrawString(header, printFont, System.Drawing.Brushes.Black, 10, 100)
        e.Graphics.DrawString(dashes, printFont, System.Drawing.Brushes.Black, 10, 120)
        If MenuView.CheckBox1.Checked Then
            e.Graphics.DrawString(l1, printFont, System.Drawing.Brushes.Black, 10, 150)
        End If
        If MenuView.CheckBox2.Checked Then
            e.Graphics.DrawString(l2, printFont, System.Drawing.Brushes.Black, 10, 200)
        End If
        If MenuView.CheckBox3.Checked Then
            e.Graphics.DrawString(l3, printFont, System.Drawing.Brushes.Black, 10, 250)
        End If
        If MenuView.CheckBox4.Checked Then
            e.Graphics.DrawString(l4, printFont, System.Drawing.Brushes.Black, 10, 300)
        End If
        If MenuView.CheckBox5.Checked Then
            e.Graphics.DrawString(l5, printFont, System.Drawing.Brushes.Black, 10, 350)
        End If
        If MenuView.CheckBox6.Checked Then
            e.Graphics.DrawString(l6, printFont, System.Drawing.Brushes.Black, 10, 400)
        End If
        If MenuView.CheckBox7.Checked Then
            e.Graphics.DrawString(l7, printFont, System.Drawing.Brushes.Black, 10, 450)
        End If
        If MenuView.CheckBox8.Checked Then
            e.Graphics.DrawString(l8, printFont, System.Drawing.Brushes.Black, 10, 500)
        End If
        If MenuView.CheckBox9.Checked Then
            e.Graphics.DrawString(l9, printFont, System.Drawing.Brushes.Black, 10, 550)
        End If
        If MenuView.CheckBox10.Checked Then
            e.Graphics.DrawString(l10, printFont, System.Drawing.Brushes.Black, 10, 600)
        End If
        e.Graphics.DrawString(dashes, printFont, System.Drawing.Brushes.Black, 10, 650)
        e.Graphics.DrawString(l11, printFont, System.Drawing.Brushes.Black, 45, 700)
        e.Graphics.DrawString(l12, printFont, System.Drawing.Brushes.Black, 50, 750)
        e.Graphics.DrawString(l12, printFont, System.Drawing.Brushes.Black, 50, 800)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Done_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListView1.View = View.List
        ListView1.Items.Add("---------------------------------------------------------------------------------------------------------")
        ListView1.Items.Add("Item" & "                  " & "QTY" & "                  " & "Price")
        ListView1.Items.Add("---------------------------------------------------------------------------------------------------------")
        If MenuView.CheckBox1.Checked Then
            ListView1.Items.Add(MenuView.CheckBox1.Text & "                  " & MenuView.t1.Text & "                  " & MenuView.p1.Text)
        End If
        If MenuView.CheckBox2.Checked Then
            ListView1.Items.Add(MenuView.CheckBox2.Text & "                  " & MenuView.t2.Text & "                  " & MenuView.p2.Text)
        End If
        If MenuView.CheckBox3.Checked Then
            ListView1.Items.Add(MenuView.CheckBox3.Text & "                  " & MenuView.t3.Text & "                  " & MenuView.p3.Text)
        End If
        If MenuView.CheckBox4.Checked Then
            ListView1.Items.Add(MenuView.CheckBox4.Text & "                  " & MenuView.t4.Text & "                  " & MenuView.p4.Text)
        End If
        If MenuView.CheckBox5.Checked Then
            ListView1.Items.Add(MenuView.CheckBox5.Text & "                  " & MenuView.t5.Text & "                  " & MenuView.p5.Text)
        End If
        If MenuView.CheckBox6.Checked Then
            ListView1.Items.Add(MenuView.CheckBox6.Text & "                  " & MenuView.t6.Text & "                  " & MenuView.p6.Text)
        End If
        If MenuView.CheckBox7.Checked Then
            ListView1.Items.Add(MenuView.CheckBox7.Text & "                  " & MenuView.t7.Text & "                  " & MenuView.p7.Text)
        End If
        If MenuView.CheckBox8.Checked Then
            ListView1.Items.Add(MenuView.CheckBox8.Text & "                  " & MenuView.t8.Text & "                  " & MenuView.p8.Text)
        End If
        If MenuView.CheckBox9.Checked Then
            ListView1.Items.Add(MenuView.CheckBox9.Text & "                  " & MenuView.t9.Text & "                  " & MenuView.p9.Text)
        End If
        If MenuView.CheckBox10.Checked Then
            ListView1.Items.Add(MenuView.CheckBox10.Text & "                  " & MenuView.t10.Text & "                  " & MenuView.p10.Text)
        End If
        ListView1.Items.Add("---------------------------------------------------------------------------------------------------------")
        ListView1.Items.Add("Total:" & MenuView.TextBox1.Text)
        ListView1.Items.Add("Username:" & MenuView.TextBox2.Text)
        ListView1.Items.Add("Address:" & Payment.txtaddress.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()
        Payment.Close()
        MenuView.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        MenuView.Show()
        Me.Close()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.Show()

    End Sub
End Class