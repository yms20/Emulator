Public Interface IMotorControlSimple

  sub PowerOn
  Sub powerOff
  Sub setDirection(dir As Integer )
  
  Function getRPM As Double
  Function getRPMmax As Double
    
  sub setRPM (tarRPM As Double ) 
    
Function getDirection As Integer 
  
End Interface
