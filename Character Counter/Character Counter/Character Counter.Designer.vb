<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacterCounter
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
        Me.lblEnterInfo = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.lblNumberOf = New System.Windows.Forms.Label()
        Me.lblUpperCase = New System.Windows.Forms.Label()
        Me.lblLowerCase = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblSpecialCharacters = New System.Windows.Forms.Label()
        Me.lblAmountUpper = New System.Windows.Forms.Label()
        Me.lblAmountNumbers = New System.Windows.Forms.Label()
        Me.lblAmountLowerCase = New System.Windows.Forms.Label()
        Me.lblAmountSpecialCharacters = New System.Windows.Forms.Label()
        Me.btnShowMe = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tltpMessages = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblEnterInfo
        '
        Me.lblEnterInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblEnterInfo.Name = "lblEnterInfo"
        Me.lblEnterInfo.Size = New System.Drawing.Size(267, 42)
        Me.lblEnterInfo.TabIndex = 0
        Me.lblEnterInfo.Text = "Please enter 12 or more charaters into the text field to count the differences be" & _
    "tween them"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 70)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(267, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(12, 51)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorMessage.TabIndex = 1
        Me.lblErrorMessage.Visible = False
        '
        'lblNumberOf
        '
        Me.lblNumberOf.AutoSize = True
        Me.lblNumberOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOf.Location = New System.Drawing.Point(82, 111)
        Me.lblNumberOf.Name = "lblNumberOf"
        Me.lblNumberOf.Size = New System.Drawing.Size(116, 12)
        Me.lblNumberOf.TabIndex = 3
        Me.lblNumberOf.Text = "Number of Characters"
        '
        'lblUpperCase
        '
        Me.lblUpperCase.AutoSize = True
        Me.lblUpperCase.Location = New System.Drawing.Point(15, 138)
        Me.lblUpperCase.Name = "lblUpperCase"
        Me.lblUpperCase.Size = New System.Drawing.Size(63, 13)
        Me.lblUpperCase.TabIndex = 4
        Me.lblUpperCase.Text = "UpperCase:"
        '
        'lblLowerCase
        '
        Me.lblLowerCase.AutoSize = True
        Me.lblLowerCase.Location = New System.Drawing.Point(171, 138)
        Me.lblLowerCase.Name = "lblLowerCase"
        Me.lblLowerCase.Size = New System.Drawing.Size(63, 13)
        Me.lblLowerCase.TabIndex = 6
        Me.lblLowerCase.Text = "LowerCase:"
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(26, 178)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(52, 13)
        Me.lblNumbers.TabIndex = 8
        Me.lblNumbers.Text = "Numbers:"
        '
        'lblSpecialCharacters
        '
        Me.lblSpecialCharacters.AutoSize = True
        Me.lblSpecialCharacters.Location = New System.Drawing.Point(135, 178)
        Me.lblSpecialCharacters.Name = "lblSpecialCharacters"
        Me.lblSpecialCharacters.Size = New System.Drawing.Size(99, 13)
        Me.lblSpecialCharacters.TabIndex = 10
        Me.lblSpecialCharacters.Text = "Special Characters:"
        '
        'lblAmountUpper
        '
        Me.lblAmountUpper.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAmountUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountUpper.Location = New System.Drawing.Point(84, 138)
        Me.lblAmountUpper.Name = "lblAmountUpper"
        Me.lblAmountUpper.Size = New System.Drawing.Size(42, 23)
        Me.lblAmountUpper.TabIndex = 5
        '
        'lblAmountNumbers
        '
        Me.lblAmountNumbers.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAmountNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountNumbers.Location = New System.Drawing.Point(84, 178)
        Me.lblAmountNumbers.Name = "lblAmountNumbers"
        Me.lblAmountNumbers.Size = New System.Drawing.Size(39, 23)
        Me.lblAmountNumbers.TabIndex = 9
        '
        'lblAmountLowerCase
        '
        Me.lblAmountLowerCase.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAmountLowerCase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountLowerCase.Location = New System.Drawing.Point(241, 138)
        Me.lblAmountLowerCase.Name = "lblAmountLowerCase"
        Me.lblAmountLowerCase.Size = New System.Drawing.Size(39, 23)
        Me.lblAmountLowerCase.TabIndex = 7
        '
        'lblAmountSpecialCharacters
        '
        Me.lblAmountSpecialCharacters.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAmountSpecialCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountSpecialCharacters.Location = New System.Drawing.Point(241, 178)
        Me.lblAmountSpecialCharacters.Name = "lblAmountSpecialCharacters"
        Me.lblAmountSpecialCharacters.Size = New System.Drawing.Size(39, 23)
        Me.lblAmountSpecialCharacters.TabIndex = 11
        '
        'btnShowMe
        '
        Me.btnShowMe.Location = New System.Drawing.Point(18, 227)
        Me.btnShowMe.Name = "btnShowMe"
        Me.btnShowMe.Size = New System.Drawing.Size(75, 23)
        Me.btnShowMe.TabIndex = 12
        Me.btnShowMe.Text = "&Show Me"
        Me.btnShowMe.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(113, 227)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = " &Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(204, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCharacterCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShowMe)
        Me.Controls.Add(Me.lblAmountSpecialCharacters)
        Me.Controls.Add(Me.lblAmountLowerCase)
        Me.Controls.Add(Me.lblAmountNumbers)
        Me.Controls.Add(Me.lblAmountUpper)
        Me.Controls.Add(Me.lblSpecialCharacters)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.lblLowerCase)
        Me.Controls.Add(Me.lblUpperCase)
        Me.Controls.Add(Me.lblNumberOf)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEnterInfo)
        Me.Name = "frmCharacterCounter"
        Me.Text = "Character Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterInfo As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents lblNumberOf As System.Windows.Forms.Label
    Friend WithEvents lblUpperCase As System.Windows.Forms.Label
    Friend WithEvents lblLowerCase As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblSpecialCharacters As System.Windows.Forms.Label
    Friend WithEvents lblAmountUpper As System.Windows.Forms.Label
    Friend WithEvents lblAmountNumbers As System.Windows.Forms.Label
    Friend WithEvents lblAmountLowerCase As System.Windows.Forms.Label
    Friend WithEvents lblAmountSpecialCharacters As System.Windows.Forms.Label
    Friend WithEvents btnShowMe As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tltpMessages As System.Windows.Forms.ToolTip

End Class
