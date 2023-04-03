Public Class 修正
    Dim TextBox7_Bit As Boolean
    Dim TextBox8_Bit As Boolean
    Dim TextBox9_Bit As Boolean
    Dim TextBox11_Bit, TextBox12_Bit, TextBox13_Bit, TextBox14_Bit, TextBox15_Bit, TextBox16_Bit, TextBox17_Bit, TextBox18_Bit, TextBox19_Bit, TextBox20_Bit As Boolean
    Dim TextBox21_Bit, TextBox22_Bit, TextBox23_Bit, TextBox24_Bit, TextBox25_Bit, TextBox26_Bit, TextBox27_Bit, TextBox28_Bit, TextBox29_Bit, TextBox30_Bit As Boolean
    Dim TextBox31_Bit, TextBox32_Bit, TextBox33_Bit, TextBox34_Bit, TextBox35_Bit, TextBox36_Bit, TextBox37_Bit, TextBox38_Bit, TextBox39_Bit, TextBox40_Bit As Boolean
    Dim TextBox41_Bit, TextBox42_Bit, TextBox43_Bit, TextBox44_Bit, TextBox45_Bit, TextBox46_Bit, TextBox47_Bit, TextBox48_Bit, TextBox49_Bit, TextBox50_Bit As Boolean
    

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim data(7) As String
        'data(0) = ProduceNumber
        'data(1) = ProduceStandard
        'data(2) = Operators
        'data(3) = Num
        'data(4) = Data_LL_Set
        'data(5) = Data_MP_Set
        'data(6) = Data_XZ_Set
        'data(7) = TestTotal
        'Backstup.ToBackstup(data)

        Data_LL = TextBox7.Text
        Data_MP1 = TextBox8.Text
        Data_MP2 = TextBox9.Text
        Data_MP3 = TextBox10.Text

        Data_XZ1 = TextBox11.Text
        Data_XZ2 = TextBox12.Text
        Data_XZ3 = TextBox13.Text
        Data_XZ4 = TextBox14.Text
        Data_XZ5 = TextBox15.Text
        Data_XZ6 = TextBox16.Text
        Data_XZ7 = TextBox17.Text
        Data_XZ8 = TextBox18.Text
        Data_XZ9 = TextBox19.Text
        Data_XZ10 = TextBox20.Text

        Data_XZ11 = TextBox21.Text
        Data_XZ12 = TextBox22.Text
        Data_XZ13 = TextBox23.Text
        Data_XZ14 = TextBox24.Text
        Data_XZ15 = TextBox25.Text
        Data_XZ16 = TextBox26.Text
        Data_XZ17 = TextBox27.Text
        Data_XZ18 = TextBox28.Text
        Data_XZ19 = TextBox29.Text
        Data_XZ20 = TextBox30.Text

        Data_XZ21 = TextBox31.Text
        Data_XZ22 = TextBox32.Text
        Data_XZ23 = TextBox33.Text
        Data_XZ24 = TextBox34.Text
        Data_XZ25 = TextBox35.Text
        Data_XZ26 = TextBox36.Text
        Data_XZ27 = TextBox37.Text
        Data_XZ28 = TextBox38.Text
        Data_XZ29 = TextBox39.Text
        Data_XZ30 = TextBox40.Text

        Data_CP = TextBox41.Text

        WindMuber2 = False
        WindMuber = 0
        '扫码系统.Show()
        'Me.Close()
        TextBox7_Bit = False
        TextBox8_Bit = False
        TextBox9_Bit = False

        TextBox11_Bit = False
        TextBox12_Bit = False
        TextBox13_Bit = False
        TextBox14_Bit = False
        TextBox15_Bit = False
        TextBox16_Bit = False
        TextBox17_Bit = False
        TextBox18_Bit = False
        TextBox19_Bit = False
        TextBox20_Bit = False

        TextBox21_Bit = False
        TextBox22_Bit = False
        TextBox23_Bit = False
        TextBox24_Bit = False
        TextBox25_Bit = False
        TextBox26_Bit = False
        TextBox27_Bit = False
        TextBox28_Bit = False
        TextBox29_Bit = False
        TextBox30_Bit = False

        TextBox31_Bit = False
        TextBox32_Bit = False
        TextBox33_Bit = False
        TextBox34_Bit = False
        TextBox35_Bit = False
        TextBox36_Bit = False
        TextBox37_Bit = False
        TextBox38_Bit = False
        TextBox39_Bit = False
        TextBox40_Bit = False

        TextBox41_Bit = False

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Icon = My.Resources.app
        WindMuber = 1
        'WindMuber2 = True
        'LV1._PortName = "com5"
        'timerLV.Interval = 100
        'timerLV.Start()
        uptimer()

        TextBox7.Text = Data_LL
        TextBox8.Text = Data_MP1
        TextBox9.Text = Data_MP2
        TextBox10.Text = Data_MP3

        TextBox11.Text = Data_XZ1
        TextBox12.Text = Data_XZ2
        TextBox13.Text = Data_XZ3
        TextBox14.Text = Data_XZ4
        TextBox15.Text = Data_XZ5
        TextBox16.Text = Data_XZ6
        TextBox17.Text = Data_XZ7
        TextBox18.Text = Data_XZ8
        TextBox19.Text = Data_XZ9
        TextBox20.Text = Data_XZ10

        TextBox21.Text = Data_XZ11
        TextBox22.Text = Data_XZ12
        TextBox23.Text = Data_XZ13
        TextBox24.Text = Data_XZ14
        TextBox25.Text = Data_XZ15
        TextBox26.Text = Data_XZ16
        TextBox27.Text = Data_XZ17
        TextBox28.Text = Data_XZ18
        TextBox29.Text = Data_XZ19
        TextBox30.Text = Data_XZ20

        TextBox31.Text = Data_XZ21
        TextBox32.Text = Data_XZ22
        TextBox33.Text = Data_XZ23
        TextBox34.Text = Data_XZ24
        TextBox35.Text = Data_XZ25
        TextBox36.Text = Data_XZ26
        TextBox37.Text = Data_XZ27
        TextBox38.Text = Data_XZ28
        TextBox39.Text = Data_XZ29
        TextBox40.Text = Data_XZ30

        TextBox41.Text = Data_CP

    End Sub


    Public Sub updata1()
        If WindMuber2 Then

            If TextBox7_Bit And LVCompleted Then
                TextBox7.Text = CNumber_1
                TextBox7_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox8_Bit And LVCompleted Then
                TextBox8.Text = CNumber_1
                TextBox8_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox9_Bit And LVCompleted Then
                TextBox9.Text = CNumber_1
                TextBox9_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If

            If TextBox11_Bit And LVCompleted Then
                TextBox11.Text = CNumber_1
                TextBox11_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox12_Bit And LVCompleted Then
                TextBox12.Text = CNumber_1
                TextBox12_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox13_Bit And LVCompleted Then
                TextBox13.Text = CNumber_1
                TextBox13_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox14_Bit And LVCompleted Then
                TextBox14.Text = CNumber_1
                TextBox14_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox15_Bit And LVCompleted Then
                TextBox15.Text = CNumber_1
                TextBox15_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox16_Bit And LVCompleted Then
                TextBox16.Text = CNumber_1
                TextBox16_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox17_Bit And LVCompleted Then
                TextBox17.Text = CNumber_1
                TextBox17_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox18_Bit And LVCompleted Then
                TextBox18.Text = CNumber_1
                TextBox18_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox19_Bit And LVCompleted Then
                TextBox19.Text = CNumber_1
                TextBox19_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox20_Bit And LVCompleted Then
                TextBox20.Text = CNumber_1
                TextBox20_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox21_Bit And LVCompleted Then
                TextBox21.Text = CNumber_1
                TextBox21_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox22_Bit And LVCompleted Then
                TextBox22.Text = CNumber_1
                TextBox22_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox23_Bit And LVCompleted Then
                TextBox23.Text = CNumber_1
                TextBox23_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox24_Bit And LVCompleted Then
                TextBox24.Text = CNumber_1
                TextBox24_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox25_Bit And LVCompleted Then
                TextBox25.Text = CNumber_1
                TextBox25_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox26_Bit And LVCompleted Then
                TextBox26.Text = CNumber_1
                TextBox26_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox27_Bit And LVCompleted Then
                TextBox27.Text = CNumber_1
                TextBox27_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox28_Bit And LVCompleted Then
                TextBox28.Text = CNumber_1
                TextBox28_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox29_Bit And LVCompleted Then
                TextBox29.Text = CNumber_1
                TextBox29_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox30_Bit And LVCompleted Then
                TextBox30.Text = CNumber_1
                TextBox30_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox31_Bit And LVCompleted Then
                TextBox31.Text = CNumber_1
                TextBox31_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox32_Bit And LVCompleted Then
                TextBox32.Text = CNumber_1
                TextBox32_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox33_Bit And LVCompleted Then
                TextBox33.Text = CNumber_1
                TextBox33_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox34_Bit And LVCompleted Then
                TextBox34.Text = CNumber_1
                TextBox34_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox35_Bit And LVCompleted Then
                TextBox35.Text = CNumber_1
                TextBox35_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox36_Bit And LVCompleted Then
                TextBox36.Text = CNumber_1
                TextBox36_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox37_Bit And LVCompleted Then
                TextBox37.Text = CNumber_1
                TextBox37_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox38_Bit And LVCompleted Then
                TextBox38.Text = CNumber_1
                TextBox38_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox39_Bit And LVCompleted Then
                TextBox39.Text = CNumber_1
                TextBox39_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox40_Bit And LVCompleted Then
                TextBox40.Text = CNumber_1
                TextBox40_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If

        End If
        Updatatimer8.Start()
    End Sub

    
    Private Sub TextBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.MouseDown
        TextBox7_Bit = True
    End Sub
    Private Sub TextBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.MouseDown
        TextBox8_Bit = True
    End Sub
    Private Sub TextBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.MouseDown
        TextBox9_Bit = True
    End Sub
    Private Sub TextBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.MouseDown
        TextBox11_Bit = True
    End Sub
    Private Sub TextBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.MouseDown
        TextBox12_Bit = True
    End Sub
    Private Sub TextBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.MouseDown
        TextBox13_Bit = True
    End Sub
    Private Sub TextBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.MouseDown
        TextBox14_Bit = True
    End Sub
    Private Sub TextBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.MouseDown
        TextBox15_Bit = True
    End Sub
    Private Sub TextBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.MouseDown
        TextBox16_Bit = True
    End Sub
    Private Sub TextBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.MouseDown
        TextBox17_Bit = True
    End Sub
    Private Sub TextBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.MouseDown
        TextBox18_Bit = True
    End Sub
    Private Sub TextBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.MouseDown
        TextBox19_Bit = True
    End Sub
    Private Sub TextBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.MouseDown
        TextBox20_Bit = True
    End Sub
    Private Sub TextBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.MouseDown
        TextBox21_Bit = True
    End Sub
    Private Sub TextBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.MouseDown
        TextBox22_Bit = True
    End Sub
    Private Sub TextBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.MouseDown
        TextBox23_Bit = True
    End Sub
    Private Sub TextBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.MouseDown
        TextBox24_Bit = True
    End Sub
    Private Sub TextBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.MouseDown
        TextBox25_Bit = True
    End Sub
    Private Sub TextBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.MouseDown
        TextBox26_Bit = True
    End Sub
    Private Sub TextBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.MouseDown
        TextBox27_Bit = True
    End Sub
    Private Sub TextBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.MouseDown
        TextBox28_Bit = True
    End Sub
    Private Sub TextBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.MouseDown
        TextBox29_Bit = True
    End Sub
    Private Sub TextBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.MouseDown
        TextBox30_Bit = True
    End Sub
    Private Sub TextBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.MouseDown
        TextBox31_Bit = True
    End Sub
    Private Sub TextBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.MouseDown
        TextBox32_Bit = True
    End Sub
    Private Sub TextBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.MouseDown
        TextBox33_Bit = True
    End Sub
    Private Sub TextBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox34.MouseDown
        TextBox34_Bit = True
    End Sub
    Private Sub TextBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.MouseDown
        TextBox35_Bit = True
    End Sub
    Private Sub TextBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox36.MouseDown
        TextBox36_Bit = True
    End Sub
    Private Sub TextBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox37.MouseDown
        TextBox37_Bit = True
    End Sub
    Private Sub TextBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox38.MouseDown
        TextBox38_Bit = True
    End Sub
    Private Sub TextBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox39.MouseDown
        TextBox39_Bit = True
    End Sub
    Private Sub TextBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox40.MouseDown
        TextBox40_Bit = True
    End Sub
    Private Sub TextBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.MouseDown
        TextBox41_Bit = True
    End Sub





    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub TextBox9_Click(sender As Object, e As MouseEventArgs) Handles TextBox9.MouseDown

    End Sub
End Class