<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkDisable = New System.Windows.Forms.CheckBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.grpJob = New System.Windows.Forms.GroupBox()
        Me.btnJob = New System.Windows.Forms.Button()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.NumDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pgbar1 = New System.Windows.Forms.ProgressBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnServer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWSpassword = New System.Windows.Forms.TextBox()
        Me.txtWSuser = New System.Windows.Forms.TextBox()
        Me.txtWSserver = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPOSPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPOSUser = New System.Windows.Forms.TextBox()
        Me.txtPOSDb = New System.Windows.Forms.TextBox()
        Me.txtPOSserver = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnJob2 = New System.Windows.Forms.Button()
        Me.cbDuration2 = New System.Windows.Forms.ComboBox()
        Me.NumDuration2 = New System.Windows.Forms.NumericUpDown()
        Me.chkDisable2 = New System.Windows.Forms.CheckBox()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pgbar12 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtlog = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ABDIJAYAHistorySalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Abdi_JayaDataSet = New WSPOSAgent.Abdi_JayaDataSet()
        Me.BindingAbdi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABDI_JAYA_History_SalesTableAdapter = New WSPOSAgent.Abdi_JayaDataSetTableAdapters.ABDI_JAYA_History_SalesTableAdapter()
        Me.BindingUpdateItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABDI_JAYA_Cause_of_InactivityTableAdapter = New WSPOSAgent.Abdi_JayaDataSetTableAdapters.ABDI_JAYA_Cause_of_InactivityTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpJob.SuspendLayout()
        CType(Me.NumDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumDuration2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABDIJAYAHistorySalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Abdi_JayaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingAbdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingUpdateItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(412, 354)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.chkDisable)
        Me.TabPage1.Controls.Add(Me.lblMsg)
        Me.TabPage1.Controls.Add(Me.grpJob)
        Me.TabPage1.Controls.Add(Me.lblDate)
        Me.TabPage1.Controls.Add(Me.lblTime)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.pgbar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(404, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Job Scheduller"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Run Now"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkDisable
        '
        Me.chkDisable.AutoSize = True
        Me.chkDisable.Location = New System.Drawing.Point(6, 151)
        Me.chkDisable.Name = "chkDisable"
        Me.chkDisable.Size = New System.Drawing.Size(81, 17)
        Me.chkDisable.TabIndex = 16
        Me.chkDisable.Text = "Disable Job"
        Me.chkDisable.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Orange
        Me.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMsg.Location = New System.Drawing.Point(3, 260)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(392, 23)
        Me.lblMsg.TabIndex = 13
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpJob
        '
        Me.grpJob.Controls.Add(Me.btnJob)
        Me.grpJob.Controls.Add(Me.cbDuration)
        Me.grpJob.Controls.Add(Me.NumDuration)
        Me.grpJob.Location = New System.Drawing.Point(6, 174)
        Me.grpJob.Name = "grpJob"
        Me.grpJob.Size = New System.Drawing.Size(392, 74)
        Me.grpJob.TabIndex = 12
        Me.grpJob.TabStop = False
        Me.grpJob.Text = "Run Job Every"
        '
        'btnJob
        '
        Me.btnJob.Location = New System.Drawing.Point(270, 28)
        Me.btnJob.Name = "btnJob"
        Me.btnJob.Size = New System.Drawing.Size(108, 23)
        Me.btnJob.TabIndex = 15
        Me.btnJob.Text = "Save Job"
        Me.btnJob.UseVisualStyleBackColor = True
        '
        'cbDuration
        '
        Me.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"Seconds", "Minutes", "Hours"})
        Me.cbDuration.Location = New System.Drawing.Point(131, 30)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(118, 21)
        Me.cbDuration.TabIndex = 14
        '
        'NumDuration
        '
        Me.NumDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumDuration.Location = New System.Drawing.Point(83, 30)
        Me.NumDuration.Name = "NumDuration"
        Me.NumDuration.Size = New System.Drawing.Size(41, 20)
        Me.NumDuration.TabIndex = 13
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(11, 119)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(119, 29)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date Now"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(145, 82)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(125, 29)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Time Now"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Time Now"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Job Progress"
        '
        'pgbar1
        '
        Me.pgbar1.Location = New System.Drawing.Point(6, 29)
        Me.pgbar1.Name = "pgbar1"
        Me.pgbar1.Size = New System.Drawing.Size(310, 23)
        Me.pgbar1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtCustCode)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnServer)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(404, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(117, 267)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(147, 20)
        Me.txtCustCode.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Default Cust Code"
        '
        'btnServer
        '
        Me.btnServer.Location = New System.Drawing.Point(290, 298)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(108, 23)
        Me.btnServer.TabIndex = 2
        Me.btnServer.Text = "Save Setting"
        Me.btnServer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtWSpassword)
        Me.GroupBox2.Controls.Add(Me.txtWSuser)
        Me.GroupBox2.Controls.Add(Me.txtWSserver)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WS Navision Server"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Server"
        '
        'txtWSpassword
        '
        Me.txtWSpassword.Location = New System.Drawing.Point(111, 71)
        Me.txtWSpassword.Name = "txtWSpassword"
        Me.txtWSpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtWSpassword.Size = New System.Drawing.Size(147, 20)
        Me.txtWSpassword.TabIndex = 5
        '
        'txtWSuser
        '
        Me.txtWSuser.Location = New System.Drawing.Point(111, 45)
        Me.txtWSuser.Name = "txtWSuser"
        Me.txtWSuser.Size = New System.Drawing.Size(147, 20)
        Me.txtWSuser.TabIndex = 4
        '
        'txtWSserver
        '
        Me.txtWSserver.Location = New System.Drawing.Point(111, 19)
        Me.txtWSserver.Name = "txtWSserver"
        Me.txtWSserver.Size = New System.Drawing.Size(275, 20)
        Me.txtWSserver.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPOSPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPOSUser)
        Me.GroupBox1.Controls.Add(Me.txtPOSDb)
        Me.GroupBox1.Controls.Add(Me.txtPOSserver)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POS Server"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password"
        '
        'txtPOSPassword
        '
        Me.txtPOSPassword.Location = New System.Drawing.Point(111, 97)
        Me.txtPOSPassword.Name = "txtPOSPassword"
        Me.txtPOSPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPOSPassword.Size = New System.Drawing.Size(147, 20)
        Me.txtPOSPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Server"
        '
        'txtPOSUser
        '
        Me.txtPOSUser.Location = New System.Drawing.Point(111, 71)
        Me.txtPOSUser.Name = "txtPOSUser"
        Me.txtPOSUser.Size = New System.Drawing.Size(147, 20)
        Me.txtPOSUser.TabIndex = 2
        '
        'txtPOSDb
        '
        Me.txtPOSDb.Location = New System.Drawing.Point(111, 45)
        Me.txtPOSDb.Name = "txtPOSDb"
        Me.txtPOSDb.Size = New System.Drawing.Size(147, 20)
        Me.txtPOSDb.TabIndex = 1
        '
        'txtPOSserver
        '
        Me.txtPOSserver.Location = New System.Drawing.Point(111, 19)
        Me.txtPOSserver.Name = "txtPOSserver"
        Me.txtPOSserver.Size = New System.Drawing.Size(147, 20)
        Me.txtPOSserver.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.lblMsg2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.chkDisable2)
        Me.TabPage3.Controls.Add(Me.lblDate2)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(Me.lblTime2)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.pgbar12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(404, 328)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Job Update Item"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(86, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Loading Update Item From NAV to POS"
        '
        'lblMsg2
        '
        Me.lblMsg2.BackColor = System.Drawing.Color.Red
        Me.lblMsg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMsg2.Location = New System.Drawing.Point(3, 276)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(392, 23)
        Me.lblMsg2.TabIndex = 26
        Me.lblMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnJob2)
        Me.GroupBox3.Controls.Add(Me.cbDuration2)
        Me.GroupBox3.Controls.Add(Me.NumDuration2)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 74)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Run Job Every"
        '
        'btnJob2
        '
        Me.btnJob2.Location = New System.Drawing.Point(270, 28)
        Me.btnJob2.Name = "btnJob2"
        Me.btnJob2.Size = New System.Drawing.Size(108, 23)
        Me.btnJob2.TabIndex = 15
        Me.btnJob2.Text = "Save Job"
        Me.btnJob2.UseVisualStyleBackColor = True
        '
        'cbDuration2
        '
        Me.cbDuration2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDuration2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDuration2.FormattingEnabled = True
        Me.cbDuration2.Items.AddRange(New Object() {"Seconds", "Minutes", "Hours"})
        Me.cbDuration2.Location = New System.Drawing.Point(131, 30)
        Me.cbDuration2.Name = "cbDuration2"
        Me.cbDuration2.Size = New System.Drawing.Size(118, 21)
        Me.cbDuration2.TabIndex = 14
        '
        'NumDuration2
        '
        Me.NumDuration2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumDuration2.Location = New System.Drawing.Point(83, 30)
        Me.NumDuration2.Name = "NumDuration2"
        Me.NumDuration2.Size = New System.Drawing.Size(41, 20)
        Me.NumDuration2.TabIndex = 13
        '
        'chkDisable2
        '
        Me.chkDisable2.AutoSize = True
        Me.chkDisable2.Location = New System.Drawing.Point(6, 149)
        Me.chkDisable2.Name = "chkDisable2"
        Me.chkDisable2.Size = New System.Drawing.Size(81, 17)
        Me.chkDisable2.TabIndex = 24
        Me.chkDisable2.Text = "Disable Job"
        Me.chkDisable2.UseVisualStyleBackColor = True
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(11, 117)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(119, 29)
        Me.lblDate2.TabIndex = 23
        Me.lblDate2.Text = "Date Now"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(322, 25)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(76, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "Run Now"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(145, 78)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(125, 29)
        Me.lblTime2.TabIndex = 21
        Me.lblTime2.Text = "Time Now"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(86, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Time Now"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Job Progress"
        '
        'pgbar12
        '
        Me.pgbar12.Location = New System.Drawing.Point(6, 25)
        Me.pgbar12.Name = "pgbar12"
        Me.pgbar12.Size = New System.Drawing.Size(310, 23)
        Me.pgbar12.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "POS WS JOB Schedule"
        Me.NotifyIcon1.BalloonTipTitle = "POS WS JOB Schedule"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "POS WS JOB is running"
        Me.NotifyIcon1.Visible = True
        '
        'txtlog
        '
        Me.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlog.Location = New System.Drawing.Point(420, 25)
        Me.txtlog.Multiline = True
        Me.txtlog.Name = "txtlog"
        Me.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtlog.Size = New System.Drawing.Size(250, 332)
        Me.txtlog.TabIndex = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'ABDIJAYAHistorySalesBindingSource
        '
        Me.ABDIJAYAHistorySalesBindingSource.DataMember = "ABDI JAYA$History Sales"
        Me.ABDIJAYAHistorySalesBindingSource.DataSource = Me.Abdi_JayaDataSet
        '
        'Abdi_JayaDataSet
        '
        Me.Abdi_JayaDataSet.DataSetName = "Abdi_JayaDataSet"
        Me.Abdi_JayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingAbdi
        '
        Me.BindingAbdi.DataMember = "ABDI JAYA$History Sales"
        Me.BindingAbdi.DataSource = Me.Abdi_JayaDataSet
        Me.BindingAbdi.Filter = "[Posted]=0"
        '
        'ABDI_JAYA_History_SalesTableAdapter
        '
        Me.ABDI_JAYA_History_SalesTableAdapter.ClearBeforeFill = True
        '
        'BindingUpdateItem
        '
        Me.BindingUpdateItem.DataMember = "ABDI JAYA$Cause of Inactivity"
        Me.BindingUpdateItem.DataSource = Me.Abdi_JayaDataSet
        '
        'ABDI_JAYA_Cause_of_InactivityTableAdapter
        '
        Me.ABDI_JAYA_Cause_of_InactivityTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 358)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS WS Job Scheduller"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpJob.ResumeLayout(False)
        CType(Me.NumDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumDuration2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABDIJAYAHistorySalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Abdi_JayaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingAbdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingUpdateItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWSpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtWSuser As System.Windows.Forms.TextBox
    Friend WithEvents txtWSserver As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSDb As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSserver As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPOSPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnServer As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pgbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpJob As System.Windows.Forms.GroupBox
    Friend WithEvents btnJob As System.Windows.Forms.Button
    Friend WithEvents cbDuration As System.Windows.Forms.ComboBox
    Friend WithEvents NumDuration As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents chkDisable As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtlog As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents BindingAbdi As System.Windows.Forms.BindingSource
    Friend WithEvents Abdi_JayaDataSet As WSPOSAgent.Abdi_JayaDataSet
    Friend WithEvents ABDI_JAYA_History_SalesTableAdapter As WSPOSAgent.Abdi_JayaDataSetTableAdapters.ABDI_JAYA_History_SalesTableAdapter
    Friend WithEvents ABDIJAYAHistorySalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnJob2 As System.Windows.Forms.Button
    Friend WithEvents cbDuration2 As System.Windows.Forms.ComboBox
    Friend WithEvents NumDuration2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDisable2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents lblTime2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pgbar12 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BindingUpdateItem As System.Windows.Forms.BindingSource
    Friend WithEvents ABDI_JAYA_Cause_of_InactivityTableAdapter As WSPOSAgent.Abdi_JayaDataSetTableAdapters.ABDI_JAYA_Cause_of_InactivityTableAdapter

End Class
