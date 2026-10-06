Public Class Form1
    Dim num1, num2, num3 As Integer

    'RADIOBUTTON
    Private Sub rbtDIV_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDIV.CheckedChanged
        'num3 = Integer.Parse(txtNum1.Text) / Integer.Parse(txtNum2.Text)
        'txtDisplay.Text = num3
    End Sub


    Private Sub rbtMOD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMOD.CheckedChanged
        'num3 = Integer.Parse(txtNum1.Text) Mod Integer.Parse(txtNum2.Text)
        'txtDisplay.Text = num3
    End Sub

    Private Sub rbtSQUARE_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSQUARE.CheckedChanged, rbtMOD.CheckedChanged, rbtDIV.CheckedChanged

        '  Dim rbt As RadioButton = CType(sender, RadioButton)
        'Select Case rbt.Name
        'Case "rbtSQUARE"
        ' num3 = Integer.Parse(txtNum1.Text) ^ Integer.Parse(txtNum2.Text)
        ' txtDisplay.Text = num3
        'Case "rbtMOD"
        ' num3 = Integer.Parse(txtNum1.Text) Mod Integer.Parse(txtNum2.Text)
        'txtDisplay.Text = num3
        ' Case "rbtDIV"
        'num3 = Integer.Parse(txtNum1.Text) / Integer.Parse(txtNum2.Text)
        'txtDisplay.Text = num3


        ' End Select

    End Sub

    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click

        If (rbtSQUARE.Checked = True) Then
            num3 = Integer.Parse(txtNum1.Text) ^ Integer.Parse(txtNum2.Text)
            txtDisplay.Text = num3
        ElseIf (rbtMOD.Checked = True) Then
            num3 = Integer.Parse(txtNum1.Text) Mod Integer.Parse(txtNum2.Text)
            txtDisplay.Text = num3
        Else
            num3 = Integer.Parse(txtNum1.Text) / Integer.Parse(txtNum2.Text)
            txtDisplay.Text = num3

        End If


    End Sub
    Private Sub cmdReset1_Click(sender As Object, e As EventArgs) Handles cmdReset1.Click
        txtNum1.Clear()
        txtNum2.Clear()
        txtDisplay.Clear()
        txtNum1.Focus()


    End Sub

    Private Sub cmdExit1_Click(sender As Object, e As EventArgs) Handles cmdExit1.Click
        Application.Exit()
    End Sub



    'CHECKLIST 




    Private Sub chkMODULO_CheckedChanged(sender As Object, e As EventArgs) Handles chkMODULO.CheckedChanged
        'num3 = Integer.Parse(txtNO1.Text) Mod Integer.Parse(txtNO2.Text)
        'txtResult.Text = num3
    End Sub

    Private Sub chkDIV_CheckedChanged(sender As Object, e As EventArgs) Handles chkDIV.CheckedChanged
        'num3 = Integer.Parse(txtNO1.Text) / Integer.Parse(txtNO2.Text)
        'txtResult.Text = num3
    End Sub


    Private Sub chkSQUARED_CheckedChanged(sender As Object, e As EventArgs) Handles chkSQUARED.CheckedChanged
        'num3 = Integer.Parse(txtNO1.Text) ^ Integer.Parse(txtNO2.Text)
        'txtResult.Text = num3
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles cmdCompute2.Click
        If (Not (IsNumeric(txtNO1.Text))) Then
            txtNO1.Clear()
        ElseIf (Not (IsNumeric(txtNO1.Text))) Then
            txtNO2.Clear()

        Else
            If (chkSQUARED.Checked = True) Then
                num3 = Integer.Parse(txtNO1.Text) ^ Integer.Parse(txtNO2.Text)
                txtResult.Text = num3
                chkMODULO.Checked = False
                chkDIV.Checked = False

            ElseIf (chkMODULO.Checked = True) Then
                num3 = Integer.Parse(txtNO1.Text) Mod Integer.Parse(txtNO2.Text)
                txtResult.Text = num3
                chkSQUARED.Checked = False
                chkDIV.Checked = False
            ElseIf (chkDIV.Checked = True) Then
                num3 = Integer.Parse(txtNO1.Text) / Integer.Parse(txtNO2.Text)
                txtResult.Text = num3
            Else
                chkMODULO.Checked = False
                chkSQUARED.Checked = False


            End If
        End If

    End Sub
    Private Sub cmdReset2_Click(sender As Object, e As EventArgs) Handles cmdReset2.Click
        txtNO1.Clear()
        txtNO2.Clear()
        txtResult.Clear()
        txtNO1.Focus()



    End Sub
    Private Sub cmdExit2_Click(sender As Object, e As EventArgs) Handles cmdExit2.Click
        Me.Close()
    End Sub
End Class

