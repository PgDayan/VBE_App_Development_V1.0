<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAssigned = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPatCMDet = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLNameCM = New System.Windows.Forms.TextBox()
        Me.TxtFNameCM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RADAllPat = New System.Windows.Forms.RadioButton()
        Me.RADMyPat = New System.Windows.Forms.RadioButton()
        Me.DGViewPatCM = New System.Windows.Forms.DataGridView()
        Me.PATIENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRLINE1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRLINE2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOMEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASSIGNED_CONTACT_PERSON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASSIGNED_CONTACT_PERSON_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMPATIENTINFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._VBE_DatamartDataSet4 = New VBEDataAppV1._0._VBE_DatamartDataSet4()
        Me.CM_PATIENT_INFOTblAdapCM = New VBEDataAppV1._0._VBE_DatamartDataSet4TableAdapters.CM_PATIENT_INFOTableAdapter()
        Me.ProgBarExcel = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGViewPatCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMPATIENTINFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._VBE_DatamartDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ProgBarExcel)
        Me.GroupBox1.Controls.Add(Me.BtnExcel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtAssigned)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPatCMDet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtLNameCM)
        Me.GroupBox1.Controls.Add(Me.TxtFNameCM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RADAllPat)
        Me.GroupBox1.Controls.Add(Me.RADMyPat)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnExcel
        '
        Me.BtnExcel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.BtnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.BtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcel.ForeColor = System.Drawing.Color.Blue
        Me.BtnExcel.Location = New System.Drawing.Point(983, 29)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(117, 21)
        Me.BtnExcel.TabIndex = 16
        Me.BtnExcel.Text = "Save As Excel File"
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(637, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Assigned Person Name:"
        '
        'TxtAssigned
        '
        Me.TxtAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAssigned.Location = New System.Drawing.Point(638, 29)
        Me.TxtAssigned.Name = "TxtAssigned"
        Me.TxtAssigned.Size = New System.Drawing.Size(167, 21)
        Me.TxtAssigned.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(198, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Filter Patients By -->"
        '
        'BtnPatCMDet
        '
        Me.BtnPatCMDet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnPatCMDet.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.BtnPatCMDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.BtnPatCMDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnPatCMDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPatCMDet.ForeColor = System.Drawing.Color.Blue
        Me.BtnPatCMDet.Location = New System.Drawing.Point(89, 10)
        Me.BtnPatCMDet.Name = "BtnPatCMDet"
        Me.BtnPatCMDet.Size = New System.Drawing.Size(96, 43)
        Me.BtnPatCMDet.TabIndex = 12
        Me.BtnPatCMDet.Text = "Launch Patient Details Tab"
        Me.BtnPatCMDet.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(468, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Patient Last Name:"
        '
        'TxtLNameCM
        '
        Me.TxtLNameCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLNameCM.Location = New System.Drawing.Point(469, 29)
        Me.TxtLNameCM.Name = "TxtLNameCM"
        Me.TxtLNameCM.Size = New System.Drawing.Size(167, 21)
        Me.TxtLNameCM.TabIndex = 8
        '
        'TxtFNameCM
        '
        Me.TxtFNameCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFNameCM.Location = New System.Drawing.Point(302, 29)
        Me.TxtFNameCM.Name = "TxtFNameCM"
        Me.TxtFNameCM.Size = New System.Drawing.Size(165, 21)
        Me.TxtFNameCM.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(300, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Patient First Name:"
        '
        'RADAllPat
        '
        Me.RADAllPat.AutoSize = True
        Me.RADAllPat.ForeColor = System.Drawing.Color.Blue
        Me.RADAllPat.Location = New System.Drawing.Point(8, 32)
        Me.RADAllPat.Name = "RADAllPat"
        Me.RADAllPat.Size = New System.Drawing.Size(77, 17)
        Me.RADAllPat.TabIndex = 1
        Me.RADAllPat.TabStop = True
        Me.RADAllPat.Text = "All Patients"
        Me.RADAllPat.UseVisualStyleBackColor = True
        '
        'RADMyPat
        '
        Me.RADMyPat.AutoSize = True
        Me.RADMyPat.ForeColor = System.Drawing.Color.Blue
        Me.RADMyPat.Location = New System.Drawing.Point(8, 11)
        Me.RADMyPat.Name = "RADMyPat"
        Me.RADMyPat.Size = New System.Drawing.Size(80, 17)
        Me.RADMyPat.TabIndex = 0
        Me.RADMyPat.TabStop = True
        Me.RADMyPat.Text = "My Patients"
        Me.RADMyPat.UseVisualStyleBackColor = True
        '
        'DGViewPatCM
        '
        Me.DGViewPatCM.AllowUserToAddRows = False
        Me.DGViewPatCM.AllowUserToDeleteRows = False
        Me.DGViewPatCM.AutoGenerateColumns = False
        Me.DGViewPatCM.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGViewPatCM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGViewPatCM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGViewPatCM.ColumnHeadersHeight = 31
        Me.DGViewPatCM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PATIENTIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.DODDataGridViewTextBoxColumn, Me.ADDRLINE1DataGridViewTextBoxColumn, Me.ADDRLINE2DataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn, Me.STATEDataGridViewTextBoxColumn, Me.ZIPCODEDataGridViewTextBoxColumn, Me.HOMEPHONEDataGridViewTextBoxColumn, Me.ASSIGNED_CONTACT_PERSON, Me.ASSIGNED_CONTACT_PERSON_NAME})
        Me.DGViewPatCM.DataSource = Me.CMPATIENTINFOBindingSource
        Me.DGViewPatCM.EnableHeadersVisualStyles = False
        Me.DGViewPatCM.Location = New System.Drawing.Point(2, 58)
        Me.DGViewPatCM.MultiSelect = False
        Me.DGViewPatCM.Name = "DGViewPatCM"
        Me.DGViewPatCM.ReadOnly = True
        Me.DGViewPatCM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGViewPatCM.RowHeadersVisible = False
        Me.DGViewPatCM.RowHeadersWidth = 62
        Me.DGViewPatCM.RowTemplate.Height = 18
        Me.DGViewPatCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewPatCM.Size = New System.Drawing.Size(1106, 409)
        Me.DGViewPatCM.TabIndex = 1
        '
        'PATIENTIDDataGridViewTextBoxColumn
        '
        Me.PATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.Name = "PATIENTIDDataGridViewTextBoxColumn"
        Me.PATIENTIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PATIENTIDDataGridViewTextBoxColumn.Visible = False
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MIDDLENAMEDataGridViewTextBoxColumn
        '
        Me.MIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLE_NAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Name = "MIDDLENAMEDataGridViewTextBoxColumn"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Width = 60
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOBDataGridViewTextBoxColumn.Width = 80
        '
        'DODDataGridViewTextBoxColumn
        '
        Me.DODDataGridViewTextBoxColumn.DataPropertyName = "DOD"
        Me.DODDataGridViewTextBoxColumn.HeaderText = "DOD"
        Me.DODDataGridViewTextBoxColumn.Name = "DODDataGridViewTextBoxColumn"
        Me.DODDataGridViewTextBoxColumn.ReadOnly = True
        Me.DODDataGridViewTextBoxColumn.Width = 80
        '
        'ADDRLINE1DataGridViewTextBoxColumn
        '
        Me.ADDRLINE1DataGridViewTextBoxColumn.DataPropertyName = "ADDR_LINE_1"
        Me.ADDRLINE1DataGridViewTextBoxColumn.HeaderText = "ADDR LINE_1"
        Me.ADDRLINE1DataGridViewTextBoxColumn.Name = "ADDRLINE1DataGridViewTextBoxColumn"
        Me.ADDRLINE1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRLINE2DataGridViewTextBoxColumn
        '
        Me.ADDRLINE2DataGridViewTextBoxColumn.DataPropertyName = "ADDR_LINE_2"
        Me.ADDRLINE2DataGridViewTextBoxColumn.HeaderText = "ADDR LINE_2"
        Me.ADDRLINE2DataGridViewTextBoxColumn.Name = "ADDRLINE2DataGridViewTextBoxColumn"
        Me.ADDRLINE2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        Me.CITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATEDataGridViewTextBoxColumn
        '
        Me.STATEDataGridViewTextBoxColumn.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn.Name = "STATEDataGridViewTextBoxColumn"
        Me.STATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATEDataGridViewTextBoxColumn.Width = 60
        '
        'ZIPCODEDataGridViewTextBoxColumn
        '
        Me.ZIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIP CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.Name = "ZIPCODEDataGridViewTextBoxColumn"
        Me.ZIPCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZIPCODEDataGridViewTextBoxColumn.Width = 60
        '
        'HOMEPHONEDataGridViewTextBoxColumn
        '
        Me.HOMEPHONEDataGridViewTextBoxColumn.DataPropertyName = "HOME_PHONE"
        Me.HOMEPHONEDataGridViewTextBoxColumn.HeaderText = "HOME PHONE"
        Me.HOMEPHONEDataGridViewTextBoxColumn.Name = "HOMEPHONEDataGridViewTextBoxColumn"
        Me.HOMEPHONEDataGridViewTextBoxColumn.ReadOnly = True
        Me.HOMEPHONEDataGridViewTextBoxColumn.Width = 80
        '
        'ASSIGNED_CONTACT_PERSON
        '
        Me.ASSIGNED_CONTACT_PERSON.DataPropertyName = "ASSIGNED_CONTACT_PERSON"
        Me.ASSIGNED_CONTACT_PERSON.HeaderText = "ASSIGNED PERSON"
        Me.ASSIGNED_CONTACT_PERSON.Name = "ASSIGNED_CONTACT_PERSON"
        Me.ASSIGNED_CONTACT_PERSON.ReadOnly = True
        Me.ASSIGNED_CONTACT_PERSON.Width = 80
        '
        'ASSIGNED_CONTACT_PERSON_NAME
        '
        Me.ASSIGNED_CONTACT_PERSON_NAME.DataPropertyName = "ASSIGNED_CONTACT_PERSON_NAME"
        Me.ASSIGNED_CONTACT_PERSON_NAME.HeaderText = "ASSIGNED PERSON NAME"
        Me.ASSIGNED_CONTACT_PERSON_NAME.Name = "ASSIGNED_CONTACT_PERSON_NAME"
        Me.ASSIGNED_CONTACT_PERSON_NAME.ReadOnly = True
        '
        'CMPATIENTINFOBindingSource
        '
        Me.CMPATIENTINFOBindingSource.DataMember = "CM_PATIENT_INFO"
        Me.CMPATIENTINFOBindingSource.DataSource = Me._VBE_DatamartDataSet4
        '
        '_VBE_DatamartDataSet4
        '
        Me._VBE_DatamartDataSet4.DataSetName = "_VBE_DatamartDataSet4"
        Me._VBE_DatamartDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CM_PATIENT_INFOTblAdapCM
        '
        Me.CM_PATIENT_INFOTblAdapCM.ClearBeforeFill = True
        '
        'ProgBarExcel
        '
        Me.ProgBarExcel.Location = New System.Drawing.Point(866, 13)
        Me.ProgBarExcel.Name = "ProgBarExcel"
        Me.ProgBarExcel.Size = New System.Drawing.Size(234, 10)
        Me.ProgBarExcel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgBarExcel.TabIndex = 17
        '
        'FormCM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 479)
        Me.Controls.Add(Me.DGViewPatCM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCM"
        Me.Text = "CM Enrolled Patients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGViewPatCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMPATIENTINFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._VBE_DatamartDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLNameCM As TextBox
    Friend WithEvents TxtFNameCM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RADAllPat As RadioButton
    Friend WithEvents RADMyPat As RadioButton
    Friend WithEvents DGViewPatCM As DataGridView
    Friend WithEvents _VBE_DatamartDataSet4 As _VBE_DatamartDataSet4
    Friend WithEvents CMPATIENTINFOBindingSource As BindingSource
    Friend WithEvents CM_PATIENT_INFOTblAdapCM As _VBE_DatamartDataSet4TableAdapters.CM_PATIENT_INFOTableAdapter
    Friend WithEvents BtnPatCMDet As Button
    Friend WithEvents PATIENTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRLINE1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRLINE2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIPCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOMEPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASSIGNED_CONTACT_PERSON As DataGridViewTextBoxColumn
    Friend WithEvents ASSIGNED_CONTACT_PERSON_NAME As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAssigned As TextBox
    Friend WithEvents BtnExcel As Button
    Friend WithEvents ProgBarExcel As ProgressBar
End Class
