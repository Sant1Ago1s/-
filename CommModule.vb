Module CommModule
    Public GT800 As New GT800.GT800PrinterHelper
    Public LV1 As New LV.Class1
    Public Backstup As New _Access.Backstup
    Public Readtotable As New _Access.ReadToTable1
    Public SaveTestData As New _Access.SaveTestData
    Public ProduceNumber As String   '生产批号
    Public ProduceStandard As String '产品规格
    Public Operators As String '操作工
    Public TestTotal As Integer '总数
    Public Num As Integer '机台号
    Public Data_LL_Set As Integer '来料条码个数
    Public Data_MP_Set As Integer '来料母排个数
    Public Data_XZ_Set As Integer '来料芯子个数
    Public Data_LL As String '来料条码
    Public Data_MP1, Data_MP2, Data_MP3 As String '母排条码
    Public Data_XZ1, Data_XZ2, Data_XZ3, Data_XZ4, Data_XZ5, Data_XZ6, Data_XZ7, Data_XZ8, Data_XZ9, Data_XZ10 As String '芯子条码
    Public Data_XZ11, Data_XZ12, Data_XZ13, Data_XZ14, Data_XZ15, Data_XZ16, Data_XZ17, Data_XZ18, Data_XZ19, Data_XZ20 As String '芯子条码
    Public Data_XZ21, Data_XZ22, Data_XZ23, Data_XZ24, Data_XZ25, Data_XZ26, Data_XZ27, Data_XZ28, Data_XZ29, Data_XZ30 As String '芯子条码
    Public Data_CP As String '成品条码



    Public Runing_Bit, Runing_Bit1, Runing_Bit2, Runing_Bit3, Runing_Bit4, Runing_Bit5, Runing_Bit6, Runing_Bit7, Runing_Bit8, Runing_Bit9 As Boolean
    Public Runing_Bit10, Runing_Bit11, Runing_Bit12, Runing_Bit13, Runing_Bit14, Runing_Bit15, Runing_Bit16, Runing_Bit17, Runing_Bit18, Runing_Bit19 As Boolean
    Public Runing_Bit20, Runing_Bit21, Runing_Bit22, Runing_Bit23, Runing_Bit24, Runing_Bit25, Runing_Bit26, Runing_Bit27, Runing_Bit28, Runing_Bit29 As Boolean
    Public Runing_Bit30, Runing_Bit31, Runing_Bit32, Runing_Bit33, Runing_Bit34, Runing_Bit35, Runing_Bit36, Runing_Bit37, Runing_Bit38, Runing_Bit39 As Boolean
    Public Auto_Bit As Boolean '自动生成成品条码

    Public WindMuber As Integer
    Public WindMuber1 As Boolean
    Public WindMuber2 As Boolean
    Public WindMuber2B As Boolean
    Public WindMuber3 As Boolean

    Public Runing_BitW As Boolean '扫完码了
    Public Runing_BitW_1 As Boolean '扫完码了
    Public Runing_BitW1 As Boolean '扫完码了
    Public Updatatimer8 As New System.Windows.Forms.Timer


    Public WithEvents timerLV As New System.Windows.Forms.Timer
    Public LVFirstBit As Boolean
    Public LVYouliao As Boolean
    Public LVMeiliao As Boolean
    Public LVMove As Boolean
    Public LVCompleted As Boolean
    Public LVworking As Boolean
    Public LVworking1 As Boolean
    Public LVStart As Boolean
    Public WithEvents CNumber As New System.ComponentModel.BackgroundWorker
    Public CNumber_1a, CNumber_1, CNumber_2, CNumber_3, CNumber_4, CNumber_5, CNumber_6, CNumber_7, CNumber_8, CNumber_9, CNumber_10, CNumber_11, CNumber_12, CNumber_13, CNumber_14, _
           CNumber_15, CNumber_16, CNumber_17, CNumber_18, CNumber_19, CNumber_20, CNumber_21, CNumber_22, CNumber_23, CNumber_24, CNumber_25, CNumber_26, CNumber_27 As String
    Public Const PLCInterval As Integer = 100


    Public Sub uptimer()
        Updatatimer8.Interval = PLCInterval
        Updatatimer8.Start()
        AddHandler Updatatimer8.Tick, AddressOf updataWorkBit
    End Sub
    Private Sub updataWorkBit()
        Updatatimer8.Stop()
        Select Case WindMuber
            Case 0
                扫码系统.updata0()
            Case 1
                修正.updata1()
        End Select









    End Sub






    Private Sub timerLV_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerLV.Tick
        timerLV.Stop()
        CNumber.RunWorkerAsync()
    End Sub

    Dim reDataLv As String
    Dim reDataLv1 As String
    Private Sub CNumber_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles CNumber.DoWork

        'If LVYouliao And LVMeiliao = False Then
        '    reDataLv = LV1._ReadNum
        'Else
        '    'LVCompleted = True
        'End If
        reDataLv = LV1._ReadNum
    End Sub

    Private Sub CNumber_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles CNumber.RunWorkerCompleted
        'If reDataLv <> "eeor" And reDataLv <> "" And reDataLv <> CNumber_1 Then
        If reDataLv <> "eeor" And reDataLv <> "" Then
            CNumber_1 = reDataLv
            'CNumber_1a = reDataLv
            LVCompleted = True
        Else
            'If LVStart And LVYouliao And LVMeiliao = False Then
            timerLV.Start()
            '    Else
            '    'LVCompleted = True
            'End If

        End If
    End Sub






























End Module