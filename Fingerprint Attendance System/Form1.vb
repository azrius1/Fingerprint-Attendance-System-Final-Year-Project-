Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports ClosedXML.Excel

Public Class Form1

    Dim interval As Integer ' used to clear the textbox1
    Dim secs As Integer
    Dim mins As Integer
    Dim value2 As Decimal
    Dim mysqlcon As New MySqlConnection("SERVER=localhost;USERID=root;PASSWORD=;DATABASE=fingerprint1;")
    Dim mysqlcommd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Dim i As Integer
    Dim data As String
    Dim stmt As String

    Dim tempFingerID As Integer
    Dim sflag1 As Integer
    Dim sflag2 As Integer
    Dim sflag3 As Integer
    Dim sflag4 As Integer
    Dim sflag5 As Integer
    Dim sflag6 As Integer
    Dim sflag7 As Integer
    Dim sflag8 As Integer
    Dim sflag9 As Integer
    Dim sflag10 As Integer
    Dim sflag11 As Integer
    Dim sflag12 As Integer
    Dim sflag13 As Integer
    Dim sflag14 As Integer
    Dim sflag15 As Integer
    Dim sflag16 As Integer
    Dim sflag17 As Integer
    Dim sflag18 As Integer
    Dim sflag19 As Integer
    Dim sflag20 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        secs = 0
        mins = 0
        interval = 0
        sflag1 = 0
        sflag2 = 0
        sflag3 = 0
        sflag4 = 0
        sflag5 = 0
        sflag6 = 0
        sflag7 = 0
        sflag8 = 0
        sflag9 = 0

        Me.CenterToScreen()
        PanelWelcome.Visible = True
        PanelAdmin.Visible = False
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = False
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = False
        PanelCheck.Visible = False

        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = "9600" 'use same baud rate as used in Arduino
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()
    End Sub

    Sub clear()
        LabelAttendance.Text = ""
        TextBoxName.Text = ""
        TextBoxClass.Text = ""
        TextBoxContact.Text = ""
        TextBoxFingerID.Text = ""
        TextBox1.Text = ""
        CheckBox1.Checked = False
    End Sub

    Sub clearR()
        TextBoxRName.Text = ""
        TextBoxRClass.Text = ""
        TextBoxRContact.Text = ""
        TextBoxRFI.Text = ""
    End Sub

    Private Sub showdata()
        mysqlcon.Open()
        With mysqlcommd
            .Connection = mysqlcon
            .CommandText = "Select * from attendance"

        End With
        da.SelectCommand = mysqlcommd
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt


        mysqlcon.Close()
    End Sub

    'interfaces
    Private Sub ButtonAttendance_Click(sender As Object, e As EventArgs) Handles ButtonAttendance.Click
        Timer1.Start()
        Timer3.Start()
        tempFingerID = 0
        LabelAttendance.Text = ""
        PanelWelcome.Visible = False
        PanelAdmin.Visible = False
        PanelAttendance.Visible = True
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = False
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = False
        PanelCheck.Visible = False
    End Sub

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        PanelWelcome.Visible = False
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = True
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = False
        PanelCheck.Visible = False
    End Sub

    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = False
        PanelReport.Visible = True
        ButtonAdminMenu.Visible = True
    End Sub

    Private Sub ButtonRegisterPanel_Click(sender As Object, e As EventArgs) Handles ButtonRegisterPanel.Click
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = True
        PanelLogin.Visible = False
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = True
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = True
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = False
        If TextBoxUsername.Text = "admin" And TextBoxPass.Text = "1234" Then
            TextBoxUsername.Text = ""
            TextBoxPass.Text = ""
            PanelAdmin.Visible = True
            PanelAttendance.Visible = False
            PanelAdminMenu.Visible = True
            PanelRegister.Visible = False
            PanelLogin.Visible = False
            PanelReport.Visible = False
        Else
            MsgBox("Invalid Username Or Password")
        End If
    End Sub

    Private Sub ButtonAdminMenu_Click(sender As Object, e As EventArgs) Handles ButtonAdminMenu.Click
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = True
        PanelRegister.Visible = False
        PanelLogin.Visible = False
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = False
        PanelCheck.Visible = False
    End Sub

    'function for attendance
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' for present 
        If ((mins <= 3) And (InStr(TextBox1.Text, "stu1")) And (sflag1 = 0)) Then
            tempFingerID = 1
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag1 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu2") And sflag2 = 0 Then
            tempFingerID = 2
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag2 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu3") And sflag3 = 0 Then
            tempFingerID = 3
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag3 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu4") And sflag4 = 0 Then
            tempFingerID = 4
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag4 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu5") And sflag5 = 0 Then
            tempFingerID = 5
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag5 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu6") And sflag6 = 0 Then
            tempFingerID = 6
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag6 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu7") And sflag7 = 0 Then
            tempFingerID = 7
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag7 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu8") And sflag8 = 0 Then
            tempFingerID = 8
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag8 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu9") And sflag9 = 0 Then
            tempFingerID = 9
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag9 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu10") And sflag10 = 0 Then
            tempFingerID = 10
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag10 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu11") And sflag11 = 0 Then
            tempFingerID = 11
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag11 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu12") And sflag12 = 0 Then
            tempFingerID = 12
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag12 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu13") And sflag13 = 0 Then
            tempFingerID = 13
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag13 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu14") And sflag14 = 0 Then
            tempFingerID = 14
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag14 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu15") And sflag15 = 0 Then
            tempFingerID = 15
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag15 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu16") And sflag16 = 0 Then
            tempFingerID = 16
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag16 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu17") And sflag17 = 0 Then
            tempFingerID = 17
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag17 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu18") And sflag18 = 0 Then
            tempFingerID = 18
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag18 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu19") And sflag19 = 0 Then
            tempFingerID = 19
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag19 = 1

        End If

        If mins <= 3 And InStr(TextBox1.Text, "stu20") And sflag20 = 0 Then
            tempFingerID = 20
            LabelAttendance.Text = "Present"
            CheckBox1.Checked = True
            sflag20 = 1

        End If
        ' for late 
        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu1") And sflag1 = 0 Then
            tempFingerID = 1
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag1 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu2") And sflag2 = 0 Then
            tempFingerID = 2
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag2 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu3") And sflag3 = 0 Then
            tempFingerID = 3
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag3 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu4") And sflag4 = 0 Then
            tempFingerID = 4
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag4 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu5") And sflag5 = 0 Then
            tempFingerID = 5
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag5 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu6") And sflag6 = 0 Then
            tempFingerID = 6
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag6 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu7") And sflag7 = 0 Then
            tempFingerID = 7
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag7 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu8") And sflag8 = 0 Then
            tempFingerID = 8
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag8 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu9") And sflag9 = 0 Then
            tempFingerID = 9
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag9 = 1

        End If


        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu10") And sflag10 = 0 Then
            tempFingerID = 10
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag10 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu11") And sflag11 = 0 Then
            tempFingerID = 11
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag11 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu12") And sflag12 = 0 Then
            tempFingerID = 12
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag12 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu13") And sflag13 = 0 Then
            tempFingerID = 13
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag13 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu14") And sflag14 = 0 Then
            tempFingerID = 14
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag14 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu15") And sflag15 = 0 Then
            tempFingerID = 15
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag15 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu16") And sflag16 = 0 Then
            tempFingerID = 16
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag16 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu17") And sflag17 = 0 Then
            tempFingerID = 17
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag17 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu18") And sflag18 = 0 Then
            tempFingerID = 18
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag18 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu19") And sflag19 = 0 Then
            tempFingerID = 19
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag19 = 1

        End If

        If mins > 3 And mins < 6 And InStr(TextBox1.Text, "stu20") And sflag20 = 0 Then
            tempFingerID = 20
            LabelAttendance.Text = "Late"
            CheckBox1.Checked = True
            sflag20 = 1
        End If

        ' for absent
        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu1") And sflag1 = 0 Then
            tempFingerID = 1
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag1 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu2") And sflag2 = 0 Then
            tempFingerID = 2
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag2 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu3") And sflag3 = 0 Then
            tempFingerID = 3
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag3 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu4") And sflag4 = 0 Then
            tempFingerID = 4
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag4 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu5") And sflag5 = 0 Then
            tempFingerID = 5
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag5 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu6") And sflag6 = 0 Then
            tempFingerID = 6
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag6 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu7") And sflag7 = 0 Then
            tempFingerID = 7
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag7 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu8") And sflag8 = 0 Then
            tempFingerID = 8
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag8 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu9") And sflag9 = 0 Then
            tempFingerID = 9
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag9 = 1

        End If


        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu10") And sflag10 = 0 Then
            tempFingerID = 10
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag10 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu11") And sflag11 = 0 Then
            tempFingerID = 11
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag11 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu12") And sflag12 = 0 Then
            tempFingerID = 12
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag12 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu13") And sflag13 = 0 Then
            tempFingerID = 13
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag13 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu14") And sflag14 = 0 Then
            tempFingerID = 14
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag14 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu15") And sflag15 = 0 Then
            tempFingerID = 15
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag15 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu16") And sflag16 = 0 Then
            tempFingerID = 16
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag16 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu17") And sflag17 = 0 Then
            tempFingerID = 17
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag17 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu18") And sflag18 = 0 Then
            tempFingerID = 18
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag18 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu19") And sflag19 = 0 Then
            tempFingerID = 19
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag19 = 1

        End If

        If mins >= 6 And mins <= 10 And InStr(TextBox1.Text, "stu20") And sflag20 = 0 Then
            tempFingerID = 20
            LabelAttendance.Text = "Absent"
            CheckBox1.Checked = True
            sflag20 = 1
        End If

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clear()
    End Sub

    'mark attendance onto database
    Private Sub ButtonAttend_Click(sender As Object, e As EventArgs) Handles ButtonAttend.Click
        ButtonAttend.Visible = False
        If tempFingerID = 0 Then
            MsgBox("No Fingerprint Detected")
        Else
            mysqlcon.Open()
            With mysqlcommd
                .Connection = mysqlcon
                .CommandText = "insert into fingerprint1.attendance(date, name, fingerprintid, class, attendance) values('" & DateTimeToday.Text & "','" & TextBoxName.Text & "','" & TextBoxFingerID.Text & "','" & TextBoxClass.Text & "','" & LabelAttendance.Text & "')"
                i = .ExecuteNonQuery
            End With
            If i > 0 Then
                MsgBox("Data saved: " & i & " rows")
                clear()

            End If
        End If
        mysqlcon.Close()
        LabelAttendance.Text = ""
        tempFingerID = 0
    End Sub

    'registration for user onto database
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        mysqlcon.Open()
        With mysqlcommd
            .Connection = mysqlcon
            .CommandText = "insert into userdata(class,contact,fingerid,name) values('" & TextBoxRClass.Text & "','" & TextBoxRContact.Text & "','" & TextBoxRFI.Text & "','" & TextBoxRName.Text & "')"
            i = .ExecuteNonQuery
        End With
        If i > 0 Then
            MsgBox("Data saved: " & i & " rows")
            clearR()

        End If
        mysqlcon.Close()
    End Sub

    'showdata in datagridview
    Private Sub ButtonView_Click(sender As Object, e As EventArgs) Handles ButtonView.Click
        showdata()
    End Sub

    'backupdata into computer
    Private Sub ButtonBackUp_Click(sender As Object, e As EventArgs) Handles ButtonBackUp.Click
        Try
            ButtonBackUp.Text = "Please Wait..."
            ButtonBackUp.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        For k As Integer = 1 To DataGridView1.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                ButtonBackUp.Text = "Export To MS Excel"
                ButtonBackUp.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    'timer use to clear textbox1
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox1.Text = ""
    End Sub

    'timer use to count mins
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        secs = secs + 1
        LabelSeconds.Text = secs
        LabelMinutes.Text = mins
        If secs = 60 Then
            secs = 0
            mins = mins + 1
        End If
    End Sub

    Private Sub ButtonUserP_Click(sender As Object, e As EventArgs) Handles ButtonUserP.Click
        PanelWelcome.Visible = False
        PanelAdmin.Visible = True
        PanelAttendance.Visible = False
        PanelAdminMenu.Visible = False
        PanelRegister.Visible = False
        PanelLogin.Visible = False
        PanelReport.Visible = False
        ButtonAdminMenu.Visible = True
        PanelCheck.Visible = True
    End Sub

    'check all existing users
    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Dim bSource As New BindingSource
        Try
            mysqlcon.Open()
            Dim Query As String
            Query = "select * from fingerprint1.userdata"
            mysqlcommd = New MySqlCommand(Query, mysqlcon)
            da.SelectCommand = mysqlcommd
            dt.Clear()
            da.Fill(dt)
            bSource.DataSource = dt
            DataGridView2.DataSource = bSource
            da.Update(dt)
            mysqlcon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub

    'function to communicate with fingerprint sensor
    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived


        Try

            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() TextBox1.Text &= mydata, MethodInvoker))
            Else
                TextBox1.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ButtonCheckInfo_Click(sender As Object, e As EventArgs) Handles ButtonCheckInfo.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim stmt As String
        mysqlcon.Open()
        LabelFingerIDCaptured.Text = tempFingerID
        If (tempFingerID = 0) Then
            MessageBox.Show("Please Scan Again")
        Else
            stmt = "SELECT * FROM userdata WHERE fingerid = '" & tempFingerID & " '"
            cmd = New MySqlCommand(stmt, mysqlcon)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBoxName.Text = dr.GetString("name")
                TextBoxContact.Text = dr.GetString("contact")
                TextBoxClass.Text = dr.GetString("class")
                TextBoxFingerID.Text = dr.GetString("fingerid")
                ButtonAttend.Visible = True
            End If
        End If
        mysqlcon.Close()


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        CheckBox1.Checked = False
    End Sub

    'havent do validation for registration page



End Class