Imports System.Xml.Serialization
Imports System.ComponentModel

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Motor
Inherits Aggregat
Implements IMotorControlSimple 


  Public Shared global_emulating As Boolean = True

  Private local_emulation As Boolean = True
  Private t As New Threading.Thread(AddressOf revolver)
  Private stw As New Stopwatch

  <XmlAttribute()> _
  Public Property rpm_current As Double = 0 'Umdrehungen pro Minute
   <XmlAttribute()> _
   Public Property rpm_target As Double = 50 'Ziel Umdrehungen pro Minute
  <XmlAttribute()> _
  Public Property rpm_max As Double = 60 'Max Umdrehungen pro Minute
  <XmlAttribute()> _
  Public Property rpm_max_ramp As Double = 500 'ms  zeit für erreichen max rpm
  <XmlAttribute()> _
  Public Property direction As Integer = 0  '0: stop 1:forwad -1:backwards

  Public Event moved(sender As Motor, delta As Double) 'delta revolutions

  Public Sub New()
    name = "Motor"

  End Sub

Public Sub powerOn() Implements IMotorControlSimple.PowerOn 

  'If IsNothing(t) Then
  If Not t.IsAlive Then
    local_emulation = True
    t = New Threading.Thread(AddressOf revolver)
    t.Start()
  End If

End Sub

Public Sub powerOff() Implements IMotorControlSimple.powerOff 
  'reverse direction 
  direction = direction * -1
  'target zero
  rpm_target = 0
  'indicate to end while loop
  local_emulation = False ' ends revlover thread
End Sub

  Sub revolver()
    stw.Reset()
    stw.Start()
    Dim keepAlive As Boolean = global_emulating And local_emulation

    While (keepAlive)

      Threading.Thread.Sleep(100)
      'while target speed not reached
      If (rpm_current * direction < rpm_target Or rpm_current * direction < rpm_max) Then
        'raise current_rpm  linear 
        rpm_current = rpm_current + stw.Elapsed.TotalMilliseconds / rpm_max_ramp * rpm_max * direction
        If rpm_current * direction > rpm_target Then
          rpm_current = rpm_target * direction
        End If
      End If
      RaiseEvent moved(Me, stw.Elapsed.TotalMinutes * rpm_current)
      stw.Reset()
      stw.Start()

      'end loop cirterias
      keepAlive = global_emulating And local_emulation
      If (Not local_emulation And rpm_current <> 0 And rpm_target = 0 and direction <> 0 ) Then
        keepAlive = True
      End If


    End While 'keepAlive

  End Sub

'0: stop 1:forwad -1:backwards
Public Function getDirection() As Integer Implements IMotorControlSimple.getDirection
  Return direction 
End Function

Public Sub setDirection( dir As Integer ) Implements IMotorControlSimple.setDirection 
  direction = dir 
End Sub

Public function getRPM As Double Implements IMotorControlSimple.getRPM 
  Return  rpm_target
End Function

Public function getRPMmax As Double Implements IMotorControlSimple.getRPMmax 
  Return  rpm_max
End Function

Public Sub setRPM (tarRPM As Double  ) Implements IMotorControlSimple.setRPM
  rpm_target =tarRPM 
End Sub
End Class

