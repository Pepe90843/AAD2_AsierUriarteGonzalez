<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Creditos))
        pbPerfil = New PictureBox()
        Label1 = New Label()
        lblRepos = New Label()
        lblNombre = New Label()
        btVolver = New Button()
        CType(pbPerfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbPerfil
        ' 
        pbPerfil.Location = New Point(71, 146)
        pbPerfil.Name = "pbPerfil"
        pbPerfil.Size = New Size(274, 292)
        pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbPerfil.TabIndex = 1
        pbPerfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 20)
        Label1.TabIndex = 2
        Label1.Text = "Repositorios públicos:"
        ' 
        ' lblRepos
        ' 
        lblRepos.AutoSize = True
        lblRepos.Location = New Point(258, 97)
        lblRepos.Name = "lblRepos"
        lblRepos.Size = New Size(46, 20)
        lblRepos.TabIndex = 3
        lblRepos.Text = "repos"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(97, 26)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(176, 54)
        lblNombre.TabIndex = 4
        lblNombre.Text = "nombre"
        ' 
        ' btVolver
        ' 
        btVolver.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btVolver.Location = New Point(258, 467)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(153, 55)
        btVolver.TabIndex = 5
        btVolver.Text = "V O L V E R"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' Creditos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(423, 534)
        Controls.Add(btVolver)
        Controls.Add(lblNombre)
        Controls.Add(lblRepos)
        Controls.Add(Label1)
        Controls.Add(pbPerfil)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Creditos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Creditos"
        CType(pbPerfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pbPerfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRepos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents btVolver As Button
End Class
