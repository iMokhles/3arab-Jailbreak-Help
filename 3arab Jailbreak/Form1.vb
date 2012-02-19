'Copyright (C) <2011>  <The Private Dev Team>

'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>
Imports MobileDevice
Public Class Form1
    Dim iphone As New MobileDevice.iPhone
    Dim cc As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Start checking for a device...
        Timer1.Start()
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label9.Text = ""
        Button2.Enabled = False
        RadioButton1.Checked = True
        'Temporary path
        Dim temp As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        'Place where I'm going to store all of the necessary files
        mode = temp & "\iMokhles\mode"
        'make sure directory doesn't already exist
        System.IO.Directory.CreateDirectory(temp & "\iMokhles")
        System.IO.Directory.CreateDirectory(temp & "\iMokhles\mode")
        System.IO.File.WriteAllBytes(mode & "\itunnel.exe", My.Resources.itunnel_mux_r61)
        System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", My.Resources.IPHUCWIN32)
        System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\readline5.dll", My.Resources.readline5)
        If System.IO.File.Exists("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll") Then
            System.IO.File.Delete("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
        Else
            System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Cool little thing for the waiting part, not important
        If cc = "..." Then
            cc = ""
        End If
        cc = cc + "."
        'Do this when iPhone is connected...
        If iphone.IsConnected = True Then
            Button2.Enabled = True
            Label1.Text = "تم الاتصال"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Timer1.Stop()
            Timer2.Start()
            'Determine what type of device it is...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod touch 3g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod touch 4"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod touch 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod touch 1g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
                iPhonev = "Apple TV 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2g"
                extra = "Verison"
            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3gs"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"
                extra = "Verison"
            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4s"
                extra = "At&t/Verison/Sprint"
            End If
            'Display it
            firmware = iphone.DeviceVersion
            model = iphone.DeviceModelNumber
            Label3.Text = firmware
            Label2.Text = iPhonev
            Label4.Text = model
            Label9.Text = extra
        Else
            'If no device is connected then keep waiting
            Button2.Enabled = False
            Label1.Text = "فى إنتظار الاتصال" + cc
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If iphone.IsConnected = False Then
            'The user unplugged their device, wait for them to plug it back in
            'Resetting values
            Button2.Enabled = False
            iPhonev = ""
            firmware = ""
            model = ""
            extra = ""
            Label2.Text = iPhonev
            Label3.Text = firmware
            Label4.Text = model
            Label9.Text = extra
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If cc = "..." Then
                cc = ""
            End If
            cc = cc + "."
            Label1.Text = "Waiting for device" + cc
        ElseIf iphone.IsConnected = True Then
            'The user plugged their devcie back in!
            Button2.Enabled = True
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Label1.Text = "تم الاتصال"
            'Once again determine which device they have...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod touch 3g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod touch 4"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod touch 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod touch 1g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
                iPhonev = "Apple TV 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2g"
                extra = "wifi"
            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2g"
                extra = "Verison"
            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3g"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3gs"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"
                extra = "Verison"
            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"
                extra = "At&t"
            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4s"
                extra = "At&t/Verison/Sprint"
            End If
            'Display it
            firmware = iphone.DeviceVersion
            model = iphone.DeviceModelNumber
            Label3.Text = firmware
            Label2.Text = iPhonev
            Label4.Text = model
            Label9.Text = extra
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Credits!
        MessageBox.Show("البرنامج صنع بواسطة مخلص مطور و محرر فى مدونتى الديف تيم العربية و أيباد بالعربى Thanks To The Private Dev Team, Comex, iH8Sn0w, Dev Team, Saurik, Pod2G, Chronic Team and The Dream Team", "3arab Jailbreak Help Rc1")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'User wants to know how to jailbreak!
        If iPhonev = "iPod touch 2g" And model = "" Then
            Form7.Show()
        End If
        If iPhonev = "iPod touch 3g" Then
            ipt3(firmware)
        ElseIf iPhonev = "iPod touch 4" Then
            ipt4(firmware)
        ElseIf iPhonev = "iPod touch 2g" Then
            If model.Contains("mc") Then
                ipt2mc(firmware)
            ElseIf model.Contains("mb") Then
                ipt2mb(firmware)
            End If
        ElseIf iPhonev = "iPod touch 1g" Then
            ipt1(firmware)
        ElseIf iPhonev = "Apple TV 2g" Then
            atv2(firmware)
        ElseIf iPhonev = "iPhone 2g" Then
            iph2(firmware)
        ElseIf iPhonev = "iPhone 3g" Then
            iph3(firmware)
        ElseIf iPhonev = "iPhone 3gs" Then
            iph3gs(firmware)
        ElseIf iPhonev = "iPhone 4" Then
            iph4(firmware)
        ElseIf iPhonev = "iPhone 4s" Then
            iph4s(firmware)
        ElseIf iPhonev = "iPad 1g" Then
            ip1(firmware)
        ElseIf iPhonev = "iPad 2g" Then
            ip2(firmware)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Timer1.Stop()
            Timer2.Stop()
            Label1.Text = "وضع يدوى"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 0
            Button2.Enabled = True
            Form6.Show()
            model = ""
            extra = ""
            Timer3.Start()
        Else
            Timer2.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label3.Text = firmware
        Label2.Text = iPhonev
        Label4.Text = model
        Label9.Text = extra
    End Sub
End Class
