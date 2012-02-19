Public Class Form6
    'For manual operation
    'Get all of the needed device info
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "iPhone" Then
            ComboBox2.Items.Insert(0, "iPhone 2g")
            ComboBox2.Items.Insert(1, "iPhone 3g")
            ComboBox2.Items.Insert(2, "iPhone 3gs")
            ComboBox2.Items.Insert(3, "iPhone 4")
            ComboBox2.Items.Insert(4, "iPhone 4s")
            ComboBox2.Visible = True
        ElseIf ComboBox1.Text = "Apple TV 2g" Then
            iPhonev = "Apple TV 2g"
            ComboBox2.Items.Insert(0, "4.1")
            ComboBox2.Items.Insert(1, "4.2.1")
            ComboBox2.Items.Insert(2, "4.3")
            ComboBox2.Items.Insert(3, "4.4")
            ComboBox2.Items.Insert(4, "4.4.1")
            ComboBox2.Items.Insert(5, "4.4.2")
            ComboBox2.Visible = True
        ElseIf ComboBox1.Text = "iPad" Then
            ComboBox2.Items.Insert(0, "iPad 1g")
            ComboBox2.Items.Insert(1, "iPad 2g")
            ComboBox2.Visible = True
        ElseIf ComboBox1.Text = "iPod touch" Then
            ComboBox2.Items.Insert(0, "iPod touch 1g")
            ComboBox2.Items.Insert(1, "iPod touch 2g")
            ComboBox2.Items.Insert(2, "iPod touch 3g")
            ComboBox2.Items.Insert(3, "iPod touch 4")
            ComboBox2.Visible = True
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.Text = "iPhone" And ComboBox2.Text = "iPhone 4s" Then
            iPhonev = "iPhone 4s"
            ComboBox3.Items.Insert(0, "5.0")
            ComboBox3.Items.Insert(1, "5.0.1")
            ComboBox3.Items.Insert(2, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPhone" And ComboBox2.Text = "iPhone 4" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPhone" And ComboBox2.Text = "iPhone 3gs" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPod touch" And ComboBox2.Text = "iPod touch 3g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPod touch" And ComboBox2.Text = "iPod touch 4" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPad" And ComboBox2.Text = "iPad 2g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPad" And ComboBox2.Text = "iPad 1g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.3")
            ComboBox3.Items.Insert(1, "4.3.1")
            ComboBox3.Items.Insert(2, "4.3.2")
            ComboBox3.Items.Insert(3, "4.3.3")
            ComboBox3.Items.Insert(4, "4.3.4")
            ComboBox3.Items.Insert(5, "4.3.5")
            ComboBox3.Items.Insert(6, "5.0")
            ComboBox3.Items.Insert(7, "5.0.1")
            ComboBox3.Items.Insert(8, "5.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPhone" And ComboBox2.Text = "iPhone 3g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.2.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPod touch" And ComboBox2.Text = "iPod touch 2g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "4.2.1")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPhone" And ComboBox2.Text = "iPhone 2g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "3.1.3")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "iPod touch" And ComboBox2.Text = "iPod touch 1g" Then
            iPhonev = ComboBox2.Text
            ComboBox3.Items.Insert(0, "3.1.3")
            ComboBox3.Visible = True
        ElseIf ComboBox1.Text = "Apple TV 2g" Then
            firmware = ComboBox2.Text
            Button1.Show()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        firmware = ComboBox3.Text
        Button1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class