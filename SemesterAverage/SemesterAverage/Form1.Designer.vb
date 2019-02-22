<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
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
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.lblLetter1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.lblLetter3 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.lblLetter4 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.lblLetter5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.txtGrade6 = New System.Windows.Forms.TextBox()
        Me.lblAverageNumber = New System.Windows.Forms.Label()
        Me.lblLetter6 = New System.Windows.Forms.Label()
        Me.lblAverageLetter = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SemesterAverageTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(55, 6)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course &1:"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade1
        '
        Me.txtGrade1.Location = New System.Drawing.Point(130, 6)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade1.TabIndex = 1
        Me.txtGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade1, "Input a number grade here")
        '
        'lblLetter1
        '
        Me.lblLetter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter1.Location = New System.Drawing.Point(236, 6)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(94, 22)
        Me.lblLetter1.TabIndex = 2
        Me.lblLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter1, "Equivalent letter grade")
        '
        'lblCourse2
        '
        Me.lblCourse2.Location = New System.Drawing.Point(55, 36)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course &2:"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade2
        '
        Me.txtGrade2.Location = New System.Drawing.Point(130, 38)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade2.TabIndex = 4
        Me.txtGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade2, "Input a number grade here")
        '
        'lblLetter2
        '
        Me.lblLetter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter2.Location = New System.Drawing.Point(236, 38)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(94, 22)
        Me.lblLetter2.TabIndex = 5
        Me.lblLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter2, "Equivalent letter grade")
        '
        'lblCourse3
        '
        Me.lblCourse3.Location = New System.Drawing.Point(55, 69)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3:"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade3
        '
        Me.txtGrade3.Location = New System.Drawing.Point(130, 66)
        Me.txtGrade3.Name = "txtGrade3"
        Me.txtGrade3.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade3.TabIndex = 7
        Me.txtGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade3, "Input a number grade here")
        '
        'lblLetter3
        '
        Me.lblLetter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter3.Location = New System.Drawing.Point(236, 66)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(94, 22)
        Me.lblLetter3.TabIndex = 8
        Me.lblLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter3, "Equivalent letter grade")
        '
        'lblCourse4
        '
        Me.lblCourse4.Location = New System.Drawing.Point(55, 96)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course &4:"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade4
        '
        Me.txtGrade4.Location = New System.Drawing.Point(130, 93)
        Me.txtGrade4.Name = "txtGrade4"
        Me.txtGrade4.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade4.TabIndex = 10
        Me.txtGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade4, "Input a number grade here")
        '
        'lblLetter4
        '
        Me.lblLetter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter4.Location = New System.Drawing.Point(236, 91)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(94, 24)
        Me.lblLetter4.TabIndex = 11
        Me.lblLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter4, "Equivalent letter grade")
        '
        'lblCourse5
        '
        Me.lblCourse5.Location = New System.Drawing.Point(55, 125)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course &5:"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade5
        '
        Me.txtGrade5.Location = New System.Drawing.Point(130, 122)
        Me.txtGrade5.Name = "txtGrade5"
        Me.txtGrade5.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade5.TabIndex = 13
        Me.txtGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade5, "Input a number grade here")
        '
        'lblLetter5
        '
        Me.lblLetter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter5.Location = New System.Drawing.Point(236, 122)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(94, 22)
        Me.lblLetter5.TabIndex = 14
        Me.lblLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter5, "Equivalent letter grade")
        '
        'lblCourse6
        '
        Me.lblCourse6.Location = New System.Drawing.Point(55, 153)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(69, 23)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course &6:"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.Location = New System.Drawing.Point(50, 182)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(74, 23)
        Me.lblSemesterAverage.TabIndex = 16
        Me.lblSemesterAverage.Text = "Semester:"
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade6
        '
        Me.txtGrade6.Location = New System.Drawing.Point(130, 150)
        Me.txtGrade6.Name = "txtGrade6"
        Me.txtGrade6.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade6.TabIndex = 17
        Me.txtGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtGrade6, "Input a number grade here")
        '
        'lblAverageNumber
        '
        Me.lblAverageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageNumber.Location = New System.Drawing.Point(130, 186)
        Me.lblAverageNumber.Name = "lblAverageNumber"
        Me.lblAverageNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageNumber.TabIndex = 18
        Me.lblAverageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageTips.SetToolTip(Me.lblAverageNumber, "The average semester number grade")
        '
        'lblLetter6
        '
        Me.lblLetter6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetter6.Location = New System.Drawing.Point(236, 149)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(94, 23)
        Me.lblLetter6.TabIndex = 19
        Me.lblLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblLetter6, "Equivalent letter grade")
        '
        'lblAverageLetter
        '
        Me.lblAverageLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageLetter.Location = New System.Drawing.Point(236, 186)
        Me.lblAverageLetter.Name = "lblAverageLetter"
        Me.lblAverageLetter.Size = New System.Drawing.Size(94, 23)
        Me.lblAverageLetter.TabIndex = 20
        Me.lblAverageLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblAverageLetter, "Equivalent letter grade")
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 215)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(320, 154)
        Me.txtOutput.TabIndex = 21
        Me.txtOutput.TabStop = False
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtOutput, "ERROR(S): Displays all inputs and any errors")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(58, 375)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 31)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterAverageTips.SetToolTip(Me.btnCalculate, "Calculate the average semester grade")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(159, 375)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 31)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterAverageTips.SetToolTip(Me.btnReset, "Reset the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(249, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 31)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.SemesterAverageTips.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(350, 426)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblAverageLetter)
        Me.Controls.Add(Me.lblLetter6)
        Me.Controls.Add(Me.lblAverageNumber)
        Me.Controls.Add(Me.txtGrade6)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblLetter5)
        Me.Controls.Add(Me.txtGrade5)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblLetter4)
        Me.Controls.Add(Me.txtGrade4)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblLetter3)
        Me.Controls.Add(Me.txtGrade3)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.txtGrade2)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblLetter1)
        Me.Controls.Add(Me.txtGrade1)
        Me.Controls.Add(Me.lblCourse1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grade Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents txtGrade1 As TextBox
    Friend WithEvents lblLetter1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents txtGrade2 As TextBox
    Friend WithEvents lblLetter2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents txtGrade3 As TextBox
    Friend WithEvents lblLetter3 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents txtGrade4 As TextBox
    Friend WithEvents lblLetter4 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents txtGrade5 As TextBox
    Friend WithEvents lblLetter5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents txtGrade6 As TextBox
    Friend WithEvents lblAverageNumber As Label
    Friend WithEvents lblLetter6 As Label
    Friend WithEvents lblAverageLetter As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SemesterAverageTips As ToolTip
End Class
