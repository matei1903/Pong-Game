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
        Me.components = New System.ComponentModel.Container()
        Me.miscare_bila = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.control_obstacol = New System.Windows.Forms.PictureBox()
        Me.control_bila = New System.Windows.Forms.PictureBox()
        Me.control_paleta = New System.Windows.Forms.PictureBox()
        Me.obstacol2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.control_obstacol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.control_bila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.control_paleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obstacol2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'miscare_bila
        '
        Me.miscare_bila.Enabled = True
        Me.miscare_bila.Interval = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(715, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vieti : "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(752, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(700, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Puncte :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(752, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 5
        '
        'control_obstacol
        '
        Me.control_obstacol.Location = New System.Drawing.Point(508, 83)
        Me.control_obstacol.Name = "control_obstacol"
        Me.control_obstacol.Size = New System.Drawing.Size(70, 25)
        Me.control_obstacol.TabIndex = 6
        Me.control_obstacol.TabStop = False
        '
        'control_bila
        '
        Me.control_bila.Location = New System.Drawing.Point(315, 189)
        Me.control_bila.Name = "control_bila"
        Me.control_bila.Size = New System.Drawing.Size(40, 40)
        Me.control_bila.TabIndex = 1
        Me.control_bila.TabStop = False
        '
        'control_paleta
        '
        Me.control_paleta.Location = New System.Drawing.Point(315, 403)
        Me.control_paleta.Name = "control_paleta"
        Me.control_paleta.Size = New System.Drawing.Size(200, 25)
        Me.control_paleta.TabIndex = 0
        Me.control_paleta.TabStop = False
        '
        'obstacol2
        '
        Me.obstacol2.Location = New System.Drawing.Point(65, 51)
        Me.obstacol2.Name = "obstacol2"
        Me.obstacol2.Size = New System.Drawing.Size(70, 25)
        Me.obstacol2.TabIndex = 7
        Me.obstacol2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Multiplayer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.obstacol2)
        Me.Controls.Add(Me.control_obstacol)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.control_bila)
        Me.Controls.Add(Me.control_paleta)
        Me.Name = "Form1"
        Me.Text = "Pong"
        CType(Me.control_obstacol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.control_bila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.control_paleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obstacol2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents control_paleta As PictureBox
    Friend WithEvents control_bila As PictureBox
    Friend WithEvents miscare_bila As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents control_obstacol As PictureBox
    Friend WithEvents obstacol2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
