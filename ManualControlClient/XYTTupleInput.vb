Public Class XYTTupleInput

Enum automatenseite  
  right
  left
End Enum
Private m_side As automatenseite 

Public Property Side As automatenseite 
Get
  Return m_side 
End Get
Set
  Select Value
   Case automatenseite.left 
  GroupBox1.Text = "Linker Greifer"  
  Case automatenseite.right 
  GroupBox1.Text = "Rechter Greifer"  
  End Select
  m_side = Value 
End Set
End Property

Public Property Value As EmulatorAPI.XYTCoord 
Get
  Dim result As new EmulatorAPI.XYTCoord 
  result .x = NumericUpDownX.Value 
  result .y = NumericUpDownY.Value 
  result .T = NumericUpDownTurn.Value 
  Return result 
End Get
Set(value As EmulatorAPI.XYTCoord)
  NumericUpDownX.Value = value.x 
  NumericUpDownY.Value = value.y 
  NumericUpDownTurn .Value = value.t 
End Set
End Property


Private Sub XYTTupleInput_Load(sender As Object, e As EventArgs) Handles Me.Load
  
End Sub

Private Sub Button1_Click( sender As Object,  e As EventArgs) Handles Button1.Click
  NumericUpDownTurn.Value = 0 
End Sub

Private Sub Button2_Click( sender As Object,  e As EventArgs) Handles Button2.Click
NumericUpDownTurn.Value = 180
End Sub

End Class
