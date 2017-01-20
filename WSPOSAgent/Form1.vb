Public Class Form1

    Public jobCount As Integer = 0
    Public jobCount2 As Integer = 0

    Structure serverinfo
        Public serveraddress As String
        Public user As String
        Public password As String
        Public database As String
    End Structure

    Structure JobSchedule
        Public count As Integer
        Public time As String
        Public isDisabled As String
        Public lastrun As String
        Public count2 As Integer
        Public time2 As String
        Public isDisabled2 As String
        Public lastrun2 As String

        Public Function totalTime() As Double
            Dim result As Double = 0
            Try
                Select Case time.ToLower
                    Case "seconds"
                        result = count * 1
                    Case "minutes"
                        result = count * 60
                    Case "hours"
                        result = count * 3600
                End Select
            Catch ex As Exception
                result = 0
            End Try
            Return result
        End Function
        Public Function totalTime2() As Double
            Dim result As Double = 0
            Try
                Select Case time2.ToLower
                    Case "seconds"
                        result = count2 * 1
                    Case "minutes"
                        result = count2 * 60
                    Case "hours"
                        result = count2 * 3600
                End Select
            Catch ex2 As Exception
                result = 0
            End Try
            Return result
        End Function

    End Structure

    Structure ConnectionInfo
        Public POS As serverinfo
        Public NAVws As serverinfo
        Public JOB As JobSchedule
        Public CustNo As String
        Public POS2 As serverinfo
        Public NAVws2 As serverinfo
        Public JOB2 As JobSchedule
        Public CustNo2 As String
    End Structure

    Public myConInfo As ConnectionInfo
    Dim ispayment2 As Boolean
    Dim grpJob2 As Object

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisable.CheckedChanged
        If CType(sender, CheckBox).Checked Then
            grpJob.Enabled = Not CType(sender, CheckBox).Checked
            'Timer1.Enabled = Not CType(sender, CheckBox).Checked
            jobCount = 0
        Else
            grpJob.Enabled = Not CType(sender, CheckBox).Checked
            'Timer1.Enabled = Not CType(sender, CheckBox).Checked
        End If
    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisable2.CheckedChanged
        If CType(sender, CheckBox).Checked Then
            grpJob2.Enabled = Not CType(sender, CheckBox).Checked
            'Timer1.Enabled = Not CType(sender, CheckBox).Checked
            jobCount2 = 0
        Else
            grpJob2.Enabled = Not CType(sender, CheckBox).Checked
            'Timer1.Enabled = Not CType(sender, CheckBox).Checked
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServer.Click
        SaveSettings()
    End Sub

    Private Sub btnJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJob.Click
        Try
            If Not (cbDuration.SelectedIndex > -1 And NumDuration.Value > 0) Then
                MsgBox("Untuk kolom durasi dan pemilihan waktunya" & vbCrLf & "Harap di isi dengan benar !", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If
            SaveSetting("MegatamaPOS", "JOB", "Count", NumDuration.Value)
            SaveSetting("MegatamaPOS", "JOB", "time", cbDuration.Text.ToLower)
            SaveSetting("MegatamaPOS", "JOB", "isdisabled", chkDisable.Checked.ToString.ToLower)
            LoadSettings()
        Catch ex As Exception
            MsgBox("Oops something wrong, " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Exit application ?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            NotifyIcon1.Dispose()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Abdi_JayaDataSet._ABDI_JAYA_Cause_of_Inactivity' table. You can move, or remove it, as needed.
        Me.ABDI_JAYA_Cause_of_InactivityTableAdapter.Fill(Me.Abdi_JayaDataSet._ABDI_JAYA_Cause_of_Inactivity)
        'TODO: This line of code loads data into the 'Abdi_JayaDataSet._ABDI_JAYA_History_Sales' table. You can move, or remove it, as needed.
        Me.ABDI_JAYA_History_SalesTableAdapter.Fill(Me.Abdi_JayaDataSet._ABDI_JAYA_History_Sales)

        'we load tha settings there
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show _
             ("Another Instance of this process is already running", _
                 "Multiple Instances Forbidden", _
                  MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        End If
        LoadSettings()
        LoadSettingsToControl()
        If CBool(myConInfo.JOB.isDisabled) Then
            chkDisable.Checked = CBool(myConInfo.JOB.isDisabled)
        End If
    End Sub

    Private Sub LoadSettings()
        With myConInfo
            With .POS
                .serveraddress = GetSetting("MegatamaPOS", "POS", "Server", "127.0.0.1")
                .database = GetSetting("MegatamaPOS", "POS", "Database")
                .user = GetSetting("MegatamaPOS", "POS", "User")
                .password = GetSetting("MegatamaPOS", "POS", "Password")
            End With
            With .NAVws
                .serveraddress = GetSetting("MegatamaPOS", "NAV WS", "Server", "Http://127.0.0.1")
                .user = GetSetting("MegatamaPOS", "NAV WS", "User")
                .password = GetSetting("MegatamaPOS", "NAV WS", "Password")
            End With
            With .JOB
                .count = GetSetting("MegatamaPOS", "JOB", "Count", "10")
                .time = GetSetting("MegatamaPOS", "JOB", "time", "minutes")
                .isDisabled = GetSetting("MegatamaPOS", "JOB", "isdisabled", "false")
                .lastrun = GetSetting("MegatamaPOS", "JOB", "lastrun", Date.Now.ToString)
                If CDate(.lastrun) < Date.Now Then
                    .lastrun = Date.Now
                End If
                CheckBox1_CheckedChanged(chkDisable, Nothing)
            End With
            .CustNo = GetSetting("MegatamaPOS", "CUST", "custno", "02/10/12")
        End With
    End Sub

    Private Sub LoadSettingsToControl()
        With myConInfo
            With .POS
                txtPOSserver.Text = .serveraddress
                txtPOSDb.Text = .database
                txtPOSUser.Text = .user
                txtPOSPassword.Text = .password
            End With
            With .NAVws
                txtWSserver.Text = .serveraddress
                txtWSuser.Text = .user
                txtWSpassword.Text = .password
            End With
            With .JOB
                NumDuration.Value = .count
                cbDuration.Text = .time
                chkDisable.Checked = CBool(.isDisabled)
            End With
            txtCustCode.Text = .CustNo
            With .POS2
                txtPOSserver.Text = .serveraddress
                txtPOSDb.Text = .database
                txtPOSUser.Text = .user
                txtPOSPassword.Text = .password
            End With
            With .NAVws2
                txtWSserver.Text = .serveraddress
                txtWSuser.Text = .user
                txtWSpassword.Text = .password
            End With
            With .JOB2
                NumDuration.Value = .count
                cbDuration.Text = .time
                chkDisable.Checked = CBool(.isDisabled)
            End With

        End With
    End Sub

    Private Sub SaveSettings()
        With myConInfo
            With .POS
                SaveSetting("MegatamaPOS", "POS", "Server", txtPOSserver.Text)
                SaveSetting("MegatamaPOS", "POS", "Database", txtPOSDb.Text)
                SaveSetting("MegatamaPOS", "POS", "User", txtPOSUser.Text)
                SaveSetting("MegatamaPOS", "POS", "Password", txtPOSPassword.Text)
            End With
            With .NAVws
                SaveSetting("MegatamaPOS", "NAV WS", "Server", txtWSserver.Text)
                SaveSetting("MegatamaPOS", "NAV WS", "User", txtWSuser.Text)
                SaveSetting("MegatamaPOS", "NAV WS", "Password", txtWSpassword.Text)
            End With
            SaveSetting("MegatamaPOS", "CUST", "custno", txtCustCode.Text)
            With .POS
                .serveraddress = GetSetting("MegatamaPOS", "POS", "Server", "127.0.0.1")
                .database = GetSetting("MegatamaPOS", "POS", "Database")
                .user = GetSetting("MegatamaPOS", "POS", "User")
                .password = GetSetting("MegatamaPOS", "POS", "Password")
            End With
            With .NAVws
                .serveraddress = GetSetting("MegatamaPOS", "NAV WS", "Server", "Http://127.0.0.1")
                .user = GetSetting("MegatamaPOS", "NAV WS", "User")
                .password = GetSetting("MegatamaPOS", "NAV WS", "Password")
            End With
            .CustNo = GetSetting("MegatamaPOS", "CUST", "custno")
        End With
    End Sub
    Private Sub SaveSettings2()
        With myConInfo
            With .POS2
                SaveSetting("MegatamaPOS", "POS", "Server", txtPOSserver.Text)
                SaveSetting("MegatamaPOS", "POS", "Database", txtPOSDb.Text)
                SaveSetting("MegatamaPOS", "POS", "User", txtPOSUser.Text)
                SaveSetting("MegatamaPOS", "POS", "Password", txtPOSPassword.Text)
            End With
            With .NAVws2
                SaveSetting("MegatamaPOS", "NAV WS", "Server", txtWSserver.Text)
                SaveSetting("MegatamaPOS", "NAV WS", "User", txtWSuser.Text)
                SaveSetting("MegatamaPOS", "NAV WS", "Password", txtWSpassword.Text)
            End With
            SaveSetting("MegatamaPOS", "CUST", "custno", txtCustCode.Text)
            With .POS2
                .serveraddress = GetSetting("MegatamaPOS", "POS", "Server", "127.0.0.1")
                .database = GetSetting("MegatamaPOS", "POS", "Database")
                .user = GetSetting("MegatamaPOS", "POS", "User")
                .password = GetSetting("MegatamaPOS", "POS", "Password")
            End With
            With .NAVws2
                .serveraddress = GetSetting("MegatamaPOS", "NAV WS", "Server", "Http://127.0.0.1")
                .user = GetSetting("MegatamaPOS", "NAV WS", "User")
                .password = GetSetting("MegatamaPOS", "NAV WS", "Password")
            End With
            .CustNo = GetSetting("MegatamaPOS", "CUST", "custno")
        End With
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jobCount += 1
        lblTime.Text = Date.Now.ToLongTimeString
        lblDate.Text = Date.Now.ToLongDateString
        If jobCount >= myConInfo.JOB.totalTime And Not chkDisable.Checked Then
            writelog("Start Job")
            runTheJob()
        End If
        If jobCount > 0 Then
            If Not CBool(myConInfo.JOB.isDisabled) Then
                Select Case myConInfo.JOB.time
                    Case "seconds"
                        lblMsg.Text = "Next run job on " & DateAdd(DateInterval.Second, myConInfo.JOB.count, CDate(myConInfo.JOB.lastrun))
                    Case "minutes"
                        lblMsg.Text = "Next run job on " & DateAdd(DateInterval.Minute, myConInfo.JOB.count, CDate(myConInfo.JOB.lastrun))
                    Case "hours"
                        lblMsg.Text = "Next run job on " & DateAdd(DateInterval.Hour, myConInfo.JOB.count, CDate(myConInfo.JOB.lastrun))
                    Case Else
                        lblMsg.Text = "No Job defined."
                End Select
            End If
        Else
            lblMsg.Text = "No Job defined."
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        jobCount2 += 1
        lblTime2.Text = Date.Now.ToLongTimeString
        lblDate2.Text = Date.Now.ToLongDateString
        If jobCount2 >= myConInfo.JOB2.totalTime And Not chkDisable2.Checked Then
            writelog2("Start Job")
            runTheJob2()
        End If
        If jobCount2 > 0 Then
            If Not CBool(myConInfo.JOB2.isDisabled) Then
                Select Case myConInfo.JOB2.time
                    Case "seconds"
                        lblMsg2.Text = "Next run job on " & DateAdd(DateInterval.Second, myConInfo.JOB2.count, CDate(myConInfo.JOB2.lastrun))
                    Case "minutes"
                        lblMsg2.Text = "Next run job on " & DateAdd(DateInterval.Minute, myConInfo.JOB2.count, CDate(myConInfo.JOB2.lastrun))
                    Case "hours"
                        lblMsg2.Text = "Next run job on " & DateAdd(DateInterval.Hour, myConInfo.JOB2.count, CDate(myConInfo.JOB2.lastrun))
                    Case Else
                        lblMsg2.Text = "No Job defined."
                End Select
            End If
        Else
            lblMsg2.Text = "No Job defined."
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.Visible = True
                Me.Hide()
            End If
        Catch ex As Exception
            writelog(ex.Message)
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
        Catch ex As Exception
            writelog(ex.Message)
        End Try
    End Sub

    Private Sub runTheJob()
        jobCount = 0
        SaveSetting("MegatamaPOS", "JOB", "lastrun", Date.Now.ToString)
        myConInfo.JOB.lastrun = GetSetting("MegatamaPOS", "JOB", "lastrun", Date.Now.ToString)
        If DoProcessDB() Then
            writelog("Job successfully executed")
        Else
            writelog("Job end with error")
        End If
        pgbar1.Value = 0
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        runTheJob()
    End Sub

    Private Function DoProcessDB() As Boolean
        Dim data As New Data.OleDb.OleDbConnection
        Dim datacommand As New Data.OleDb.OleDbCommand
        Dim result As Boolean = True
        With myConInfo.POS
            data.ConnectionString = "Provider=SQLOLEDB;server=" & .serveraddress & ";Trusted_Connection=no;database=" & .database & ";uid=" & .user & ";pwd=" & .password
        End With
        Try
            data.Open()
            If data.State = ConnectionState.Open Then
                datacommand = data.CreateCommand()
                datacommand.CommandText = "select distinct receive_no from [receive] where (exists(select 0 from trans where trans.receive_no=[receive].receive_no and tonav is null) or exists(select 0 from detailtrans where detailtrans.receive_no=[receive].receive_no and tonav is null))"
                datacommand.Prepare()
                'datacommand.ExecuteNonQuery()
                Dim datas As New Data.DataSet
                Dim datareader As New Data.OleDb.OleDbDataAdapter(datacommand)
                datareader.Fill(datas)
                Dim i As Integer = 0, i2 As Integer = 0, i3 As Integer = 0
                If datas.Tables(0).Rows.Count <= 0 Then
                    writelog("No record(s) Found")
                    Return True
                End If
                pgbar1.Minimum = 0
                pgbar1.Maximum = datas.Tables(0).Rows.Count - 1
                For i = 0 To datas.Tables(0).Rows.Count - 1
                    pgbar1.Value = i
                    Application.DoEvents()
                    datacommand.CommandText = "select searchcode,case when isnull((select  top  1 base_pk_unit  from  uvw_get_barcode " & _
                                              "where  barcode_no=detailtrans.stock_code order by base_pk_unit desc),'') ='' then (select  SC01009  from  sc010100 " & _
                                              "where  SC01001 = detailtrans.stock_code) else (select  top  1 base_pk_unit  from  uvw_get_barcode where  barcode_no = detailtrans.stock_code order by base_pk_unit desc) end as  pck_unit, [cust_id]," & _
                                              "(select doc_no from detail_specialtrans where code=2 and receive_no=[receive].receive_no) as reffdoc,[receive].code,currcode,(select currency_name from currency where currency_code=[receive].currcode) as currname," & _
                                              "[receive].transdate as transdate,[receive].posid,receive_id,[receive].receive_no,stock_code,quantity,disc*quantity as disc,custdisc*quantity as custdisc,disc+unitprice as unitprice," & _
                                              "(quantity*(unitprice+disc))-((disc+custdisc)*quantity) as totalprice,(disc+custdisc)*quantity as totaldisc, " & _
                                              "((disc*quantity/(case when unitprice=0 then 1 else (unitprice+disc)*quantity end))*100) as discpercent from detailtrans, [receive]" & _
                                              "where [receive].receive_no=detailtrans.receive_no and detailtrans.receive_no='" & datas.Tables(0).Rows(i).Item("receive_no") & "' and tonav is null  order by detailtrans.receive_no,receive_id"
                    datacommand.Prepare()
                    Dim dataread As New Data.DataSet
                    datareader = New Data.OleDb.OleDbDataAdapter(datacommand)
                    datareader.Fill(dataread)
                    Dim datatable As Data.DataTable = dataread.Tables(0)
                            'writelog("invoice")
                    i3 = 0
                    For i2 = 0 To datatable.Rows.Count - 1
                        Try
                            Application.DoEvents()
                                    'do ws here
                            If navisionWs(False, datatable.Rows(i2), i2 + 1) Then
                                        'do update here
                                datacommand.CommandText = "update detailtrans set tonav=1,tonavdt=getdate() where receive_id='" & datatable.Rows(i2).Item("receive_id") & "'"
                                datacommand.ExecuteNonQuery()
                                If datatable.Rows(i2).Item("reffdoc") & "" <> "" Then
                                    datacommand.CommandText = "update detail_specialtrans set tonav=1,tonavdt=getdate() where receive_no='" & datas.Tables(0).Rows(i).Item("receive_no") & "'"
                                    datacommand.ExecuteNonQuery()
                                        End If
                                    End If
                        Catch ex As Exception
                            result = False
                            writelog(ex.Message)
                                End Try
                        i3 += 1
                    Next
                            'writelog("payment")
                    dataread.Clear()
                    datatable.Clear()
                    datacommand.CommandText = "select min(paymenttype.type) as type,[receive].transdate,[receive].posid,trans.receive_no,trans_type,paymenttype.name,currency_code as currcode,(select currency_name from currency where currency_code=trans.currency_code) as currname,sum(payment) as totalprice,id as cardno,approval_no as reffno from trans,paymenttype,[receive] " & _
                            "Where Trans.trans_type = paymenttype.code And Trans.receive_no = [Receive].receive_no and trans.tonav is null and trans.receive_no='" & datas.Tables(0).Rows(i).Item("receive_no") & "' " & _
                            " group by trans.trans_type,[receive].transdate,[receive].posid,trans.receive_no,currency_code,trans.id,approval_no,paymenttype.name"
                    datacommand.Prepare()
                    datareader = New Data.OleDb.OleDbDataAdapter(datacommand)
                    datareader.Fill(dataread)
                    datatable = dataread.Tables(0)
                    For i2 = 0 To datatable.Rows.Count - 1
                        Try
                            Application.DoEvents()
                                    'do ws here
                            If navisionWs(True, datatable.Rows(i2), i2 + 1) Then
                                        'do update here
                                datacommand.CommandText = "update trans set tonav=1,tonavdt=getdate() where receive_no='" & datatable.Rows(i2).Item("receive_no") & "' and trans_type='" & datatable.Rows(i2).Item("trans_type") & "'"
                                datacommand.ExecuteNonQuery()
                                    End If
                        Catch ex As Exception
                            result = False
                            writelog(ex.Message)
                                End Try
                        i3 += 1
                    Next
                    dataread.Clear()
                Next
                datacommand.Dispose()
                datas.Dispose()
            End If
            data.Close()
            Return result
        Catch ex As Exception
            result = False
            data.Close()
            writelog(ex.Message)
            Return result
        End Try
    End Function

    Private Function navisionWs(ByVal ispayment As Boolean, ByVal data As DataRow, ByVal lineno As Integer) As Boolean
        Try
            Dim ws As New WSNAVHistSales.HistSales_Service
            ws.UseDefaultCredentials = True
            With myConInfo.NAVws
                ws.Url = .serveraddress 'Mid(.serveraddress, 1, InStr(1, .serveraddress, "://", 1) + 2) _
                '& .user & ":" & .password & "@" & _
                'Mid(.serveraddress, InStr(1, .serveraddress, "://", 1) + 3)
            End With
            Dim sales As New WSNAVHistSales.HistSales
            If Not ispayment Then
                sales.Document_TypeSpecified = True
                sales.Document_Type = IIf(data.Item("code") = 0, WSNAVHistSales.Document_Type.Invoice, WSNAVHistSales.Document_Type.Credit_Memo)
                sales.Document_No = data.Item("receive_no").ToString.Substring(8)
                sales.Location_Code = "DISPLAY" 'data.Item("posid")
                sales.Line_NoSpecified = True
                sales.Line_No = lineno
                ws.Create(sales)
                sales.Line_No = lineno
                ws.Update(sales)
                sales.Bar_Code = data.Item("searchcode").ToString
                sales.Unit_of_Measure_Code = data.Item("pck_unit").ToString
                sales.Sell_to_Customer_No = IIf(data.Item("cust_id").ToString & "" = "0" Or data.Item("cust_id").ToString.Trim & "" = "", myConInfo.CustNo, data.Item("cust_id"))
                sales.Document_Date = CDate(data.Item("transdate"))
                sales.Posting_Date = CDate(data.Item("transdate"))
                sales.Currency_Code = data.Item("currname").ToString.ToLower.Replace("rp", "").Replace("idr", "")
                sales.Item_No = data.Item("stock_code")
                sales.Quantity = data.Item("quantity")
                sales.Unit_Price = data.Item("unitprice")
                sales.Line_Disc_Percent = data.Item("discpercent")
                sales.Line_Disc_Amt = data.Item("totaldisc")
                sales.Amount = data.Item("totalprice")
                sales.External_Document_No = data.Item("reffdoc") & ""
                ws.Update(sales)
            Else
                sales.Document_TypeSpecified = True
                sales.Document_Type = WSNAVHistSales.Document_Type.Payment
                sales.Document_No = data.Item("receive_no").ToString.Substring(8)
                sales.Location_Code = "DISPLAY" 'data.Item("posid")
                sales.Line_NoSpecified = True
                sales.Line_No = lineno
                ws.Create(sales)
                sales.Line_No = lineno
                ws.Update(sales)
                sales.Bar_Code = data.Item("searchcode").ToString
                sales.Unit_of_Measure_Code = data.Item("pck_unit").ToString
                sales.Sell_to_Customer_No = IIf(data.Item("cust_id").ToString & "" = "0" Or data.Item("cust_id").ToString.Trim & "" = "", myConInfo.CustNo, data.Item("cust_id"))
                sales.Document_Type = WSNAVHistSales.Document_Type.Payment
                sales.Document_Date = CDate(data.Item("transdate"))
                sales.Posting_Date = CDate(data.Item("transdate"))
                sales.Currency_Code = data.Item("currname").ToString.ToLower.Replace("rp", "").Replace("idr", "")
                sales.Amount = data.Item("totalprice")
                sales.Payment_Method_Code = data.Item("type") & ""
                sales.Payment_Type = data.Item("type") & ""
                sales.Payment_Name = data.Item("name") & ""
                sales.Card_No = data.Item("cardno") & ""
                sales.Reference_No = data.Item("reffno") & ""
                ws.Update(sales)
            End If
            ws.Dispose()
            Return True
        Catch ex As Exception
            writelog(">>" & ex.Message)
            Return False
        End Try
    End Function

    Private Sub writelog(ByVal str As String)
        Try
            txtlog.Text &= Date.Now & " -> " & str & vbCrLf
        Catch ex As Exception
            txtlog.Text = Date.Now & " -> " & ex.Message & vbCrLf
        End Try
    End Sub

    


    Private Sub txtlog_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlog.DoubleClick
        writelog("Programmed By: Setyadi Eko Purnomo @2014, e-mail: oneboth@yahoo.com")
    End Sub

    Private Sub txtlog_TextChanged(sender As Object, e As EventArgs) Handles txtlog.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub runTheJob2()
        jobCount2 = 0
        SaveSetting("MegatamaPOS", "JOB", "lastrun", Date.Now.ToString)
        myConInfo.JOB2.lastrun = GetSetting("MegatamaPOS", "JOB", "lastrun", Date.Now.ToString)
        If DoProcessDB2() Then
            writelog2("Job successfully executed")
        Else
            writelog2("Job end with error")
        End If
        pgbar12.Value = 0
    End Sub
 
    Private Function DoProcessDB2() As Boolean
        Dim data2 As New Data.OleDb.OleDbConnection
        Dim datacommand2 As New Data.OleDb.OleDbCommand
        Dim result2 As Boolean = True
        With myConInfo.NAVws
            data2.ConnectionString = "Provider=SQLOLEDB;server=" & .serveraddress & ";Trusted_Connection=no;database=" & .database & ";uid=" & .user & ";pwd=" & .password
        End With
        Try
            data2.Open()
            If data2.State = ConnectionState.Open Then
                datacommand2 = data2.CreateCommand()
                'datacommand2.CommandText = "select distinct receive_no from [receive] where (exists(select 0 from trans where trans.receive_no=[receive].receive_no and tonav is null) or exists(select 0 from detailtrans where detailtrans.receive_no=[receive].receive_no and tonav is null))"
                datacommand2.CommandText = "SELECT [timestamp],[No],[Description 1],[Search Description],[Unit Price],[Description 2],[Base Unit of Measure],[Item Category Code],[Manufacturer Code],[Product Group Code],[Vendor No],[Vendor Item No] " & _
                                           ",[Blocked],[Global Dimension 1 Code],[Variant] FROM [Abdi Jaya].[dbo].[ABDI JAYA$Cause of Inactivity] "
                datacommand2.Prepare()
                'datacommand.ExecuteNonQuery()
                Dim datas2 As New Data.DataSet
                Dim datareader2 As New Data.OleDb.OleDbDataAdapter(datacommand2)
                datareader2.Fill(datas2)
                Dim i As Integer = 0, i2 As Integer = 0, i3 As Integer = 0
                If datas2.Tables(0).Rows.Count <= 0 Then
                    writelog2("No record(s) Found")
                    Return True
                End If
                pgbar12.Minimum = 0
                pgbar12.Maximum = datas2.Tables(0).Rows.Count - 1
                For i = 0 To datas2.Tables(0).Rows.Count - 1
                    pgbar12.Value = i
                    Application.DoEvents()
                    'datacommand2.CommandText = "select searchcode,case when isnull((select  top  1 base_pk_unit  from  uvw_get_barcode " & _
                    '                          "where  barcode_no=detailtrans.stock_code order by base_pk_unit desc),'') ='' then (select  SC01009  from  sc010100 " & _
                    '                          "where  SC01001 = detailtrans.stock_code) else (select  top  1 base_pk_unit  from  uvw_get_barcode where  barcode_no = detailtrans.stock_code order by base_pk_unit desc) end as  pck_unit, [cust_id]," & _
                    '                          "(select doc_no from detail_specialtrans where code=2 and receive_no=[receive].receive_no) as reffdoc,[receive].code,currcode,(select currency_name from currency where currency_code=[receive].currcode) as currname," & _
                    '                          "[receive].transdate as transdate,[receive].posid,receive_id,[receive].receive_no,stock_code,quantity,disc*quantity as disc,custdisc*quantity as custdisc,disc+unitprice as unitprice," & _
                    '                          "(quantity*(unitprice+disc))-((disc+custdisc)*quantity) as totalprice,(disc+custdisc)*quantity as totaldisc, " & _
                    '                          "((disc*quantity/(case when unitprice=0 then 1 else (unitprice+disc)*quantity end))*100) as discpercent from detailtrans, [receive]" & _
                    '                          "where [receive].receive_no=detailtrans.receive_no and detailtrans.receive_no='" & datas2.Tables(0).Rows(i).Item("receive_no") & "' and tonav is null  order by detailtrans.receive_no,receive_id"

                    datacommand2.CommandText = "SELECT  [timestamp],[No],[Description 1],[Search Description],[Unit Price],[Description 2],[Base Unit of Measure],[Item Category Code],[Manufacturer Code],[Product Group Code],[Vendor No],[Vendor Item No] " & _
                                               ",[Blocked],[Global Dimension 1 Code],[Variant] FROM [Abdi Jaya].[dbo].[ABDI JAYA$Cause of Inactivity] "
                    datacommand2.Prepare()
                    Dim dataread2 As New Data.DataSet
                    datareader2 = New Data.OleDb.OleDbDataAdapter(datacommand2)
                    datareader2.Fill(dataread2)
                    Dim datatable2 As Data.DataTable = dataread2.Tables(0)
                    'writelog("invoice")
                    i3 = 0
                    For i2 = 0 To datatable2.Rows.Count - 1
                        Try
                            Application.DoEvents()
                            'do ws here
                            If navisionWs2(False, datatable2.Rows(i2), i2 + 1) Then
                                'do update here
                                datacommand2.CommandText = "update detailtrans set tonav=1,tonavdt=getdate() where receive_id='" & DataTable.Rows(i2).Item("receive_id") & "'"
                                datacommand2.ExecuteNonQuery()
                                If datatable2.Rows(i2).Item("reffdoc") & "" <> "" Then
                                    datacommand2.CommandText = "update detail_specialtrans set tonav=1,tonavdt=getdate() where receive_no='" & datas2.Tables(0).Rows(i).Item("receive_no") & "'"
                                    datacommand2.ExecuteNonQuery()
                                End If
                            End If
                        Catch ex2 As Exception
                            result2 = False
                            writelog2(ex2.Message)
                        End Try
                        i3 += 1
                    Next
                    'writelog("payment")
                    dataread2.Clear()
                    datatable2.Clear()
                    datacommand2.CommandText = "select min(paymenttype.type) as type,[receive].transdate,[receive].posid,trans.receive_no,trans_type,paymenttype.name,currency_code as currcode,(select currency_name from currency where currency_code=trans.currency_code) as currname,sum(payment) as totalprice,id as cardno,approval_no as reffno from trans,paymenttype,[receive] " & _
                            "Where Trans.trans_type = paymenttype.code And Trans.receive_no = [Receive].receive_no and trans.tonav is null and trans.receive_no='" & datas2.Tables(0).Rows(i).Item("receive_no") & "' " & _
                            " group by trans.trans_type,[receive].transdate,[receive].posid,trans.receive_no,currency_code,trans.id,approval_no,paymenttype.name"
                    datacommand2.Prepare()
                    datareader2 = New Data.OleDb.OleDbDataAdapter(datacommand2)
                    datareader2.Fill(dataread2)
                    datatable2 = dataread2.Tables(0)
                    For i2 = 0 To datatable2.Rows.Count - 1
                        Try
                            Application.DoEvents()
                            'do ws here
                            If navisionWs2(True, datatable2.Rows(i2), i2 + 1) Then
                                'do update here
                                datacommand2.CommandText = "update trans set tonav=1,tonavdt=getdate() where receive_no='" & DataTable.Rows(i2).Item("receive_no") & "' and trans_type='" & DataTable.Rows(i2).Item("trans_type") & "'"
                                datacommand2.ExecuteNonQuery()
                            End If
                        Catch ex2 As Exception
                            result2 = False
                            writelog2(ex2.Message)
                        End Try
                        i3 += 1
                    Next
                    dataread2.Clear()
                Next
                datacommand2.Dispose()
                datas2.Dispose()
            End If
            data2.Close()
            Return result2
        Catch ex2 As Exception
            result2 = False
            data2.Close()
            writelog2(ex2.Message)
            Return result2
        End Try
    End Function
    Private Function navisionWs2(ByVal ispayment2 As Boolean, ByVal data2 As DataRow, ByVal lineno2 As Integer) As Boolean
        Try
            Dim ws2 As New WSNAVHistSales.HistSales_Service
            ws2.UseDefaultCredentials = True
            With myConInfo.NAVws2
                ws2.Url = .serveraddress 'Mid(.serveraddress, 1, InStr(1, .serveraddress, "://", 1) + 2) _
                '& .user & ":" & .password & "@" & _
                'Mid(.serveraddress, InStr(1, .serveraddress, "://", 1) + 3)
            End With
            'Dim sales2 As New WSNAVHistSales.HistSales
            Dim sales2 As New LogUpdateItem.UpdateItem
            sales2.
            'If Not ispayment2 Then
            'sales2.Document_TypeSpecified = True
            'sales2.Document_Type = IIf(Data.Item("code") = 0, WSNAVHistSales.Document_Type.Invoice, WSNAVHistSales.Document_Type.Credit_Memo)
            'sales2.Document_No = Data.Item("receive_no").ToString.Substring(8)
            'sales2.Location_Code = "DISPLAY" 'data.Item("posid")
            'sales2.Line_NoSpecified = True
            'sales2.Line_No = lineno2
            'ws2.Create(sales2)
            'sales2.Line_No = lineno2
            'ws2.Update(sales2)
            'sales2.Bar_Code = Data.Item("searchcode").ToString
            'sales2.Unit_of_Measure_Code = Data.Item("pck_unit").ToString
            'sales2.Sell_to_Customer_No = IIf(Data.Item("cust_id").ToString & "" = "0" Or Data.Item("cust_id").ToString.Trim & "" = "", myConInfo.CustNo, Data.Item("cust_id"))
            'sales2.Document_Date = CDate(Data.Item("transdate"))
            'sales2.Posting_Date = CDate(Data.Item("transdate"))
            'sales2.Currency_Code = Data.Item("currname").ToString.ToLower.Replace("rp", "").Replace("idr", "")
            'sales2.Item_No = Data.Item("stock_code")
            'sales2.Quantity = Data.Item("quantity")
            'sales2.Unit_Price = Data.Item("unitprice")
            'sales2.Line_Disc_Percent = Data.Item("discpercent")
            'sales2.Line_Disc_Amt = Data.Item("totaldisc")
            'sales2.Amount = Data.Item("totalprice")
            'sales2.External_Document_No = Data.Item("reffdoc") & ""
            'ws2.Update(sales2)

            'Else
            'sales2.Document_TypeSpecified = True
            'sales2.Document_Type = WSNAVHistSales.Document_Type.Payment
            'sales2.Document_No = Data.Item("receive_no").ToString.Substring(8)
            'sales2.Location_Code = "DISPLAY" 'data.Item("posid")
            'sales2.Line_NoSpecified = True
            'sales2.Line_No = lineno2
            'ws2.Create(sales2)
            'sales2.Line_No = lineno2
            'ws2.Update(sales2)
            'sales2.Bar_Code = Data.Item("searchcode").ToString
            'sales2.Unit_of_Measure_Code = Data.Item("pck_unit").ToString
            'sales2.Sell_to_Customer_No = IIf(Data.Item("cust_id").ToString & "" = "0" Or Data.Item("cust_id").ToString.Trim & "" = "", myConInfo.CustNo, Data.Item("cust_id"))
            'sales2.Document_Type = WSNAVHistSales.Document_Type.Payment
            'sales2.Document_Date = CDate(Data.Item("transdate"))
            'sales2.Posting_Date = CDate(Data.Item("transdate"))
            'sales2.Currency_Code = Data.Item("currname").ToString.ToLower.Replace("rp", "").Replace("idr", "")
            'sales2.Amount = Data.Item("totalprice")
            'sales2.Payment_Method_Code = Data.Item("type") & ""
            'sales2.Payment_Type = Data.Item("type") & ""
            'sales2.Payment_Name = Data.Item("name") & ""
            'sales2.Card_No = Data.Item("cardno") & ""
            'sales2.Reference_No = Data.Item("reffno") & ""
            'ws2.Update(sales2)
            'End If
            ws2.Dispose()
            Return True
        Catch ex As Exception
            writelog2(">>" & ex2.Message)
            Return False
        End Try
    End Function
    Private Sub writelog2(ByVal str2 As String)
        Try
            txtlog2.Text &= Date.Now & " -> " & str2 & vbCrLf
        Catch ex As Exception
            txtlog2.Text = Date.Now & " -> " & ex2.Message & vbCrLf
        End Try
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        runTheJob2()
    End Sub

    Private Sub btnJob2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJob2.Click
        Try
            If Not (cbDuration2.SelectedIndex > -1 And NumDuration2.Value > 0) Then
                MsgBox("Untuk kolom durasi dan pemilihan waktunya" & vbCrLf & "Harap di isi dengan benar !", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If
            SaveSetting("MegatamaPOS", "JOB", "Count", NumDuration2.Value)
            SaveSetting("MegatamaPOS", "JOB", "time", cbDuration2.Text.ToLower)
            SaveSetting("MegatamaPOS", "JOB", "isdisabled", chkDisable2.Checked.ToString.ToLower)
            LoadSettings()
        Catch ex2 As Exception
            MsgBox("Oops something wrong, " & ex2.Message, MsgBoxStyle.Critical)
        End Try
    End Sub





End Class
