<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_giorniMese
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
        Me.txt_mese = New System.Windows.Forms.TextBox()
        Me.lbl_mese = New System.Windows.Forms.Label()
        Me.lbl_giorni = New System.Windows.Forms.Label()
        Me.btn_assegna = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_esci = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_mese
        '
        Me.txt_mese.Location = New System.Drawing.Point(79, 57)
        Me.txt_mese.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_mese.Name = "txt_mese"
        Me.txt_mese.Size = New System.Drawing.Size(110, 23)
        Me.txt_mese.TabIndex = 0
        '
        'lbl_mese
        '
        Me.lbl_mese.AutoSize = True
        Me.lbl_mese.Location = New System.Drawing.Point(13, 64)
        Me.lbl_mese.Name = "lbl_mese"
        Me.lbl_mese.Size = New System.Drawing.Size(38, 15)
        Me.lbl_mese.TabIndex = 1
        Me.lbl_mese.Text = "Mese:"
        '
        'lbl_giorni
        '
        Me.lbl_giorni.AutoSize = True
        Me.lbl_giorni.Location = New System.Drawing.Point(13, 102)
        Me.lbl_giorni.Name = "lbl_giorni"
        Me.lbl_giorni.Size = New System.Drawing.Size(0, 15)
        Me.lbl_giorni.TabIndex = 2
        '
        'btn_assegna
        '
        Me.btn_assegna.Location = New System.Drawing.Point(13, 150)
        Me.btn_assegna.Name = "btn_assegna"
        Me.btn_assegna.Size = New System.Drawing.Size(75, 23)
        Me.btn_assegna.TabIndex = 3
        Me.btn_assegna.Text = "Assegna"
        Me.btn_assegna.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(94, 150)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 4
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_esci
        '
        Me.btn_esci.Location = New System.Drawing.Point(175, 150)
        Me.btn_esci.Name = "btn_esci"
        Me.btn_esci.Size = New System.Drawing.Size(75, 23)
        Me.btn_esci.TabIndex = 5
        Me.btn_esci.Text = "Esci"
        Me.btn_esci.UseVisualStyleBackColor = True
        '
        'frm_giorniMese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 192)
        Me.Controls.Add(Me.btn_esci)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_assegna)
        Me.Controls.Add(Me.lbl_giorni)
        Me.Controls.Add(Me.lbl_mese)
        Me.Controls.Add(Me.txt_mese)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_giorniMese"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcolo dei giorni nei mesi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_mese As TextBox
    Friend WithEvents lbl_mese As Label
    Friend WithEvents lbl_giorni As Label
    Friend WithEvents btn_assegna As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_esci As Button
End Class
