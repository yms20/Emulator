Public Class Controller

  Private m_input As Geber 
   public Property output As IMotorControlSimple  'harware specs like start and stop ram, as well as commands to start and stop movement

  public Property input as Geber
    Get
      Return m_input 
    End Get
    Set(value As Geber)
      If Not IsNothing(m_input )
       RemoveHandler m_input.movedTo , AddressOf moveTo
      End If
      m_input = value 
      AddHandler m_input.movedTo , AddressOf Me.moveTo 
    End Set
  End Property
'gets current location from here
  Public Property targetTicks As Double = 0 
  Public Property isMoving As Boolean = False 

  Private lastTarDirection As Integer = 0 'remembers last (to reduce rpm if toggled)

  Public Event targetReaced 'raised each time tar coord is reached

public Sub startMove(targetTicks As Double )
  isMoving = True 
  Me.targetTicks = targetTicks 
  moveTo( nothing, 0) 
End Sub

  private sub moveTo( sender As Aggregat, delta As Double )  
    'safety check
    If IsNothing (output ) or IsNothing (input )
      'log trouble 
      Console.WriteLine ("Controller: moveTo: either no input nor output")
      Return
    End If

    Dim deltaToTarget = targetTicks - input.location 
    Dim tardirection = Math.Sign (deltaToTarget  )

    If (tardirection <> lastTarDirection and lastTarDirection <> 0 )
      output.setRPM ( output.getRPM / 2) 
    End If
      output.setDirection (  tardirection ) 

           

    If Math.Abs ( deltaToTarget ) <= input.tolerance 
      output.powerOff 
      lastTarDirection = 0 
      isMoving = False 
      RaiseEvent targetReaced
    Else
      output.PowerOn 
      If output.getRPM < 1
        output.setRPM (output.getRPMmax )
      End If
    End If  

    lastTarDirection = tardirection    
    
  End Sub


End Class
