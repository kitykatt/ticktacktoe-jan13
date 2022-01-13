Public Class Form1
    Dim go As Integer = 0
    Dim xs As Integer = 0
    Dim os As Integer = 0
    Dim stp As Integer = 0
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click
        If Me.BackColor = DefaultBackColor Then
            If (sender.Text = "" And go = 0 Or sender.Text = "O") Then
                sender.Text = "X"
                go = 1
            ElseIf (sender.Text = "" And go = 1 Or sender.Text = "X") Then
                sender.Text = "O"
                go = 0
            End If
        End If
        If winner() Then
            If stp = 0 Then
                stp = 1
                If go = 1 Then
                    xs = xs + 1
                    Label1.Text = xs
                End If
                If go = 0 Then
                    os = os + 1
                    Label2.Text = os
                End If
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
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    End Sub
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
End Class
