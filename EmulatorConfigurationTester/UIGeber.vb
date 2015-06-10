Imports EmulatorAPI

Public Class UIGeber
Implements IFromAchse

WithEvents g As Geber

Dim lastLocation As Double = 0

Public Sub handleMove(sender As Aggregat , location As Double ) Handles g.movedTo 
lastLocation = location 
End Sub

Public Sub handleEndPosReached (sender As Aggregat , state As Geber.Extreme ) Handles g.endPosReached 
  Select Case state
    Case Geber.Extreme.max 
      lbMax.BackColor = Color.Yellow 
    Case Geber.Extreme.min  
      lbMin.BackColor = Color.Yellow 

  End Select
End Sub
Public Sub setFromAchse(a As Achse ) Implements IFromAchse.setFromAchse 
  setGeber (a.geber )
End Sub

Public Sub  setGeber (g as Geber ) 


  me.g = g 
  lbLoc.Text = String.Format ("loc: {0:0.000}" ,g.location  )
  lbMax.Text = String.Format ("max: {0:0.000}" ,g.max   )
  lbMin.Text = String.Format ("min: {0:0.000}" ,g.min   )

End Sub

Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
  lbLoc.Text = String.Format ("loc: {0:0.000}" ,lastLocation   )
  
  If IsNothing (g)
    Return 
  End If
  If (lastLocation < g.max and lastLocation > g.min)
    lbMax.BackColor = Color.FromKnownColor(KnownColor.Window ) 
    lbMin.BackColor = Color.FromKnownColor(KnownColor.Window ) 
  End If

End Sub
End Class
