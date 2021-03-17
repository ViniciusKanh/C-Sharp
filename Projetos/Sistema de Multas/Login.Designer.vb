<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'btnLogar
        '
        Me.btnLogar.BackColor = System.Drawing.Color.Transparent
        Me.btnLogar.BackgroundImage = CType(resources.GetObject("btnLogar.BackgroundImage"), System.Drawing.Image)
        Me.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogar.FlatAppearance.BorderSize = 0
        Me.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogar.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogar.Location = New System.Drawing.Point(126, 138)
        Me.btnLogar.Name = "btnLogar"
        Me.btnLogar.Size = New System.Drawing.Size(88, 60)
        Me.btnLogar.TabIndex = 1
        Me.btnLogar.Text = "Entrar"
        Me.btnLogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(189, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(23, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sistema de Registro de Multas"
        '
        'btnsair
        '
        Me.btnsair.BackColor = System.Drawing.Color.Transparent
        Me.btnsair.BackgroundImage = CType(resources.GetObject("btnsair.BackgroundImage"), System.Drawing.Image)
        Me.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsair.FlatAppearance.BorderSize = 0
        Me.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.ForeColor = System.Drawing.Color.Transparent
        Me.btnsair.Location = New System.Drawing.Point(237, 138)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(88, 60)
        Me.btnsair.TabIndex = 7
        Me.btnsair.Text = "Sair"
        Me.btnsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsair.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsair As Button
End Class
