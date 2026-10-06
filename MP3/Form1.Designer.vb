<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPos1 = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtPosition1 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBcSalary = New System.Windows.Forms.TextBox()
        Me.txtPaygrade = New System.Windows.Forms.TextBox()
        Me.txtHrsWrk1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNetP = New System.Windows.Forms.TextBox()
        Me.txtDeduct = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGrossP = New System.Windows.Forms.TextBox()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.txtHrsWrk2 = New System.Windows.Forms.TextBox()
        Me.txtPosition2 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdCompute = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtComp2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtPos1)
        Me.GroupBox1.Controls.Add(Me.txtD)
        Me.GroupBox1.Controls.Add(Me.txtComp)
        Me.GroupBox1.Controls.Add(Me.txtName1)
        Me.GroupBox1.Controls.Add(Me.txtPosition1)
        Me.GroupBox1.Controls.Add(Me.txtDept)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE INFO"
        '
        'txtPos1
        '
        Me.txtPos1.Location = New System.Drawing.Point(137, 155)
        Me.txtPos1.Name = "txtPos1"
        Me.txtPos1.Size = New System.Drawing.Size(125, 27)
        Me.txtPos1.TabIndex = 7
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(137, 115)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(125, 27)
        Me.txtD.TabIndex = 6
        '
        'txtComp
        '
        Me.txtComp.Location = New System.Drawing.Point(137, 76)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(125, 27)
        Me.txtComp.TabIndex = 5
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(137, 42)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(125, 27)
        Me.txtName1.TabIndex = 4
        '
        'txtPosition1
        '
        Me.txtPosition1.AutoSize = True
        Me.txtPosition1.Location = New System.Drawing.Point(25, 155)
        Me.txtPosition1.Name = "txtPosition1"
        Me.txtPosition1.Size = New System.Drawing.Size(77, 20)
        Me.txtPosition1.TabIndex = 3
        Me.txtPosition1.Text = "POSITION:"
        '
        'txtDept
        '
        Me.txtDept.AutoSize = True
        Me.txtDept.Location = New System.Drawing.Point(25, 115)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(104, 20)
        Me.txtDept.TabIndex = 2
        Me.txtDept.Text = "DEPARTMENT:"
        '
        'txtCompany
        '
        Me.txtCompany.AutoSize = True
        Me.txtCompany.Location = New System.Drawing.Point(25, 76)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(81, 20)
        Me.txtCompany.TabIndex = 1
        Me.txtCompany.Text = "COMPANY:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.txtBcSalary)
        Me.GroupBox2.Controls.Add(Me.txtPaygrade)
        Me.GroupBox2.Controls.Add(Me.txtHrsWrk1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 313)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PAYROLL INPUTS:"
        '
        'txtBcSalary
        '
        Me.txtBcSalary.Location = New System.Drawing.Point(163, 119)
        Me.txtBcSalary.Name = "txtBcSalary"
        Me.txtBcSalary.Size = New System.Drawing.Size(125, 27)
        Me.txtBcSalary.TabIndex = 5
        '
        'txtPaygrade
        '
        Me.txtPaygrade.Location = New System.Drawing.Point(163, 72)
        Me.txtPaygrade.Name = "txtPaygrade"
        Me.txtPaygrade.Size = New System.Drawing.Size(125, 27)
        Me.txtPaygrade.TabIndex = 5
        '
        'txtHrsWrk1
        '
        Me.txtHrsWrk1.Location = New System.Drawing.Point(163, 35)
        Me.txtHrsWrk1.Name = "txtHrsWrk1"
        Me.txtHrsWrk1.Size = New System.Drawing.Size(125, 27)
        Me.txtHrsWrk1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "BASIC SALARY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "PAY GRADE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HOURS WORK:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Olive
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtComp2)
        Me.GroupBox3.Controls.Add(Me.txtNetP)
        Me.GroupBox3.Controls.Add(Me.txtDeduct)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtGrossP)
        Me.GroupBox3.Controls.Add(Me.txtOT)
        Me.GroupBox3.Controls.Add(Me.txtHrsWrk2)
        Me.GroupBox3.Controls.Add(Me.txtPosition2)
        Me.GroupBox3.Controls.Add(Me.txtName2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(822, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 413)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PAYSLIP"
        '
        'txtNetP
        '
        Me.txtNetP.Location = New System.Drawing.Point(155, 278)
        Me.txtNetP.Name = "txtNetP"
        Me.txtNetP.Size = New System.Drawing.Size(125, 27)
        Me.txtNetP.TabIndex = 19
        '
        'txtDeduct
        '
        Me.txtDeduct.Location = New System.Drawing.Point(155, 239)
        Me.txtDeduct.Name = "txtDeduct"
        Me.txtDeduct.Size = New System.Drawing.Size(125, 27)
        Me.txtDeduct.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "NET PAY:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "DEDUCTIONS:"
        '
        'txtGrossP
        '
        Me.txtGrossP.Location = New System.Drawing.Point(155, 195)
        Me.txtGrossP.Name = "txtGrossP"
        Me.txtGrossP.Size = New System.Drawing.Size(125, 27)
        Me.txtGrossP.TabIndex = 18
        '
        'txtOT
        '
        Me.txtOT.Location = New System.Drawing.Point(155, 155)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(125, 27)
        Me.txtOT.TabIndex = 17
        '
        'txtHrsWrk2
        '
        Me.txtHrsWrk2.Location = New System.Drawing.Point(155, 115)
        Me.txtHrsWrk2.Name = "txtHrsWrk2"
        Me.txtHrsWrk2.Size = New System.Drawing.Size(125, 27)
        Me.txtHrsWrk2.TabIndex = 16
        '
        'txtPosition2
        '
        Me.txtPosition2.Location = New System.Drawing.Point(144, 76)
        Me.txtPosition2.Name = "txtPosition2"
        Me.txtPosition2.Size = New System.Drawing.Size(125, 27)
        Me.txtPosition2.TabIndex = 15
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(144, 39)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(125, 27)
        Me.txtName2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "GROSS PAY:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "OVERTIME:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "HOURS WORKED:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "POSITION:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "NAME:"
        '
        'cmdCompute
        '
        Me.cmdCompute.Location = New System.Drawing.Point(273, 414)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(94, 29)
        Me.cmdCompute.TabIndex = 3
        Me.cmdCompute.Text = "COMPUTE"
        Me.cmdCompute.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(415, 414)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(94, 29)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "RESET"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(558, 414)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(94, 29)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "EXIT"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtComp2
        '
        Me.txtComp2.Location = New System.Drawing.Point(155, 330)
        Me.txtComp2.Name = "txtComp2"
        Me.txtComp2.Size = New System.Drawing.Size(125, 27)
        Me.txtComp2.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "COMPANY:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 555)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPosition1 As Label
    Friend WithEvents txtDept As Label
    Friend WithEvents txtCompany As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPos1 As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtComp As TextBox
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBcSalary As TextBox
    Friend WithEvents txtPaygrade As TextBox
    Friend WithEvents txtHrsWrk1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOT As TextBox
    Friend WithEvents txtHrsWrk2 As TextBox
    Friend WithEvents txtPosition2 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNetP As TextBox
    Friend WithEvents txtDeduct As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGrossP As TextBox
    Friend WithEvents cmdCompute As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComp2 As TextBox
End Class
