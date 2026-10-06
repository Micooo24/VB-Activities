Public Class Form1

    'COMBO BOX 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtDept.Text = ComboBox1.Text

        TextBox1.Text = ComboBox1.SelectedIndex

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Remove(txtDept.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RemoveAt.Click
        ComboBox1.Items.RemoveAt(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Insert(3, "Electronics")
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim dept As String
        Dim i As Integer

        dept = InputBox("Enter depeartment name", "Dept")

        For i = 0 To ComboBox1.Items.Count - 1

            If (ComboBox1.Items(i) = dept) Then
                MessageBox.Show("Existing", "Error")
                Exit Sub

            End If
        Next i
        ComboBox1.Items.Add(dept)


    End Sub


    'LIST BOX
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtDept2.Text = ListBox1.Text

        TextBox3.Text = ListBox1.SelectedIndex

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(txtDept2.Text)
    End Sub

    Private Sub RemoveAt2_Click(sender As Object, e As EventArgs) Handles RemoveAt2.Click

        ListBox1.Items.RemoveAt(TextBox3.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Insert(4, "SOCCER")

    End Sub

    Private Sub cmdAdd2_Click(sender As Object, e As EventArgs) Handles cmdAdd2.Click

        Dim department As String
        Dim j As Integer

        department = InputBox("Enter depeartment name", "Dept")

        For j = 0 To ListBox1.Items.Count - 1

            If (ListBox1.Items(j) = department) Then
                MessageBox.Show("Existing", "Error")
                Exit Sub

            End If
        Next j
        ListBox1.Items.Add(department)


    End Sub











End Class
