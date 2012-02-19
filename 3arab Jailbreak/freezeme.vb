Public Class freezeme

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("الجيلبريك غير المقيد هو الجيلبريك الذى من خلاله لا تحتاج لكمبيوتر عند اعادة تشغيلك للجهاز", "3arab Jailbreak Help Rc1")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("http://freezeme.co.nr/")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://www.jailbreakme.com/")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class