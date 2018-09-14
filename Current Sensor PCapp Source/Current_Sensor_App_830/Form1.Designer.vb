<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbbCOMPorts = New System.Windows.Forms.ComboBox()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.cmdDisconnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClearReceive = New System.Windows.Forms.Button()
        Me.cBar = New CircularProgressBar.CircularProgressBar()
        Me.cbarFullRange = New CircularProgressBar.CircularProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbbCOMPorts
        '
        Me.cbbCOMPorts.FormattingEnabled = True
        Me.cbbCOMPorts.Location = New System.Drawing.Point(673, 91)
        Me.cbbCOMPorts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbbCOMPorts.Name = "cbbCOMPorts"
        Me.cbbCOMPorts.Size = New System.Drawing.Size(270, 28)
        Me.cbbCOMPorts.TabIndex = 0
        '
        'cmdConnect
        '
        Me.cmdConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.Location = New System.Drawing.Point(951, 91)
        Me.cmdConnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(176, 42)
        Me.cmdConnect.TabIndex = 1
        Me.cmdConnect.Text = "&Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisconnect.Location = New System.Drawing.Point(951, 135)
        Me.cmdDisconnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.Size = New System.Drawing.Size(176, 40)
        Me.cmdDisconnect.TabIndex = 2
        Me.cmdDisconnect.Text = "&Disconnect"
        Me.cmdDisconnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(667, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available COM Ports"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(673, 135)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(270, 40)
        Me.lblMessage.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1045, 781)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Receive Data"
        '
        'txtReceive
        '
        Me.txtReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceive.Location = New System.Drawing.Point(1203, 742)
        Me.txtReceive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReceive.Multiline = True
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(291, 161)
        Me.txtReceive.TabIndex = 14
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 50
        '
        'cmdClearReceive
        '
        Me.cmdClearReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearReceive.Location = New System.Drawing.Point(1050, 830)
        Me.cmdClearReceive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdClearReceive.Name = "cmdClearReceive"
        Me.cmdClearReceive.Size = New System.Drawing.Size(174, 40)
        Me.cmdClearReceive.TabIndex = 16
        Me.cmdClearReceive.Text = "Clea&r"
        Me.cmdClearReceive.UseVisualStyleBackColor = True
        '
        'cBar
        '
        Me.cBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.cBar.AnimationSpeed = 500
        Me.cBar.BackColor = System.Drawing.Color.Transparent
        Me.cBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cBar.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cBar.InnerMargin = 2
        Me.cBar.InnerWidth = -1
        Me.cBar.Location = New System.Drawing.Point(35, 25)
        Me.cBar.MarqueeAnimationSpeed = 2000
        Me.cBar.Maximum = 35
        Me.cBar.Name = "cBar"
        Me.cBar.OuterColor = System.Drawing.Color.Gray
        Me.cBar.OuterMargin = -25
        Me.cBar.OuterWidth = 25
        Me.cBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cBar.ProgressWidth = 65
        Me.cBar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBar.Size = New System.Drawing.Size(599, 595)
        Me.cBar.StartAngle = 270
        Me.cBar.Step = 1
        Me.cBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cBar.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cBar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.cBar.SubscriptText = ""
        Me.cBar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cBar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.cBar.SuperscriptText = ""
        Me.cBar.TabIndex = 17
        Me.cBar.Text = "Current"
        Me.cBar.TextMargin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.cBar.Value = 35
        '
        'cbarFullRange
        '
        Me.cbarFullRange.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.cbarFullRange.AnimationSpeed = 500
        Me.cbarFullRange.BackColor = System.Drawing.Color.Transparent
        Me.cbarFullRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbarFullRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbarFullRange.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbarFullRange.InnerMargin = 2
        Me.cbarFullRange.InnerWidth = -1
        Me.cbarFullRange.Location = New System.Drawing.Point(733, 550)
        Me.cbarFullRange.MarqueeAnimationSpeed = 2000
        Me.cbarFullRange.Maximum = 65
        Me.cbarFullRange.Name = "cbarFullRange"
        Me.cbarFullRange.OuterColor = System.Drawing.Color.Gray
        Me.cbarFullRange.OuterMargin = -25
        Me.cbarFullRange.OuterWidth = 25
        Me.cbarFullRange.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbarFullRange.ProgressWidth = 65
        Me.cbarFullRange.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbarFullRange.Size = New System.Drawing.Size(296, 298)
        Me.cbarFullRange.StartAngle = 270
        Me.cbarFullRange.Step = 1
        Me.cbarFullRange.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cbarFullRange.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cbarFullRange.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.cbarFullRange.SubscriptText = ""
        Me.cbarFullRange.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cbarFullRange.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.cbarFullRange.SuperscriptText = ""
        Me.cbarFullRange.TabIndex = 18
        Me.cbarFullRange.Text = "Current"
        Me.cbarFullRange.TextMargin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.cbarFullRange.Value = 65
        Me.cbarFullRange.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Amps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1224, 545)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Full Range"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 697)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbarFullRange)
        Me.Controls.Add(Me.cBar)
        Me.Controls.Add(Me.cmdClearReceive)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cbbCOMPorts)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Current Sensor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbCOMPorts As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents cmdDisconnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReceive As System.Windows.Forms.TextBox
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents cmdClearReceive As System.Windows.Forms.Button
    Friend WithEvents cBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents cbarFullRange As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
