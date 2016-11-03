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
        Me.txtAsm = New System.Windows.Forms.TextBox()
        Me.btnInj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAsm
        '
        Me.txtAsm.AcceptsReturn = True
        Me.txtAsm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAsm.Location = New System.Drawing.Point(12, 12)
        Me.txtAsm.Multiline = True
        Me.txtAsm.Name = "txtAsm"
        Me.txtAsm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAsm.Size = New System.Drawing.Size(468, 204)
        Me.txtAsm.TabIndex = 0
        '
        'btnInj
        '
        Me.btnInj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInj.Location = New System.Drawing.Point(185, 243)
        Me.btnInj.Name = "btnInj"
        Me.btnInj.Size = New System.Drawing.Size(75, 23)
        Me.btnInj.TabIndex = 1
        Me.btnInj.Text = "Inj"
        Me.btnInj.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 278)
        Me.Controls.Add(Me.btnInj)
        Me.Controls.Add(Me.txtAsm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAsm As TextBox
    Friend WithEvents btnInj As Button
End Class
