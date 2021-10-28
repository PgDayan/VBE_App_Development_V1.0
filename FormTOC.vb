Imports System.Data.SqlClient
Public Class FormTOC
    Dim blankDate As Date
    Dim CMBStr As String
    'Dim vCell19 As String
    'Dim vCell22 As String
    'Dim vCell23 As String
    Dim vUpdStatus As String

    Dim rs As New Resizer

    Sub DgvStyleRow()
        'CMBPracticeTOC.Items.Add("ALL")
        For i As Integer = 0 To DGViewPatSrch.RowCount - 1
            If DGViewPatSrch.Rows(i).Cells(20).Value = "N" Then
                DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
            Else
                DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
            If Not CMBPracticeTOC.Items.Contains(DGViewPatSrch.Rows(i).Cells(10).Value) Then
                CMBPracticeTOC.Items.Add(DGViewPatSrch.Rows(i).Cells(10).Value)
            End If
        Next
    End Sub

    Sub DgvActiveRow(vAct As String)
        For i As Integer = 0 To DGViewPatSrch.RowCount - 1
            Select Case vAct
                Case "A"
                    If DGViewPatSrch.Rows(i).Cells(20).Value = "Y" Then
                        DGViewPatSrch.Rows(i).Visible = True
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.White
                    Else
                        DGViewPatSrch.CurrentCell = Nothing
                        DGViewPatSrch.Rows(i).Visible = False
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Case "I"
                    If DGViewPatSrch.Rows(i).Cells(20).Value = "Y" Then
                        DGViewPatSrch.CurrentCell = Nothing
                        DGViewPatSrch.Rows(i).Visible = False
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.White
                    Else
                        DGViewPatSrch.Rows(i).Visible = True
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Case "B"
                    DGViewPatSrch.Rows(i).Visible = True
                    If DGViewPatSrch.Rows(i).Cells(20).Value = "N" Then
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                    Else
                        DGViewPatSrch.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
            End Select
        Next
    End Sub

    Private Sub CmbFNameTOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFNameTOC.SelectedIndexChanged
        If TxtFNameTOC.Text = "" Then
            MessageBox.Show("First Name field is blank - please enter valid value")
        Else
            Select Case CmbFNameTOC.Text
                Case "Starts With"
                    TxtFNameTOC.Text = Replace(TxtFNameTOC.Text, "%", "")
                    TxtFNameTOC.Text = TxtFNameTOC.Text + "%"
                Case "Ends With"
                    TxtFNameTOC.Text = Replace(TxtFNameTOC.Text, "%", "")
                    TxtFNameTOC.Text = "%" + TxtFNameTOC.Text
                Case "Contains"
                    TxtFNameTOC.Text = Replace(TxtFNameTOC.Text, "%", "")
                    TxtFNameTOC.Text = "%" + TxtFNameTOC.Text + "%"
                Case "Full Word"
                    TxtFNameTOC.Text = Replace(TxtFNameTOC.Text, "%", "")
            End Select
        End If
    End Sub

    Private Sub CmbLNameTOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLNameTOC.SelectedIndexChanged
        If TxtLNameTOC.Text = "" Then
            MessageBox.Show("Last Name field is blank - please enter valid value")
        Else
            Select Case CmbLNameTOC.Text
                Case "Starts With"
                    TxtLNameTOC.Text = Replace(TxtLNameTOC.Text, "%", "")
                    TxtLNameTOC.Text = TxtLNameTOC.Text + "%"
                Case "Ends With"
                    TxtLNameTOC.Text = Replace(TxtLNameTOC.Text, "%", "")
                    TxtLNameTOC.Text = "%" + TxtLNameTOC.Text
                Case "Contains"
                    TxtLNameTOC.Text = Replace(TxtLNameTOC.Text, "%", "")
                    TxtLNameTOC.Text = "%" + TxtLNameTOC.Text + "%"
                Case "Full Word"
                    TxtLNameTOC.Text = Replace(TxtLNameTOC.Text, "%", "")
            End Select
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTPickDOBTOC.ValueChanged
        TxtDOBTOC.Text = DTPickDOBTOC.Text
        TxtFNameTOC.Text = ""
        TxtLNameTOC.Text = ""
    End Sub

    Private Sub BtnClearTOC_Click(sender As Object, e As EventArgs) Handles BtnClearTOC.Click
        TxtDOBTOC.Text = ""
        TxtLNameTOC.Text = ""
        TxtFNameTOC.Text = ""
        TxtBoxPracName.Text = ""
        CMBPracticeTOC.ResetText()
        CMBPracticeTOC.Items.Clear()
        Me.CM_PAT_TblAdapTOC.FillPatLast(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, "XXXXXXXX")
        PatSrchCnt()
    End Sub

    Private Sub TxtFNameTOC_Enter(sender As Object, e As EventArgs) Handles TxtFNameTOC.Enter
        If TxtFNameTOC.Text = "" Then
            'TxtFNameTOC.Text = "%"
            TxtDOBTOC.Text = ""
        End If
    End Sub

    Private Sub TxtLNameTOC_Enter(sender As Object, e As EventArgs) Handles TxtLNameTOC.Enter
        If TxtLNameTOC.Text = "" Then
            'TxtLNameTOC.Text = "%"
            TxtDOBTOC.Text = ""
        End If
    End Sub
    Private Sub BtnPatSrchTOC_Click(sender As Object, e As EventArgs) Handles BtnPatSrchTOC.Click
        CMBPracticeTOC.Items.Clear()
        CMBPracticeTOC.ResetText()
        TxtPracNameTOC.Text = ""
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = ""
        If TxtLNameTOC.Text <> "" And TxtFNameTOC.Text <> "" Then
            Me.CM_PAT_TblAdapTOC.FillBothNames(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtLNameTOC.Text, TxtFNameTOC.Text)
        ElseIf TxtLNameTOC.Text <> "" Then
            Me.CM_PAT_TblAdapTOC.FillPatLast(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtLNameTOC.Text)
        ElseIf TxtFNameTOC.Text <> "" Then
            Me.CM_PAT_TblAdapTOC.FillPatFirst(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtFNameTOC.Text)
        ElseIf TxtDOBTOC.Text = "" Then
            MessageBox.Show("Both First and Last name fields are blank", "BLANK FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If TxtDOBTOC.Text <> "" Then
            Me.CM_PAT_TblAdapTOC.FillDOB(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, Convert.ToDateTime(TxtDOBTOC.Text))
        End If

        DgvStyleRow()

        DGViewPatSrch.ClearSelection()
        PatSrchCnt()

    End Sub

    Private Sub FormTOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCallList.Close()
        rs.FindAllControls(Me)
        Try
            'TODO: This line of code loads data into the '_VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC' table. You can move, or remove it, as needed.
            Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, 0)
            'TODO: This line of code loads data into the '_VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY' table. You can move, or remove it, as needed.
            Me.CM_UTIL_HIST_TblAdapTOC.FillUtilHist(Me._VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY, 0)
            'TODO: This line of code loads data into the '_VBE_DatamartDataSet.CM_PATIENT_INFO' table. You can move, or remove it, as needed.
            Me.CM_PAT_TblAdapTOC.FillPatLast(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, "XXXXXX")
            'TODO: This line of code loads data into the '_VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY' table. You can move, or remove it, as needed.
            Select Case Today.DayOfWeek
                Case 1
                    Me.CM_UTIL_SRCH_TblAdap.FillDates(Me._VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY, Today.AddDays(-2), Today)
                    Me.CM_CONT_SRCH_TblAdap.FillContHist(Me._VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC, Today.AddDays(-3), Today)
                Case 7
                    Me.CM_UTIL_SRCH_TblAdap.FillDates(Me._VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY, Today.AddDays(-1), Today)
                    Me.CM_CONT_SRCH_TblAdap.FillContHist(Me._VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC, Today.AddDays(-2), Today)
                Case Else
                    Me.CM_UTIL_SRCH_TblAdap.FillDates(Me._VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY, Today, Today)
                    Me.CM_CONT_SRCH_TblAdap.FillContHist(Me._VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC, Today.AddDays(-1), Today)
            End Select
            DGViewPatSrch.Columns(1).Frozen = True
            DGViewContHist.Columns(3).Frozen = True
            DGViewUtilSrch.Columns(2).Frozen = True
            DGViewContSrch.Columns(3).Frozen = True
            LoadCmbBox()
            EnableFlds("NO")
            BtnUndoCont.Enabled = False
            BtnSaveCont.Enabled = False
            BtnPatDet.Enabled = False
            'MessageBox.Show(DGViewUtilSrch.RowCount)
            If DGViewUtilSrch.RowCount <> 0 Then
                If DGViewUtilSrch.Rows(0).Cells(0).Value <> Nothing Then
                    BtnPatDet.Enabled = True
                End If
            End If
            FormCallList.ShowDialog()
            PatSrchCnt()
            UtilSrchCnt()
            ContSrchCnt()
        Catch ExDB As Exception
            MessageBox.Show("Invalid Data Access: " & ExDB.Message)
        End Try

    End Sub

    Private Sub RADActive_CheckedChanged(sender As Object, e As EventArgs) Handles RADActiveTOC.CheckedChanged
        If RADActiveTOC.Checked Then
            RADBothTOC.Checked = False
            RADInActTOC.Checked = False
            DgvActiveRow("A")
        End If
    End Sub

    Private Sub RADBothTOC_CheckedChanged(sender As Object, e As EventArgs) Handles RADBothTOC.CheckedChanged
        If RADBothTOC.Checked Then
            RADActiveTOC.Checked = False
            RADInActTOC.Checked = False
            DgvActiveRow("B")
        End If
    End Sub

    Private Sub RADInActTOC_CheckedChanged(sender As Object, e As EventArgs) Handles RADInActTOC.CheckedChanged
        If RADInActTOC.Checked Then
            RADActiveTOC.Checked = False
            RADBothTOC.Checked = False
            DgvActiveRow("I")
        End If
    End Sub

    Private Sub CMBPracticeTOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPracticeTOC.SelectedIndexChanged
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = "PRACTICE_NAME= '" + CMBPracticeTOC.Text + "'"
        DGViewPatSrch.DataSource = _VBE_DatamartDataSet.Tables(0).DefaultView
        DgvActiveRow("B")
        PatSrchCnt()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGViewPatSrch.CellMouseDown
        DGViewPatSrch.ContextMenuStrip = ContMenuPatTOC
    End Sub

    Private Sub ProvLastNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvLastNToolStripMenuItem.Click
        MessageBox.Show(DGViewPatSrch.CurrentRow.Cells(9).Value, "Filter By Provider's Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = "PROVIDER_LAST_NAME= '" + DGViewPatSrch.CurrentRow.Cells(9).Value + "'"
        DGViewPatSrch.DataSource = _VBE_DatamartDataSet.Tables(0).DefaultView
        DgvActiveRow("B")
    End Sub

    Private Sub ProvFirstNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvFirstNToolStripMenuItem.Click
        MessageBox.Show(DGViewPatSrch.CurrentRow.Cells(8).Value, "Filter By Provider's First Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = "PROVIDER_FIRST_NAME= '" + DGViewPatSrch.CurrentRow.Cells(8).Value + "'"
        DGViewPatSrch.DataSource = _VBE_DatamartDataSet.Tables(0).DefaultView
        DgvActiveRow("B")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        CreateExcel(DGViewPatSrch, "PatList_", DGViewPatSrch.RowCount)
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

    Private Sub CmbPracNameTOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPracNameTOC.SelectedIndexChanged
        If TxtPracNameTOC.Text = "" Then
            MessageBox.Show("Practice Name field is blank", "BLANK FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case CmbPracNameTOC.Text
                Case "Starts With"
                    TxtPracNameTOC.Text = Replace(TxtPracNameTOC.Text, "%", "")
                    TxtPracNameTOC.Text = TxtPracNameTOC.Text + "%"
                Case "Ends With"
                    TxtPracNameTOC.Text = Replace(TxtPracNameTOC.Text, "%", "")
                    TxtPracNameTOC.Text = "%" + TxtPracNameTOC.Text
                Case "Contains"
                    TxtPracNameTOC.Text = Replace(TxtPracNameTOC.Text, "%", "")
                    TxtPracNameTOC.Text = "%" + TxtPracNameTOC.Text + "%"
                Case "Full Word"
                    TxtPracNameTOC.Text = Replace(TxtPracNameTOC.Text, "%", "")
            End Select
        End If
        PatSrchCnt()
    End Sub

    Private Sub BtnPracSrchTOC_Click(sender As Object, e As EventArgs) Handles BtnPracSrchTOC.Click
        CMBPracticeTOC.Items.Clear()
        CMBPracticeTOC.ResetText()
        TxtDOBTOC.Text = ""
        TxtLNameTOC.Text = ""
        TxtFNameTOC.Text = ""
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = ""
        If TxtPracNameTOC.Text = "" Then
            MessageBox.Show("Practice/Provider Name field is blank - please enter a valid practice or provider name", "BLANK FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.CM_PAT_TblAdapTOC.FillPractice(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtPracNameTOC.Text)
        End If
        DgvStyleRow()
        PatSrchCnt()
    End Sub

    Private Sub PatLastNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatLastNToolStripMenuItem.Click
        MessageBox.Show(DGViewPatSrch.CurrentRow.Cells(1).Value, "Filter By Patient's Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = "LAST_NAME= '" + DGViewPatSrch.CurrentRow.Cells(1).Value + "'"
        DGViewPatSrch.DataSource = _VBE_DatamartDataSet.Tables(0).DefaultView
        DgvActiveRow("B")
    End Sub

    Private Sub PatFirstNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatFirstNToolStripMenuItem.Click
        MessageBox.Show(DGViewPatSrch.CurrentRow.Cells(0).Value, "Filter By Patient's First Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = "FIRST_NAME= '" + DGViewPatSrch.CurrentRow.Cells(0).Value + "'"
        DGViewPatSrch.DataSource = _VBE_DatamartDataSet.Tables(0).DefaultView
        DgvActiveRow("B")
    End Sub

    Private Sub PatDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatDetailsToolStripMenuItem.Click
        Dim SqlCMCon As New SqlConnection
        Dim SqlCMCmd As New SqlCommand
        Dim SqlCMReader As SqlDataReader
        Dim SqlCMString As String
        TxtBoxPatFirst.Text = DGViewPatSrch.CurrentRow.Cells(0).Value
        TxtBoxPatLast.Text = DGViewPatSrch.CurrentRow.Cells(1).Value
        TxtBoxPatID.Text = DGViewPatSrch.CurrentRow.Cells(4).Value
        TxtBoxPatDOB.Text = DGViewPatSrch.CurrentRow.Cells(3).Value
        TxtBoxProvFirst.Text = DGViewPatSrch.CurrentRow.Cells(8).Value
        TxtBoxProvLast.Text = DGViewPatSrch.CurrentRow.Cells(9).Value
        TxtBoxPracName.Text = DGViewPatSrch.CurrentRow.Cells(10).Value
        TxtPatDemAdd1.Text = DGViewPatSrch.CurrentRow.Cells(11).Value
        TxtPatDemAdd2.Text = DGViewPatSrch.CurrentRow.Cells(12).Value
        TxtPatDemCity.Text = DGViewPatSrch.CurrentRow.Cells(13).Value
        TxtPatDemState.Text = DGViewPatSrch.CurrentRow.Cells(14).Value
        TxtPatDemZip.Text = DGViewPatSrch.CurrentRow.Cells(15).Value
        TxtPatDemPhoneH.Text = DGViewPatSrch.CurrentRow.Cells(16).Value
        If DGViewPatSrch.CurrentRow.Cells(20).Value = "N" Then
            ChkBoxInActive.BackColor = Color.LightYellow
            ChkBoxInActive.Checked = True
        Else
            ChkBoxInActive.BackColor = Color.White
            ChkBoxInActive.Checked = False
        End If

        vCell19.Text = DGViewPatSrch.CurrentRow.Cells(19).Value
        vCell23.Text = Convert.ToString(DGViewPatSrch.CurrentRow.Cells(23).Value)
        vCell22.Text = DGViewPatSrch.CurrentRow.Cells(22).Value

        Me.CM_UTIL_HIST_TblAdapTOC.FillUtilHist(Me._VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY, Convert.ToInt64(TxtBoxPatID.Text))
        Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(TxtBoxPatID.Text))
        If DGViewContHist.CurrentCell Is Nothing Then
            LblDoNot.Visible = False
        ElseIf DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
            LblDoNot.Visible = True
        Else
            LblDoNot.Visible = False
        End If

        TabControl1.SelectedIndex = 1

        DGViewUtilHist.ClearSelection()
        DGViewContHist.ClearSelection()
        ResetFlds("YES")
        ChkBoxCM.Enabled = True
        rs.ResizeAllControls(Me)
        'Get CM Enrollment
        Try
            SqlCMCon.Close()
            SqlCMCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlCMCon.Open()
            SqlCMCmd.Connection = SqlCMCon
            SqlCMString = "SELECT CM_ENROLLMENT FROM CM_PATIENT_INFO_DETAIL WHERE PATIENT_ID = "
            SqlCMCmd = New SqlCommand(SqlCMString + TxtBoxPatID.Text, SqlCMCon)
            SqlCMReader = SqlCMCmd.ExecuteReader()
            While SqlCMReader.Read()
                If SqlCMReader.Item(0) = "YES" Then
                    ChkBoxCM.Checked = True
                Else
                    ChkBoxCM.Checked = False
                End If
            End While
        Catch CMEnEx As Exception
            MsgBox("RETRIEVE CM ENROLLMENT ERROR - " + CMEnEx.Message)
        Finally
            SqlCMCon.Close()
        End Try
    End Sub

    Private Sub BtnProvFNSrchTOC_Click(sender As Object, e As EventArgs) Handles BtnProvFNSrchTOC.Click
        CMBPracticeTOC.Items.Clear()
        CMBPracticeTOC.ResetText()
        TxtDOBTOC.Text = ""
        TxtLNameTOC.Text = ""
        TxtFNameTOC.Text = ""
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = ""
        If TxtPracNameTOC.Text = "" Then
            MessageBox.Show("Practice/Provider Name field is blank - please enter a valid practice or provider name", "BLANK FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.CM_PAT_TblAdapTOC.FillProvFirst(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtPracNameTOC.Text)
        End If
        DgvStyleRow()
        PatSrchCnt()
    End Sub

    Private Sub BtnProvLNSrchTOC_Click(sender As Object, e As EventArgs) Handles BtnProvLNSrchTOC.Click
        CMBPracticeTOC.Items.Clear()
        CMBPracticeTOC.ResetText()
        TxtDOBTOC.Text = ""
        TxtLNameTOC.Text = ""
        TxtFNameTOC.Text = ""
        _VBE_DatamartDataSet.CM_PATIENT_INFO.DefaultView.RowFilter = ""
        If TxtPracNameTOC.Text = "" Then
            MessageBox.Show("Practice/Provider Name field is blank - please enter a valid practice or provider name", "BLANK FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.CM_PAT_TblAdapTOC.FillProvLast(Me._VBE_DatamartDataSet.CM_PATIENT_INFO, TxtPracNameTOC.Text)
        End If
        DgvStyleRow()
        PatSrchCnt()
    End Sub

    Private Sub DatePickRet_ValueChanged(sender As Object, e As EventArgs) Handles DTPickRet.ValueChanged
        MaskedRetDate.Text = DTPickRet.Value.ToString("MM/dd/yyyy")
    End Sub
    Sub LoadCmbBox()
        Dim SqlCon As New SqlConnection
        Dim SqlCmd As New SqlCommand
        Dim SqlReader As SqlDataReader

        Try
            SqlCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlCon.Open()
            SqlCmd.Connection = SqlCon
            SqlCmd = New SqlCommand("SELECT LIST_ITEM FROM MAP_SCREEN_LISTS WHERE LIST_NAME = 'Contact Made'", SqlCon)
            SqlReader = SqlCmd.ExecuteReader()
            While SqlReader.Read()
                CmbContMade.Items.Add(SqlReader.Item(0))
            End While
            CmbContMade.Items.Add("")

            SqlCon.Close()
            SqlCon.Open()
            SqlCmd.Connection = SqlCon
            SqlCmd = New SqlCommand("SELECT LIST_ITEM FROM MAP_SCREEN_LISTS WHERE LIST_NAME = 'Reason for Outreach Primary'", SqlCon)
            SqlReader = SqlCmd.ExecuteReader()
            While SqlReader.Read()
                CmbReasonOR.Items.Add(SqlReader.Item(0))
            End While
            CmbReasonOR.Items.Add("")

            SqlCon.Close()
            SqlCon.Open()
            SqlCmd.Connection = SqlCon
            SqlCmd = New SqlCommand("SELECT LIST_ITEM FROM MAP_SCREEN_LISTS WHERE LIST_NAME = 'No Contact Made'", SqlCon)
            SqlReader = SqlCmd.ExecuteReader()
            While SqlReader.Read()
                CmbNoContMade.Items.Add(SqlReader.Item(0))
            End While
            CmbNoContMade.Items.Add("")

            SqlCon.Close()
            SqlCon.Open()
            SqlCmd.Connection = SqlCon
            SqlCmd = New SqlCommand("SELECT LIST_ITEM FROM MAP_SCREEN_LISTS WHERE LIST_NAME = 'Case Management Patient Referral Source'", SqlCon)
            SqlReader = SqlCmd.ExecuteReader()
            While SqlReader.Read()
                CmbPatRefSrc.Items.Add(SqlReader.Item(0))
            End While
            CmbPatRefSrc.Items.Add("")

            SqlCon.Close()
            SqlCon.Open()
            SqlCmd.Connection = SqlCon
            SqlCmd = New SqlCommand("SELECT LIST_ITEM FROM MAP_SCREEN_LISTS WHERE LIST_NAME = 'Contact Status'", SqlCon)
            SqlReader = SqlCmd.ExecuteReader()
            While SqlReader.Read()
                CmbContStatus.Items.Add(SqlReader.Item(0))
            End While
            CmbContStatus.Items.Add("")

        Catch ExCmb As Exception
            MessageBox.Show("Combo-Box Load Failed " & ExCmb.Message)
        Finally
            SqlCon.Close()
        End Try
    End Sub

    Private Sub DTPickAppt_ValueChanged(sender As Object, e As EventArgs) Handles DTPickAppt.ValueChanged
        MaskedApptDate.Text = DTPickAppt.Value.ToString("MM/dd/yyyy")
    End Sub

    Sub EnableFlds(vEna As String)
        Select Case vEna
            Case "YES"
                CmbReasonOR.Enabled = True
                CmbContMade.Enabled = True
                CmbNoContMade.Enabled = True
                MaskedRetDate.Enabled = True
                DTPickRet.Enabled = True
                MaskedApptDate.Enabled = True
                DTPickAppt.Enabled = True
                ChkBoxDoNotCall.Enabled = True
                CmbPatRefSrc.Enabled = True
                'TxtPatAdd1.Enabled = True
                'TxtPatAdd2.Enabled = True
                'TxtPatCity.Enabled = True
                'TxtPatState.Enabled = True
                'TxtPatZip.Enabled = True
                'MaskedPatHPhone.Enabled = True
                'TxtPatEmail.Enabled = True
                'RichTextORNotes.Enabled = True
                RichTextORNotes.ReadOnly = False
                CmbContStatus.Enabled = True
                'MaskedPatMobile.Enabled = True
                'TxtPatWPhone.Enabled = True
                ChkBoxUpdAddress.Enabled = True
            Case "NO"
                CmbReasonOR.Enabled = False
                CmbContMade.Enabled = False
                CmbNoContMade.Enabled = False
                MaskedRetDate.Enabled = False
                DTPickRet.Enabled = False
                MaskedApptDate.Enabled = False
                DTPickAppt.Enabled = False
                ChkBoxDoNotCall.Enabled = False
                CmbPatRefSrc.Enabled = False
                TxtPatAdd1.Enabled = False
                TxtPatAdd2.Enabled = False
                TxtPatCity.Enabled = False
                TxtPatState.Enabled = False
                TxtPatZip.Enabled = False
                MaskedPatHPhone.Enabled = False
                TxtPatEmail.Enabled = False
                'RichTextORNotes.Enabled = False
                RichTextORNotes.ReadOnly = True
                CmbContStatus.Enabled = False
                MaskedPatMobile.Enabled = False
                TxtPatWPhone.Enabled = False
                ChkBoxUpdAddress.Enabled = False
            Case "ADDRESS"
                TxtPatAdd1.Enabled = True
                TxtPatAdd2.Enabled = True
                TxtPatCity.Enabled = True
                TxtPatState.Enabled = True
                TxtPatZip.Enabled = True
                MaskedPatHPhone.Enabled = True
                TxtPatEmail.Enabled = True
                MaskedPatMobile.Enabled = True
                TxtPatWPhone.Enabled = True
            Case "NOADDRESS"
                TxtPatAdd1.Text = ""
                TxtPatAdd2.Text = ""
                TxtPatCity.Text = ""
                TxtPatState.Text = ""
                TxtPatZip.Text = ""
                MaskedPatHPhone.Text = ""
                TxtPatEmail.Text = ""
                MaskedPatMobile.Text = ""
                TxtPatWPhone.Text = ""
                TxtPatAdd1.Enabled = False
                TxtPatAdd2.Enabled = False
                TxtPatCity.Enabled = False
                TxtPatState.Enabled = False
                TxtPatZip.Enabled = False
                MaskedPatHPhone.Enabled = False
                TxtPatEmail.Enabled = False
                MaskedPatMobile.Enabled = False
                TxtPatWPhone.Enabled = False
        End Select
    End Sub

    Sub ResetFlds(vSet As String)
        Select Case vSet
            Case "YES"
                CmbReasonOR.Text = ""
                CmbContMade.Text = ""
                CmbNoContMade.Text = ""
                MaskedRetDate.Text = ""
                'DTPickRet.Text = ""
                MaskedApptDate.Text = ""
                'DTPickAppt.Text = ""
                ChkBoxDoNotCall.Text = ""
                CmbPatRefSrc.Text = ""
                TxtPatAdd1.Text = ""
                TxtPatAdd2.Text = ""
                TxtPatCity.Text = ""
                TxtPatState.Text = ""
                TxtPatZip.Text = ""
                MaskedPatHPhone.Text = ""
                TxtPatEmail.Text = ""
                RichTextORNotes.Text = ""
                CmbContStatus.Text = ""
                MaskedPatMobile.Text = ""
                TxtPatWPhone.Text = ""
                ChkBoxUpdAddress.Checked = False
                ChkBoxDoNotCall.Checked = False
        End Select
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 1 Then
            'If DGViewContHist.RowCount = 0 Then
            BtnDelCont.Enabled = False
            BtnEditCont.Enabled = False
            'Else
            'BtnDelCont.Enabled = True
            'BtnEditCont.Enabled = True
            'End If
            If TxtBoxPatID.Text = "" Then
                BtnNewCont.Enabled = False
            Else
                BtnNewCont.Enabled = True
            End If
        End If

        If TabControl1.SelectedIndex = 2 Then
            If Trim(MaskedDtContFr.Text) = "/  /" Then
                Select Case Today.DayOfWeek
                    Case 1
                        MaskedDtContFr.Text = Today.AddDays(-3).ToString("MM/dd/yyyy")
                    Case 7
                        MaskedDtContFr.Text = Today.AddDays(-2).ToString("MM/dd/yyyy")
                    Case Else
                        MaskedDtContFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                End Select
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            End If
        End If

        If TabControl1.SelectedIndex = 3 Then
            If Trim(MaskedDtUtilFr.Text) = "/  /" Then
                Select Case Today.DayOfWeek
                    Case 1
                        MaskedDtUtilFr.Text = Today.AddDays(-3).ToString("MM/dd/yyyy")
                    Case 7
                        MaskedDtUtilFr.Text = Today.AddDays(-2).ToString("MM/dd/yyyy")
                    Case Else
                        MaskedDtUtilFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                End Select
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            End If
        End If
    End Sub

    Private Sub BtnNewCont_Click(sender As Object, e As EventArgs) Handles BtnNewCont.Click
        BtnDelCont.Enabled = False
        BtnNewCont.Enabled = False
        BtnEditCont.Enabled = False
        BtnUndoCont.Enabled = True
        BtnSaveCont.Enabled = True
        vUpdStatus = "NEW"
        EnableFlds("YES")
        ResetFlds("YES")
        CmbPatRefSrc.Text = "Payer"
        CmbContStatus.Text = "Open"
    End Sub

    Private Sub BtnDelCont_Click(sender As Object, e As EventArgs) Handles BtnDelCont.Click
        Dim DelRes As MsgBoxResult
        If CmbReasonOR.Text = "" Then
            MessageBox.Show("Please select a contact record to delete", "SELECT CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DelRes = MsgBox("Are you sure you want to delete the selected contact record - Please Confirm?", MsgBoxStyle.YesNo, "DELETE CONTACT")
            If (DelRes = MsgBoxResult.Yes) Then
                'BtnNewCont.Enabled = False
                'BtnDelCont.Enabled = False
                'BtnUndoCont.Enabled = True
                'BtnSaveCont.Enabled = True
                SaveContRec("DELETE")
                'EnableFlds("YES")
            End If
        End If
    End Sub

    Private Sub BtnSaveCont_Click(sender As Object, e As EventArgs) Handles BtnSaveCont.Click
        Dim ContFlag As Boolean = True

        If TxtBoxPatID.Text = "" Then
            MessageBox.Show("Patient ID field is blank, please select a patient from the 'PATIENT DEMOGRAPHIC' tab", "BLANK PATIENT ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If vUpdStatus = "NEW" Then
                If CmbReasonOR.Text = "" Then
                    MessageBox.Show("Please select a valid 'Reason for Outreach'", "BLANK REASON FOR OUTREACH", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                ElseIf CmbContMade.Text = "" And CmbNoContMade.Text = "" Then
                    MessageBox.Show("Both 'Contact Made' and 'No Contact Made' cannot be blank", "BLANK CONTACT MADE FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                ElseIf CmbPatRefSrc.Text = "" Then
                    MessageBox.Show("Please select a valid 'CM Patient Referral Source", "BLANK CM PATIENT REFERRAL SOURCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                ElseIf CmbContStatus.Text = "" Then
                    MessageBox.Show("Please select a valid 'Contact Status'", "BLANK CONTACT STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                End If

                If TxtPatEmail.Text <> "" And CheckString(TxtPatEmail.Text, "@") = -1 Then
                    MessageBox.Show("Enter an email In the correct format, Like name@example.com'", "INVALID EMAIL FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                End If

                If RichTextORNotes.Text <> "" And CheckString(RichTextORNotes.Text, "'") <> -1 Then
                    MessageBox.Show("Entry for 'Notes' cannot contain single quotation mark'", "INVALID NOTES ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ContFlag = False
                End If

                If ContFlag Then
                    SaveContRec("CREATE")
                End If
            End If

            If ContFlag Then
                BtnNewCont.Enabled = True
                BtnDelCont.Enabled = False
                BtnUndoCont.Enabled = False
                BtnSaveCont.Enabled = False
                BtnEditCont.Enabled = False
                vUpdStatus = ""
                ResetFlds("YES")
                EnableFlds("NO")
            End If
        End If
    End Sub

    Private Sub BtnUndoCont_Click(sender As Object, e As EventArgs) Handles BtnUndoCont.Click
        BtnDelCont.Enabled = False
        BtnNewCont.Enabled = True
        BtnUndoCont.Enabled = False
        BtnSaveCont.Enabled = False
        BtnEditCont.Enabled = False
        vUpdStatus = ""
        ResetFlds("YES")
        EnableFlds("NO")
    End Sub

    Sub SaveContRec(vSave As String)
        Dim UpdSqlCon As New SqlConnection
        Dim UpdSqlCom As New SqlCommand
        Dim ValStr As String
        Dim SqlQry As String
        Dim DoNotCall As String
        Dim RetDateStr As String
        Dim ApptDateStr As String

        If MaskedRetDate.Text.Length <> 10 Or MaskedRetDate.Text = "00/00/0000" Then
            RetDateStr = "NULL"
        Else
            RetDateStr = "'" + MaskedRetDate.Text + "'"
        End If

        If MaskedApptDate.Text.Length <> 10 Or MaskedApptDate.Text = "00/00/0000" Then
            ApptDateStr = "NULL"
        Else
            ApptDateStr = "'" + MaskedApptDate.Text + "'"
        End If

        If ChkBoxDoNotCall.Checked Then
            DoNotCall = "Y"
        Else
            DoNotCall = "N"
        End If

        Select Case vSave
            Case "CREATE"
                Try
                    ValStr = "'" + TxtBoxPatID.Text + "','" + Date.Today + "','" + DateTime.Now + "','" + FormMain.UserADID + "','" + FormMain.UserADName
                    ValStr = ValStr + "','" + CmbReasonOR.Text + "','" + CmbContMade.Text + "','" + CmbNoContMade.Text + "'," + RetDateStr + "," + ApptDateStr
                    ValStr = ValStr + ",'" + DoNotCall + "','" + CmbPatRefSrc.Text + "','" + TxtPatAdd1.Text + "','" + TxtPatAdd2.Text + "','" + TxtPatCity.Text
                    ValStr = ValStr + "','" + TxtPatState.Text + "','" + TxtPatZip.Text + "','" + MaskedPatHPhone.Text + "','" + TxtPatWPhone.Text + "','" + MaskedPatMobile.Text
                    ValStr = ValStr + "','" + TxtPatEmail.Text + "','" + vCell19.Text + "','" + RichTextORNotes.Text + "','" + CmbContStatus.Text
                    ValStr = ValStr + "','" + vCell23.Text + "','" + vCell22.Text + "'"
                    SqlQry = "INSERT INTO CM_PATIENT_CONTACT_DOC VALUES (" + ValStr + ")"
                    'MessageBox.Show(ValStr, "BLANK FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show(SqlQry, "BLANK FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdSqlCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
                    UpdSqlCon.Open()
                    UpdSqlCom.Connection = UpdSqlCon
                    UpdSqlCom = New SqlCommand(SqlQry, UpdSqlCon)
                    UpdSqlCom.ExecuteNonQuery()
                    Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(TxtBoxPatID.Text))
                    If DGViewContHist.CurrentCell Is Nothing Then
                        LblDoNot.Visible = False
                    ElseIf DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
                        LblDoNot.Visible = True
                    Else
                        LblDoNot.Visible = False
                    End If
                    MessageBox.Show("Contact created successfully", "NEW CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch UpdEx As Exception
                    MsgBox("CREATE CONTACTS ERROR - " + UpdEx.Message)
                Finally
                    UpdSqlCon.Close()
                End Try

            Case "DELETE"
                Try
                    ValStr = " PATIENT_ID = '" + TxtBoxPatID.Text + "' AND OUTREACH_DATE = '" + DGViewContHist.CurrentRow.Cells(0).Value
                    ValStr = ValStr + "' AND OUTREACH_ENTRY_DATETIME = '" + DGViewContHist.CurrentRow.Cells(1).Value
                    'Insert Audit
                    SqlQry = "INSERT INTO CM_PATIENT_CONTACT_DOC_AUDIT SELECT *, GETDATE(), '"
                    SqlQry = SqlQry + FormMain.UserADID + "', '" + FormMain.UserADName + "', 'DELETE' FROM CM_PATIENT_CONTACT_DOC WHERE " + ValStr + "'"
                    'MessageBox.Show(SqlQry, "BLANK FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdSqlCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
                    UpdSqlCon.Open()
                    UpdSqlCom.Connection = UpdSqlCon
                    UpdSqlCom = New SqlCommand(SqlQry, UpdSqlCon)
                    UpdSqlCom.ExecuteNonQuery()
                    UpdSqlCon.Close()

                    'Delete Contact
                    SqlQry = "DELETE FROM CM_PATIENT_CONTACT_DOC WHERE " + ValStr + "'"
                    'MessageBox.Show(SqlQry, "BLANK FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdSqlCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
                    UpdSqlCon.Open()
                    UpdSqlCom.Connection = UpdSqlCon
                    UpdSqlCom = New SqlCommand(SqlQry, UpdSqlCon)
                    UpdSqlCom.ExecuteNonQuery()
                    Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(TxtBoxPatID.Text))
                    If DGViewContHist.CurrentCell Is Nothing Then
                        LblDoNot.Visible = False
                    ElseIf DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
                        LblDoNot.Visible = True
                    Else
                        LblDoNot.Visible = False
                    End If
                    MessageBox.Show("Contact deleted successfully", "NEW CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch DelEx As Exception
                    MsgBox("DELETE CONTACTS ERROR - " + DelEx.Message)
                Finally
                    UpdSqlCon.Close()
                End Try

        End Select
    End Sub

    Private Sub DGViewContHist_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGViewContHist.CellMouseClick
        Dim DispRetStr As String
        Dim DispApptStr As String

        BtnDelCont.Enabled = True
        BtnEditCont.Enabled = True

        If DGViewContHist.CurrentRow.Cells(9).Value Is DBNull.Value Then
            DispRetStr = "00/00/0000"
        Else
            DispRetStr = DGViewContHist.CurrentRow.Cells(9).Value
            If DispRetStr.Substring(1, 1) = "/" Then
                DispRetStr = "0" + DispRetStr
            End If
            If DispRetStr.Substring(4, 1) = "/" Then
                DispRetStr = DispRetStr.Substring(0, 3) + "0" + DispRetStr.Substring(3)
            End If
        End If

        If DGViewContHist.CurrentRow.Cells(10).Value Is DBNull.Value Then
            DispApptStr = "00/00/0000"
        Else
            DispApptStr = DGViewContHist.CurrentRow.Cells(10).Value
            If DispApptStr.Substring(1, 1) = "/" Then
                DispApptStr = "0" + DispApptStr
            End If
            If DispApptStr.Substring(4, 1) = "/" Then
                DispApptStr = DispApptStr.Substring(0, 3) + "0" + DispApptStr.Substring(3)
            End If
        End If

        CmbReasonOR.Text = DGViewContHist.CurrentRow.Cells(6).Value
        CmbContMade.Text = DGViewContHist.CurrentRow.Cells(7).Value
        CmbNoContMade.Text = DGViewContHist.CurrentRow.Cells(8).Value
        MaskedRetDate.Text = DispRetStr
        MaskedApptDate.Text = DispApptStr

        If DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
            ChkBoxDoNotCall.Checked = True
        Else
            ChkBoxDoNotCall.Checked = False
        End If

        CmbPatRefSrc.Text = DGViewContHist.CurrentRow.Cells(12).Value

        TxtPatAdd1.Text = DGViewContHist.CurrentRow.Cells(13).Value
        TxtPatAdd2.Text = DGViewContHist.CurrentRow.Cells(14).Value
        TxtPatCity.Text = DGViewContHist.CurrentRow.Cells(15).Value
        TxtPatState.Text = DGViewContHist.CurrentRow.Cells(16).Value
        TxtPatZip.Text = DGViewContHist.CurrentRow.Cells(17).Value
        MaskedPatHPhone.Text = DGViewContHist.CurrentRow.Cells(4).Value
        TxtPatWPhone.Text = DGViewContHist.CurrentRow.Cells(18).Value
        MaskedPatMobile.Text = DGViewContHist.CurrentRow.Cells(5).Value
        TxtPatEmail.Text = DGViewContHist.CurrentRow.Cells(19).Value
        RichTextORNotes.Text = DGViewContHist.CurrentRow.Cells(21).Value

        CmbContStatus.Text = DGViewContHist.CurrentRow.Cells(22).Value

    End Sub

    Private Sub CmbContMade_MouseClick(sender As Object, e As MouseEventArgs) Handles CmbContMade.MouseClick
        CmbNoContMade.Text = ""
    End Sub

    Private Sub CmbNoContMade_MouseClick(sender As Object, e As MouseEventArgs) Handles CmbNoContMade.MouseClick
        CmbContMade.Text = ""
    End Sub

    Function CheckString(ByVal InputStr As String, ByVal InputChar As String) As Integer
        Return InputStr.IndexOf(InputChar)
    End Function

    Private Sub DTPickUtilFr_ValueChanged(sender As Object, e As EventArgs) Handles DTPickUtilFr.ValueChanged
        MaskedDtUtilFr.Text = DTPickUtilFr.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTPickUtilTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPickUtilTo.ValueChanged
        MaskedDtUtilTo.Text = DTPickUtilTo.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub CmbBoxDishDT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxDishDT.SelectedIndexChanged
        Select Case CmbBoxDishDT.Text
            Case "Today"
                MaskedDtUtilFr.Text = Today.ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Day"
                MaskedDtUtilFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Days"
                MaskedDtUtilFr.Text = Today.AddDays(-2).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Three Days"
                MaskedDtUtilFr.Text = Today.AddDays(-3).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Four Days"
                MaskedDtUtilFr.Text = Today.AddDays(-4).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Five Days"
                MaskedDtUtilFr.Text = Today.AddDays(-5).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Week"
                MaskedDtUtilFr.Text = Today.AddDays(-7).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Weeks"
                MaskedDtUtilFr.Text = Today.AddDays(-14).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Month"
                MaskedDtUtilFr.Text = Today.AddDays(-30).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Months"
                MaskedDtUtilFr.Text = Today.AddDays(-60).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Six Months"
                MaskedDtUtilFr.Text = Today.AddDays(-180).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Year"
                MaskedDtUtilFr.Text = Today.AddDays(-365).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
            Case Else
                MaskedDtUtilFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                MaskedDtUtilTo.Text = Today.ToString("MM/dd/yyyy")
        End Select
    End Sub

    Private Sub BtnSrchUtil_Click(sender As Object, e As EventArgs) Handles BtnSrchUtil.Click
        If MaskedDtUtilFr.Text <> "" And MaskedDtUtilTo.Text <> "" Then
            Me.CM_UTIL_SRCH_TblAdap.FillDates(Me._VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY, Convert.ToDateTime(MaskedDtUtilFr.Text), Convert.ToDateTime(MaskedDtUtilTo.Text))
            BtnPatDet.Enabled = True
        Else
            BtnPatDet.Enabled = False
            MessageBox.Show("From/To date cannot be blank", "BLANK DATE FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchFName_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchFName.TextChanged
        If TxtSrchFName.Text.Length = 1 Then
            ClearFilter(1)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "FIRST_NAME LIKE '" + TxtSrchFName.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub BtnClrFil_Click(sender As Object, e As EventArgs) Handles BtnClrFil.Click
        ClearFilter(99)
    End Sub

    Sub ClearFilter(FldNum As String)
        If TxtSrchFName.Text <> "" And FldNum <> 1 Then
            TxtSrchFName.Text = ""
        End If
        If TxtSrchLName.Text <> "" And FldNum <> 2 Then
            TxtSrchLName.Text = ""
        End If
        If TxtSrchSvc.Text <> "" And FldNum <> 3 Then
            TxtSrchSvc.Text = ""
        End If
        If TxtSrchFac.Text <> "" And FldNum <> 4 Then
            TxtSrchFac.Text = ""
        End If
        If TxtSrchPCont.Text <> "" And FldNum <> 5 Then
            TxtSrchPCont.Text = ""
        End If
        If TxtSrchPayer.Text <> "" And FldNum <> 6 Then
            TxtSrchPayer.Text = ""
        End If
        If TxtSrchDSrc.Text <> "" And FldNum <> 7 Then
            TxtSrchDSrc.Text = ""
        End If
        If TxtSrchPrac.Text <> "" And FldNum <> 8 Then
            TxtSrchPrac.Text = ""
        End If
        'Me.CM_UTIL_SRCH_TblAdap.FillDates(Me._VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY, Convert.ToDateTime(MaskedDtUtilFr.Text), Convert.ToDateTime(MaskedDtUtilTo.Text))
    End Sub

    Private Sub TxtSrchLName_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchLName.TextChanged
        If TxtSrchLName.Text.Length = 1 Then
            ClearFilter(2)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "LAST_NAME LIKE '" + TxtSrchLName.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchSvc_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchSvc.TextChanged
        If TxtSrchSvc.Text.Length = 1 Then
            ClearFilter(3)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "SERVICE_TYPE LIKE '" + TxtSrchSvc.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchFac_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchFac.TextChanged
        If TxtSrchFac.Text.Length = 1 Then
            ClearFilter(4)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "FACILITY LIKE '" + TxtSrchFac.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchPCont_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchPCont.TextChanged
        If TxtSrchPCont.Text.Length = 1 Then
            ClearFilter(5)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "PAYER_CONTRACT LIKE '" + TxtSrchPCont.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchPayer_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchPayer.TextChanged
        If TxtSrchPayer.Text.Length = 1 Then
            ClearFilter(6)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "PAYER LIKE '" + TxtSrchPayer.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub TxtSrchDSrc_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchDSrc.TextChanged
        If TxtSrchDSrc.Text.Length = 1 Then
            ClearFilter(7)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "[DATA SOURCE] LIKE '" + TxtSrchDSrc.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
        UtilSrchCnt()
    End Sub

    Private Sub BtnPatDet_Click(sender As Object, e As EventArgs) Handles BtnPatDet.Click
        Dim SqlUCon As New SqlConnection
        Dim SqlUCmd As New SqlCommand
        Dim SqlUReader As SqlDataReader
        Dim SqlUString As String

        SqlUString = "SELECT DOB, PROVIDER_FIRST_NAME, PROVIDER_LAST_NAME, prac.PRACTICE_NAME, ACTIVE_PATIENT_FLAG, LAST_REVISE_DATE, MAX_ATTRIBUTION_MONTH,"
        SqlUString = SqlUString + " pat.ADDR_LINE_1, pat.ADDR_LINE_2, pat.CITY, pat.STATE, pat.ZIP_CODE, pat.HOME_PHONE, pat.WORK_PHONE, pat.MOBILE_PHONE"
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
            SqlUCmd = New SqlCommand(SqlUString + DGViewUtilSrch.CurrentRow.Cells(15).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                TxtBoxPatFirst.Text = DGViewUtilSrch.CurrentRow.Cells(1).Value
                TxtBoxPatLast.Text = DGViewUtilSrch.CurrentRow.Cells(2).Value
                TxtBoxPatID.Text = DGViewUtilSrch.CurrentRow.Cells(15).Value
                TxtBoxPatDOB.Text = SqlUReader.Item(0)
                TxtBoxProvFirst.Text = SqlUReader.Item(1)
                TxtBoxProvLast.Text = SqlUReader.Item(2)
                TxtBoxPracName.Text = SqlUReader.Item(3)
                vCell19.Text = SqlUReader.Item(4)
                vCell23.Text = Convert.ToString(SqlUReader.Item(6))
                vCell22.Text = SqlUReader.Item(5)
                If SqlUReader.Item(4) = "N" Then
                    ChkBoxInActive.BackColor = Color.Yellow
                    ChkBoxInActive.Checked = True
                Else
                    ChkBoxInActive.BackColor = Color.White
                    ChkBoxInActive.Checked = False
                End If
                TxtPatDemAdd1.Text = SqlUReader.Item(7)
                TxtPatDemAdd2.Text = SqlUReader.Item(8)
                TxtPatDemCity.Text = SqlUReader.Item(9)
                TxtPatDemState.Text = SqlUReader.Item(10)
                TxtPatDemZip.Text = SqlUReader.Item(11)
                TxtPatDemPhoneH.Text = SqlUReader.Item(12)
                TxtPatDemPhoneW.Text = SqlUReader.Item(13)
                TxtPatDemPhoneC.Text = SqlUReader.Item(14)

                Me.CM_UTIL_HIST_TblAdapTOC.FillUtilHist(Me._VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY, Convert.ToInt64(TxtBoxPatID.Text))
                Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(TxtBoxPatID.Text))
                If DGViewContHist.CurrentCell Is Nothing Then
                    LblDoNot.Visible = False
                ElseIf DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
                    LblDoNot.Visible = True
                Else
                    LblDoNot.Visible = False
                End If
                TabControl1.SelectedIndex = 1

                DGViewUtilHist.ClearSelection()
                DGViewContHist.ClearSelection()
                ResetFlds("YES")
                ChkBoxCM.Enabled = True
                rs.ResizeAllControls(Me)
            End While
            'Get CM Enrollment
            SqlUCon.Close()
            SqlUCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlUCon.Open()
            SqlUCmd.Connection = SqlUCon
            SqlUString = "SELECT CM_ENROLLMENT FROM CM_PATIENT_INFO_DETAIL WHERE PATIENT_ID = "
            SqlUCmd = New SqlCommand(SqlUString + DGViewUtilSrch.CurrentRow.Cells(15).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                If SqlUReader.Item(0) = "YES" Then
                    ChkBoxCM.Checked = True
                Else
                    ChkBoxCM.Checked = False
                End If
            End While
        Catch ExUCmb As Exception
            MessageBox.Show("Get patient details failed during Utilization History: " & ExUCmb.Message)
        Finally
            SqlUCon.Close()
            ChkBoxCM.Enabled = True
        End Try
    End Sub

    Private Sub FormTOC_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub DGViewPatSrch_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGViewPatSrch.ColumnHeaderMouseClick
        DgvStyleRow()
    End Sub

    Private Sub ChkBoxUpdAddress_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxUpdAddress.CheckedChanged
        If ChkBoxUpdAddress.Checked Then
            EnableFlds("ADDRESS")
        Else
            EnableFlds("NOADDRESS")
        End If
    End Sub

    Private Sub ChkBoxCM_Click(sender As Object, e As EventArgs) Handles ChkBoxCM.Click
        '        Private Sub ChkBoxCM_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxCM.CheckedChanged
        Dim CMRes As MsgBoxResult
        Dim CMCon As New SqlConnection
        Dim CMCom As New SqlCommand
        Dim CMStr As String
        Dim CMQry As String

        If ChkBoxCM.Checked Then
            CMRes = MsgBox("Do you want to enroll this patient in the CM program?", MsgBoxStyle.YesNo, "CM Enrollment")
            If (CMRes = MsgBoxResult.Yes) Then
                Try
                    CMStr = " SET CM_ENROLLMENT = 'YES', ASSIGNED_CONTACT_PERSON = '" + FormMain.UserADID + "', "
                    CMStr = CMStr + "ASSIGNED_CONTACT_PERSON_NAME = '" + FormMain.UserADName + "', "
                    CMStr = CMStr + "LAST_REVISE_DATE = '" + Date.Today + "' WHERE PATIENT_ID = '" + TxtBoxPatID.Text + "'"
                    CMQry = "UPDATE CM_PATIENT_INFO_DETAIL " + CMStr
                    CMCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
                    CMCon.Open()
                    CMCom.Connection = CMCon
                    CMCom = New SqlCommand(CMQry, CMCon)
                    CMCom.ExecuteNonQuery()
                    MessageBox.Show("Enrolled in CM program", "CM Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch CMEx As Exception
                    MsgBox("ADD CM ENROLLMENT ERROR - " + CMEx.Message)
                Finally
                    CMCon.Close()
                End Try
            Else
                ChkBoxCM.Checked = False
            End If
        Else
            CMRes = MsgBox("Do you want to remove this patient from the CM program?", MsgBoxStyle.YesNo, "Remove CM Enrollment")
            If (CMRes = MsgBoxResult.Yes) Then
                Try
                    CMStr = " SET CM_ENROLLMENT = 'NO', ASSIGNED_CONTACT_PERSON = '" + FormMain.UserADID + "', "
                    CMStr = CMStr + "ASSIGNED_CONTACT_PERSON_NAME = '" + FormMain.UserADName + "', "
                    CMStr = CMStr + "LAST_REVISE_DATE = '" + Date.Today + "' WHERE PATIENT_ID = '" + TxtBoxPatID.Text + "'"
                    CMQry = "UPDATE CM_PATIENT_INFO_DETAIL " + CMStr
                    CMCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
                    CMCon.Open()
                    CMCom.Connection = CMCon
                    CMCom = New SqlCommand(CMQry, CMCon)
                    CMCom.ExecuteNonQuery()
                    MessageBox.Show("Removed CM Enrollment", "Remove CM Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch CMEx As Exception
                    MsgBox("REMOVE CM ENROLLMENT ERROR - " + CMEx.Message)
                Finally
                    CMCon.Close()
                End Try
            Else
                ChkBoxCM.Checked = True
            End If
        End If
    End Sub

    Private Sub DTPickContFr_ValueChanged(sender As Object, e As EventArgs) Handles DTPickContFr.ValueChanged
        MaskedDtContFr.Text = DTPickContFr.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTPickContTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPickContTo.ValueChanged
        MaskedDtContTo.Text = DTPickContTo.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub CmbBoxContDT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxContDT.SelectedIndexChanged
        Select Case CmbBoxContDT.Text
            Case "One Day"
                MaskedDtContFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Days"
                MaskedDtContFr.Text = Today.AddDays(-2).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Three Days"
                MaskedDtContFr.Text = Today.AddDays(-3).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Four Days"
                MaskedDtContFr.Text = Today.AddDays(-4).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Five Days"
                MaskedDtContFr.Text = Today.AddDays(-5).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Week"
                MaskedDtContFr.Text = Today.AddDays(-7).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Weeks"
                MaskedDtContFr.Text = Today.AddDays(-14).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Month"
                MaskedDtContFr.Text = Today.AddDays(-30).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Two Months"
                MaskedDtContFr.Text = Today.AddDays(-60).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "Six Months"
                MaskedDtContFr.Text = Today.AddDays(-180).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case "One Year"
                MaskedDtContFr.Text = Today.AddDays(-365).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
            Case Else
                MaskedDtContFr.Text = Today.AddDays(-1).ToString("MM/dd/yyyy")
                MaskedDtContTo.Text = Today.ToString("MM/dd/yyyy")
        End Select
    End Sub

    Private Sub BtnPatCMTOC_Click(sender As Object, e As EventArgs) Handles BtnPatCMTOC.Click
        FormCM.ShowDialog()
    End Sub

    Private Sub TxtSrchPrac_TextChanged(sender As Object, e As EventArgs) Handles TxtSrchPrac.TextChanged
        If TxtSrchPrac.Text.Length = 1 Then
            ClearFilter(8)
        End If
        _VBE_DatamartDataSet3.CM_UTILIZATION_HISTORY.DefaultView.RowFilter = "PRACTICE_NAME LIKE '" + TxtSrchPrac.Text + "%'"
        DGViewUtilSrch.DataSource = _VBE_DatamartDataSet3.Tables(0).DefaultView
    End Sub

    Private Sub BtnSrchCont_Click(sender As Object, e As EventArgs) Handles BtnSrchCont.Click
        If MaskedDtContFr.Text <> "" And MaskedDtContTo.Text <> "" Then
            Me.CM_CONT_SRCH_TblAdap.FillContHist(Me._VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC, Convert.ToDateTime(MaskedDtContFr.Text), Convert.ToDateTime(MaskedDtContTo.Text))
            BtnContPatDet.Enabled = True
        Else
            BtnContPatDet.Enabled = False
            MessageBox.Show("From/To date cannot be blank", "BLANK DATE FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ContSrchCnt()
    End Sub

    Private Sub ContSrchCnt()
        If DGViewContSrch.RowCount > 0 Then
            TxtContCnt.Text = Convert.ToString(DGViewContSrch.RowCount)
        Else
            TxtContCnt.Text = ""
        End If
    End Sub
    Private Sub UtilSrchCnt()
        If DGViewUtilSrch.RowCount > 0 Then
            TxtUtilCnt.Text = Convert.ToString(DGViewUtilSrch.RowCount)
        Else
            TxtUtilCnt.Text = ""
        End If
    End Sub

    Private Sub PatSrchCnt()
        If DGViewPatSrch.RowCount > 0 Then
            TxtPatCnt.Text = Convert.ToString(DGViewPatSrch.RowCount)
        Else
            TxtPatCnt.Text = ""
        End If
    End Sub
    Private Sub BtnContPatDet_Click(sender As Object, e As EventArgs) Handles BtnContPatDet.Click
        Dim SqlUCon As New SqlConnection
        Dim SqlUCmd As New SqlCommand
        Dim SqlUReader As SqlDataReader
        Dim SqlUString As String

        SqlUString = "SELECT DOB, PROVIDER_FIRST_NAME, PROVIDER_LAST_NAME, prac.PRACTICE_NAME, ACTIVE_PATIENT_FLAG, LAST_REVISE_DATE, MAX_ATTRIBUTION_MONTH,"
        SqlUString = SqlUString + " pat.ADDR_LINE_1, pat.ADDR_LINE_2, pat.CITY, pat.STATE, pat.ZIP_CODE, pat.HOME_PHONE, pat.WORK_PHONE, pat.MOBILE_PHONE"
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
            SqlUCmd = New SqlCommand(SqlUString + DGViewContSrch.CurrentRow.Cells(0).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                TxtBoxPatFirst.Text = DGViewContSrch.CurrentRow.Cells(3).Value
                TxtBoxPatLast.Text = DGViewContSrch.CurrentRow.Cells(4).Value
                TxtBoxPatID.Text = DGViewContSrch.CurrentRow.Cells(0).Value
                TxtBoxPatDOB.Text = SqlUReader.Item(0)
                TxtBoxProvFirst.Text = SqlUReader.Item(1)
                TxtBoxProvLast.Text = SqlUReader.Item(2)
                TxtBoxPracName.Text = SqlUReader.Item(3)
                vCell19.Text = SqlUReader.Item(4)
                vCell23.Text = Convert.ToString(SqlUReader.Item(6))
                vCell22.Text = SqlUReader.Item(5)
                If SqlUReader.Item(4) = "N" Then
                    ChkBoxInActive.BackColor = Color.Yellow
                    ChkBoxInActive.Checked = True
                Else
                    ChkBoxInActive.BackColor = Color.White
                    ChkBoxInActive.Checked = False
                End If
                TxtPatDemAdd1.Text = SqlUReader.Item(7)
                TxtPatDemAdd2.Text = SqlUReader.Item(8)
                TxtPatDemCity.Text = SqlUReader.Item(9)
                TxtPatDemState.Text = SqlUReader.Item(10)
                TxtPatDemZip.Text = SqlUReader.Item(11)
                TxtPatDemPhoneH.Text = SqlUReader.Item(12)
                TxtPatDemPhoneW.Text = SqlUReader.Item(13)
                TxtPatDemPhoneC.Text = SqlUReader.Item(14)

                Me.CM_UTIL_HIST_TblAdapTOC.FillUtilHist(Me._VBE_DatamartDataSet1.CM_UTILIZATION_HISTORY, Convert.ToInt64(TxtBoxPatID.Text))
                Me.CM_CONT_HIST_TblAdapTOC.FillContHist(Me._VBE_DatamartDataSet2.CM_PATIENT_CONTACT_DOC, Convert.ToInt64(TxtBoxPatID.Text))
                If DGViewContHist.CurrentCell Is Nothing Then
                    LblDoNot.Visible = False
                ElseIf DGViewContHist.CurrentRow.Cells(11).Value = "Y" Then
                    LblDoNot.Visible = True
                Else
                    LblDoNot.Visible = False
                End If
                TabControl1.SelectedIndex = 1

                DGViewUtilHist.ClearSelection()
                DGViewContHist.ClearSelection()
                ResetFlds("YES")
                ChkBoxCM.Enabled = True
                rs.ResizeAllControls(Me)
            End While
            'Get CM Enrollment
            SqlUCon.Close()
            SqlUCon.ConnectionString = "Data Source=cpdvwpdbsvcp01;Initial Catalog=VBE.Datamart;Integrated Security=True"
            SqlUCon.Open()
            SqlUCmd.Connection = SqlUCon
            SqlUString = "SELECT CM_ENROLLMENT FROM CM_PATIENT_INFO_DETAIL WHERE PATIENT_ID = "
            SqlUCmd = New SqlCommand(SqlUString + DGViewContSrch.CurrentRow.Cells(0).Value.ToString, SqlUCon)
            SqlUReader = SqlUCmd.ExecuteReader()
            While SqlUReader.Read()
                If SqlUReader.Item(0) = "YES" Then
                    ChkBoxCM.Checked = True
                Else
                    ChkBoxCM.Checked = False
                End If
            End While
        Catch ExUCmb As Exception
            MessageBox.Show("Get patient details failed during Utilization History: " & ExUCmb.Message)
        Finally
            SqlUCon.Close()
            ChkBoxCM.Enabled = True
        End Try
    End Sub

    Private Sub TxtContFName_TextChanged(sender As Object, e As EventArgs) Handles TxtContFName.TextChanged
        If TxtContFName.Text.Length = 1 Then
            ClearContFilter(1)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "FIRST_NAME LIKE '" + TxtContFName.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Sub ClearContFilter(FldNum As String)
        If TxtContFName.Text <> "" And FldNum <> 1 Then
            TxtContFName.Text = ""
        End If
        If TxtContLName.Text <> "" And FldNum <> 2 Then
            TxtContLName.Text = ""
        End If
        If TxtORName.Text <> "" And FldNum <> 3 Then
            TxtORName.Text = ""
        End If
        If TxtORReason.Text <> "" And FldNum <> 4 Then
            TxtORReason.Text = ""
        End If
        If TxtContMade.Text <> "" And FldNum <> 5 Then
            TxtContMade.Text = ""
        End If
        If TxtNoContMade.Text <> "" And FldNum <> 6 Then
            TxtNoContMade.Text = ""
        End If
        If TxtCMEnroll.Text <> "" And FldNum <> 7 Then
            TxtCMEnroll.Text = ""
        End If
    End Sub

    Private Sub BtnContFil_Click(sender As Object, e As EventArgs) Handles BtnContFil.Click
        ClearContFilter(99)
        ContSrchCnt()
    End Sub

    Private Sub TxtContLName_TextChanged(sender As Object, e As EventArgs) Handles TxtContLName.TextChanged
        If TxtContLName.Text.Length = 1 Then
            ClearContFilter(2)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "LAST_NAME LIKE '" + TxtContLName.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub TxtORName_TextChanged(sender As Object, e As EventArgs) Handles TxtORName.TextChanged
        If TxtORName.Text.Length = 1 Then
            ClearContFilter(3)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "OUTREACH_CONTACT_PERSON_NAME LIKE '" + TxtORName.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtORReason.TextChanged
        If TxtORReason.Text.Length = 1 Then
            ClearContFilter(4)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "REASON_FOR_OUTREACH LIKE '" + TxtORReason.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub TxtContMade_TextChanged(sender As Object, e As EventArgs) Handles TxtContMade.TextChanged
        If TxtContMade.Text.Length = 1 Then
            ClearContFilter(5)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "CONTACT_MADE_REASON LIKE '" + TxtContMade.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub TxtNoContMade_TextChanged(sender As Object, e As EventArgs) Handles TxtNoContMade.TextChanged
        If TxtNoContMade.Text.Length = 1 Then
            ClearContFilter(6)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "CONTACT_NOT_MADE_REASON LIKE '" + TxtNoContMade.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub TxtCMEnroll_TextChanged(sender As Object, e As EventArgs) Handles TxtCMEnroll.TextChanged
        If TxtCMEnroll.Text.Length = 1 Then
            ClearContFilter(7)
        End If
        _VBE_DatamartDataSet5.CM_PATIENT_CONTACT_DOC.DefaultView.RowFilter = "CM_ENROLLMENT LIKE '" + TxtCMEnroll.Text + "%'"
        DGViewContSrch.DataSource = _VBE_DatamartDataSet5.Tables(0).DefaultView
        ContSrchCnt()
    End Sub

    Private Sub BtnEditCont_Click(sender As Object, e As EventArgs) Handles BtnEditCont.Click
        BtnDelCont.Enabled = False
        BtnNewCont.Enabled = False
        BtnEditCont.Enabled = False
        BtnUndoCont.Enabled = True
        BtnSaveCont.Enabled = True
        vUpdStatus = "NEW"
        EnableFlds("YES")
        'ResetFlds("YES")
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

    Private Sub BtnContExcel_Click(sender As Object, e As EventArgs) Handles BtnContExcel.Click
        CreateExcel(DGViewContSrch, "ContPatList_", DGViewContSrch.RowCount)
    End Sub

    Private Sub BtnCensusExcel_Click(sender As Object, e As EventArgs) Handles BtnCensusExcel.Click
        CreateExcel(DGViewUtilSrch, "CensusList_", DGViewUtilSrch.RowCount)
    End Sub
End Class

Public Class Resizer

    '----------------------------------------------------------
    ' ControlInfo
    ' Structure of original state of all processed controls
    '----------------------------------------------------------
    Private Structure ControlInfo
        Public name As String
        Public parentName As String
        Public leftOffsetPercent As Double
        Public topOffsetPercent As Double
        Public heightPercent As Double
        Public originalHeight As Integer
        Public originalWidth As Integer
        Public widthPercent As Double
        Public originalFontSize As Single
    End Structure

    '-------------------------------------------------------------------------
    ' ctrlDict
    ' Dictionary of (control name, control info) for all processed controls
    '-------------------------------------------------------------------------
    Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

    '----------------------------------------------------------------------------------------
    ' FindAllControls
    ' Recursive function to process all controls contained in the initially passed
    ' control container and store it in the Control dictionary
    '----------------------------------------------------------------------------------------
    Public Sub FindAllControls(thisCtrl As Control)

        '-- If the current control has a parent, store all original relative position
        '-- and size information in the dictionary.
        '-- Recursively call FindAllControls for each control contained in the
        '-- current Control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo
                    c.name = ctl.Name
                    c.parentName = ctl.Parent.Name
                    c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                    c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                    c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                    c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                    c.originalFontSize = ctl.Font.Size
                    c.originalHeight = ctl.Height
                    c.originalWidth = ctl.Width
                    ctrlDict.Add(c.name, c)
                End If

            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try

            If ctl.Controls.Count > 0 Then
                FindAllControls(ctl)
            End If

        Next '-- For Each

    End Sub

    '----------------------------------------------------------------------------------------
    ' ResizeAllControls
    ' Recursive function to resize and reposition all controls contained in the Control
    ' dictionary
    '----------------------------------------------------------------------------------------
    Public Sub ResizeAllControls(thisCtrl As Control)

        'Dim fontRatioW As Single
        'Dim fontRatioH As Single
        'Dim fontRatio As Single
        'Dim f As Font

        '-- Resize and reposition all controls in the passed control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo

                    Dim ret As Boolean = False
                    Try
                        '-- Get the current control's info from the control info dictionary
                        ret = ctrlDict.TryGetValue(ctl.Name, c)

                        '-- If found, adjust the current control based on control relative
                        '-- size and position information stored in the dictionary
                        If (ret) Then
                            '-- Size
                            ctl.Width = Int(parentWidth * c.widthPercent)
                            ctl.Height = Int(parentHeight * c.heightPercent)

                            '-- Position
                            ctl.Top = Int(parentHeight * c.topOffsetPercent)
                            ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                            '-- Font
                            'f = ctl.Font
                            'fontRatioW = ctl.Width / c.originalWidth
                            'fontRatioH = ctl.Height / c.originalHeight
                            'fontRatio = (fontRatioW +
                            'fontRatioH) / 2 '-- average change in control Height and Width
                            'ctl.Font = New Font(f.FontFamily,
                            'c.originalFontSize * fontRatio, f.Style)

                        End If
                    Catch
                    End Try
                End If
            Catch ex As Exception
            End Try

            '-- Recursive call for controls contained in the current control
            If ctl.Controls.Count > 0 Then
                ResizeAllControls(ctl)
            End If

        Next '-- For Each
    End Sub

End Class '-- Resizer