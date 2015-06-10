Public Class XYTMove

Public Property isMoving As Boolean = False 

Dim WithEvents  x_controller As New Controller
dim WithEvents  y_controller As New Controller
Dim WithEvents t_controller As New Controller

Dim targetCoord As XYTCoord 


Public Sub new (x As Achse , y As Achse , t As Achse ) 
  x_controller.input = x.geber 
  x_controller.output = x.motor 

  y_controller.input = y.geber 
  y_controller.output = y.motor 

  t_controller.input = t.geber 
  t_controller.output = t.motor 

End Sub

Dim threadX As Threading.Thread 
Dim threadY As Threading.Thread 


Function startMoveX( ) 
  x_controller.startMove (targetCoord.x )
End Function


Function startMoveY( ) 
  Y_controller.startMove (targetCoord.Y )
End Function



'blocking move
Sub beginMove (target As XYTCoord )
  Me.targetCoord = target 
  isMoving = True 

threadX = New Threading.Thread (AddressOf startMoveX  )
threadX.Start 
threadY = New Threading.Thread (AddressOf startMoveY  )
threadY.Start 

  'x_controller.startMove (targetCoord.x )
  'Y_controller.startMove (targetCoord.Y )
End Sub

Sub bigAxisTargetReachedHAndler Handles x_controller.targetReaced , y_controller.targetReaced 
  If  (x_controller.isMoving or y_controller.isMoving )
    Return 
  End If
  t_controller.startMove (targetCoord.t ) 
End Sub


sub turnMovedone  Handles t_controller.targetReaced 
  me.isMoving = False 
End Sub

End Class

<Serializable > _ 
Public Structure XYTCoord 
Public x As Integer ' x Ticks
Public y As Integer ' y Ticks
Public t As Integer ' Turn angle Ticks
End Structure