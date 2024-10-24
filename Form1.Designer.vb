<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_id = New TextBox()
        txt_nome = New TextBox()
        msk_nota = New MaskedTextBox()
        btn_create = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        dg_alunos = New DataGridView()
        CType(dg_alunos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(96, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 31)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(54, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 31)
        Label2.TabIndex = 1
        Label2.Text = "Nome"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(66, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 31)
        Label3.TabIndex = 2
        Label3.Text = "Nota"
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_id.Location = New Point(136, 57)
        txt_id.Name = "txt_id"
        txt_id.ReadOnly = True
        txt_id.Size = New Size(61, 34)
        txt_id.TabIndex = 3
        txt_id.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_nome
        ' 
        txt_nome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_nome.Location = New Point(136, 144)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(604, 34)
        txt_nome.TabIndex = 4
        ' 
        ' msk_nota
        ' 
        msk_nota.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        msk_nota.Location = New Point(136, 230)
        msk_nota.Mask = "00"
        msk_nota.Name = "msk_nota"
        msk_nota.Size = New Size(55, 34)
        msk_nota.TabIndex = 5
        msk_nota.TextAlign = HorizontalAlignment.Center
        ' 
        ' btn_create
        ' 
        btn_create.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_create.Location = New Point(71, 308)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(93, 43)
        btn_create.TabIndex = 6
        btn_create.Text = "Create"
        btn_create.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_update.Location = New Point(184, 308)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(93, 43)
        btn_update.TabIndex = 7
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_delete.Location = New Point(298, 308)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(93, 43)
        btn_delete.TabIndex = 8
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' dg_alunos
        ' 
        dg_alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_alunos.Location = New Point(31, 380)
        dg_alunos.Name = "dg_alunos"
        dg_alunos.RowHeadersWidth = 51
        dg_alunos.RowTemplate.Height = 29
        dg_alunos.Size = New Size(709, 236)
        dg_alunos.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 628)
        Controls.Add(dg_alunos)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_create)
        Controls.Add(msk_nota)
        Controls.Add(txt_nome)
        Controls.Add(txt_id)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD"
        CType(dg_alunos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents msk_nota As MaskedTextBox
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents dg_alunos As DataGridView
End Class
