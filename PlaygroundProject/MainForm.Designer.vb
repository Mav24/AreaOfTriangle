<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstBase = New System.Windows.Forms.ListBox()
        Me.lstHeight = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBase
        '
        Me.lstBase.FormattingEnabled = True
        Me.lstBase.ItemHeight = 15
        Me.lstBase.Location = New System.Drawing.Point(12, 31)
        Me.lstBase.Name = "lstBase"
        Me.lstBase.Size = New System.Drawing.Size(120, 94)
        Me.lstBase.TabIndex = 0
        '
        'lstHeight
        '
        Me.lstHeight.FormattingEnabled = True
        Me.lstHeight.ItemHeight = 15
        Me.lstHeight.Location = New System.Drawing.Point(152, 31)
        Me.lstHeight.Name = "lstHeight"
        Me.lstHeight.Size = New System.Drawing.Size(120, 94)
        Me.lstHeight.TabIndex = 0
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 15
        Me.lstPrice.Location = New System.Drawing.Point(291, 31)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(120, 94)
        Me.lstPrice.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Base:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price per Sq. Ft.:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(336, 162)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area:"
        '
        'lblArea
        '
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(16, 162)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(98, 27)
        Me.lblArea.TabIndex = 3
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cost:"
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost.Location = New System.Drawing.Point(152, 162)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(98, 27)
        Me.lblCost.TabIndex = 3
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 218)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstHeight)
        Me.Controls.Add(Me.lstBase)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate Area of a Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBase As ListBox
    Friend WithEvents lstHeight As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCost As Label
End Class
