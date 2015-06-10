Imports EmulatorAPI

Public Class UIAchse
Implements IFromAchse

Public Event doubleClicked (sender As Object,  e As MouseEventArgs)

  Public a As Achse

  Public Sub setFromAchse (a As Achse)  Implements IFromAchse.setFromAchse
    Me.a = a
    TableLayoutPanel1.Controls.Clear 
    lbAxisName.Text = a.name 
    UiMotor1.setFromAchse (a)
    UiGeber1.setFromAchse (a)
    setupSignalsFromAchse (a) 


  End Sub

  sub handleSignal (sender as Aggregat)

  End Sub

Class SignalBox 
Inherits CheckBox 
Sub new (s As signal )
Text = s.name 
Checked = s.isTriggered 
  AddHandler s.triggered   , AddressOf  signalHandler 
  AddHandler s.untriggered , AddressOf  signalHandler 
End Sub

Function signalHandler(sender As Aggregat )
  setCheckbox(CType (sender,Signal ).isTriggered )
End Function

Function setCheckbox ( value As Boolean )
  If Not Me.IsHandleCreated 
    Return Nothing 
  End If
  If InvokeRequired 
    Invoke (Function () setCheckbox (  value))
  else
    Checked = value 
  End If 
End Function

End Class

'Erzeuge checkboxen für jeden signal und verbinde die events
'triggered und untriggered des signals mit einem handler in
'der jeweiligen checkbox
Sub setupSignalsFromAchse (a As Achse ) 
For Each s As signal In a.Signals 

  Dim sb As new SignalBox (s)
  TableLayoutPanel1.Controls.Add (sb)
Next

End Sub


Private Sub UIAchse_MouseDoubleClick( sender As Object,  e As MouseEventArgs) Handles MyBase.MouseDoubleClick
  RaiseEvent  doubleClicked (me, e)
End Sub


Private Sub TableLayoutPanel1_DoubleClick( sender As Object,  e As EventArgs) Handles TableLayoutPanel1.DoubleClick
RaiseEvent  doubleClicked (me, e)
End Sub

Private Sub SplitContainer1_Panel1_DoubleClick( sender As Object,  e As EventArgs) Handles SplitContainer1.Panel1.DoubleClick
RaiseEvent  doubleClicked (me, e)
End Sub
Private Sub SplitContainer1_Panel2_DoubleClick( sender As Object,  e As EventArgs) Handles SplitContainer1.Panel2.DoubleClick
RaiseEvent  doubleClicked (me, e)
End Sub
End Class
