<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCallList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPatCMDet = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBoxCallDT = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.RadCallAppt = New System.Windows.Forms.RadioButton()
        Me.RadCallRet = New System.Windows.Forms.RadioButton()
        Me.RadCallBoth = New System.Windows.Forms.RadioButton()
        Me.DGViewCall = New System.Windows.Forms.DataGridView()
        Me.PATIENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETURNCALLDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OUTREACH_ENTRY_DATETIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REASONFOROUTREACHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTMADEREASONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_ENROLLMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMPATIENTCONTACTDOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._VBE_DatamartDataSet6 = New VBEDataAppV1._0._VBE_DatamartDataSet6()
        Me.CM_CONT_TblAdapCall = New VBEDataAppV1._0._VBE_DatamartDataSet6TableAdapters.CM_PATIENT_CONTACT_DOCTableAdapter()
        Me.ProgBarExcel = New System.Windows.Forms.ProgressBar()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGViewCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMPATIENTCONTACTDOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._VBE_DatamartDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.BtnPatCMDet)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnPatCMDet
        '
        Me.BtnPatCMDet.BackColor = System.Drawing.Color.IndianRed
        Me.BtnPatCMDet.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.BtnPatCMDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.BtnPatCMDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnPatCMDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPatCMDet.ForeColor = System.Drawing.Color.MistyRose
        Me.BtnPatCMDet.Location = New System.Drawing.Point(5, 1)
        Me.BtnPatCMDet.Name = "BtnPatCMDet"
        Me.BtnPatCMDet.Size = New System.Drawing.Size(94, 62)
        Me.BtnPatCMDet.TabIndex = 24
        Me.BtnPatCMDet.Text = "Launch Patient Details Tab"
        Me.BtnPatCMDet.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox2.Controls.Add(Me.BtnExcel)
        Me.GroupBox2.Controls.Add(Me.ProgBarExcel)
        Me.GroupBox2.Controls.Add(Me.CmbBoxCallDT)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.RadCallAppt)
        Me.GroupBox2.Controls.Add(Me.RadCallRet)
        Me.GroupBox2.Controls.Add(Me.RadCallBoth)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(108, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CmbBoxCallDT
        '
        Me.CmbBoxCallDT.BackColor = System.Drawing.Color.RosyBrown
        Me.CmbBoxCallDT.ForeColor = System.Drawing.SystemColors.Window
        Me.CmbBoxCallDT.FormattingEnabled = True
        Me.CmbBoxCallDT.Items.AddRange(New Object() {"ALL", "Today", "One Day", "Two Days", "Three Days", "Four Days", "Five Days", "One Week", "Two Weeks", "One Month", "Two Months"})
        Me.CmbBoxCallDT.Location = New System.Drawing.Point(126, 25)
        Me.CmbBoxCallDT.Name = "CmbBoxCallDT"
        Me.CmbBoxCallDT.Size = New System.Drawing.Size(158, 21)
        Me.CmbBoxCallDT.TabIndex = 35
        Me.CmbBoxCallDT.Text = "ALL"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.DarkRed
        Me.Label53.Location = New System.Drawing.Point(110, 9)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(192, 13)
        Me.Label53.TabIndex = 28
        Me.Label53.Text = "Choose Future Call Return Date Range"
        '
        'RadCallAppt
        '
        Me.RadCallAppt.AutoSize = True
        Me.RadCallAppt.Location = New System.Drawing.Point(9, 45)
        Me.RadCallAppt.Name = "RadCallAppt"
        Me.RadCallAppt.Size = New System.Drawing.Size(89, 17)
        Me.RadCallAppt.TabIndex = 26
        Me.RadCallAppt.Text = "Appointments"
        Me.RadCallAppt.UseVisualStyleBackColor = True
        '
        'RadCallRet
        '
        Me.RadCallRet.AutoSize = True
        Me.RadCallRet.Location = New System.Drawing.Point(9, 25)
        Me.RadCallRet.Name = "RadCallRet"
        Me.RadCallRet.Size = New System.Drawing.Size(77, 17)
        Me.RadCallRet.TabIndex = 25
        Me.RadCallRet.Text = "Call Return"
        Me.RadCallRet.UseVisualStyleBackColor = True
        '
        'RadCallBoth
        '
        Me.RadCallBoth.AutoSize = True
        Me.RadCallBoth.Checked = True
        Me.RadCallBoth.Location = New System.Drawing.Point(9, 4)
        Me.RadCallBoth.Name = "RadCallBoth"
        Me.RadCallBoth.Size = New System.Drawing.Size(47, 17)
        Me.RadCallBoth.TabIndex = 24
        Me.RadCallBoth.TabStop = True
        Me.RadCallBoth.Text = "Both"
        Me.RadCallBoth.UseVisualStyleBackColor = True
        '
        'DGViewCall
        '
        Me.DGViewCall.AllowUserToAddRows = False
        Me.DGViewCall.AllowUserToDeleteRows = False
        Me.DGViewCall.AutoGenerateColumns = False
        Me.DGViewCall.BackgroundColor = System.Drawing.Color.SeaShell
        Me.DGViewCall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGViewCall.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGViewCall.ColumnHeadersHeight = 31
        Me.DGViewCall.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PATIENTIDDataGridViewTextBoxColumn, Me.RETURNCALLDATEDataGridViewTextBoxColumn, Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn, Me.OUTREACH_ENTRY_DATETIME, Me.FIRST_NAME, Me.LAST_NAME, Me.DOB, Me.REASONFOROUTREACHDataGridViewTextBoxColumn, Me.CONTACTMADEREASONDataGridViewTextBoxColumn, Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn, Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn, Me.CM_ENROLLMENT})
        Me.DGViewCall.DataSource = Me.CMPATIENTCONTACTDOCBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGViewCall.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGViewCall.EnableHeadersVisualStyles = False
        Me.DGViewCall.Location = New System.Drawing.Point(3, 72)
        Me.DGViewCall.MultiSelect = False
        Me.DGViewCall.Name = "DGViewCall"
        Me.DGViewCall.ReadOnly = True
        Me.DGViewCall.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGViewCall.RowHeadersVisible = False
        Me.DGViewCall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewCall.Size = New System.Drawing.Size(933, 517)
        Me.DGViewCall.TabIndex = 2
        '
        'PATIENTIDDataGridViewTextBoxColumn
        '
        Me.PATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.Name = "PATIENTIDDataGridViewTextBoxColumn"
        Me.PATIENTIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PATIENTIDDataGridViewTextBoxColumn.Visible = False
        '
        'RETURNCALLDATEDataGridViewTextBoxColumn
        '
        Me.RETURNCALLDATEDataGridViewTextBoxColumn.DataPropertyName = "RETURN_CALL_DATE"
        Me.RETURNCALLDATEDataGridViewTextBoxColumn.HeaderText = "RETURN CALL"
        Me.RETURNCALLDATEDataGridViewTextBoxColumn.Name = "RETURNCALLDATEDataGridViewTextBoxColumn"
        Me.RETURNCALLDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.RETURNCALLDATEDataGridViewTextBoxColumn.Width = 70
        '
        'APPOINTMENTDATERESULTDataGridViewTextBoxColumn
        '
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn.DataPropertyName = "APPOINTMENT_DATE_RESULT"
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn.HeaderText = "APPT. DATE"
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn.Name = "APPOINTMENTDATERESULTDataGridViewTextBoxColumn"
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn.ReadOnly = True
        Me.APPOINTMENTDATERESULTDataGridViewTextBoxColumn.Width = 70
        '
        'OUTREACH_ENTRY_DATETIME
        '
        Me.OUTREACH_ENTRY_DATETIME.DataPropertyName = "OUTREACH_ENTRY_DATETIME"
        DataGridViewCellStyle8.Format = "t"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.OUTREACH_ENTRY_DATETIME.DefaultCellStyle = DataGridViewCellStyle8
        Me.OUTREACH_ENTRY_DATETIME.HeaderText = "TIME"
        Me.OUTREACH_ENTRY_DATETIME.Name = "OUTREACH_ENTRY_DATETIME"
        Me.OUTREACH_ENTRY_DATETIME.ReadOnly = True
        Me.OUTREACH_ENTRY_DATETIME.Width = 50
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.DataPropertyName = "FIRST_NAME"
        Me.FIRST_NAME.HeaderText = "FIRST NAME"
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.ReadOnly = True
        '
        'LAST_NAME
        '
        Me.LAST_NAME.DataPropertyName = "LAST_NAME"
        Me.LAST_NAME.HeaderText = "LAST NAME"
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.ReadOnly = True
        '
        'DOB
        '
        Me.DOB.DataPropertyName = "DOB"
        Me.DOB.HeaderText = "DOB"
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Width = 70
        '
        'REASONFOROUTREACHDataGridViewTextBoxColumn
        '
        Me.REASONFOROUTREACHDataGridViewTextBoxColumn.DataPropertyName = "REASON_FOR_OUTREACH"
        Me.REASONFOROUTREACHDataGridViewTextBoxColumn.HeaderText = "OUTREACH REASON"
        Me.REASONFOROUTREACHDataGridViewTextBoxColumn.Name = "REASONFOROUTREACHDataGridViewTextBoxColumn"
        Me.REASONFOROUTREACHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTMADEREASONDataGridViewTextBoxColumn
        '
        Me.CONTACTMADEREASONDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_MADE_REASON"
        Me.CONTACTMADEREASONDataGridViewTextBoxColumn.HeaderText = "CONTACT REASON"
        Me.CONTACTMADEREASONDataGridViewTextBoxColumn.Name = "CONTACTMADEREASONDataGridViewTextBoxColumn"
        Me.CONTACTMADEREASONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTNOTMADEREASONDataGridViewTextBoxColumn
        '
        Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_NOT_MADE_REASON"
        Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn.HeaderText = "NO CONTACT REASON"
        Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn.Name = "CONTACTNOTMADEREASONDataGridViewTextBoxColumn"
        Me.CONTACTNOTMADEREASONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DDNOTCONTACTFLAGDataGridViewTextBoxColumn
        '
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn.DataPropertyName = "DD_NOT_CONTACT_FLAG"
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn.HeaderText = "DO NOT CONTACT"
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn.Name = "DDNOTCONTACTFLAGDataGridViewTextBoxColumn"
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn.ReadOnly = True
        Me.DDNOTCONTACTFLAGDataGridViewTextBoxColumn.Width = 80
        '
        'CM_ENROLLMENT
        '
        Me.CM_ENROLLMENT.DataPropertyName = "CM_ENROLLMENT"
        Me.CM_ENROLLMENT.HeaderText = "CM ENROLLMENT"
        Me.CM_ENROLLMENT.Name = "CM_ENROLLMENT"
        Me.CM_ENROLLMENT.ReadOnly = True
        Me.CM_ENROLLMENT.Width = 90
        '
        'CMPATIENTCONTACTDOCBindingSource
        '
        Me.CMPATIENTCONTACTDOCBindingSource.DataMember = "CM_PATIENT_CONTACT_DOC"
        Me.CMPATIENTCONTACTDOCBindingSource.DataSource = Me._VBE_DatamartDataSet6
        '
        '_VBE_DatamartDataSet6
        '
        Me._VBE_DatamartDataSet6.DataSetName = "_VBE_DatamartDataSet6"
        Me._VBE_DatamartDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CM_CONT_TblAdapCall
        '
        Me.CM_CONT_TblAdapCall.ClearBeforeFill = True
        '
        'ProgBarExcel
        '
        Me.ProgBarExcel.Location = New System.Drawing.Point(588, 11)
        Me.ProgBarExcel.Name = "ProgBarExcel"
        Me.ProgBarExcel.Size = New System.Drawing.Size(234, 10)
        Me.ProgBarExcel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgBarExcel.TabIndex = 36
        '
        'BtnExcel
        '
        Me.BtnExcel.BackColor = System.Drawing.Color.IndianRed
        Me.BtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.BtnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.BtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcel.ForeColor = System.Drawing.Color.MistyRose
        Me.BtnExcel.Location = New System.Drawing.Point(732, 27)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(90, 21)
        Me.BtnExcel.TabIndex = 37
        Me.BtnExcel.Text = "Save As Excel"
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'FormCallList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 589)
        Me.Controls.Add(Me.DGViewCall)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormCallList"
        Me.Text = "Call Return / Appointment Reminder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGViewCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMPATIENTCONTACTDOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._VBE_DatamartDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPatCMDet As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadCallAppt As RadioButton
    Friend WithEvents RadCallRet As RadioButton
    Friend WithEvents RadCallBoth As RadioButton
    Friend WithEvents DGViewCall As DataGridView
    Friend WithEvents _VBE_DatamartDataSet6 As _VBE_DatamartDataSet6
    Friend WithEvents CMPATIENTCONTACTDOCBindingSource As BindingSource
    Friend WithEvents CM_CONT_TblAdapCall As _VBE_DatamartDataSet6TableAdapters.CM_PATIENT_CONTACT_DOCTableAdapter
    Friend WithEvents NETWORKPATIENTADDRLINE1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTADDRLINE2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTCITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTSTATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTZIPCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTHOMEPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTWORKPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTMOBILEPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NETWORKPATIENTEMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVEPATIENTFLAGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MAXATTRIBUTIONMONTHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTREVISEDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PATIENTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RETURNCALLDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPOINTMENTDATERESULTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OUTREACH_ENTRY_DATETIME As DataGridViewTextBoxColumn
    Friend WithEvents FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents LAST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
    Friend WithEvents REASONFOROUTREACHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTMADEREASONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNOTMADEREASONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DDNOTCONTACTFLAGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CM_ENROLLMENT As DataGridViewTextBoxColumn
    Friend WithEvents CmbBoxCallDT As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents ProgBarExcel As ProgressBar
    Friend WithEvents BtnExcel As Button
End Class
