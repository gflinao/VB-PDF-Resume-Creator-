<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResCre
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
        Me.BtnGen = New System.Windows.Forms.Button()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnGen
        '
        Me.BtnGen.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnGen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGen.ForeColor = System.Drawing.Color.White
        Me.BtnGen.Location = New System.Drawing.Point(198, 76)
        Me.BtnGen.Name = "BtnGen"
        Me.BtnGen.Size = New System.Drawing.Size(118, 44)
        Me.BtnGen.TabIndex = 0
        Me.BtnGen.Text = "Generate"
        Me.BtnGen.UseVisualStyleBackColor = False
        '
        'BtnExt
        '
        Me.BtnExt.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnExt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExt.ForeColor = System.Drawing.Color.White
        Me.BtnExt.Location = New System.Drawing.Point(198, 126)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(118, 44)
        Me.BtnExt.TabIndex = 1
        Me.BtnExt.Text = "Exit"
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'ResCre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PDF_Resume_Creator_VB.My.Resources.Resources.bgres
        Me.ClientSize = New System.Drawing.Size(328, 182)
        Me.Controls.Add(Me.BtnExt)
        Me.Controls.Add(Me.BtnGen)
        Me.Name = "ResCre"
        Me.Text = "PDF Resume Creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnGen As Button
    Friend WithEvents BtnExt As Button
End Class
