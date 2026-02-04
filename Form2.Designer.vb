<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbPelicula = New PictureBox()
        lblTitulo = New Label()
        btVenderEntradas = New Button()
        Label1 = New Label()
        lblEstreno = New Label()
        Label2 = New Label()
        lblDuracion = New Label()
        Label3 = New Label()
        lblPrecio = New Label()
        Label4 = New Label()
        btVolver = New Button()
        tbSinopsis = New TextBox()
        CType(pbPelicula, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbPelicula
        ' 
        pbPelicula.Location = New Point(59, 59)
        pbPelicula.Name = "pbPelicula"
        pbPelicula.Size = New Size(267, 373)
        pbPelicula.SizeMode = PictureBoxSizeMode.StretchImage
        pbPelicula.TabIndex = 0
        pbPelicula.TabStop = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.Location = New Point(342, 59)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(99, 31)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "TITULO"
        ' 
        ' btVenderEntradas
        ' 
        btVenderEntradas.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btVenderEntradas.Location = New Point(59, 449)
        btVenderEntradas.Name = "btVenderEntradas"
        btVenderEntradas.Size = New Size(267, 44)
        btVenderEntradas.TabIndex = 2
        btVenderEntradas.Text = "Vender entradas"
        btVenderEntradas.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(342, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 3
        Label1.Text = "Año de estreno:"
        ' 
        ' lblEstreno
        ' 
        lblEstreno.AutoSize = True
        lblEstreno.Location = New Point(461, 100)
        lblEstreno.Name = "lblEstreno"
        lblEstreno.Size = New Size(58, 20)
        lblEstreno.TabIndex = 4
        lblEstreno.Text = "estreno"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(342, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 5
        Label2.Text = "Duración:"
        ' 
        ' lblDuracion
        ' 
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(424, 131)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(67, 20)
        lblDuracion.TabIndex = 6
        lblDuracion.Text = "duracion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(342, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 7
        Label3.Text = "Precio entrada:"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(461, 166)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(51, 20)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(342, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 9
        Label4.Text = "Sinopsis:"
        ' 
        ' btVolver
        ' 
        btVolver.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btVolver.Location = New Point(699, 449)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(143, 44)
        btVolver.TabIndex = 11
        btVolver.Text = "V O L V E R"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' tbSinopsis
        ' 
        tbSinopsis.BackColor = SystemColors.Info
        tbSinopsis.Enabled = False
        tbSinopsis.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbSinopsis.ForeColor = SystemColors.ActiveCaptionText
        tbSinopsis.Location = New Point(342, 228)
        tbSinopsis.Multiline = True
        tbSinopsis.Name = "tbSinopsis"
        tbSinopsis.Size = New Size(491, 204)
        tbSinopsis.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(877, 538)
        Controls.Add(tbSinopsis)
        Controls.Add(btVolver)
        Controls.Add(Label4)
        Controls.Add(lblPrecio)
        Controls.Add(Label3)
        Controls.Add(lblDuracion)
        Controls.Add(Label2)
        Controls.Add(lblEstreno)
        Controls.Add(Label1)
        Controls.Add(btVenderEntradas)
        Controls.Add(lblTitulo)
        Controls.Add(pbPelicula)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pelicula Seleccionada"
        CType(pbPelicula, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbPelicula As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btVenderEntradas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEstreno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btVolver As Button
    Friend WithEvents tbSinopsis As TextBox
End Class
