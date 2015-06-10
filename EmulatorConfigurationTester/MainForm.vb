Imports EmulatorAPI

Public Class MainForm
Dim  a as  Achse = Achse.config1

Dim achsen As new List(Of Achse )

Dim controller As New Controller 

Sub loadConfig(machineConfig As String )
 Try
      a.motor.powerOff 
      If machineConfig.Contains ("<Achsen>")
        achsen =  XML.readFromString ( Of Achsen )  ( machineConfig ).Achsen 
        For Each a As Achse In achsen
          addAchse ( a ) 
        Next
      Else 
        a =   XML.readFromString ( Of Achse )  ( machineConfig)
        addAchse ( a ) 
      End If

    Catch ex As Exception
      TextBox1.AppendText (ex.ToString ) 
    End Try
End Sub

'create achsen controller gui elements and signal handlers
Sub addAchse(a As Achse, optional recursive as boolean = false) 
  a.setConnections
  Dim uiachse As New UIAchse

  uiachse.setFromAchse (a) 
  FlowLayoutMotorControls.Controls.Add(uiachse )
  AddHandler uiachse.doubleClicked , AddressOf TableLayoutPanel1_MouseClick 
      
  If a.geber.plot.enabled  
    Dim plotty As New Plotter with {.max = a.geber.max - 1, .min = a.geber.min +1, .scaleMode = Plotter.scaleModes.Fixed  }
    AddHandler a.geber.movedTo , AddressOf plotty.addValue 
        
    plots.Controls.Add(plotty )
    plotty.Dock = DockStyle.Fill 
    plotty.BackColor = Color.White 
    'Zeichne nur hauptachsen in ScenePlotter
    If Not recursive 
      ScenePlotter1.achsen.Add (a )
    End If

  End If

  'get in deep recursivly
  For Each sa As Achse In a.geber.SubAchsen 
    addAchse (sa,True  ) 
  Next

End Sub

Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

if e.Control and e.KeyCode = Keys.A
    textBox1.SelectAll()
End If

  If (e.KeyCode = Keys.F1) Then
    TextBox1.AppendText("- F1 print out this help instructions" & Environment.NewLine)
    TextBox1.AppendText("- F2 print out default Config " & Environment.NewLine)
    TextBox1.AppendText("- F3 deserialize marked Area" & Environment.NewLine)
    TextBox1.AppendText("- F4 print out Test Stuff" & Environment.NewLine)
    TextBox1.AppendText("- F5 print out current Config " & Environment.NewLine)
  End If

  If (e.KeyCode = Keys.F2) Then
    TextBox1.AppendText ( XML.toXMLString(Of Achse)  ( a) )
  End If

  If (e.KeyCode = Keys.F3) Then
   loadConfig(TextBox1.SelectedText ) 
  End If

  If (e.KeyCode = Keys.F4) Then
    Dim ac As Achse = Achse.config1 
    ac.geber.SubAchsen.Add ( Achse.config1 )
    ac.geber.SubAchsen(0).geber = New GeberRotation 
    TextBox1.AppendText ( XML.toXMLString(Of Achse)  ( ac) )
  End If

  If (e.KeyCode = Keys.F5) Then
  Dim achsenn As new achsen
  achsenn.Achsen = achsen 
   TextBox1.AppendText ( XML.toXMLString(Of Achsen)  ( achsenn ) )
  End If
End Sub
 


Private Sub Form1_FormClosing( sender As Object,  e As FormClosingEventArgs) Handles MyBase.FormClosing
  Motor.global_emulating = false
End Sub


Private Sub TableLayoutPanel1_MouseClick( sender As Object,  e As MouseEventArgs) 

  
  For Each  uiAchse As UIAchse In Me.FlowLayoutMotorControls.Controls 
    uiAchse.BorderStyle = BorderStyle.None 
    uiAchse.BackColor = Color.DimGray 

  Next
  

  Dim text As String = e.Location.ToString
  
  Dim hit As Object  =  sender
  If (Not IsNothing ( hit ))
    If  hit.GetType  is GetType (UIAchse )
      Dim uiachse As UIAchse = CType (hit,UIAchse ) 
      uiachse.BorderStyle  = BorderStyle.FixedSingle  
      uiAchse.BackColor = Color.SteelBlue 

      a = uiachse.a 
      hit = a 
    End If
    text += Environment.NewLine 
    text += hit.ToString 
  End If

'  MsgBox (text )
  PropertyGrid1.SelectedObject =  hit 
End Sub

Private Sub btClear_Click( sender As Object,  e As EventArgs) Handles btClear.Click
  Motor.global_emulating = false
  Threading.Thread.Sleep (201)
  Motor.global_emulating = True
  FlowLayoutMotorControls.Controls.Clear 
  plots.Controls.Clear
  ScenePlotter1.achsen.Clear
  achsen.Clear 
  
End Sub

Private Sub tbConfigPath_MouseDoubleClick( sender As Object,  e As MouseEventArgs) Handles tbConfigPath.MouseDoubleClick
  Dim loader As New OpenFileDialog
  loader.Filter = "*.xml|"
  loader.InitialDirectory = My.Settings.ConfigPath 
  If (loader.ShowDialog = Windows.Forms.DialogResult.OK )
    tbConfigPath.Text = loader.FileName 
    My.Settings.ConfigPath = loader.FileName 
    My.Settings.Save 
  End If

End Sub

Private Sub MainForm_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
  tbConfigPath.Text = My.Settings.ConfigPath 
End Sub

Private Sub btLoad_Click( sender As Object,  e As EventArgs) Handles btLoad.Click
  Try
    achsen =  XML.read ( Of Achsen )  ( tbConfigPath.Text  ).Achsen 
    For Each a As Achse In achsen
      addAchse ( a ) 
    Next
  Catch ex As Exception
    TextBox1.AppendText (ex.ToString )
  End Try
End Sub

Private Sub TabPage4_Click( sender As Object,  e As EventArgs) Handles TabPage4.Click

End Sub


sub fillControllComboRec ( achsen As List(Of Achse) )

  For Each  a As Achse In achsen
    ComboBox1.Items.Add (  a) 
    If a.geber.SubAchsen.Count > 0
      fillControllComboRec (a.geber.SubAchsen )
    End If
  Next

End Sub

Private Sub TabPage4_DoubleClick( sender As Object,  e As EventArgs) Handles TabPage4.DoubleClick
  ComboBox1.Items.Clear 
  fillControllComboRec (achsen) 

End Sub

Private Sub ComboBox1_SelectedIndexChanged( sender As Object,  e As EventArgs) Handles ComboBox1.SelectedIndexChanged
  Dim currentAchse as Achse = CType (ComboBox1.SelectedItem , Achse ) 
  controller.input = currentAchse.geber 
  controller.output = currentAchse.motor 

  PropertyGrid1.SelectedObject = controller   
End Sub

Private Sub NumericUpDown1_ValueChanged( sender As Object,  e As EventArgs) Handles NumericUpDown1.ValueChanged
  controller.startMove(NumericUpDown1.Value)
End Sub

Private Sub ScenePlotter1_Load( sender As Object,  e As EventArgs) Handles ScenePlotter1.Load

End Sub
End Class
