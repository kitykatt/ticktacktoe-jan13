Public Class Form1
    Dim go As Integer = 0
    Dim xs As Integer = 0
    Dim os As Integer = 0
    Dim stp As Integer = 0
    Dim bestof As Integer
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click
        If Me.BackColor = DefaultBackColor Then
            If (sender.Text = "" And go = 0) Then 'Or sender.Text = "O") Then
                sender.Text = "X"
                go = 1
            ElseIf (sender.Text = "" And go = 1) Then 'Or sender.Text = "X") Then
                sender.Text = "O"
                go = 0
            End If
        End If
        If winner() Then
            If stp = 0 Then
                stp = 1
                If go = 0 Then
                    os = os + 1
                    Label2.Text = os
                    If os = bestof Then
                        MsgBox("O Is Winner")
                        reset()
                        XO()
                        GroupBox1.Visible = False
                        GroupBox2.Visible = True
                    End If
                End If
                If go = 1 Then
                    xs = xs + 1
                    Label1.Text = xs
                    If xs = bestof Then
                        MsgBox("X Is Winner")
                        reset()
                        XO()
                        GroupBox1.Visible = False
                        GroupBox2.Visible = True
                    End If
                End If
                If GroupBox1.Visible = True Then
                    green()
                End If
            End If
        End If
    End Sub
    Function reset() As Integer
        go = 0
        stp = 0
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
        Me.BackColor = DefaultBackColor
        B1.BackColor = DefaultBackColor
        B2.BackColor = DefaultBackColor
        B3.BackColor = DefaultBackColor
        B4.BackColor = DefaultBackColor
        B5.BackColor = DefaultBackColor
        B6.BackColor = DefaultBackColor
        B7.BackColor = DefaultBackColor
        B8.BackColor = DefaultBackColor
        B9.BackColor = DefaultBackColor
    End Function
    Function XO() As Integer
        xs = 0
        Label1.Text = xs
        os = 0
        Label2.Text = os
    End Function
    Function green() As Integer
        Me.BackColor = Color.Green
        B1.BackColor = Color.Green
        B2.BackColor = Color.Green
        B3.BackColor = Color.Green
        B4.BackColor = Color.Green
        B5.BackColor = Color.Green
        B6.BackColor = Color.Green
        B7.BackColor = Color.Green
        B8.BackColor = Color.Green
        B9.BackColor = Color.Green
    End Function
    Function winner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> "" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> "" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> "" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> "" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> "" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> "" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> "" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> "" Then Return True
        Return False
    End Function
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        bestof = 2
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        bestof = 3
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        bestof = 4
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        bestof = 5
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reset()
        XO()
    End Sub
End Class