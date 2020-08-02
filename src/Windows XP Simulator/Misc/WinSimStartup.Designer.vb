<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinSimStartup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinSimStartup))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.startup_lbl = New System.Windows.Forms.Label()
        Me.install_btn = New System.Windows.Forms.Button()
        Me.toggleMusic = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Windows_XP_Simulator.My.Resources.Resources.windows_xp_withtext
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(323, 372)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(75, 23)
        Me.start_btn.TabIndex = 1
        Me.start_btn.Text = "Start Now"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'startup_lbl
        '
        Me.startup_lbl.Location = New System.Drawing.Point(12, 279)
        Me.startup_lbl.Name = "startup_lbl"
        Me.startup_lbl.Size = New System.Drawing.Size(386, 90)
        Me.startup_lbl.TabIndex = 2
        Me.startup_lbl.Text = resources.GetString("startup_lbl.Text")
        '
        'install_btn
        '
        Me.install_btn.Location = New System.Drawing.Point(12, 372)
        Me.install_btn.Name = "install_btn"
        Me.install_btn.Size = New System.Drawing.Size(105, 23)
        Me.install_btn.TabIndex = 3
        Me.install_btn.Text = "Practice Installing"
        Me.install_btn.UseVisualStyleBackColor = True
        '
        'toggleMusic
        '
        Me.toggleMusic.Location = New System.Drawing.Point(0, 0)
        Me.toggleMusic.Name = "toggleMusic"
        Me.toggleMusic.Size = New System.Drawing.Size(81, 23)
        Me.toggleMusic.TabIndex = 4
        Me.toggleMusic.Text = "Music Toggle"
        Me.toggleMusic.UseVisualStyleBackColor = True
        '
        'WinSimStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 407)
        Me.Controls.Add(Me.toggleMusic)
        Me.Controls.Add(Me.install_btn)
        Me.Controls.Add(Me.startup_lbl)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinSimStartup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows XP Simulator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents start_btn As Button
    Friend WithEvents startup_lbl As Label
    Friend WithEvents install_btn As Button
    Friend WithEvents toggleMusic As Button
End Class
