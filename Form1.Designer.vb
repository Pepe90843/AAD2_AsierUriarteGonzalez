<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblPeliculas = New Label()
        pbINTERESTELAR = New PictureBox()
        pbPRIMATE = New PictureBox()
        pbVELOCIPASTOR = New PictureBox()
        pbPIJAMARAYAS = New PictureBox()
        pbPEORVECINO = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Button1 = New Button()
        btSalir = New Button()
        lblHora = New Label()
        CType(pbINTERESTELAR, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbPRIMATE, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbVELOCIPASTOR, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbPIJAMARAYAS, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbPEORVECINO, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPeliculas
        ' 
        lblPeliculas.AutoSize = True
        lblPeliculas.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeliculas.Location = New Point(43, 34)
        lblPeliculas.Name = "lblPeliculas"
        lblPeliculas.Size = New Size(203, 46)
        lblPeliculas.TabIndex = 0
        lblPeliculas.Text = "PELÍCULAS:"
        ' 
        ' pbINTERESTELAR
        ' 
        pbINTERESTELAR.ImageLocation = "https://i.redd.it/fui-assistir-interestelar-pela-primeira-vez-no-reprise-de-v0-g2p75retb9de1.jpg?width=683&format=pjpg&auto=webp&s=eccbd25ffb3e516f5b749d09ddd7c635367dff8b"
        pbINTERESTELAR.Location = New Point(78, 151)
        pbINTERESTELAR.Name = "pbINTERESTELAR"
        pbINTERESTELAR.Size = New Size(203, 290)
        pbINTERESTELAR.SizeMode = PictureBoxSizeMode.StretchImage
        pbINTERESTELAR.TabIndex = 1
        pbINTERESTELAR.TabStop = False
        ' 
        ' pbPRIMATE
        ' 
        pbPRIMATE.ImageLocation = "https://www.moviementarios.com/wp-content/uploads/2025/09/primate-poster.jpg"
        pbPRIMATE.Location = New Point(301, 151)
        pbPRIMATE.Name = "pbPRIMATE"
        pbPRIMATE.Size = New Size(203, 290)
        pbPRIMATE.SizeMode = PictureBoxSizeMode.StretchImage
        pbPRIMATE.TabIndex = 2
        pbPRIMATE.TabStop = False
        ' 
        ' pbVELOCIPASTOR
        ' 
        pbVELOCIPASTOR.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRfucoolW9BhrZDYGdbeY__x3qLqyYwucX5og&s"
        pbVELOCIPASTOR.Location = New Point(528, 151)
        pbVELOCIPASTOR.Name = "pbVELOCIPASTOR"
        pbVELOCIPASTOR.Size = New Size(203, 290)
        pbVELOCIPASTOR.SizeMode = PictureBoxSizeMode.StretchImage
        pbVELOCIPASTOR.TabIndex = 3
        pbVELOCIPASTOR.TabStop = False
        ' 
        ' pbPIJAMARAYAS
        ' 
        pbPIJAMARAYAS.ImageLocation = "https://www.aceprensa.com/wp-content/uploads/2008/09/14574-0.jpg"
        pbPIJAMARAYAS.Location = New Point(751, 151)
        pbPIJAMARAYAS.Name = "pbPIJAMARAYAS"
        pbPIJAMARAYAS.Size = New Size(203, 290)
        pbPIJAMARAYAS.SizeMode = PictureBoxSizeMode.StretchImage
        pbPIJAMARAYAS.TabIndex = 4
        pbPIJAMARAYAS.TabStop = False
        ' 
        ' pbPEORVECINO
        ' 
        pbPEORVECINO.ImageLocation = "https://lh3.googleusercontent.com/pw/AIL4fc84M7qI0DL8mHlw64cePcD4UXzoOYAxbp5rJzg-mk6-U1fnE7H3Rj_pKoHhishUjsAXagf4vNt217BLB1ZPgKpyibLZBP5P_NH9EeXSD7S8vtkIo5x4=w2400"
        pbPEORVECINO.Location = New Point(979, 151)
        pbPEORVECINO.Name = "pbPEORVECINO"
        pbPEORVECINO.Size = New Size(203, 290)
        pbPEORVECINO.SizeMode = PictureBoxSizeMode.StretchImage
        pbPEORVECINO.TabIndex = 5
        pbPEORVECINO.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 444)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 31)
        Label1.TabIndex = 6
        Label1.Text = "INTERESTELAR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(355, 444)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 31)
        Label2.TabIndex = 7
        Label2.Text = "PRIMATE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(521, 444)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 31)
        Label3.TabIndex = 8
        Label3.Text = "THE VELOCIPASTOR"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(751, 444)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 62)
        Label4.TabIndex = 9
        Label4.Text = "EL NIÑO CON EL" & vbCrLf & "PIJAMA DE RAYAS"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(992, 444)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 62)
        Label5.TabIndex = 10
        Label5.Text = "EL PEOR VECINO" & vbCrLf & "DEL MUNDO"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(156, 486)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 11
        Label6.Text = "SALA 1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(382, 486)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 12
        Label7.Text = "SALA 3"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(606, 486)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 20)
        Label8.TabIndex = 13
        Label8.Text = "SALA 7"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(825, 515)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 14
        Label9.Text = "SALA 5"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1056, 515)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 20)
        Label10.TabIndex = 15
        Label10.Text = "SALA 10"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1056, 542)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 54)
        Button1.TabIndex = 16
        Button1.Text = "C R E D I T O S"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btSalir
        ' 
        btSalir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btSalir.Location = New Point(29, 542)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(124, 46)
        btSalir.TabIndex = 17
        btSalir.Text = "S A L I R"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Location = New Point(1095, 21)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(61, 20)
        lblHora.TabIndex = 18
        lblHora.Text = "Label11"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1250, 633)
        Controls.Add(lblHora)
        Controls.Add(btSalir)
        Controls.Add(Button1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbPEORVECINO)
        Controls.Add(pbPIJAMARAYAS)
        Controls.Add(pbVELOCIPASTOR)
        Controls.Add(pbPRIMATE)
        Controls.Add(pbINTERESTELAR)
        Controls.Add(lblPeliculas)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Películas"
        CType(pbINTERESTELAR, ComponentModel.ISupportInitialize).EndInit()
        CType(pbPRIMATE, ComponentModel.ISupportInitialize).EndInit()
        CType(pbVELOCIPASTOR, ComponentModel.ISupportInitialize).EndInit()
        CType(pbPIJAMARAYAS, ComponentModel.ISupportInitialize).EndInit()
        CType(pbPEORVECINO, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPeliculas As Label
    Friend WithEvents pbINTERESTELAR As PictureBox
    Friend WithEvents pbPRIMATE As PictureBox
    Friend WithEvents pbVELOCIPASTOR As PictureBox
    Friend WithEvents pbPIJAMARAYAS As PictureBox
    Friend WithEvents pbPEORVECINO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents lblHora As Label

End Class
