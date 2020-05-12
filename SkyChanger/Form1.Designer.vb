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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.openFileButton = New System.Windows.Forms.Button()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.nsd = New System.Windows.Forms.Label()
        Me.fsd = New System.Windows.Forms.Label()
        Me.nsdTextbox = New System.Windows.Forms.TextBox()
        Me.fsdTextbox = New System.Windows.Forms.TextBox()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.fogcolor = New System.Windows.Forms.Label()
        Me.fogColorTextbox = New System.Windows.Forms.TextBox()
        Me.fogRangeTextbox = New System.Windows.Forms.TextBox()
        Me.fogRange = New System.Windows.Forms.Label()
        Me.helpbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'openFileButton
        '
        Me.openFileButton.Location = New System.Drawing.Point(12, 12)
        Me.openFileButton.Name = "openFileButton"
        Me.openFileButton.Size = New System.Drawing.Size(108, 32)
        Me.openFileButton.TabIndex = 0
        Me.openFileButton.Text = "Open LVL File"
        Me.openFileButton.UseVisualStyleBackColor = True
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Location = New System.Drawing.Point(79, 50)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(183, 20)
        Me.FileNameTextBox.TabIndex = 1
        '
        'nsd
        '
        Me.nsd.AutoSize = True
        Me.nsd.Location = New System.Drawing.Point(47, 178)
        Me.nsd.Name = "nsd"
        Me.nsd.Size = New System.Drawing.Size(99, 13)
        Me.nsd.TabIndex = 2
        Me.nsd.Text = "Near Scene Range"
        '
        'fsd
        '
        Me.fsd.AutoSize = True
        Me.fsd.Location = New System.Drawing.Point(47, 208)
        Me.fsd.Name = "fsd"
        Me.fsd.Size = New System.Drawing.Size(91, 13)
        Me.fsd.TabIndex = 3
        Me.fsd.Text = "Far Scene Range"
        '
        'nsdTextbox
        '
        Me.nsdTextbox.Location = New System.Drawing.Point(180, 175)
        Me.nsdTextbox.Name = "nsdTextbox"
        Me.nsdTextbox.Size = New System.Drawing.Size(100, 20)
        Me.nsdTextbox.TabIndex = 4
        '
        'fsdTextbox
        '
        Me.fsdTextbox.Location = New System.Drawing.Point(180, 205)
        Me.fsdTextbox.Name = "fsdTextbox"
        Me.fsdTextbox.Size = New System.Drawing.Size(100, 20)
        Me.fsdTextbox.TabIndex = 5
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(122, 262)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(75, 23)
        Me.ChangeButton.TabIndex = 6
        Me.ChangeButton.Text = "Change Sky Values"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'fogcolor
        '
        Me.fogcolor.AutoSize = True
        Me.fogcolor.Location = New System.Drawing.Point(47, 105)
        Me.fogcolor.Name = "fogcolor"
        Me.fogcolor.Size = New System.Drawing.Size(52, 13)
        Me.fogcolor.TabIndex = 7
        Me.fogcolor.Text = "Fog Color"
        '
        'fogColorTextbox
        '
        Me.fogColorTextbox.Location = New System.Drawing.Point(180, 102)
        Me.fogColorTextbox.Name = "fogColorTextbox"
        Me.fogColorTextbox.Size = New System.Drawing.Size(100, 20)
        Me.fogColorTextbox.TabIndex = 8
        '
        'fogRangeTextbox
        '
        Me.fogRangeTextbox.Location = New System.Drawing.Point(180, 138)
        Me.fogRangeTextbox.Name = "fogRangeTextbox"
        Me.fogRangeTextbox.Size = New System.Drawing.Size(100, 20)
        Me.fogRangeTextbox.TabIndex = 9
        '
        'fogRange
        '
        Me.fogRange.AutoSize = True
        Me.fogRange.Location = New System.Drawing.Point(47, 141)
        Me.fogRange.Name = "fogRange"
        Me.fogRange.Size = New System.Drawing.Size(60, 13)
        Me.fogRange.TabIndex = 10
        Me.fogRange.Text = "Fog Range"
        '
        'helpbtn
        '
        Me.helpbtn.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.helpbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.helpbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.helpbtn.Location = New System.Drawing.Point(237, 316)
        Me.helpbtn.Name = "helpbtn"
        Me.helpbtn.Size = New System.Drawing.Size(75, 23)
        Me.helpbtn.TabIndex = 11
        Me.helpbtn.Text = "Help"
        Me.helpbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 351)
        Me.Controls.Add(Me.helpbtn)
        Me.Controls.Add(Me.fogRange)
        Me.Controls.Add(Me.fogRangeTextbox)
        Me.Controls.Add(Me.fogColorTextbox)
        Me.Controls.Add(Me.fogcolor)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.fsdTextbox)
        Me.Controls.Add(Me.nsdTextbox)
        Me.Controls.Add(Me.fsd)
        Me.Controls.Add(Me.nsd)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Me.openFileButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Battlefront Sky Changer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents openFileButton As Button
    Friend WithEvents FileNameTextBox As TextBox
    Friend WithEvents nsd As Label
    Friend WithEvents fsd As Label
    Friend WithEvents nsdTextbox As TextBox
    Friend WithEvents fsdTextbox As TextBox
    Friend WithEvents ChangeButton As Button
    Friend WithEvents fogcolor As Label
    Friend WithEvents fogColorTextbox As TextBox
    Friend WithEvents fogRangeTextbox As TextBox
    Friend WithEvents fogRange As Label
    Friend WithEvents helpbtn As Button
End Class
