Public Class frmAbaks

   Private op As String
   Private opResult As String
   Private opInitial As Double

   Private Sub ApplyPendingOperation()
      If opResult <> "" Then
         Dim value = Double.Parse(opResult)

         Select Case op
            Case "+"
               opInitial += value
            Case "-"
               opInitial -= value
            Case "*"
               opInitial *= value
            Case "/"
               If value <> 0 Then
                  opInitial /= value
               Else
                  MessageBox.Show("Cannot divide by zero")
               End If
            Case ""   ' first number entered
               opInitial = value
         End Select
      End If

      txtBoxResult.Text = opInitial.ToString()
      opResult = ""
   End Sub

   Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      opResult = ""
      opInitial = 0
   End Sub

   Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
      opResult += "1"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
      opResult += "2"
      txtBoxCurrent.Text = opResult
   End Sub
   Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
      opResult += "3"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
      opResult += "4"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
      opResult += "5"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
      opResult += "6"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
      opResult += "7"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
      opResult += "8"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
      opResult += "9"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
      opResult += "0"
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
      txtBoxCurrent.Text = ""
   End Sub

   Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
      txtBoxCurrent.Text = ""
      txtBoxResult.Text = ""
   End Sub

   Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click
      opResult = (-Double.Parse(opResult)).ToString()
      txtBoxCurrent.Text = opResult
   End Sub

   Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
      ApplyPendingOperation()
      op = "+"
   End Sub

   Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
      ApplyPendingOperation()
      op = "-"
   End Sub

   Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
      ApplyPendingOperation()
      op = "*"
   End Sub

   Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
      ApplyPendingOperation()
      op = "/"
   End Sub

   Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
      ApplyPendingOperation()
      op = ""
   End Sub
End Class
