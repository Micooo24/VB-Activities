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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RemoveAt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cmdAdd2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RemoveAt2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDept2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.RemoveAt)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txtDept)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(135, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 281)
        Me.Panel1.TabIndex = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(142, 199)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(94, 29)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(260, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Insert"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RemoveAt
        '
        Me.RemoveAt.Location = New System.Drawing.Point(142, 153)
        Me.RemoveAt.Name = "RemoveAt"
        Me.RemoveAt.Size = New System.Drawing.Size(94, 29)
        Me.RemoveAt.TabIndex = 5
        Me.RemoveAt.Text = "Remove"
        Me.RemoveAt.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Index"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"IT", "CIVIL", "ELECTRICAL"})
        Me.ComboBox1.Location = New System.Drawing.Point(283, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(142, 38)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(125, 27)
        Me.txtDept.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.cmdAdd2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.RemoveAt2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.txtDept2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(637, 152)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 281)
        Me.Panel2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(109, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 27)
        Me.TextBox3.TabIndex = 8
        '
        'cmdAdd2
        '
        Me.cmdAdd2.Location = New System.Drawing.Point(123, 210)
        Me.cmdAdd2.Name = "cmdAdd2"
        Me.cmdAdd2.Size = New System.Drawing.Size(94, 29)
        Me.cmdAdd2.TabIndex = 8
        Me.cmdAdd2.Text = "Add"
        Me.cmdAdd2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(238, 165)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Insert"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RemoveAt2
        '
        Me.RemoveAt2.Location = New System.Drawing.Point(123, 165)
        Me.RemoveAt2.Name = "RemoveAt2"
        Me.RemoveAt2.Size = New System.Drawing.Size(94, 29)
        Me.RemoveAt2.TabIndex = 8
        Me.RemoveAt2.Text = "Remove"
        Me.RemoveAt2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDept2
        '
        Me.txtDept2.Location = New System.Drawing.Point(109, 37)
        Me.txtDept2.Name = "txtDept2"
        Me.txtDept2.Size = New System.Drawing.Size(125, 27)
        Me.txtDept2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Index"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Department"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"BASKETBALL", "VOLLEYBALL", "BADMINTON", "TENNIS"})
        Me.ListBox1.Location = New System.Drawing.Point(238, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 144)
        Me.ListBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 506)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDept As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RemoveAt As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdAdd2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents RemoveAt2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDept2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
