Imports System.Data.SqlClient
Public Class FormCallList
    Private Sub FormCallList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC' table. You can move, or remove it, as needed.
        Me.CM_CONT_TblAdapCall.FillContCall(Me._VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC, FormMain.UserADID)
        If DGViewCall.RowCount = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub RadCallRet_CheckedChanged(sender As Object, e As EventArgs) Handles RadCallRet.CheckedChanged
        _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "RETURN_CALL_DATE IS NOT NULL"
        DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
    End Sub

    Private Sub RadCallAppt_CheckedChanged(sender As Object, e As EventArgs) Handles RadCallAppt.CheckedChanged
        _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "APPOINTMENT_DATE_RESULT IS NOT NULL"
        DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
    End Sub

    Private Sub RadCallBoth_CheckedChanged(sender As Object, e As EventArgs) Handles RadCallBoth.CheckedChanged
        _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = ""
        DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
    End Sub

    Private Sub CmbBoxContDT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxCallDT.SelectedIndexChanged
        Dim FilStr As String
        Select Case CmbBoxCallDT.Text
            Case "ALL"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = ""
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Today"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "One Day"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+1) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+1) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Two Days"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+2) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+2) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Three Days"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+3) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+3) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Four Days"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+4) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+4) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Five Days"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+5) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+5) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "One Week"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+7) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+7) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Two Weeks"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+7) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+7) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "One Month"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+30) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+30) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
            Case "Two Months"
                FilStr = "(RETURN_CALL_DATE >= '" + Today + "' AND RETURN_CALL_DATE <= '" + Today.AddDays(+60) + "')"
                FilStr = FilStr + " OR (APPOINTMENT_DATE_RESULT >= '" + Today + "' AND APPOINTMENT_DATE_RESULT <= '" + Today.AddDays(+60) + "')"
                _VBE_DatamartDataSet6.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = FilStr
                DGViewCall.DataSource = _VBE_DatamartDataSet6.Tables(0).DefaultView
        End Select
    End Sub

    Private Sub BtnPatCMDet_Click(sender As Object, e As EventArgs) Handles BtnPatCMDet.Click
        Dim SqlUCon As New SqlConnection
        Dim SqlUCmd As New SqlCommand
        Dim SqlUReader As SqlDataReader
        Dim SqlUString As String

        SqlUString = "SELECT DOB, PROVIDER_FIRST_NAME, PROVIDER_LAST_NAME, prac.PRACTICE_NAME, ACTIVE_PATIENT_FLAG, LAST_REVISE_DATE, MAX_ATTRIBUTION_MONTH,"
        SqlUString = SqlUString + " pat.ADDR_LINE_1, pat.ADDR_LINE_2, pat.CITY, pat.STATE, pat.ZIP_CODE, pat.HOME_PHONE, pat.WORK_PHONE, pat.MOBILE_PHONE,"
        SqlUString = SqlUString + " pat.FIRST_NAME, pat.LAST_NAME"
        SqlUString = SqlUString + " FROM CM_PATIENT_INFO pat"
        SqlUString = SqlUString + " LEFT JOIN CM_PATIENT_ATTR_PROVIDER p_attr"
        SqlUString = SqlUString + " on pat.PATIENT_ID = p_attr.PATIENT_ID"
        SqlUString = SqlUString + " LEFT JOIN CM_DICT_PROVIDER_INFO prov"
        SqlUString = SqlUString + " on p_attr.PROVIDER_ID = prov.PROVIDER_ID"
        SqlUString = SqlUString + " LEFT JOIN CM_DICT_PRACTICE prac"
        SqlUString = SqlUString + " on p_attr.PRACTICE_ID = prac.PRACTICE_ID"
        SqlUString = SqlUString + " WHERE pat.PATIENT_ID = "

        Try
            SqlUCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlUCon.Open()
            SqlUCmd.Connection = SqlUCon
            SqlUCmd = New SqlCommand(SqlUString + DGViewCall.CurrentRow.Cells(0).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                FormTOC.TxtBoxPatFirst.Text = SqlUReader.Item(15)
                FormTOC.TxtBoxPatLast.Text = SqlUReader.Item(16)
                FormTOC.TxtBoxPatID.Text = DGViewCall.CurrentRow.Cells(0).Value
                FormTOC.TxtBoxPatDOB.Text = SqlUReader.Item(0)
                FormTOC.TxtBoxProvFirst.Text = SqlUReader.Item(1)
                FormTOC.TxtBoxProvLast.Text = SqlUReader.Item(2)
                FormTOC.TxtBoxPracName.Text = SqlUReader.Item(3)
                FormTOC.vCell19.Text = SqlUReader.Item(4)
                FormTOC.vCell23.Text = Convert.ToString(SqlUReader.Item(6))
                FormTOC.vCell22.Text = SqlUReader.Item(5)
                If SqlUReader.Item(4) = "N" Then
                    FormTOC.ChkBoxInActive.BackColor = Color.Yellow
                    FormTOC.ChkBoxInActive.Checked = True
                Else
                    FormTOC.ChkBoxInActive.BackColor = Color.White
                    FormTOC.ChkBoxInActive.Checked = False
                End If
                FormTOC.TxtPatDemAdd1.Text = SqlUReader.Item(7)
                FormTOC.TxtPatDemAdd2.Text = SqlUReader.Item(8)
                FormTOC.TxtPatDemCity.Text = SqlUReader.Item(9)
                FormTOC.TxtPatDemState.Text = SqlUReader.Item(10)
                FormTOC.TxtPatDemZip.Text = SqlUReader.Item(11)
                FormTOC.TxtPatDemPhoneH.Text = SqlUReader.Item(12)
                FormTOC.TxtPatDemPhoneW.Text = SqlUReader.Item(13)
                FormTOC.TxtPatDemPhoneC.Text = SqlUReader.Item(14)

                FormTOC.CM_UTIL_HIST_TblAdapTOC.FillUtilHist(FormTOC._VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY, Convert.ToInt64(FormTOC.TxtBoxPatID.Text))
                FormTOC.CM_CONT_HIST_TblAdapTOC.FillContHist(FormTOC._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(FormTOC.TxtBoxPatID.Text))
                If FormTOC.DGViewContHist.CurrentCell Is Nothing Then
                    FormTOC.LblDoNot.Visible = False
                ElseIf FormTOC.DGViewContHist.CurrentRow.Cells(20).Value = "Y" Then
                    FormTOC.LblDoNot.Visible = True
                Else
                    FormTOC.LblDoNot.Visible = False
                End If
                FormTOC.TabControl1.SelectedIndex = 1

                FormTOC.DGViewUtilHist.ClearSelection()
                FormTOC.DGViewContHist.ClearSelection()
                FormTOC.ResetFlds("YES")
                FormTOC.ChkBoxCM.Enabled = True
                'rs.ResizeAllControls(Me)
            End While
            'Get CM Enrollment
            SqlUCon.Close()
            SqlUCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlUCon.Open()
            SqlUCmd.Connection = SqlUCon
            SqlUString = "SELECT CM_ENROLLMENT FROM CM_PATIENT_INFO_DETAIL WHERE PATIENT_ID = "
            SqlUCmd = New SqlCommand(SqlUString + DGViewCall.CurrentRow.Cells(0).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                If SqlUReader.Item(0) = "YES" Then
                    FormTOC.ChkBoxCM.Checked = True
                Else
                    FormTOC.ChkBoxCM.Checked = False
                End If
            End While
        Catch ExCall As Exception
            MessageBox.Show("Get patient details failed during Utilization History: " & ExCall.Message)
        Finally
            SqlUCon.Close()
            FormTOC.ChkBoxCM.Enabled = True
        End Try
        Me.Close()
    End Sub

    Private Sub CreateExcel(GenDGV As DataGridView, ExcelName As String, RowCnt As Integer)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim tempFldr As String
        Dim resExcel As MsgBoxResult

        If RowCnt > 0 Then
            ProgBarExcel.Value = 0
            tempFldr = System.IO.Path.GetTempPath() + ExcelName + Format(Date.Now(), "ddMMMyyyy")
            resExcel = MsgBoxResult.Yes
            If RowCnt > 40 Then
                resExcel = MsgBox("This process will take about " & (RowCnt / 40) & " minutes to complete. Do you want to continue?", MsgBoxStyle.YesNo, "New Excel File")
            End If
            If (resExcel = MsgBoxResult.Yes) Then
                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWkBook = xlApp.Workbooks.Add(misValue)
                xlWkSheet = xlWkBook.Sheets("sheet1")

                For i = 0 To GenDGV.RowCount - 1
                    For j = 0 To GenDGV.ColumnCount - 1
                        For k As Integer = 1 To GenDGV.Columns.Count
                            xlWkSheet.Cells(1, k) = GenDGV.Columns(k - 1).HeaderText
                            xlWkSheet.Cells(i + 2, j + 1) = GenDGV(j, i).Value
                        Next
                    Next
                    If (ProgBarExcel.Value + (100 / RowCnt)) < 100 Then
                        ProgBarExcel.Value = ProgBarExcel.Value + (100 / RowCnt)
                    End If
                Next
                ProgBarExcel.Value = 100
                xlWkSheet.SaveAs(tempFldr + ".xlsx")
                xlWkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWkBook)
                releaseObject(xlWkSheet)

                resExcel = MsgBox("Process Completed, Would you like to open the excel file", MsgBoxStyle.YesNo, "New Excel File")
                If (resExcel = MsgBoxResult.Yes) Then
                    Process.Start(tempFldr + ".xlsx")
                End If
            End If
            ProgBarExcel.Value = 0
        Else
            MsgBox("There is no data in the grid to print the excel file", MsgBoxStyle.Information, "New Excel File")
        End If

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

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        CreateExcel(DGViewCall, "CallReminder_", DGViewCall.RowCount)
    End Sub
End Class