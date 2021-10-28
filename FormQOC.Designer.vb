<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQOC
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabQOCPatSrch = New System.Windows.Forms.TabPage()
        Me.TabQOCPatHist = New System.Windows.Forms.TabPage()
        Me.TabQOCPatUpd = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabQOCPatSrch)
        Me.TabControl1.Controls.Add(Me.TabQOCPatHist)
        Me.TabControl1.Controls.Add(Me.TabQOCPatUpd)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1212, 623)
        Me.TabControl1.TabIndex = 0
        '
        'TabQOCPatSrch
        '
        Me.TabQOCPatSrch.Location = New System.Drawing.Point(4, 22)
        Me.TabQOCPatSrch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatSrch.Name = "TabQOCPatSrch"
        Me.TabQOCPatSrch.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatSrch.Size = New System.Drawing.Size(1204, 597)
        Me.TabQOCPatSrch.TabIndex = 0
        Me.TabQOCPatSrch.Text = "Patient Search"
        Me.TabQOCPatSrch.UseVisualStyleBackColor = True
        '
        'TabQOCPatHist
        '
        Me.TabQOCPatHist.Location = New System.Drawing.Point(4, 22)
        Me.TabQOCPatHist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatHist.Name = "TabQOCPatHist"
        Me.TabQOCPatHist.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatHist.Size = New System.Drawing.Size(1204, 597)
        Me.TabQOCPatHist.TabIndex = 1
        Me.TabQOCPatHist.Text = "History Details"
        Me.TabQOCPatHist.UseVisualStyleBackColor = True
        '
        'TabQOCPatUpd
        '
        Me.TabQOCPatUpd.Location = New System.Drawing.Point(4, 22)
        Me.TabQOCPatUpd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatUpd.Name = "TabQOCPatUpd"
        Me.TabQOCPatUpd.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabQOCPatUpd.Size = New System.Drawing.Size(1204, 597)
        Me.TabQOCPatUpd.TabIndex = 2
        Me.TabQOCPatUpd.Text = "Create / Update Records"
        Me.TabQOCPatUpd.UseVisualStyleBackColor = True
        '
        'FormQOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 626)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormQOC"
        Me.Text = "Quality Of Care (QOC)"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabQOCPatSrch As TabPage
    Friend WithEvents TabQOCPatHist As TabPage
    Friend WithEvents TabQOCPatUpd As TabPage
End Class
