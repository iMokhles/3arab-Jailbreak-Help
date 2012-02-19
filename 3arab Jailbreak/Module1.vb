Module Module1
    Public firmware As String = ""
    Public iPhonev As String = ""
    Public model As String = ""
    Public extra As String = ""
    Public tether As Boolean = False
    Public bits As String
    Public itunesexists As Boolean = False
    Public mode As String
    Private Property window As ProcessWindowStyle

    Public Sub cmd(ByVal file As String, ByVal arg As String)
        'from stantheripper (who probably took it from iH8s0w)...
        Dim procNlite As New Process
        window = 1
        procNlite.StartInfo.FileName = file
        procNlite.StartInfo.Arguments = " " & arg
        procNlite.StartInfo.WindowStyle = window
        Application.DoEvents()
        procNlite.Start()
        Do Until procNlite.HasExited
            Application.DoEvents()
            For i = 0 To 5000000
                Application.DoEvents()
            Next
        Loop
        procNlite.WaitForExit()
    End Sub
    'How to jailbreak!
    Public Sub ipt3(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form4.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            freezeme.Show()
        ElseIf fwv = "4.3.1" Then
            freezeme.Show()
        ElseIf fwv = "4.3" Then
            freezeme.Show()
        ElseIf fwv = "5.1" Then
            tether = True
            Form5.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub ipt4(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form4.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            freezeme.Show()
        ElseIf fwv = "4.3.1" Then
            freezeme.Show()
        ElseIf fwv = "4.3" Then
            freezeme.Show()
        ElseIf fwv = "5.1" Then
            tether = True
            Form5.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub ipt2mc(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub ipt2mb(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub ipt1(ByVal fwv As String)
        If fwv = "3.1.3" Then
            freezeme.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub atv2(ByVal fwv As String)
        MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
    End Sub
    Public Sub ip1(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form4.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            freezeme.Show()
        ElseIf fwv = "4.3.1" Then
            freezeme.Show()
        ElseIf fwv = "4.3" Then
            freezeme.Show()
        ElseIf fwv = "5.1" Then
            tether = True
            Form5.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub ip2(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = False
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = False
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = False
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = False
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            tether = False
            Form5.Show()
        ElseIf fwv = "4.3.1" Then
            tether = False
            Form5.Show()
        ElseIf fwv = "4.3" Then
            'There was a leaked version of comex's jailbreakme that supposedly jailbroke this firmware... I still have that pdf
            tether = False
            Form5.Show()
        ElseIf fwv = "5.1" Then
            tether = False
            Form5.Show()
        Else
            'Should not happen, all current firmwares are supported
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub iph2(ByVal fwv As String)
        If fwv = "3.1.3" Then
            freezeme.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub iph3(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub iph3gs(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form4.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            freezeme.Show()
        ElseIf fwv = "4.3.1" Then
            freezeme.Show()
        ElseIf fwv = "4.3" Then
            freezeme.Show()
        ElseIf fwv = "5.1" Then
            tether = True
            Form5.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub iph4(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form4.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.5" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.4" Then
            tether = True
            Form5.Show()
        ElseIf fwv = "4.3.3" Then
            freezeme.Show()
        ElseIf fwv = "4.3.2" Then
            freezeme.Show()
        ElseIf fwv = "4.3.1" Then
            freezeme.Show()
        ElseIf fwv = "4.3" Then
            freezeme.Show()
        ElseIf fwv = "5.1" Then
            tether = True
            Form5.Show()
        Else
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
    Public Sub iph4s(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = False
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = False
            Form3.Show()
        ElseIf fwv = "5.1" Then
            tether = False
            Form5.Show()
        Else
            'Should not happen, all current firmwares are supported
            MessageBox.Show("لا يوجد جيلبريك لهذا الاصدار بالبرنامج بعد سنضعة في تحديثاتنا القادمة")
        End If
    End Sub
End Module
