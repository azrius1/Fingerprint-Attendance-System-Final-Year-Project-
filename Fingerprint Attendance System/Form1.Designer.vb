<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.ButtonAttendance = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelAttendance = New System.Windows.Forms.Panel()
        Me.DateTimeToday = New System.Windows.Forms.DateTimePicker()
        Me.LabelFingerIDCaptured = New System.Windows.Forms.Label()
        Me.ButtonCheckInfo = New System.Windows.Forms.Button()
        Me.TextBoxFingerID = New System.Windows.Forms.TextBox()
        Me.TextBoxContact = New System.Windows.Forms.TextBox()
        Me.TextBoxClass = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelFingerID = New System.Windows.Forms.Label()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.LabelContact = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonAttend = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelSeconds = New System.Windows.Forms.Label()
        Me.LabelMinutes = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelAttendance = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.ButtonAdminMenu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelReport = New System.Windows.Forms.Panel()
        Me.ButtonBackUp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.PanelCheck = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.PanelAdminMenu = New System.Windows.Forms.Panel()
        Me.ButtonUserP = New System.Windows.Forms.Button()
        Me.ButtonRegisterPanel = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.PanelRegister = New System.Windows.Forms.Panel()
        Me.TextBoxRFI = New System.Windows.Forms.TextBox()
        Me.TextBoxRContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TextBoxRClass = New System.Windows.Forms.TextBox()
        Me.TextBoxRName = New System.Windows.Forms.TextBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelWelcome = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAttendance.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.PanelReport.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCheck.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdminMenu.SuspendLayout()
        Me.PanelRegister.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.PanelWelcome.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelMenu.Controls.Add(Me.ButtonAdmin)
        Me.PanelMenu.Controls.Add(Me.ButtonAttendance)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Location = New System.Drawing.Point(0, -1)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(306, 452)
        Me.PanelMenu.TabIndex = 0
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdmin.Location = New System.Drawing.Point(2, 369)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(302, 36)
        Me.ButtonAdmin.TabIndex = 2
        Me.ButtonAdmin.Text = "Administration"
        Me.ButtonAdmin.UseVisualStyleBackColor = True
        '
        'ButtonAttendance
        '
        Me.ButtonAttendance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAttendance.Location = New System.Drawing.Point(2, 315)
        Me.ButtonAttendance.Name = "ButtonAttendance"
        Me.ButtonAttendance.Size = New System.Drawing.Size(302, 36)
        Me.ButtonAttendance.TabIndex = 1
        Me.ButtonAttendance.Text = "Attendance"
        Me.ButtonAttendance.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Fingerprint_Attendance_System.My.Resources.Resources._360_F_253881133_IYEIf0Hocwfv2lvjKlcHtaeHBxo5N4ZV
        Me.PictureBox1.Location = New System.Drawing.Point(83, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelAttendance
        '
        Me.PanelAttendance.Controls.Add(Me.DateTimeToday)
        Me.PanelAttendance.Controls.Add(Me.LabelFingerIDCaptured)
        Me.PanelAttendance.Controls.Add(Me.ButtonCheckInfo)
        Me.PanelAttendance.Controls.Add(Me.TextBoxFingerID)
        Me.PanelAttendance.Controls.Add(Me.TextBoxContact)
        Me.PanelAttendance.Controls.Add(Me.TextBoxClass)
        Me.PanelAttendance.Controls.Add(Me.TextBoxName)
        Me.PanelAttendance.Controls.Add(Me.LabelFingerID)
        Me.PanelAttendance.Controls.Add(Me.LabelClass)
        Me.PanelAttendance.Controls.Add(Me.LabelContact)
        Me.PanelAttendance.Controls.Add(Me.Label4)
        Me.PanelAttendance.Controls.Add(Me.LabelName)
        Me.PanelAttendance.Controls.Add(Me.Label3)
        Me.PanelAttendance.Controls.Add(Me.Label1)
        Me.PanelAttendance.Controls.Add(Me.Label2)
        Me.PanelAttendance.Controls.Add(Me.ButtonClear)
        Me.PanelAttendance.Controls.Add(Me.ButtonAttend)
        Me.PanelAttendance.Controls.Add(Me.TextBox1)
        Me.PanelAttendance.Controls.Add(Me.CheckBox1)
        Me.PanelAttendance.Controls.Add(Me.Label25)
        Me.PanelAttendance.Controls.Add(Me.Label24)
        Me.PanelAttendance.Controls.Add(Me.LabelSeconds)
        Me.PanelAttendance.Controls.Add(Me.LabelMinutes)
        Me.PanelAttendance.Controls.Add(Me.Label21)
        Me.PanelAttendance.Controls.Add(Me.LabelAttendance)
        Me.PanelAttendance.Controls.Add(Me.Label5)
        Me.PanelAttendance.Location = New System.Drawing.Point(315, 28)
        Me.PanelAttendance.Name = "PanelAttendance"
        Me.PanelAttendance.Size = New System.Drawing.Size(483, 410)
        Me.PanelAttendance.TabIndex = 4
        '
        'DateTimeToday
        '
        Me.DateTimeToday.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeToday.Enabled = False
        Me.DateTimeToday.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeToday.Location = New System.Drawing.Point(159, 11)
        Me.DateTimeToday.Name = "DateTimeToday"
        Me.DateTimeToday.Size = New System.Drawing.Size(86, 21)
        Me.DateTimeToday.TabIndex = 35
        '
        'LabelFingerIDCaptured
        '
        Me.LabelFingerIDCaptured.AutoSize = True
        Me.LabelFingerIDCaptured.Location = New System.Drawing.Point(20, 50)
        Me.LabelFingerIDCaptured.Name = "LabelFingerIDCaptured"
        Me.LabelFingerIDCaptured.Size = New System.Drawing.Size(13, 13)
        Me.LabelFingerIDCaptured.TabIndex = 34
        Me.LabelFingerIDCaptured.Text = "0"
        Me.LabelFingerIDCaptured.Visible = False
        '
        'ButtonCheckInfo
        '
        Me.ButtonCheckInfo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheckInfo.Location = New System.Drawing.Point(42, 160)
        Me.ButtonCheckInfo.Name = "ButtonCheckInfo"
        Me.ButtonCheckInfo.Size = New System.Drawing.Size(176, 49)
        Me.ButtonCheckInfo.TabIndex = 33
        Me.ButtonCheckInfo.Text = "1. Check Info"
        Me.ButtonCheckInfo.UseVisualStyleBackColor = True
        '
        'TextBoxFingerID
        '
        Me.TextBoxFingerID.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFingerID.Location = New System.Drawing.Point(217, 344)
        Me.TextBoxFingerID.Name = "TextBoxFingerID"
        Me.TextBoxFingerID.Size = New System.Drawing.Size(172, 21)
        Me.TextBoxFingerID.TabIndex = 32
        '
        'TextBoxContact
        '
        Me.TextBoxContact.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContact.Location = New System.Drawing.Point(217, 307)
        Me.TextBoxContact.Name = "TextBoxContact"
        Me.TextBoxContact.Size = New System.Drawing.Size(172, 21)
        Me.TextBoxContact.TabIndex = 31
        '
        'TextBoxClass
        '
        Me.TextBoxClass.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClass.Location = New System.Drawing.Point(217, 271)
        Me.TextBoxClass.Name = "TextBoxClass"
        Me.TextBoxClass.Size = New System.Drawing.Size(172, 21)
        Me.TextBoxClass.TabIndex = 30
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(217, 237)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(172, 21)
        Me.TextBoxName.TabIndex = 29
        '
        'LabelFingerID
        '
        Me.LabelFingerID.AutoSize = True
        Me.LabelFingerID.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFingerID.Location = New System.Drawing.Point(182, 347)
        Me.LabelFingerID.Name = "LabelFingerID"
        Me.LabelFingerID.Size = New System.Drawing.Size(0, 18)
        Me.LabelFingerID.TabIndex = 28
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClass.Location = New System.Drawing.Point(182, 275)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(0, 18)
        Me.LabelClass.TabIndex = 27
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContact.Location = New System.Drawing.Point(182, 311)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(0, 18)
        Me.LabelContact.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Class/Department   :"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(182, 240)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(0, 18)
        Me.LabelName.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Contact                  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name                     : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fingerprint ID         :"
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(411, 369)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(55, 26)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonAttend
        '
        Me.ButtonAttend.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAttend.Location = New System.Drawing.Point(248, 161)
        Me.ButtonAttend.Name = "ButtonAttend"
        Me.ButtonAttend.Size = New System.Drawing.Size(176, 49)
        Me.ButtonAttend.TabIndex = 19
        Me.ButtonAttend.Text = "2. Mark Attendance"
        Me.ButtonAttend.UseVisualStyleBackColor = True
        Me.ButtonAttend.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(44, 132)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 20)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Fingerprint Captured"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(286, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 18)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "s"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(231, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 18)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "m  :"
        '
        'LabelSeconds
        '
        Me.LabelSeconds.AutoSize = True
        Me.LabelSeconds.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeconds.Location = New System.Drawing.Point(262, 35)
        Me.LabelSeconds.Name = "LabelSeconds"
        Me.LabelSeconds.Size = New System.Drawing.Size(22, 18)
        Me.LabelSeconds.TabIndex = 14
        Me.LabelSeconds.Text = "00"
        '
        'LabelMinutes
        '
        Me.LabelMinutes.AutoSize = True
        Me.LabelMinutes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinutes.Location = New System.Drawing.Point(208, 35)
        Me.LabelMinutes.Name = "LabelMinutes"
        Me.LabelMinutes.Size = New System.Drawing.Size(22, 18)
        Me.LabelMinutes.TabIndex = 13
        Me.LabelMinutes.Text = "00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(103, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 18)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Time Elapsed :"
        '
        'LabelAttendance
        '
        Me.LabelAttendance.AutoSize = True
        Me.LabelAttendance.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAttendance.Location = New System.Drawing.Point(218, 70)
        Me.LabelAttendance.Name = "LabelAttendance"
        Me.LabelAttendance.Size = New System.Drawing.Size(0, 61)
        Me.LabelAttendance.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "YOU ARE"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.Controls.Add(Me.ButtonAdminMenu)
        Me.PanelAdmin.Controls.Add(Me.Label8)
        Me.PanelAdmin.Controls.Add(Me.PanelAdminMenu)
        Me.PanelAdmin.Controls.Add(Me.PanelCheck)
        Me.PanelAdmin.Controls.Add(Me.PanelRegister)
        Me.PanelAdmin.Controls.Add(Me.PanelLogin)
        Me.PanelAdmin.Controls.Add(Me.PanelReport)
        Me.PanelAdmin.Location = New System.Drawing.Point(315, 28)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(492, 410)
        Me.PanelAdmin.TabIndex = 5
        '
        'ButtonAdminMenu
        '
        Me.ButtonAdminMenu.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdminMenu.Location = New System.Drawing.Point(15, 27)
        Me.ButtonAdminMenu.Name = "ButtonAdminMenu"
        Me.ButtonAdminMenu.Size = New System.Drawing.Size(111, 23)
        Me.ButtonAdminMenu.TabIndex = 9
        Me.ButtonAdminMenu.Text = "Back to Menu"
        Me.ButtonAdminMenu.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(166, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 27)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Administration"
        '
        'PanelReport
        '
        Me.PanelReport.Controls.Add(Me.ButtonBackUp)
        Me.PanelReport.Controls.Add(Me.DataGridView1)
        Me.PanelReport.Controls.Add(Me.ButtonView)
        Me.PanelReport.Location = New System.Drawing.Point(-2, 68)
        Me.PanelReport.Name = "PanelReport"
        Me.PanelReport.Size = New System.Drawing.Size(494, 311)
        Me.PanelReport.TabIndex = 6
        '
        'ButtonBackUp
        '
        Me.ButtonBackUp.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackUp.Location = New System.Drawing.Point(333, 276)
        Me.ButtonBackUp.Name = "ButtonBackUp"
        Me.ButtonBackUp.Size = New System.Drawing.Size(128, 23)
        Me.ButtonBackUp.TabIndex = 8
        Me.ButtonBackUp.Text = "Back-up/ Save"
        Me.ButtonBackUp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(460, 217)
        Me.DataGridView1.TabIndex = 7
        '
        'ButtonView
        '
        Me.ButtonView.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonView.Location = New System.Drawing.Point(184, 18)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(75, 23)
        Me.ButtonView.TabIndex = 2
        Me.ButtonView.Text = "View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'PanelCheck
        '
        Me.PanelCheck.Controls.Add(Me.DataGridView2)
        Me.PanelCheck.Controls.Add(Me.ButtonCheck)
        Me.PanelCheck.Location = New System.Drawing.Point(3, 140)
        Me.PanelCheck.Name = "PanelCheck"
        Me.PanelCheck.Size = New System.Drawing.Size(474, 265)
        Me.PanelCheck.TabIndex = 7
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(15, 70)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(441, 175)
        Me.DataGridView2.TabIndex = 8
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheck.Location = New System.Drawing.Point(93, 19)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(302, 34)
        Me.ButtonCheck.TabIndex = 7
        Me.ButtonCheck.Text = "Check Current Users"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'PanelAdminMenu
        '
        Me.PanelAdminMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelAdminMenu.Controls.Add(Me.ButtonUserP)
        Me.PanelAdminMenu.Controls.Add(Me.ButtonRegisterPanel)
        Me.PanelAdminMenu.Controls.Add(Me.ButtonReport)
        Me.PanelAdminMenu.Location = New System.Drawing.Point(6, 79)
        Me.PanelAdminMenu.Name = "PanelAdminMenu"
        Me.PanelAdminMenu.Size = New System.Drawing.Size(477, 319)
        Me.PanelAdminMenu.TabIndex = 25
        '
        'ButtonUserP
        '
        Me.ButtonUserP.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUserP.Location = New System.Drawing.Point(81, 205)
        Me.ButtonUserP.Name = "ButtonUserP"
        Me.ButtonUserP.Size = New System.Drawing.Size(302, 41)
        Me.ButtonUserP.TabIndex = 6
        Me.ButtonUserP.Text = "Show Current Users"
        Me.ButtonUserP.UseVisualStyleBackColor = True
        '
        'ButtonRegisterPanel
        '
        Me.ButtonRegisterPanel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegisterPanel.Location = New System.Drawing.Point(81, 136)
        Me.ButtonRegisterPanel.Name = "ButtonRegisterPanel"
        Me.ButtonRegisterPanel.Size = New System.Drawing.Size(302, 36)
        Me.ButtonRegisterPanel.TabIndex = 5
        Me.ButtonRegisterPanel.Text = "Register New User"
        Me.ButtonRegisterPanel.UseVisualStyleBackColor = True
        '
        'ButtonReport
        '
        Me.ButtonReport.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReport.Location = New System.Drawing.Point(81, 68)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(302, 36)
        Me.ButtonReport.TabIndex = 4
        Me.ButtonReport.Text = "Generate Report"
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'PanelRegister
        '
        Me.PanelRegister.Controls.Add(Me.TextBoxRFI)
        Me.PanelRegister.Controls.Add(Me.TextBoxRContact)
        Me.PanelRegister.Controls.Add(Me.Label10)
        Me.PanelRegister.Controls.Add(Me.Label11)
        Me.PanelRegister.Controls.Add(Me.Label12)
        Me.PanelRegister.Controls.Add(Me.Label13)
        Me.PanelRegister.Controls.Add(Me.Label14)
        Me.PanelRegister.Controls.Add(Me.Label15)
        Me.PanelRegister.Controls.Add(Me.Label16)
        Me.PanelRegister.Controls.Add(Me.Label17)
        Me.PanelRegister.Controls.Add(Me.Label9)
        Me.PanelRegister.Controls.Add(Me.ButtonRegister)
        Me.PanelRegister.Controls.Add(Me.TextBoxRClass)
        Me.PanelRegister.Controls.Add(Me.TextBoxRName)
        Me.PanelRegister.Location = New System.Drawing.Point(15, 80)
        Me.PanelRegister.Name = "PanelRegister"
        Me.PanelRegister.Size = New System.Drawing.Size(454, 289)
        Me.PanelRegister.TabIndex = 9
        '
        'TextBoxRFI
        '
        Me.TextBoxRFI.Location = New System.Drawing.Point(187, 225)
        Me.TextBoxRFI.Name = "TextBoxRFI"
        Me.TextBoxRFI.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRFI.TabIndex = 21
        '
        'TextBoxRContact
        '
        Me.TextBoxRContact.Location = New System.Drawing.Point(187, 190)
        Me.TextBoxRContact.Name = "TextBoxRContact"
        Me.TextBoxRContact.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRContact.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(178, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 18)
        Me.Label10.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(178, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 18)
        Me.Label11.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(178, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 18)
        Me.Label12.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Class/Department   : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(47, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 18)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Contact                  : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 227)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Fingerprint ID (1-127) :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(178, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 18)
        Me.Label16.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(47, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 18)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Name                     : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(168, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 27)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Registration"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.Location = New System.Drawing.Point(337, 251)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(91, 35)
        Me.ButtonRegister.TabIndex = 5
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'TextBoxRClass
        '
        Me.TextBoxRClass.Location = New System.Drawing.Point(187, 154)
        Me.TextBoxRClass.Name = "TextBoxRClass"
        Me.TextBoxRClass.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRClass.TabIndex = 4
        '
        'TextBoxRName
        '
        Me.TextBoxRName.Location = New System.Drawing.Point(187, 119)
        Me.TextBoxRName.Name = "TextBoxRName"
        Me.TextBoxRName.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRName.TabIndex = 3
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.ButtonLogin)
        Me.PanelLogin.Controls.Add(Me.TextBoxPass)
        Me.PanelLogin.Controls.Add(Me.TextBoxUsername)
        Me.PanelLogin.Controls.Add(Me.Label7)
        Me.PanelLogin.Controls.Add(Me.Label6)
        Me.PanelLogin.Location = New System.Drawing.Point(6, 79)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(474, 328)
        Me.PanelLogin.TabIndex = 26
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(198, 205)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(91, 35)
        Me.ButtonLogin.TabIndex = 10
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(207, 134)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxPass.TabIndex = 9
        Me.TextBoxPass.UseSystemPasswordChar = True
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(207, 88)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxUsername.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password                     : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Username                    : "
        '
        'PanelWelcome
        '
        Me.PanelWelcome.Controls.Add(Me.Label28)
        Me.PanelWelcome.Controls.Add(Me.Label27)
        Me.PanelWelcome.Controls.Add(Me.Label26)
        Me.PanelWelcome.Controls.Add(Me.Label23)
        Me.PanelWelcome.Controls.Add(Me.Label22)
        Me.PanelWelcome.Location = New System.Drawing.Point(313, 13)
        Me.PanelWelcome.Name = "PanelWelcome"
        Me.PanelWelcome.Size = New System.Drawing.Size(491, 410)
        Me.PanelWelcome.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(23, 298)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(454, 27)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "And afterwards would be marked as ""absent""."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(21, 262)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(300, 27)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Next 2 mins marked as ""late"","
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(20, 225)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(335, 27)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "First 4 mins marked as ""present"","
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 127)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(461, 27)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Press ""Attendace"" to start marking attendance"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(62, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 27)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Welcome!"
        '
        'SerialPort1
        '
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 4000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(810, 450)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.PanelWelcome)
        Me.Controls.Add(Me.PanelAttendance)
        Me.Name = "Form1"
        Me.Text = "Fingerprint Attendance System"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAttendance.ResumeLayout(False)
        Me.PanelAttendance.PerformLayout()
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        Me.PanelReport.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCheck.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdminMenu.ResumeLayout(False)
        Me.PanelRegister.ResumeLayout(False)
        Me.PanelRegister.PerformLayout()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelWelcome.ResumeLayout(False)
        Me.PanelWelcome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonAttendance As Button
    Friend WithEvents ButtonAdmin As Button
    Friend WithEvents PanelAttendance As Panel
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelAttendance As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents TextBoxRFI As TextBox
    Friend WithEvents TextBoxRContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents TextBoxRClass As TextBox
    Friend WithEvents TextBoxRName As TextBox
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelAdminMenu As Panel
    Friend WithEvents ButtonRegisterPanel As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents PanelReport As Panel
    Friend WithEvents ButtonBackUp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonView As Button
    Friend WithEvents ButtonAdminMenu As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents LabelSeconds As Label
    Friend WithEvents LabelMinutes As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonAttend As Button
    Friend WithEvents PanelWelcome As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PanelCheck As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ButtonCheck As Button
    Friend WithEvents ButtonUserP As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBoxFingerID As TextBox
    Friend WithEvents TextBoxContact As TextBox
    Friend WithEvents TextBoxClass As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelFingerID As Label
    Friend WithEvents LabelClass As Label
    Friend WithEvents LabelContact As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCheckInfo As Button
    Friend WithEvents LabelFingerIDCaptured As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents DateTimeToday As DateTimePicker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
