<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Startingup
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.winInfo_lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.progressBoot_progr = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Windows_XP_Simulator.My.Resources.Resources.XP_Animated
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'winInfo_lbl
        '
        Me.winInfo_lbl.AutoSize = True
        Me.winInfo_lbl.Location = New System.Drawing.Point(12, 94)
        Me.winInfo_lbl.Name = "winInfo_lbl"
        Me.winInfo_lbl.Size = New System.Drawing.Size(122, 13)
        Me.winInfo_lbl.TabIndex = 2
        Me.winInfo_lbl.Text = "Windows is starting up..."
        '
        'Timer1
        '
        '
        'progressBoot_progr
        '
        Me.progressBoot_progr.Location = New System.Drawing.Point(311, 111)
        Me.progressBoot_progr.Name = "progressBoot_progr"
        Me.progressBoot_progr.Size = New System.Drawing.Size(100, 23)
        Me.progressBoot_progr.TabIndex = 3
        Me.progressBoot_progr.Visible = False
        '
        'Panel_Startingup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.progressBoot_progr)
        Me.Controls.Add(Me.winInfo_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Panel_Startingup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Wait..."
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents winInfo_lbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents progressBoot_progr As ProgressBar
End Class
