<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Entradas = New NumericUpDown()
        Label1 = New Label()
        btComprar = New Button()
        Label2 = New Label()
        lblEntradas = New Label()
        btVolver = New Button()
        CType(Entradas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Entradas
        ' 
        Entradas.Location = New Point(129, 144)
        Entradas.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Entradas.Name = "Entradas"
        Entradas.Size = New Size(150, 27)
        Entradas.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 31)
        Label1.TabIndex = 1
        Label1.Text = "¿CUANTAS ENTRADAS DESEA?"
        ' 
        ' btComprar
        ' 
        btComprar.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btComprar.Location = New Point(59, 190)
        btComprar.Name = "btComprar"
        btComprar.Size = New Size(289, 95)
        btComprar.TabIndex = 2
        btComprar.Text = "C O M P R A R"
        btComprar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 3
        Label2.Text = "Entradas disponibles:"
        ' 
        ' lblEntradas
        ' 
        lblEntradas.AutoSize = True
        lblEntradas.Location = New Point(232, 100)
        lblEntradas.Name = "lblEntradas"
        lblEntradas.Size = New Size(66, 20)
        lblEntradas.TabIndex = 4
        lblEntradas.Text = "entradas"
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(308, 303)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(94, 29)
        btVolver.TabIndex = 5
        btVolver.Text = "V O L V E R"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(414, 368)
        Controls.Add(btVolver)
        Controls.Add(lblEntradas)
        Controls.Add(Label2)
        Controls.Add(btComprar)
        Controls.Add(Label1)
        Controls.Add(Entradas)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Comprar entradas"
        CType(Entradas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Entradas As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btComprar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEntradas As Label
    Friend WithEvents btVolver As Button
End Class
