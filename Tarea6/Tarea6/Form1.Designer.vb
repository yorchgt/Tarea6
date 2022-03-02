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
        Me.btnAmenos = New System.Windows.Forms.Button()
        Me.btnAmas = New System.Windows.Forms.Button()
        Me.btnBmenos = New System.Windows.Forms.Button()
        Me.btnBmas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAmenos
        '
        Me.btnAmenos.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAmenos.Location = New System.Drawing.Point(106, 68)
        Me.btnAmenos.Name = "btnAmenos"
        Me.btnAmenos.Size = New System.Drawing.Size(52, 58)
        Me.btnAmenos.TabIndex = 0
        Me.btnAmenos.Text = "-"
        Me.btnAmenos.UseVisualStyleBackColor = True
        '
        'btnAmas
        '
        Me.btnAmas.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAmas.Location = New System.Drawing.Point(270, 70)
        Me.btnAmas.Name = "btnAmas"
        Me.btnAmas.Size = New System.Drawing.Size(50, 54)
        Me.btnAmas.TabIndex = 1
        Me.btnAmas.Text = "+"
        Me.btnAmas.UseVisualStyleBackColor = True
        '
        'btnBmenos
        '
        Me.btnBmenos.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBmenos.Location = New System.Drawing.Point(106, 186)
        Me.btnBmenos.Name = "btnBmenos"
        Me.btnBmenos.Size = New System.Drawing.Size(52, 57)
        Me.btnBmenos.TabIndex = 2
        Me.btnBmenos.Text = "-"
        Me.btnBmenos.UseVisualStyleBackColor = True
        '
        'btnBmas
        '
        Me.btnBmas.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBmas.Location = New System.Drawing.Point(270, 186)
        Me.btnBmas.Name = "btnBmas"
        Me.btnBmas.Size = New System.Drawing.Size(50, 57)
        Me.btnBmas.TabIndex = 3
        Me.btnBmas.Text = "+"
        Me.btnBmas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(14, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblA.Location = New System.Drawing.Point(198, 77)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(35, 41)
        Me.lblA.TabIndex = 6
        Me.lblA.Text = "0"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblB.Location = New System.Drawing.Point(198, 194)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(35, 41)
        Me.lblB.TabIndex = 7
        Me.lblB.Text = "0"
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblresultado.Location = New System.Drawing.Point(151, 328)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(219, 41)
        Me.lblresultado.TabIndex = 8
        Me.lblresultado.Text = "El resultado es:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(470, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Suma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Resta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(468, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 35)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Multiplicacion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(470, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 26)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Division"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(685, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(288, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 41)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "201222719"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBmas)
        Me.Controls.Add(Me.btnBmenos)
        Me.Controls.Add(Me.btnAmas)
        Me.Controls.Add(Me.btnAmenos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAmenos As Button
    Friend WithEvents btnAmas As Button
    Friend WithEvents btnBmenos As Button
    Friend WithEvents btnBmas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblresultado As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
End Class
