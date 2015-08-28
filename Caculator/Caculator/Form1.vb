Public Class Calculator

    Private Sub calculateBtn_toggle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateBtn.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        If input1TextBox.Text = "" OrElse input2TextBox.Text = "" Then
            MessageBox.Show("Please Enter a Number")
        ElseIf additionRb.Checked = False And SubtractRb.Checked = False And MultiplyRb.Checked = False And DivideRb.Checked = False Then
            MessageBox.Show("Please Choose an Operation")
        Else
            number1 = Double.Parse(input1TextBox.Text)
            number2 = Double.Parse(input1TextBox.Text)

            If additionRb.Checked = True Then
                answer = number1 + number2
                answerLbl.Text = answer.ToString()
            ElseIf SubtractRb.Checked = True Then
                answer = number1 - number2
                answerLbl.Text = answer.ToString()
            ElseIf MultiplyRb.Checked = True Then
                If number1 = 0 OrElse number2 = 0 Then
                    answerLbl.Text = "0"
                Else
                    answer = number1 * number2
                    answerLbl.Text = answer.ToString()
                End If
            ElseIf DivideRb.Checked = True Then
                If number1 = 0 Then
                    answerLbl.Text = "0"
                ElseIf number2 = 0 Then
                    answerLbl.Text = "Cannot Divide by Zero"
                Else
                    answer = number1 / number2
                    answerLbl.Text = answer.ToString()
                End If
            End If
        End If

    End Sub

    Private Sub userInput1TextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles input1TextBox.TextChanged

    End Sub

    Private Sub userInput2TextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles input2TextBox.TextChanged

    End Sub

    Private Sub CalculateBtn_Click(sender As System.Object, e As System.EventArgs) Handles calculateBtn.Click

    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        input1TextBox.Text = ""
        input2TextBox.Text = ""
        answerLbl.Text = ""

        If additionRb.Checked = True Then
            additionRb.Checked = False
            symbolLbl.Text = ""
        ElseIf SubtractRb.Checked = True Then
            SubtractRb.Checked = False
            symbolLbl.Text = ""
        ElseIf MultiplyRb.Checked = True Then
            MultiplyRb.Checked = False
            symbolLbl.Text = ""
        Else
            DivideRb.Checked = False
            symbolLbl.Text = ""
        End If
    End Sub

    Private Sub additionRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles additionRb.CheckedChanged
        symbolLbl.Text = "+"
        answerLbl.Text = ""
    End Sub

    Private Sub subtractRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtractRb.CheckedChanged
        symbolLbl.Text = "-"
        answerLbl.Text = ""
    End Sub

    Private Sub multiplyRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiplyRb.CheckedChanged
        symbolLbl.Text = "*"
        answerLbl.Text = ""
    End Sub

    Private Sub divideRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivideRb.CheckedChanged
        symbolLbl.Text = "/"
        answerLbl.Text = ""
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class