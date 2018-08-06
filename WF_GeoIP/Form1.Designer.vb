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
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.btnConsultaCep = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(13, 13)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(29, 13)
        Me.lblCep.TabIndex = 0
        Me.lblCep.Text = "Cep:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(16, 29)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(483, 20)
        Me.txtCep.TabIndex = 1
        '
        'btnConsultaCep
        '
        Me.btnConsultaCep.Location = New System.Drawing.Point(16, 55)
        Me.btnConsultaCep.Name = "btnConsultaCep"
        Me.btnConsultaCep.Size = New System.Drawing.Size(483, 23)
        Me.btnConsultaCep.TabIndex = 2
        Me.btnConsultaCep.Text = "Consultar Cep"
        Me.btnConsultaCep.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(13, 123)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "Resultado"
        '
        'lbResultado
        '
        Me.lbResultado.FormattingEnabled = True
        Me.lbResultado.Location = New System.Drawing.Point(16, 139)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(441, 186)
        Me.lbResultado.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnConsultaCep)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCep As Label
    Friend WithEvents txtCep As TextBox
    Friend WithEvents btnConsultaCep As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents lbResultado As ListBox
End Class
