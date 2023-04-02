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
        Me.picMicrophone = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboChoices = New System.Windows.Forms.ComboBox()
        Me.lblChoiceTitle = New System.Windows.Forms.Label()
        Me.txtNumOfSongs = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picMicrophone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMicrophone
        '
        Me.picMicrophone.BackgroundImage = Global.Kareoke_app.My.Resources.Resources.karaoke
        Me.picMicrophone.Location = New System.Drawing.Point(3, 2)
        Me.picMicrophone.Name = "picMicrophone"
        Me.picMicrophone.Size = New System.Drawing.Size(344, 492)
        Me.picMicrophone.TabIndex = 0
        Me.picMicrophone.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(422, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(294, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Karaoke Music Night"
        '
        'cboChoices
        '
        Me.cboChoices.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChoices.FormattingEnabled = True
        Me.cboChoices.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboChoices.Location = New System.Drawing.Point(428, 140)
        Me.cboChoices.Name = "cboChoices"
        Me.cboChoices.Size = New System.Drawing.Size(288, 26)
        Me.cboChoices.TabIndex = 2
        Me.cboChoices.Text = "Customize your Night"
        '
        'lblChoiceTitle
        '
        Me.lblChoiceTitle.AutoSize = True
        Me.lblChoiceTitle.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoiceTitle.ForeColor = System.Drawing.Color.White
        Me.lblChoiceTitle.Location = New System.Drawing.Point(468, 224)
        Me.lblChoiceTitle.Name = "lblChoiceTitle"
        Me.lblChoiceTitle.Size = New System.Drawing.Size(0, 18)
        Me.lblChoiceTitle.TabIndex = 3
        Me.lblChoiceTitle.Visible = False
        '
        'txtNumOfSongs
        '
        Me.txtNumOfSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfSongs.Location = New System.Drawing.Point(549, 273)
        Me.txtNumOfSongs.Name = "txtNumOfSongs"
        Me.txtNumOfSongs.Size = New System.Drawing.Size(37, 26)
        Me.txtNumOfSongs.TabIndex = 4
        Me.txtNumOfSongs.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(381, 336)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(142, 36)
        Me.btnTotalCost.TabIndex = 5
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        Me.btnTotalCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(612, 336)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 36)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(381, 417)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(63, 19)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Label1"
        Me.lblTotalCost.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtNumOfSongs)
        Me.Controls.Add(Me.lblChoiceTitle)
        Me.Controls.Add(Me.cboChoices)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMicrophone)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMicrophone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMicrophone As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboChoices As ComboBox
    Friend WithEvents lblChoiceTitle As Label
    Friend WithEvents txtNumOfSongs As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
