<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.BtnTOC = New System.Windows.Forms.Button()
        Me.BtnQOC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTOC
        '
        Me.BtnTOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTOC.ForeColor = System.Drawing.Color.Blue
        Me.BtnTOC.Location = New System.Drawing.Point(11, 23)
        Me.BtnTOC.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTOC.Name = "BtnTOC"
        Me.BtnTOC.Size = New System.Drawing.Size(121, 34)
        Me.BtnTOC.TabIndex = 0
        Me.BtnTOC.Text = "Transition Of Care"
        Me.BtnTOC.UseVisualStyleBackColor = True
        '
        'BtnQOC
        '
        Me.BtnQOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQOC.ForeColor = System.Drawing.Color.Blue
        Me.BtnQOC.Location = New System.Drawing.Point(11, 62)
        Me.BtnQOC.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnQOC.Name = "BtnQOC"
        Me.BtnQOC.Size = New System.Drawing.Size(121, 34)
        Me.BtnQOC.TabIndex = 1
        Me.BtnQOC.Text = "Quality Of Care"
        Me.BtnQOC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login Details:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "---"
        '
        'TextID
        '
        Me.TextID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.ForeColor = System.Drawing.Color.Red
        Me.TextID.Location = New System.Drawing.Point(79, 14)
        Me.TextID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(61, 23)
        Me.TextID.TabIndex = 4
        Me.TextID.TabStop = False
        '
        'TextName
        '
        Me.TextName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.ForeColor = System.Drawing.Color.Red
        Me.TextName.Location = New System.Drawing.Point(163, 14)
        Me.TextName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(157, 23)
        Me.TextName.TabIndex = 5
        Me.TextName.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextName)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(465, 36)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.BtnTOC)
        Me.GroupBox2.Controls.Add(Me.BtnQOC)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 60)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(155, 293)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Care Management"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Location = New System.Drawing.Point(182, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(151, 293)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Claims Management"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(337, 60)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(151, 293)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VBE Analytics"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBEDataAppV1._0.My.Resources.Resources.HcaVcp
        Me.PictureBox1.Location = New System.Drawing.Point(23, 358)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 283)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 643)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMain"
        Me.Text = "VBE V1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTOC As Button
    Friend WithEvents BtnQOC As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
