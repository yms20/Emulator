<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.plots = New System.Windows.Forms.TableLayoutPanel()
    Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
    Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
    Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
    Me.FlowLayoutMotorControls = New System.Windows.Forms.FlowLayoutPanel()
    Me.ScenePlotter1 = New EmulatorConfigurationTester.scenePlotter()
    Me.TabContainer1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btLoad = New System.Windows.Forms.Button()
    Me.btClear = New System.Windows.Forms.Button()
    Me.tbConfigPath = New System.Windows.Forms.TextBox()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SplitContainer2.Panel1.SuspendLayout
    Me.SplitContainer2.Panel2.SuspendLayout
    Me.SplitContainer2.SuspendLayout
    CType(Me.SplitContainer3,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SplitContainer3.Panel1.SuspendLayout
    Me.SplitContainer3.Panel2.SuspendLayout
    Me.SplitContainer3.SuspendLayout
    Me.TabContainer1.SuspendLayout
    Me.TabPage1.SuspendLayout
    Me.Panel1.SuspendLayout
    Me.TabPage2.SuspendLayout
    Me.TabPage3.SuspendLayout
    Me.TabPage4.SuspendLayout
    CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'TextBox1
    '
    Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBox1.Location = New System.Drawing.Point(3, 52)
    Me.TextBox1.Multiline = true
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.TextBox1.Size = New System.Drawing.Size(273, 435)
    Me.TextBox1.TabIndex = 0
    Me.TextBox1.Text = "Press F1 for help."
    '
    'plots
    '
    Me.plots.AutoSize = true
    Me.plots.ColumnCount = 1
    Me.plots.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
    Me.plots.Dock = System.Windows.Forms.DockStyle.Fill
    Me.plots.Location = New System.Drawing.Point(3, 3)
    Me.plots.Name = "plots"
    Me.plots.RowCount = 12
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.plots.Size = New System.Drawing.Size(273, 484)
    Me.plots.TabIndex = 4
    '
    'PropertyGrid1
    '
    Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
    Me.PropertyGrid1.Name = "PropertyGrid1"
    Me.PropertyGrid1.Size = New System.Drawing.Size(273, 484)
    Me.PropertyGrid1.TabIndex = 6
    '
    'SplitContainer2
    '
    Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer2.Name = "SplitContainer2"
    '
    'SplitContainer2.Panel1
    '
    Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
    Me.SplitContainer2.Panel1MinSize = 250
    '
    'SplitContainer2.Panel2
    '
    Me.SplitContainer2.Panel2.Controls.Add(Me.TabContainer1)
    Me.SplitContainer2.Panel2MinSize = 10
    Me.SplitContainer2.Size = New System.Drawing.Size(820, 518)
    Me.SplitContainer2.SplitterDistance = 527
    Me.SplitContainer2.TabIndex = 8
    '
    'SplitContainer3
    '
    Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer3.Name = "SplitContainer3"
    Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer3.Panel1
    '
    Me.SplitContainer3.Panel1.Controls.Add(Me.FlowLayoutMotorControls)
    '
    'SplitContainer3.Panel2
    '
    Me.SplitContainer3.Panel2.Controls.Add(Me.ScenePlotter1)
    Me.SplitContainer3.Size = New System.Drawing.Size(525, 516)
    Me.SplitContainer3.SplitterDistance = 132
    Me.SplitContainer3.TabIndex = 7
    '
    'FlowLayoutMotorControls
    '
    Me.FlowLayoutMotorControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutMotorControls.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutMotorControls.Name = "FlowLayoutMotorControls"
    Me.FlowLayoutMotorControls.Size = New System.Drawing.Size(525, 132)
    Me.FlowLayoutMotorControls.TabIndex = 6
    '
    'ScenePlotter1
    '
    Me.ScenePlotter1.BackColor = System.Drawing.Color.SteelBlue
    Me.ScenePlotter1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ScenePlotter1.Location = New System.Drawing.Point(0, 0)
    Me.ScenePlotter1.Name = "ScenePlotter1"
    Me.ScenePlotter1.scale = 1.7R
    Me.ScenePlotter1.Size = New System.Drawing.Size(525, 380)
    Me.ScenePlotter1.TabIndex = 5
    '
    'TabContainer1
    '
    Me.TabContainer1.Controls.Add(Me.TabPage1)
    Me.TabContainer1.Controls.Add(Me.TabPage2)
    Me.TabContainer1.Controls.Add(Me.TabPage3)
    Me.TabContainer1.Controls.Add(Me.TabPage4)
    Me.TabContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabContainer1.Location = New System.Drawing.Point(0, 0)
    Me.TabContainer1.Name = "TabContainer1"
    Me.TabContainer1.SelectedIndex = 0
    Me.TabContainer1.Size = New System.Drawing.Size(287, 516)
    Me.TabContainer1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TextBox1)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(279, 490)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Open"
    Me.TabPage1.UseVisualStyleBackColor = true
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btLoad)
    Me.Panel1.Controls.Add(Me.btClear)
    Me.Panel1.Controls.Add(Me.tbConfigPath)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(273, 49)
    Me.Panel1.TabIndex = 9
    '
    'btLoad
    '
    Me.btLoad.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btLoad.Location = New System.Drawing.Point(0, 20)
    Me.btLoad.Name = "btLoad"
    Me.btLoad.Size = New System.Drawing.Size(198, 29)
    Me.btLoad.TabIndex = 7
    Me.btLoad.Text = "Load"
    Me.btLoad.UseVisualStyleBackColor = true
    '
    'btClear
    '
    Me.btClear.Dock = System.Windows.Forms.DockStyle.Right
    Me.btClear.Location = New System.Drawing.Point(198, 20)
    Me.btClear.Name = "btClear"
    Me.btClear.Size = New System.Drawing.Size(75, 29)
    Me.btClear.TabIndex = 6
    Me.btClear.Text = "Clear"
    Me.btClear.UseVisualStyleBackColor = true
    '
    'tbConfigPath
    '
    Me.tbConfigPath.Dock = System.Windows.Forms.DockStyle.Top
    Me.tbConfigPath.Location = New System.Drawing.Point(0, 0)
    Me.tbConfigPath.Name = "tbConfigPath"
    Me.tbConfigPath.Size = New System.Drawing.Size(273, 20)
    Me.tbConfigPath.TabIndex = 8
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.PropertyGrid1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(279, 490)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Config"
    Me.TabPage2.UseVisualStyleBackColor = true
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.plots)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(279, 490)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Monitor"
    Me.TabPage3.UseVisualStyleBackColor = true
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.NumericUpDown1)
    Me.TabPage4.Controls.Add(Me.ComboBox1)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(279, 490)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "Control"
    Me.TabPage4.UseVisualStyleBackColor = true
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Dock = System.Windows.Forms.DockStyle.Top
    Me.NumericUpDown1.Location = New System.Drawing.Point(3, 24)
    Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(273, 20)
    Me.NumericUpDown1.TabIndex = 1
    '
    'ComboBox1
    '
    Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBox1.FormattingEnabled = true
    Me.ComboBox1.Location = New System.Drawing.Point(3, 3)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(273, 21)
    Me.ComboBox1.TabIndex = 0
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(820, 518)
    Me.Controls.Add(Me.SplitContainer2)
    Me.Name = "MainForm"
    Me.Text = "Main Form"
    Me.SplitContainer2.Panel1.ResumeLayout(false)
    Me.SplitContainer2.Panel2.ResumeLayout(false)
    CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
    Me.SplitContainer2.ResumeLayout(false)
    Me.SplitContainer3.Panel1.ResumeLayout(false)
    Me.SplitContainer3.Panel2.ResumeLayout(false)
    CType(Me.SplitContainer3,System.ComponentModel.ISupportInitialize).EndInit
    Me.SplitContainer3.ResumeLayout(false)
    Me.TabContainer1.ResumeLayout(false)
    Me.TabPage1.ResumeLayout(false)
    Me.TabPage1.PerformLayout
    Me.Panel1.ResumeLayout(false)
    Me.Panel1.PerformLayout
    Me.TabPage2.ResumeLayout(false)
    Me.TabPage3.ResumeLayout(false)
    Me.TabPage3.PerformLayout
    Me.TabPage4.ResumeLayout(false)
    CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents plots As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ScenePlotter1 As EmulatorConfigurationTester.scenePlotter
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents tbConfigPath As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutMotorControls As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabContainer1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
