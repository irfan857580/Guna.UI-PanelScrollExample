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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.GunaHScrollBar1 = New Guna.UI.WinForms.GunaHScrollBar()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(36, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 332)
        Me.Panel1.TabIndex = 0
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaVScrollBar1.LargeChange = 10
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(631, 47)
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(10, 200)
        Me.GunaVScrollBar1.TabIndex = 0
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'GunaHScrollBar1
        '
        Me.GunaHScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaHScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaHScrollBar1.LargeChange = 10
        Me.GunaHScrollBar1.Location = New System.Drawing.Point(36, 392)
        Me.GunaHScrollBar1.Maximum = 100
        Me.GunaHScrollBar1.Name = "GunaHScrollBar1"
        Me.GunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver
        Me.GunaHScrollBar1.Size = New System.Drawing.Size(200, 10)
        Me.GunaHScrollBar1.TabIndex = 1
        Me.GunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray
        Me.GunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray
        Me.GunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 441)
        Me.Controls.Add(Me.GunaHScrollBar1)
        Me.Controls.Add(Me.GunaVScrollBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents GunaHScrollBar1 As Guna.UI.WinForms.GunaHScrollBar
End Class
