<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.txtemployeename = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.Label()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtHourlyRate = New System.Windows.Forms.Label()
        Me.txthoursrate = New System.Windows.Forms.TextBox()
        Me.txtTaxRate = New System.Windows.Forms.Label()
        Me.taxrate = New System.Windows.Forms.TextBox()
        Me.lblgrossSalary = New System.Windows.Forms.Label()
        Me.grosspay = New System.Windows.Forms.TextBox()
        Me.lblammountdeducted = New System.Windows.Forms.Label()
        Me.ammountded = New System.Windows.Forms.TextBox()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.netsal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.userout = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtemployeename
        '
        Me.txtemployeename.AutoSize = True
        Me.txtemployeename.ForeColor = System.Drawing.Color.Cyan
        Me.txtemployeename.Location = New System.Drawing.Point(35, 91)
        Me.txtemployeename.Name = "txtemployeename"
        Me.txtemployeename.Size = New System.Drawing.Size(84, 13)
        Me.txtemployeename.TabIndex = 0
        Me.txtemployeename.Text = "Employee Name"
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txtTitle.ForeColor = System.Drawing.Color.Cyan
        Me.txtTitle.Location = New System.Drawing.Point(271, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(228, 37)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Payroll System"
        '
        'txtUsername
        '
        Me.txtUsername.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtUsername.Location = New System.Drawing.Point(38, 107)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(180, 19)
        Me.txtUsername.TabIndex = 2
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.AutoSize = True
        Me.txtHoursWorked.ForeColor = System.Drawing.Color.Cyan
        Me.txtHoursWorked.Location = New System.Drawing.Point(35, 143)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(76, 13)
        Me.txtHoursWorked.TabIndex = 3
        Me.txtHoursWorked.Text = "Hours Worked"
        '
        'txthours
        '
        Me.txthours.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txthours.Location = New System.Drawing.Point(38, 159)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(180, 19)
        Me.txthours.TabIndex = 4
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.AutoSize = True
        Me.txtHourlyRate.ForeColor = System.Drawing.Color.Cyan
        Me.txtHourlyRate.Location = New System.Drawing.Point(35, 199)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(63, 13)
        Me.txtHourlyRate.TabIndex = 5
        Me.txtHourlyRate.Text = "Hourly Rate"
        '
        'txthoursrate
        '
        Me.txthoursrate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txthoursrate.Location = New System.Drawing.Point(38, 216)
        Me.txthoursrate.Name = "txthoursrate"
        Me.txthoursrate.Size = New System.Drawing.Size(180, 19)
        Me.txthoursrate.TabIndex = 6
        '
        'txtTaxRate
        '
        Me.txtTaxRate.AutoSize = True
        Me.txtTaxRate.ForeColor = System.Drawing.Color.Cyan
        Me.txtTaxRate.Location = New System.Drawing.Point(35, 252)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(51, 13)
        Me.txtTaxRate.TabIndex = 7
        Me.txtTaxRate.Text = "Tax Rate"
        '
        'taxrate
        '
        Me.taxrate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.taxrate.Location = New System.Drawing.Point(38, 269)
        Me.taxrate.Name = "taxrate"
        Me.taxrate.Size = New System.Drawing.Size(180, 19)
        Me.taxrate.TabIndex = 8
        '
        'lblgrossSalary
        '
        Me.lblgrossSalary.AutoSize = True
        Me.lblgrossSalary.ForeColor = System.Drawing.Color.Cyan
        Me.lblgrossSalary.Location = New System.Drawing.Point(356, 91)
        Me.lblgrossSalary.Name = "lblgrossSalary"
        Me.lblgrossSalary.Size = New System.Drawing.Size(55, 13)
        Me.lblgrossSalary.TabIndex = 9
        Me.lblgrossSalary.Text = "Gross Pay"
        '
        'grosspay
        '
        Me.grosspay.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grosspay.Location = New System.Drawing.Point(359, 105)
        Me.grosspay.Name = "grosspay"
        Me.grosspay.Size = New System.Drawing.Size(188, 19)
        Me.grosspay.TabIndex = 10
        '
        'lblammountdeducted
        '
        Me.lblammountdeducted.AutoSize = True
        Me.lblammountdeducted.ForeColor = System.Drawing.Color.Cyan
        Me.lblammountdeducted.Location = New System.Drawing.Point(356, 143)
        Me.lblammountdeducted.Name = "lblammountdeducted"
        Me.lblammountdeducted.Size = New System.Drawing.Size(101, 13)
        Me.lblammountdeducted.TabIndex = 11
        Me.lblammountdeducted.Text = "Ammount Deducted"
        '
        'ammountded
        '
        Me.ammountded.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ammountded.Location = New System.Drawing.Point(359, 157)
        Me.ammountded.Name = "ammountded"
        Me.ammountded.Size = New System.Drawing.Size(188, 19)
        Me.ammountded.TabIndex = 12
        '
        'lblNetSalary
        '
        Me.lblNetSalary.AutoSize = True
        Me.lblNetSalary.ForeColor = System.Drawing.Color.Cyan
        Me.lblNetSalary.Location = New System.Drawing.Point(359, 199)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(56, 13)
        Me.lblNetSalary.TabIndex = 13
        Me.lblNetSalary.Text = "Net Salary"
        '
        'netsal
        '
        Me.netsal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.netsal.Location = New System.Drawing.Point(359, 214)
        Me.netsal.Name = "netsal"
        Me.netsal.Size = New System.Drawing.Size(188, 19)
        Me.netsal.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.Cyan
        Me.btnClear.Location = New System.Drawing.Point(359, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 43)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCalculate.ForeColor = System.Drawing.Color.Cyan
        Me.btnCalculate.Location = New System.Drawing.Point(472, 264)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Padding = New System.Windows.Forms.Padding(10)
        Me.btnCalculate.Size = New System.Drawing.Size(94, 43)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.Cyan
        Me.btnExit.Location = New System.Drawing.Point(706, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 43)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(38, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "denniskibet 2021"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(38, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 51)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'userout
        '
        Me.userout.AutoSize = True
        Me.userout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.userout.Location = New System.Drawing.Point(359, 60)
        Me.userout.Name = "userout"
        Me.userout.Size = New System.Drawing.Size(0, 22)
        Me.userout.TabIndex = 20
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 339)
        Me.Controls.Add(Me.userout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.netsal)
        Me.Controls.Add(Me.lblNetSalary)
        Me.Controls.Add(Me.ammountded)
        Me.Controls.Add(Me.lblammountdeducted)
        Me.Controls.Add(Me.grosspay)
        Me.Controls.Add(Me.lblgrossSalary)
        Me.Controls.Add(Me.taxrate)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.txthoursrate)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtemployeename)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Name = "frmPayroll"
        Me.Text = "Payroll System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtemployeename As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.Label
    Friend WithEvents txthours As System.Windows.Forms.TextBox
    Friend WithEvents txtHourlyRate As System.Windows.Forms.Label
    Friend WithEvents txthoursrate As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxRate As System.Windows.Forms.Label
    Friend WithEvents taxrate As System.Windows.Forms.TextBox
    Friend WithEvents lblgrossSalary As System.Windows.Forms.Label
    Friend WithEvents grosspay As System.Windows.Forms.TextBox
    Friend WithEvents lblammountdeducted As System.Windows.Forms.Label
    Friend WithEvents ammountded As System.Windows.Forms.TextBox
    Friend WithEvents lblNetSalary As System.Windows.Forms.Label
    Friend WithEvents netsal As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents userout As System.Windows.Forms.Label

End Class
