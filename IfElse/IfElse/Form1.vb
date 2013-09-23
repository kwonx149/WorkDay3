Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        'If ser did not type the numbers, eliminate him
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'If user did not type the positive numbers, eliminate him
        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Error: Please type a positive number")
            Return
        End If

        'Sterile area
        If (num1 > num2) Then
            txtResult.Text = "Larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "Larger number is " & num2
        Else
            txtResult.Text = "The two are equal."

        End If
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
