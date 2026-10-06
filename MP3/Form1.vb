

Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Form1
    Dim name1, company, dept, paygrd, position1, position2 As String
    Dim hours, bcsalary, ot, grossp, deduction, netp, taxsal As Single


    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click

        If Not (IsNumeric(txtHrsWrk1.Text)) Then
            txtName1.Clear()
            txtComp.Clear()
            txtD.Clear()
            txtBcSalary.Clear()
            txtPos1.Clear()
            txtHrsWrk1.Clear()
            txtPaygrade.Clear()
            txtName2.Clear()
            txtPosition2.Clear()
            txtHrsWrk2.Clear()
            txtOT.Clear()
            txtGrossP.Clear()
            txtDeduct.Clear()
            txtNetP.Clear()
            txtHrsWrk1.Focus()
        Else

            name1 = txtName1.Text
            company = txtComp.Text
            dept = txtD.Text
            hours = txtHrsWrk1.Text
            paygrd = txtPaygrade.Text
            position1 = txtPos1.Text

            Select Case position1
                Case "M"
                    position2 = "Messenger"
                    If (position1 = "M") Then
                        If (paygrd = "A") Then
                            bcsalary = 5500
                            taxsal = 5500 * 0.05
                        End If
                        If (paygrd = "B") Then
                            bcsalary = 6500
                            taxsal = 6500 * 0.05
                        End If
                    End If
                Case "E"
                    position2 = "Encoder"
                    If (position1 = "E") Then
                        If (paygrd = "A") Then
                            bcsalary = 6500
                            taxsal = 6500 * 0.06
                        End If
                        If (paygrd = "B") Then
                            bcsalary = 7500
                            taxsal = 7500 * 0.06
                        End If
                    End If
                Case "T"
                    position2 = "Technician"
                    If (position1 = "T") Then
                        If (paygrd = "A") Then
                            bcsalary = 7500
                            taxsal = 7500 * 0.07
                        End If
                        If (paygrd = "B") Then
                            bcsalary = 8500
                            taxsal = 8500 * 0.07
                        End If
                    End If
                Case "P"
                    position2 = "Programmer"
                    If (position1 = "P") Then
                        If (paygrd = "A") Then
                            bcsalary = 10000
                            taxsal = 10000 * 0.08
                        End If
                        If (paygrd = "B") Then
                            bcsalary = 10500
                            taxsal = 10500 * 0.08
                        End If
                    End If
                Case "S"
                    position2 = "System Analyst"
                    If (position1 = "S") Then
                        If (paygrd = "A") Then
                            bcsalary = 12500
                            taxsal = 12500 * 0.09
                        End If
                        If (paygrd = "B") Then
                            bcsalary = 12500
                            taxsal = 12500 * 0.09
                        End If
                    End If
                Case Else
                    txtPos1.Clear()
                    txtPos1.Focus()

            End Select





            If hours > 160 Then
                ot = (hours - 160) * (bcsalary / 160) * 1.5
                deduction = 300 + taxsal
            ElseIf hours = 160 Then
                ot = 0
                deduction = 300 + taxsal

            ElseIf hours < 160 Then
                ot = 0
                deduction = 300 + (bcsalary / 160) * (160 - hours) + taxsal

            End If

            grossp = bcsalary + ot
            netp = grossp - deduction


            txtName2.Text = name1
            txtHrsWrk2.Text = hours
            txtOT.Text = ot.ToString("C2")
            txtGrossP.Text = grossp.ToString("C2")
            txtDeduct.Text = deduction.ToString("C2")
            txtNetP.Text = netp.ToString("C2")
            txtBcSalary.Text = bcsalary.ToString("C2")
            txtPosition2.Text = position2
            txtComp2.Text = company


        End If

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim x As DialogResult
        x = MessageBox.Show("Are you sure you want to exit?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Application.Exit()
        Else
            txtName1.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName2.Enabled = False
        txtPosition2.Enabled = False
        txtHrsWrk2.Enabled = False
        txtOT.Enabled = False
        txtGrossP.Enabled = False
        txtDeduct.Enabled = False
        txtNetP.Enabled = False
        txtBcSalary.Enabled = False
        txtComp2.Enabled = False
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtName1.Clear()
        txtComp.Clear()
        txtD.Clear()
        txtBcSalary.Clear()
        txtPos1.Clear()
        txtHrsWrk1.Clear()
        txtPaygrade.Clear()
        txtName2.Clear()
        txtPosition2.Clear()
        txtHrsWrk2.Clear()
        txtOT.Clear()
        txtGrossP.Clear()
        txtDeduct.Clear()
        txtNetP.Clear()
        txtName1.Focus()
    End Sub
End Class
