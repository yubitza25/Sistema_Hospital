﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarPacientes
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
        BtnModificar = New Button()
        BtnAgregar = New Button()
        BtnEliminar = New Button()
        LblBuscar = New Label()
        BtnBuscar = New Button()
        DgTablaPacientes = New DataGridView()
        TbBuscar = New TextBox()
        LblTitulo = New Label()
        Panel1 = New Panel()
        CType(DgTablaPacientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnModificar
        ' 
        BtnModificar.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        BtnModificar.Cursor = Cursors.Hand
        BtnModificar.FlatStyle = FlatStyle.Flat
        BtnModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnModificar.ForeColor = Color.White
        BtnModificar.Location = New Point(525, 424)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(97, 44)
        BtnModificar.TabIndex = 20
        BtnModificar.Text = "Modificar"
        BtnModificar.UseVisualStyleBackColor = False
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnAgregar.Cursor = Cursors.Hand
        BtnAgregar.FlatStyle = FlatStyle.Flat
        BtnAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAgregar.ForeColor = Color.White
        BtnAgregar.Location = New Point(422, 424)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(97, 44)
        BtnAgregar.TabIndex = 19
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.Red
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEliminar.ForeColor = Color.White
        BtnEliminar.Location = New Point(628, 424)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(97, 44)
        BtnEliminar.TabIndex = 18
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' LblBuscar
        ' 
        LblBuscar.AutoSize = True
        LblBuscar.Location = New Point(125, 106)
        LblBuscar.Name = "LblBuscar"
        LblBuscar.Size = New Size(55, 20)
        LblBuscar.TabIndex = 17
        LblBuscar.Text = "Buscar:"
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackgroundImage = My.Resources.Resources.buscar1
        BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        BtnBuscar.Cursor = Cursors.Hand
        BtnBuscar.Location = New Point(535, 103)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(35, 34)
        BtnBuscar.TabIndex = 16
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' DgTablaPacientes
        ' 
        DgTablaPacientes.BackgroundColor = SystemColors.ButtonFace
        DgTablaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgTablaPacientes.Location = New Point(129, 162)
        DgTablaPacientes.Name = "DgTablaPacientes"
        DgTablaPacientes.RowHeadersWidth = 51
        DgTablaPacientes.Size = New Size(596, 239)
        DgTablaPacientes.TabIndex = 15
        ' 
        ' TbBuscar
        ' 
        TbBuscar.ForeColor = SystemColors.ActiveCaptionText
        TbBuscar.Location = New Point(186, 103)
        TbBuscar.Multiline = True
        TbBuscar.Name = "TbBuscar"
        TbBuscar.PlaceholderText = "Ingrese nombre de usuario"
        TbBuscar.Size = New Size(343, 34)
        TbBuscar.TabIndex = 14
        ' 
        ' LblTitulo
        ' 
        LblTitulo.AutoSize = True
        LblTitulo.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitulo.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        LblTitulo.Location = New Point(326, 46)
        LblTitulo.Name = "LblTitulo"
        LblTitulo.Size = New Size(193, 28)
        LblTitulo.TabIndex = 34
        LblTitulo.Text = "Listar pacientes"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 22)
        Panel1.TabIndex = 35
        ' 
        ' FrmListarPacientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(825, 500)
        Controls.Add(Panel1)
        Controls.Add(LblTitulo)
        Controls.Add(BtnModificar)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(LblBuscar)
        Controls.Add(BtnBuscar)
        Controls.Add(DgTablaPacientes)
        Controls.Add(TbBuscar)
        Name = "FrmListarPacientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmListarPacientes"
        CType(DgTablaPacientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblBuscar As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DgTablaPacientes As DataGridView
    Friend WithEvents TbBuscar As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Panel1 As Panel
End Class
