Public Class Payment
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Total.Text = MenuView.TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkCard()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtcard.Clear()
        txtcvv.Clear()
        txte.Clear()
        txtaddress.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
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
    Function calculate()
        Dim total, price, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 As Double
        If MenuView.CheckBox1.Checked Then
            s1 = CDbl(MenuView.p1.Text) * CDbl(MenuView.t1.Text)
        End If
        If MenuView.CheckBox2.Checked Then
            s2 = CDbl(MenuView.p2.Text) * CDbl(MenuView.t2.Text)
        End If
        If MenuView.CheckBox3.Checked Then
            s3 = CDbl(MenuView.p3.Text) * CDbl(MenuView.t3.Text)
        End If
        If MenuView.CheckBox4.Checked Then
            s4 = CDbl(MenuView.p4.Text) * CDbl(MenuView.t4.Text)
        End If
        If MenuView.CheckBox5.Checked Then
            s5 = CDbl(MenuView.p5.Text) * CDbl(MenuView.t5.Text)
        End If
        If MenuView.CheckBox6.Checked Then
            s6 = CDbl(MenuView.p6.Text) * CDbl(MenuView.t6.Text)
        End If
        If MenuView.CheckBox7.Checked Then
            s7 = CDbl(MenuView.p7.Text) * CDbl(MenuView.t7.Text)
        End If
        If MenuView.CheckBox8.Checked Then
            s8 = CDbl(MenuView.p8.Text) * CDbl(MenuView.t8.Text)
        End If
        If MenuView.CheckBox9.Checked Then
            s9 = CDbl(MenuView.p9.Text) * CDbl(MenuView.t9.Text)
        End If
        If MenuView.CheckBox10.Checked Then
            s10 = CDbl(MenuView.p10.Text) * CDbl(MenuView.t10.Text)
        End If
        total = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
        If MenuView.RadioButton1.Checked Then
            price = (total - (total * 0.25))
        Else
            price = total
        End If
        Return price
    End Function
    Function checkCard()
        Dim dat As Integer = CDate(txte.Text).Year
        If txtcard.Text.Length() <> 16 Then
            MessageBox.Show("Please Enter 16 number of your card!", "ERROR")
        ElseIf txte.Text.Length() <> 10 Then
            MessageBox.Show("Please Enter expiry date of your card!E.g: 01/01/2020", "ERROR")
        ElseIf dat < Today.Year Then
            MessageBox.Show("Your card is expired", "ERROR")
        ElseIf txtcvv.Text.Length() <> 3 Then
            MessageBox.Show("Please Enter security code of your card!E.g: 123", "ERROR")

        ElseIf txtaddress.Text = "" Then
            MessageBox.Show("Please Enter your address ", "ERROR")
        Else
            Done.Show()
            MessageBox.Show("Your payment is confirmed ", "Confirmed")
        End If
        Return ""
    End Function

End Class