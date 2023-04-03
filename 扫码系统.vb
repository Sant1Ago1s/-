Public Class 扫码系统
    Dim TextBox0_Bit As Boolean
    Dim TextBox1_Bit As Boolean
    Dim TextBox2_Bit As Boolean
    Dim TextBox3_Bit As Boolean
    Dim TextBox7_Bit As Boolean
    Dim TextBox8_Bit As Boolean
    Dim TextBox9_Bit As Boolean
    Dim TextBox10_Bit As Boolean
    Dim TextBox41_Bit As Boolean
    Dim TextBox50_Bit As Boolean
    Dim TextBox51_Bit As Boolean
    Dim TextBox52_Bit As Boolean
    Dim TextBox53_Bit As Boolean
    Dim TextBox54_Bit As Boolean
    Dim Working1 As Boolean
    Dim x1 As Integer
    Dim y1 As Integer
    Dim cszie As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Dim fsize As Integer
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim data(7) As String
        data(0) = ProduceNumber
        data(1) = ProduceStandard
        data(2) = Operators
        data(3) = Num
        data(4) = Data_LL_Set
        data(5) = Data_MP_Set
        data(6) = Data_XZ_Set
        data(7) = TestTotal
        Backstup.ToBackstup(data)

        My.Settings.data1X = TextBox51.Text
        My.Settings.data1Y = TextBox52.Text
        My.Settings.data2X = TextBox53.Text
        My.Settings.data2Y = TextBox54.Text
        My.Settings.dataX = TextBox55.Text
        My.Settings.dataY = TextBox56.Text
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindMuber = 0
        If GT800.Connect("COM1") Then
        Else
            MessageBox.Show("打印机未连接！")
        End If

        LV1._PortName = "COM2"
        timerLV.Interval = 100
        timerLV.Start()
        'updata0()
        uptimer()

        Dim data(7) As String
        data = Backstup.ReadBackstup
        ProduceNumber = data(0)
        ProduceStandard = data(1)
        Operators = data(2)
        Num = data(3)
        Data_LL_Set = data(4)
        Data_MP_Set = data(5)
        Data_XZ_Set = data(6)
        TestTotal = data(7)

        TextBox0.Text = ProduceNumber
        TextBox1.Text = ProduceStandard
        TextBox2.Text = Operators
        ComboBox1.Text = Num
        ComboBox2.Text = Data_LL_Set
        ComboBox3.Text = Data_MP_Set
        ComboBox4.Text = Data_XZ_Set

        'TextBox0.Text = ProduceNumber
        'TextBox4.Text = ProduceStandard
        'TextBox5.Text = Operators
        'TextBox6.Text = Num
        'TextBox42.Text = TestTotal

        TextBox51.Text = My.Settings.data1X
        TextBox52.Text = My.Settings.data1Y
        TextBox53.Text = My.Settings.data2X
        TextBox54.Text = My.Settings.data2Y
        TextBox55.Text = My.Settings.dataX
        TextBox56.Text = My.Settings.dataY
    End Sub
    Public Sub updata0()
        My.Application.DoEvents()


        'TextBox41.Text = Data_CP
        TextBox42.Text = TestTotal
        '
        '清码
        '
        If Runing_BitW1 And LVCompleted Then
            Runing_BitW1 = False

            'If ComboBox2.Text > 0 Then
            '    TextBox7.Text = ""
            'End If
            'If ComboBox3.Text > 0 Then
            '    TextBox8.Text = ""
            '    TextBox9.Text = ""
            'End If
            If ComboBox4.Text > 0 Then
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""

                TextBox21.Text = ""
                TextBox22.Text = ""
                TextBox23.Text = ""
                TextBox24.Text = ""
                TextBox25.Text = ""
                TextBox26.Text = ""
                TextBox27.Text = ""
                TextBox28.Text = ""
                TextBox29.Text = ""
                TextBox30.Text = ""

                TextBox31.Text = ""
                TextBox32.Text = ""
                TextBox33.Text = ""
                TextBox34.Text = ""
                TextBox35.Text = ""
                TextBox36.Text = ""
                TextBox37.Text = ""
                TextBox38.Text = ""
                TextBox39.Text = ""
                TextBox40.Text = ""

                TextBox41.Text = ""
            End If
        End If
        '
        '码传画面2修改
        '

        If WindMuber2B And WindMuber2 = False Then
            WindMuber2B = False
            Working1 = False

            'TextBox7.Text = Data_LL
            'TextBox8.Text = Data_MP1
            'TextBox9.Text = Data_MP2

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

        End If

        If WindMuber2B = False Then
            '
            '参数设置
            '
            If TextBox0_Bit And LVCompleted Then
                TextBox0.Text = CNumber_1
                TextBox0_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox1_Bit And LVCompleted Then
                TextBox1.Text = CNumber_1
                TextBox1_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If
            If TextBox2_Bit And LVCompleted Then
                TextBox2.Text = CNumber_1
                TextBox2_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If

            If TextBox7_Bit And LVCompleted Then
                TextBox7.Text = CNumber_1
                TextBox7_Bit = False
                LVCompleted = False
                TestTotal = 0
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
            If TextBox10_Bit And LVCompleted Then
                TextBox10.Text = CNumber_1
                TextBox10_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If

            If TextBox50_Bit And LVCompleted Then
                TextBox50.Text = CNumber_1
                TextBox50_Bit = False
                LVCompleted = False
                timerLV.Start()
            End If



            ''
            ''扫码显示
            ''
            ''来料
            'If ComboBox2.Text = 1 Then
            '    If Runing_Bit And LVCompleted Then
            '        TextBox7.Text = CNumber_1
            '        Data_LL = TextBox7.Text
            '        Runing_Bit1 = True
            '        Runing_Bit = False
            '        LVCompleted = False
            '        timerLV.Start()
            '    End If
            'Else
            '    If Runing_Bit Then
            '        Runing_Bit1 = True
            '        Runing_Bit = False
            '    End If
            'End If
            ''母排
            'Select Case ComboBox3.Text
            '    Case 0
            '        If Runing_Bit1 Then
            '            Runing_Bit3 = True
            '            Runing_Bit1 = False
            '        End If
            '    Case 1
            '        If Runing_Bit1 And LVCompleted Then
            '            TextBox8.Text = CNumber_1
            '            Runing_Bit3 = True
            '            Runing_Bit1 = False
            '            LVCompleted = False
            '            timerLV.Start()
            '        End If
            '    Case 2
            '        If Runing_Bit1 And LVCompleted Then
            '            TextBox8.Text = CNumber_1
            '            Runing_Bit2 = True
            '            Runing_Bit1 = False
            '            LVCompleted = False
            '            timerLV.Start()
            '        End If
            '        If Runing_Bit2 And LVCompleted Then
            '            TextBox9.Text = CNumber_1
            '            Runing_Bit3 = True
            '            Runing_Bit2 = False
            '            LVCompleted = False
            '            timerLV.Start()
            '        End If
            'End Select
            '芯子

            Select Case ComboBox4.Text
                Case 0
                    If Runing_Bit Then
                        Runing_BitW = True
                        Runing_Bit = False
                    End If
                Case 1
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 2
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 3
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 4
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 5
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 6
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 7
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 8
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 9
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                Case 10
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 11
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 12
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 13
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 14
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 15
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 16
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 17
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 18
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 19
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 20
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 21
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 22
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 23
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 24
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 25
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 26
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_Bit28 = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit28 And LVCompleted Then
                        TextBox36.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit28 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 27
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_Bit28 = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit28 And LVCompleted Then
                        TextBox36.Text = CNumber_1
                        Runing_Bit29 = True
                        Runing_Bit28 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit29 And LVCompleted Then
                        TextBox37.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit29 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 28
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_Bit28 = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit28 And LVCompleted Then
                        TextBox36.Text = CNumber_1
                        Runing_Bit29 = True
                        Runing_Bit28 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit29 And LVCompleted Then
                        TextBox37.Text = CNumber_1
                        Runing_Bit30 = True
                        Runing_Bit29 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit30 And LVCompleted Then
                        TextBox38.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit30 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 29
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_Bit28 = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit28 And LVCompleted Then
                        TextBox36.Text = CNumber_1
                        Runing_Bit29 = True
                        Runing_Bit28 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit29 And LVCompleted Then
                        TextBox37.Text = CNumber_1
                        Runing_Bit30 = True
                        Runing_Bit29 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit30 And LVCompleted Then
                        TextBox38.Text = CNumber_1
                        Runing_Bit1 = True
                        Runing_Bit30 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit1 And LVCompleted Then
                        TextBox39.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit1 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

                Case 30
                    If Runing_Bit And LVCompleted Then
                        TextBox11.Text = CNumber_1
                        Runing_Bit4 = True
                        Runing_Bit = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit4 And LVCompleted Then
                        TextBox12.Text = CNumber_1
                        Runing_Bit5 = True
                        Runing_Bit4 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit5 And LVCompleted Then
                        TextBox13.Text = CNumber_1
                        Runing_Bit6 = True
                        Runing_Bit5 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit6 And LVCompleted Then
                        TextBox14.Text = CNumber_1
                        Runing_Bit7 = True
                        Runing_Bit6 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit7 And LVCompleted Then
                        TextBox15.Text = CNumber_1
                        Runing_Bit8 = True
                        Runing_Bit7 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit8 And LVCompleted Then
                        TextBox16.Text = CNumber_1
                        Runing_Bit9 = True
                        Runing_Bit8 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit9 And LVCompleted Then
                        TextBox17.Text = CNumber_1
                        Runing_Bit10 = True
                        Runing_Bit9 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit10 And LVCompleted Then
                        TextBox18.Text = CNumber_1
                        Runing_Bit11 = True
                        Runing_Bit10 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit11 And LVCompleted Then
                        TextBox19.Text = CNumber_1
                        Runing_Bit12 = True
                        Runing_Bit11 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit12 And LVCompleted Then
                        TextBox20.Text = CNumber_1
                        Runing_Bit13 = True
                        Runing_Bit12 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit13 And LVCompleted Then
                        TextBox21.Text = CNumber_1
                        Runing_Bit14 = True
                        Runing_Bit13 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit14 And LVCompleted Then
                        TextBox22.Text = CNumber_1
                        Runing_Bit15 = True
                        Runing_Bit14 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit15 And LVCompleted Then
                        TextBox23.Text = CNumber_1
                        Runing_Bit16 = True
                        Runing_Bit15 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit16 And LVCompleted Then
                        TextBox24.Text = CNumber_1
                        Runing_Bit17 = True
                        Runing_Bit16 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit17 And LVCompleted Then
                        TextBox25.Text = CNumber_1
                        Runing_Bit18 = True
                        Runing_Bit17 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit18 And LVCompleted Then
                        TextBox26.Text = CNumber_1
                        Runing_Bit19 = True
                        Runing_Bit18 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit19 And LVCompleted Then
                        TextBox27.Text = CNumber_1
                        Runing_Bit20 = True
                        Runing_Bit19 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit20 And LVCompleted Then
                        TextBox28.Text = CNumber_1
                        Runing_Bit21 = True
                        Runing_Bit20 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit21 And LVCompleted Then
                        TextBox29.Text = CNumber_1
                        Runing_Bit22 = True
                        Runing_Bit21 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit22 And LVCompleted Then
                        TextBox30.Text = CNumber_1
                        Runing_Bit23 = True
                        Runing_Bit22 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit23 And LVCompleted Then
                        TextBox31.Text = CNumber_1
                        Runing_Bit24 = True
                        Runing_Bit23 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit24 And LVCompleted Then
                        TextBox32.Text = CNumber_1
                        Runing_Bit25 = True
                        Runing_Bit24 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit25 And LVCompleted Then
                        TextBox33.Text = CNumber_1
                        Runing_Bit26 = True
                        Runing_Bit25 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit26 And LVCompleted Then
                        TextBox34.Text = CNumber_1
                        Runing_Bit27 = True
                        Runing_Bit26 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit27 And LVCompleted Then
                        TextBox35.Text = CNumber_1
                        Runing_Bit28 = True
                        Runing_Bit27 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit28 And LVCompleted Then
                        TextBox36.Text = CNumber_1
                        Runing_Bit29 = True
                        Runing_Bit28 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit29 And LVCompleted Then
                        TextBox37.Text = CNumber_1
                        Runing_Bit30 = True
                        Runing_Bit29 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit30 And LVCompleted Then
                        TextBox38.Text = CNumber_1
                        Runing_Bit1 = True
                        Runing_Bit30 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit1 And LVCompleted Then
                        TextBox39.Text = CNumber_1
                        Runing_Bit2 = True
                        Runing_Bit1 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If
                    If Runing_Bit2 And LVCompleted Then
                        TextBox40.Text = CNumber_1
                        Runing_BitW = True
                        Runing_Bit2 = False
                        LVCompleted = False
                        timerLV.Start()
                    End If

            End Select
            If Auto_Bit Then
                
                If Runing_BitW And TextBox41_Bit Then
                    TestTotal += 1
                    'TextBox41.Text = CNumber_1
                    Runing_BitW_1 = True
                    Runing_BitW = False
                    'LVCompleted = False
                    'timerLV.Start()
                End If
            Else
                
                If Runing_BitW Then
                    If Backstup.duqu(TextBox7.Text) = "OK" Then
                        Dim reader() As String
                        reader = Backstup.redata
                        TestTotal = reader(1)
                        TextBox42.Text = TestTotal
                        'MessageBox.Show("读取参数成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        'MessageBox.Show("读取参数失败!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TestTotal = "0"
                        TextBox42.Text = TestTotal
                    End If

                    TestTotal += 1
                    If TestTotal < 100 Then
                        If TestTotal < 10 Then
                            Data_CP = TextBox7.Text & "-00" & TestTotal
                        Else
                            Data_CP = TextBox7.Text & "-0" & TestTotal
                        End If
                    Else
                        Data_CP = TextBox7.Text & "-" & TestTotal
                    End If
                    TextBox41.Text = Data_CP
                    Runing_BitW_1 = True
                    Runing_BitW = False
                    LVCompleted = False

                    Dim write(2) As String
                    '生产料号
                    write(0) = TextBox7.Text
                    write(1) = TestTotal
                    If write(0) = "" Or write(0) = Nothing Then
                        MessageBox.Show("产品批号不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        If Backstup.baocun(write) = "OK" Then
                            'MessageBox.Show("保存参数成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'MessageBox.Show("保存参数失败!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                    timerLV.Start()
                End If


            End If
        End If


        If Runing_BitW_1 Then
            Runing_BitW_1 = False
            Runing_BitW1 = True
            Runing_Bit = True
            'TestTotal += 1

            x1 = CInt(TextBox51.Text)
            y1 = CInt(TextBox52.Text)
            x2 = CInt(TextBox53.Text)
            y2 = CInt(TextBox54.Text)
            cszie = CInt(TextBox55.Text)
            fsize = CInt(TextBox56.Text)
            GT800.PrintPDF417(TextBox41.Text, x1, y1, cszie, x2, y2, fsize)

            'Data_LL = TextBox7.Text
            'If TestTotal < 100 Then
            '    If TestTotal < 10 Then
            '        Data_CP = Data_LL & "-00" & TestTotal
            '    Else
            '        Data_CP = Data_LL & "-0" & TestTotal
            '    End If
            'Else

            '    Data_CP = Data_LL & "-" & TestTotal
            'End If
            'TextBox41.Text = Data_CP


            Dim data(39) As String
            data(0) = ProduceNumber
            data(1) = ProduceStandard
            data(2) = Operators
            data(3) = Num
            data(4) = TextBox41.Text
            data(5) = TestTotal
            If TextBox7.Text = "" Then
                data(6) = "-"
            Else
                data(6) = TextBox7.Text
            End If
            If TextBox8.Text = "" Then
                data(7) = "-"
            Else
                data(7) = TextBox8.Text
            End If
            If TextBox9.Text = "" Then
                data(8) = "-"
            Else
                data(8) = TextBox9.Text
            End If
            If TextBox10.Text = "" Then
                data(9) = "-"
            Else
                data(9) = TextBox10.Text
            End If

            If TextBox11.Text = "" Then
                data(10) = "-"
            Else
                data(10) = TextBox11.Text
            End If
            If TextBox12.Text = "" Then
                data(11) = "-"
            Else
                data(11) = TextBox12.Text
            End If
            If TextBox13.Text = "" Then
                data(12) = "-"
            Else
                data(12) = TextBox13.Text
            End If
            If TextBox14.Text = "" Then
                data(13) = "-"
            Else
                data(13) = TextBox14.Text
            End If
            If TextBox15.Text = "" Then
                data(14) = "-"
            Else
                data(14) = TextBox15.Text
            End If
            If TextBox16.Text = "" Then
                data(15) = "-"
            Else
                data(15) = TextBox16.Text
            End If
            If TextBox17.Text = "" Then
                data(16) = "-"
            Else
                data(16) = TextBox17.Text
            End If
            If TextBox18.Text = "" Then
                data(17) = "-"
            Else
                data(17) = TextBox18.Text
            End If
            If TextBox19.Text = "" Then
                data(18) = "-"
            Else
                data(18) = TextBox19.Text
            End If
            If TextBox20.Text = "" Then
                data(19) = "-"
            Else
                data(19) = TextBox20.Text
            End If
            If TextBox21.Text = "" Then
                data(20) = "-"
            Else
                data(20) = TextBox21.Text
            End If

            If TextBox22.Text = "" Then
                data(21) = "-"
            Else
                data(21) = TextBox22.Text
            End If
            If TextBox23.Text = "" Then
                data(22) = "-"
            Else
                data(22) = TextBox23.Text
            End If
            If TextBox24.Text = "" Then
                data(23) = "-"
            Else
                data(23) = TextBox24.Text
            End If
            If TextBox25.Text = "" Then
                data(24) = "-"
            Else
                data(24) = TextBox25.Text
            End If
            If TextBox26.Text = "" Then
                data(25) = "-"
            Else
                data(25) = TextBox26.Text
            End If
            If TextBox27.Text = "" Then
                data(26) = "-"
            Else
                data(26) = TextBox27.Text
            End If
            If TextBox28.Text = "" Then
                data(27) = "-"
            Else
                data(27) = TextBox28.Text
            End If
            If TextBox29.Text = "" Then
                data(28) = "-"
            Else
                data(28) = TextBox29.Text
            End If
            If TextBox30.Text = "" Then
                data(29) = "-"
            Else
                data(29) = TextBox30.Text
            End If
            If TextBox31.Text = "" Then
                data(30) = "-"
            Else
                data(30) = TextBox31.Text
            End If


            If TextBox32.Text = "" Then
                data(31) = "-"
            Else
                data(31) = TextBox32.Text
            End If
            If TextBox33.Text = "" Then
                data(32) = "-"
            Else
                data(32) = TextBox33.Text
            End If
            If TextBox34.Text = "" Then
                data(33) = "-"
            Else
                data(33) = TextBox34.Text
            End If
            If TextBox35.Text = "" Then
                data(34) = "-"
            Else
                data(34) = TextBox35.Text
            End If
            If TextBox36.Text = "" Then
                data(35) = "-"
            Else
                data(35) = TextBox36.Text
            End If
            If TextBox37.Text = "" Then
                data(36) = "-"
            Else
                data(36) = TextBox37.Text
            End If
            If TextBox38.Text = "" Then
                data(37) = "-"
            Else
                data(37) = TextBox38.Text
            End If
            If TextBox39.Text = "" Then
                data(38) = "-"
            Else
                data(38) = TextBox39.Text
            End If
            If TextBox40.Text = "" Then
                data(39) = "-"
            Else
                data(39) = TextBox40.Text
            End If

            SaveTestData.ToTable1two(data)
            SaveTestData.ToTable1two2(data)

            'Dim write(2) As String
            ''生产料号
            'write(0) = TextBox7.Text
            'write(1) = TestTotal
            'If write(0) = "" Or write(0) = Nothing Then
            '    MessageBox.Show("产品批号不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Else
            '    If Backstup.baocun(write) = "OK" Then
            '        'MessageBox.Show("保存参数成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        'MessageBox.Show("保存参数失败!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    End If
            'End If
        End If
        'updata0()
        Updatatimer8.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim hh As String
        'hh = TextBox0.Text

        'Dim result As String
        'result = Readtotable.AddTable(hh)
        ''result = Readtotable.AddTable2(hh)
        'If result = "ok" And Readtotable.ExistTable = False Then
        '    ProduceNumber = TextBox0.Text
        '    ProduceStandard = TextBox1.Text
        '    Operators = TextBox2.Text
        '    Num = ComboBox1.Text
        '    TestTotal = 0
        '    TextBox3.Text = TextBox0.Text
        '    TextBox4.Text = TextBox1.Text
        '    TextBox5.Text = TextBox2.Text

        '    TextBox42.Text = TestTotal

        'ElseIf result = "ok" Then
        '    TestTotal = SaveTestData.ReadTable1(hh)

        '    ProduceNumber = TextBox0.Text
        '    ProduceStandard = TextBox1.Text
        '    Operators = TextBox2.Text
        '    Num = ComboBox1.Text
        '    TestTotal = TextBox42.Text
        '    TextBox3.Text = TextBox0.Text
        '    TextBox4.Text = TextBox1.Text
        '    TextBox5.Text = TextBox2.Text

        'End If
        ''ProduceNumber = TextBox3.Text
        ''ProduceStandard = TextBox4.Text
        ''Operators = TextBox5.Text
        ''Num = TextBox6.Text
        'Data_LL_Set = ComboBox2.Text
        'Data_MP_Set = ComboBox3.Text
        'Data_XZ_Set = ComboBox4.Text
        ''TestTotal = TextBox42.Text

        My.Settings.data1X = TextBox51.Text
        My.Settings.data1Y = TextBox52.Text
        My.Settings.data2X = TextBox53.Text
        My.Settings.data2Y = TextBox54.Text
        My.Settings.dataX = TextBox55.Text
        My.Settings.dataY = TextBox54.Text

    End Sub

    'Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim TableList As String()
    '    TableList = Backstup.updataname()
    '    'Process.Start("osk.exe")
    '    ComboBox5.Items.Clear()
    '    Dim qq As Integer
    '    For qq = 0 To Backstup.MaxReadDataList - 1
    '        ComboBox5.Items.Add(TableList(qq))
    '    Next
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("osk.exe")
    End Sub

















    'Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
    '    WindMuber2 = True
    'End Sub

    'Private Sub TextBox0__Validating(sender As Object, e As EventArgs) Handles TextBox0.Validating
    '    TextBox1_Bit = True
    'End Sub
    'Private Sub TextBox0__Validated(ByVal Value As Decimal) Handles TextBox0.Validating
    '    'M218._Write(205, CInt(Value))
    '    TextBox1_Bit = True
    'End Sub
    Private Sub TextBox0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox0.MouseDown
        TextBox0_Bit = True
    End Sub
    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseDown
        TextBox1_Bit = True
    End Sub
    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.MouseDown
        TextBox2_Bit = True
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
    Private Sub TextBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.MouseDown
        TextBox10_Bit = True
    End Sub
    'Private Sub TextBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.MouseDown
    '    TextBox50_Bit = True
    'End Sub
    Private Sub TextBox50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox50.MouseDown
        TextBox50_Bit = True
    End Sub
   
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        'TextBox3.Text = TextBox0.Text
        'TextBox4.Text = TextBox1.Text
        'TextBox5.Text = TextBox2.Text
        'TextBox6.Text = ComboBox1.Text
        'TextBox42.Text = TestTotal
    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Table1 As New DataTable
        Table1 = Readtotable.DiplayTable(ListBox1.SelectedItem)
        DataGridView1.DataSource = Table1

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim result As String
        result = Readtotable.ToExecel(ListBox1.SelectedItem)
        If result = "ok" Then
            MessageBox.Show("导出成功！")

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Readtotable.DelectTable(ListBox1.SelectedItem)
        ListBox1.Items.Clear()
        updataList()
    End Sub
    Sub updataList()
        Dim data() As String
        data = Backstup.updataname
        Dim qq As Integer
        For qq = 0 To Backstup.MaxReadDataList - 1
            ListBox1.Items.Add(data(qq))
        Next
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'If Runing_Bit = False And Runing_BitW = False Then


        If Runing_Bit = False Then
            Runing_Bit = True
            Button7.Text = "运行中..."

            TextBox0_Bit = False
            TextBox1_Bit = False
            TextBox2_Bit = False
            TextBox10_Bit = False
            TextBox7_Bit = False
            TextBox8_Bit = False
            TextBox9_Bit = False
            TextBox50_Bit = False

            If Backstup.duqu(TextBox7.Text) = "OK" Then
                Dim reader() As String
                reader = Backstup.redata
                TestTotal = reader(1)
                TextBox42.Text = TestTotal
                'MessageBox.Show("读取参数成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'MessageBox.Show("读取参数失败!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TestTotal = "0"
                TextBox42.Text = TestTotal
            End If
        Else
            Runing_Bit = False
            Button7.Text = "启动"

            Dim write(2) As String
            '生产料号
            write(0) = TextBox7.Text
            write(1) = TextBox42.Text
            If write(0) = "" Or write(0) = Nothing Then
                MessageBox.Show("产品批号不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Backstup.baocun(write) = "OK" Then
                    'MessageBox.Show("保存参数成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("保存参数失败!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.Clear()
        Dim data As String()
        data = Backstup.updataname
        Dim qq As Integer
        For qq = 0 To Backstup.MaxReadDataList - 1
            ListBox1.Items.Add(data(qq))
        Next

    End Sub
  
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        'Me.Close()
        WindMuber2 = True
        WindMuber2B = True

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

        修正.Show()
    End Sub
   
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        x1 = CInt(TextBox51.Text)
        y1 = CInt(TextBox52.Text)
        x2 = CInt(TextBox53.Text)
        y2 = CInt(TextBox54.Text)
        cszie = CInt(TextBox55.Text)
        fsize = CInt(TextBox56.Text)
        GT800.PrintPDF417(TextBox41.Text, x1, y1, cszie, x2, y2, fsize)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Auto_Bit = False Then
            Auto_Bit = True
            Button11.Text = "手动输入"

        Else
            Auto_Bit = False
            Button11.Text = "自动生成"
        End If
    End Sub

    

    
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        x1 = CInt(TextBox51.Text)
        y1 = CInt(TextBox52.Text)
        x2 = CInt(TextBox53.Text)
        y2 = CInt(TextBox54.Text)
        cszie = CInt(TextBox55.Text)
        fsize = CInt(TextBox56.Text)
        GT800.PrintPDF417(TextBox50.Text, x1, y1, cszie, x2, y2, fsize)
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim hh As String
        hh = TextBox0.Text

        Dim result As String
        result = Readtotable.AddTable(hh)
        result = Readtotable.AddTable2(hh)
        If result = "ok" And Readtotable.ExistTable = False Then
            ProduceNumber = TextBox0.Text
            ProduceStandard = TextBox1.Text
            Operators = TextBox2.Text
            Num = ComboBox1.Text
            TestTotal = 0
            'TextBox3.Text = TextBox0.Text
            TextBox1.Text = TextBox1.Text
            TextBox2.Text = TextBox2.Text

            TextBox42.Text = TestTotal

        ElseIf result = "ok" Then
            TestTotal = SaveTestData.ReadTable1(hh)

            ProduceNumber = TextBox0.Text
            ProduceStandard = TextBox1.Text
            Operators = TextBox2.Text
            Num = ComboBox1.Text
            TestTotal = TextBox42.Text
            'TextBox3.Text = TextBox0.Text
            TextBox1.Text = TextBox1.Text
            TextBox2.Text = TextBox2.Text

        End If
        'ProduceNumber = TextBox3.Text
        'ProduceStandard = TextBox4.Text
        'Operators = TextBox5.Text
        'Num = TextBox6.Text
        Data_LL_Set = ComboBox2.Text
        Data_MP_Set = ComboBox3.Text
        Data_XZ_Set = ComboBox4.Text
        'TestTotal = TextBox42.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub TextBox9_Click(sender As Object, e As MouseEventArgs) Handles TextBox9.MouseDown

    End Sub

    Private Sub TextBox41_TextChanged(sender As Object, e As EventArgs) Handles TextBox41.TextChanged
        TextBox41_Bit = True
    End Sub
End Class