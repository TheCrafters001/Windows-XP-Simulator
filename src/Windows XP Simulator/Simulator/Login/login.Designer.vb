<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.userName_lbl = New System.Windows.Forms.Label()
        Me.userName_txtBox = New System.Windows.Forms.TextBox()
        Me.passWord_txtBox = New System.Windows.Forms.TextBox()
        Me.passWord_lbl = New System.Windows.Forms.Label()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Windows_XP_Simulator.My.Resources.Resources.XP
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'userName_lbl
        '
        Me.userName_lbl.AutoSize = True
        Me.userName_lbl.Location = New System.Drawing.Point(12, 112)
        Me.userName_lbl.Name = "userName_lbl"
        Me.userName_lbl.Size = New System.Drawing.Size(61, 13)
        Me.userName_lbl.TabIndex = 1
        Me.userName_lbl.Text = "User name:"
        '
        'userName_txtBox
        '
        Me.userName_txtBox.Location = New System.Drawing.Point(118, 109)
        Me.userName_txtBox.Name = "userName_txtBox"
        Me.userName_txtBox.Size = New System.Drawing.Size(234, 20)
        Me.userName_txtBox.TabIndex = 2
        '
        'passWord_txtBox
        '
        Me.passWord_txtBox.Location = New System.Drawing.Point(118, 135)
        Me.passWord_txtBox.Name = "passWord_txtBox"
        Me.passWord_txtBox.Size = New System.Drawing.Size(234, 20)
        Me.passWord_txtBox.TabIndex = 4
        Me.passWord_txtBox.UseSystemPasswordChar = True
        '
        'passWord_lbl
        '
        Me.passWord_lbl.AutoSize = True
        Me.passWord_lbl.Location = New System.Drawing.Point(12, 138)
        Me.passWord_lbl.Name = "passWord_lbl"
        Me.passWord_lbl.Size = New System.Drawing.Size(56, 13)
        Me.passWord_lbl.TabIndex = 3
        Me.passWord_lbl.Text = "Password:"
        '
        'ok_btn
        '
        Me.ok_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_btn.Location = New System.Drawing.Point(243, 167)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.ok_btn.TabIndex = 5
        Me.ok_btn.Text = "OK"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel_btn.Enabled = False
        Me.cancel_btn.Location = New System.Drawing.Point(324, 167)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 6
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AcceptButton = Me.ok_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel_btn
        Me.ClientSize = New System.Drawing.Size(411, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.passWord_txtBox)
        Me.Controls.Add(Me.passWord_lbl)
        Me.Controls.Add(Me.userName_txtBox)
        Me.Controls.Add(Me.userName_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log On to Windows"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents userName_lbl As Label
    Friend WithEvents userName_txtBox As TextBox
    Friend WithEvents passWord_txtBox As TextBox
    Friend WithEvents passWord_lbl As Label
    Friend WithEvents ok_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
