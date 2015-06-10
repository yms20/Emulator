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
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
    Me.TextBox2_SucheLinks = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TextBox3 = New System.Windows.Forms.TextBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.TextBox5_SucheRechts = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
    Me.GroupBox1.SuspendLayout
    Me.GroupBox2.SuspendLayout
    Me.SuspendLayout
    '
    'TextBox1
    '
    Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TextBox1.Location = New System.Drawing.Point(3, 16)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(1014, 20)
    Me.TextBox1.TabIndex = 0
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'OpenFileDialog2
    '
    Me.OpenFileDialog2.FileName = "OpenFileDialog2"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(6, 144)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(86, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Time Stamp Size"
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Location = New System.Drawing.Point(98, 137)
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(61, 20)
    Me.NumericUpDown1.TabIndex = 2
    Me.NumericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
    '
    'TextBox2_SucheLinks
    '
    Me.TextBox2_SucheLinks.Location = New System.Drawing.Point(184, 42)
    Me.TextBox2_SucheLinks.Multiline = true
    Me.TextBox2_SucheLinks.Name = "TextBox2_SucheLinks"
    Me.TextBox2_SucheLinks.Size = New System.Drawing.Size(316, 115)
    Me.TextBox2_SucheLinks.TabIndex = 3
    Me.TextBox2_SucheLinks.Text = "left AU: START_MOTION"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"left AU: PICKER_HOOKON"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"left AU: PICKER_HOOKOFF_LAST"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"left"& _ 
    " AU: OUTPUT_SAFE"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"left AU: COMPARTMENT_SAFE_BRINGBACK"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"left AU: WegVonGegenseite"& _ 
    ""
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(81, 45)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(97, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Such Pattern Links"
    '
    'TextBox3
    '
    Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBox3.Location = New System.Drawing.Point(3, 16)
    Me.TextBox3.Multiline = true
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(1014, 158)
    Me.TextBox3.TabIndex = 6
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.TextBox3)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 189)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(1020, 177)
    Me.GroupBox1.TabIndex = 7
    Me.GroupBox1.TabStop = false
    Me.GroupBox1.Text = "Result"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.Button2)
    Me.GroupBox2.Controls.Add(Me.TextBox5_SucheRechts)
    Me.GroupBox2.Controls.Add(Me.Label4)
    Me.GroupBox2.Controls.Add(Me.Button1)
    Me.GroupBox2.Controls.Add(Me.TextBox1)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
    Me.GroupBox2.Controls.Add(Me.TextBox2_SucheLinks)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(1020, 189)
    Me.GroupBox2.TabIndex = 8
    Me.GroupBox2.TabStop = false
    Me.GroupBox2.Text = "Search"
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(875, 45)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 11
    Me.Button2.Text = "Connect"
    Me.Button2.UseVisualStyleBackColor = true
    '
    'TextBox5_SucheRechts
    '
    Me.TextBox5_SucheRechts.Location = New System.Drawing.Point(553, 45)
    Me.TextBox5_SucheRechts.Multiline = true
    Me.TextBox5_SucheRechts.Name = "TextBox5_SucheRechts"
    Me.TextBox5_SucheRechts.Size = New System.Drawing.Size(316, 112)
    Me.TextBox5_SucheRechts.TabIndex = 10
    Me.TextBox5_SucheRechts.Text = "right AU: START_MOTION"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"right AU: PICKER_HOOKON"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"right AU: PICKER_HOOKOFF_LAST"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"r"& _ 
    "ight AU: OUTPUT_SAFE"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"right AU: COMPARTMENT_SAFE_BRINGBACK"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"right AU: WegVonGege"& _ 
    "nseite"
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(506, 45)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(41, 13)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "Rechts"
    '
    'Button1
    '
    Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Button1.Location = New System.Drawing.Point(3, 163)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(1014, 23)
    Me.Button1.TabIndex = 6
    Me.Button1.Text = "Search"
    Me.Button1.UseVisualStyleBackColor = true
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1020, 366)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.GroupBox2)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
    Me.GroupBox1.ResumeLayout(false)
    Me.GroupBox1.PerformLayout
    Me.GroupBox2.ResumeLayout(false)
    Me.GroupBox2.PerformLayout
    Me.ResumeLayout(false)

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox2_SucheLinks As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5_SucheRechts As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
