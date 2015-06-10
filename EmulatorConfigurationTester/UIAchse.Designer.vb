<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIAchse
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Dim Motor1 As EmulatorAPI.Motor = New EmulatorAPI.Motor()
    Me.lbAxisName = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.UiMotor1 = New EmulatorConfigurationTester.UIMotor()
    Me.UiGeber1 = New EmulatorConfigurationTester.UIGeber()
    CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SplitContainer1.Panel1.SuspendLayout
    Me.SplitContainer1.Panel2.SuspendLayout
    Me.SplitContainer1.SuspendLayout
    Me.SuspendLayout
    '
    'lbAxisName
    '
    Me.lbAxisName.AutoSize = true
    Me.lbAxisName.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbAxisName.Location = New System.Drawing.Point(82, 0)
    Me.lbAxisName.Name = "lbAxisName"
    Me.lbAxisName.Size = New System.Drawing.Size(54, 13)
    Me.lbAxisName.TabIndex = 4
    Me.lbAxisName.Text = "AxisName"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.AutoSize = true
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(70, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(70, 52)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
    Me.SplitContainer1.Panel1MinSize = 15
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.UiMotor1)
    Me.SplitContainer1.Panel2.Controls.Add(Me.lbAxisName)
    Me.SplitContainer1.Panel2.Controls.Add(Me.UiGeber1)
    Me.SplitContainer1.Panel2MinSize = 85
    Me.SplitContainer1.Size = New System.Drawing.Size(243, 52)
    Me.SplitContainer1.SplitterDistance = 25
    Me.SplitContainer1.TabIndex = 5
    '
    'UiMotor1
    '
    Me.UiMotor1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.UiMotor1.Location = New System.Drawing.Point(82, 32)
    Motor1.direction = 0
    Motor1.id = 0
    Motor1.name = "Motor"
    Motor1.rpm_current = 0R
    Motor1.rpm_max = 60R
    Motor1.rpm_max_ramp = 500R
    Motor1.rpm_target = 50R
    Me.UiMotor1.m = Motor1
    Me.UiMotor1.Name = "UiMotor1"
    Me.UiMotor1.Size = New System.Drawing.Size(132, 20)
    Me.UiMotor1.TabIndex = 1
    '
    'UiGeber1
    '
    Me.UiGeber1.Dock = System.Windows.Forms.DockStyle.Left
    Me.UiGeber1.Location = New System.Drawing.Point(0, 0)
    Me.UiGeber1.Name = "UiGeber1"
    Me.UiGeber1.Size = New System.Drawing.Size(82, 52)
    Me.UiGeber1.TabIndex = 2
    '
    'UIAchse
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.DimGray
    Me.Controls.Add(Me.SplitContainer1)
    Me.Name = "UIAchse"
    Me.Size = New System.Drawing.Size(243, 52)
    Me.SplitContainer1.Panel1.ResumeLayout(false)
    Me.SplitContainer1.Panel1.PerformLayout
    Me.SplitContainer1.Panel2.ResumeLayout(false)
    Me.SplitContainer1.Panel2.PerformLayout
    CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
    Me.SplitContainer1.ResumeLayout(false)
    Me.ResumeLayout(false)

End Sub
    Friend WithEvents UiMotor1 As EmulatorConfigurationTester.UIMotor
    Friend WithEvents UiGeber1 As EmulatorConfigurationTester.UIGeber
    Friend WithEvents lbAxisName As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
