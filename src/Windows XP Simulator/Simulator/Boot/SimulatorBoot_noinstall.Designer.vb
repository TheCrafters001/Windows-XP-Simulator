<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimulatorBoot_noinstall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BootScreen_Animated = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.BootScreen_Animated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BootScreen_Animated
        '
        Me.BootScreen_Animated.Image = Global.Windows_XP_Simulator.My.Resources.Resources.BootScreen
        Me.BootScreen_Animated.Location = New System.Drawing.Point(77, 57)
        Me.BootScreen_Animated.Name = "BootScreen_Animated"
        Me.BootScreen_Animated.Size = New System.Drawing.Size(640, 480)
        Me.BootScreen_Animated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BootScreen_Animated.TabIndex = 0
        Me.BootScreen_Animated.TabStop = False
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 565)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'SimulatorBoot_noinstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BootScreen_Animated)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SimulatorBoot_noinstall"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimulatorBoot_noinstall"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BootScreen_Animated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BootScreen_Animated As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
