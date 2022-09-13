<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisease
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
        Me.grdHIV = New UJGrid.UJGrid()
        Me.txtMaxAgeHIV = New System.Windows.Forms.TextBox()
        Me.txtGenderRatioHIV = New System.Windows.Forms.TextBox()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdMalaria = New UJGrid.UJGrid()
        Me.txtMaxAgeMalaria = New System.Windows.Forms.TextBox()
        Me.txtGenderRatioMalaria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdHIV
        '
        Me.grdHIV.FixedCols = 1
        Me.grdHIV.FixedRows = 1
        Me.grdHIV.Location = New System.Drawing.Point(124, 92)
        Me.grdHIV.Name = "grdHIV"
        Me.grdHIV.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdHIV.Size = New System.Drawing.Size(573, 104)
        Me.grdHIV.TabIndex = 0
        '
        'txtMaxAgeHIV
        '
        Me.txtMaxAgeHIV.Location = New System.Drawing.Point(289, 202)
        Me.txtMaxAgeHIV.Name = "txtMaxAgeHIV"
        Me.txtMaxAgeHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxAgeHIV.TabIndex = 1
        '
        'txtGenderRatioHIV
        '
        Me.txtGenderRatioHIV.Location = New System.Drawing.Point(552, 202)
        Me.txtGenderRatioHIV.Name = "txtGenderRatioHIV"
        Me.txtGenderRatioHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtGenderRatioHIV.TabIndex = 2
        '
        'txtDisease
        '
        Me.txtDisease.Location = New System.Drawing.Point(411, 381)
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(100, 20)
        Me.txtDisease.TabIndex = 3
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(287, 63)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(244, 23)
        Me.btnInput.TabIndex = 4
        Me.btnInput.Text = "Input Affected Person's information"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(540, 63)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(156, 23)
        Me.btnResults.TabIndex = 6
        Me.btnResults.Text = "Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Evaluation of People Suffering From Hiv&Aids And Malaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Eldest Person Affected:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender Ratio (Male/Female):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "More Common Disease:"
        '
        'grdMalaria
        '
        Me.grdMalaria.FixedCols = 1
        Me.grdMalaria.FixedRows = 1
        Me.grdMalaria.Location = New System.Drawing.Point(124, 231)
        Me.grdMalaria.Name = "grdMalaria"
        Me.grdMalaria.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMalaria.Size = New System.Drawing.Size(572, 98)
        Me.grdMalaria.TabIndex = 12
        '
        'txtMaxAgeMalaria
        '
        Me.txtMaxAgeMalaria.Location = New System.Drawing.Point(289, 335)
        Me.txtMaxAgeMalaria.Name = "txtMaxAgeMalaria"
        Me.txtMaxAgeMalaria.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxAgeMalaria.TabIndex = 13
        '
        'txtGenderRatioMalaria
        '
        Me.txtGenderRatioMalaria.Location = New System.Drawing.Point(552, 334)
        Me.txtGenderRatioMalaria.Name = "txtGenderRatioMalaria"
        Me.txtGenderRatioMalaria.Size = New System.Drawing.Size(100, 20)
        Me.txtGenderRatioMalaria.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Eldest Person Affected:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Gender Ratio (Male/Female):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-1, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "HIV And AIDS :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "MALARIA :"
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(124, 63)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(154, 23)
        Me.btnInit.TabIndex = 19
        Me.btnInit.Text = "Initialize"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'frmDisease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 413)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGenderRatioMalaria)
        Me.Controls.Add(Me.txtMaxAgeMalaria)
        Me.Controls.Add(Me.grdMalaria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtDisease)
        Me.Controls.Add(Me.txtGenderRatioHIV)
        Me.Controls.Add(Me.txtMaxAgeHIV)
        Me.Controls.Add(Me.grdHIV)
        Me.Name = "frmDisease"
        Me.Text = "Disease "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdHIV As UJGrid.UJGrid
    Friend WithEvents txtMaxAgeHIV As TextBox
    Friend WithEvents txtGenderRatioHIV As TextBox
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grdMalaria As UJGrid.UJGrid
    Friend WithEvents txtMaxAgeMalaria As TextBox
    Friend WithEvents txtGenderRatioMalaria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnInit As Button
End Class
