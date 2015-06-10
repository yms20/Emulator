Imports EmulatorAPI

Public Class UIMotor
Implements IFromAchse

Public WithEvents  m As Motor
Dim stringQueue As new List(Of String)

Public sub new ()

' Dieser Aufruf ist für den Designer erforderlich.
InitializeComponent()

' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
m= New Motor 
End Sub

Public Sub new (m As Motor )
Me.New 
setMotor (m)
End Sub

Public Sub setFromAchse (a As Achse ) Implements IFromAchse.setFromAchse 
  setMotor (a.motor ) 
End Sub

Public sub setMotor (m  as Motor ) 
Me.m = m
End Sub


Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click

  If m.direction = 0 
    m.direction = -1 
  End If
  m.direction *= -1
  m.rpm_target = m.rpm_max 
  m.powerOn 
End Sub

Private Sub btStop_Click( sender As Object,  e As EventArgs) Handles btStop.Click
    m.powerOff 
End Sub

Sub handleMotorMove (sender As Motor, delta As Double ) Handles m.moved 
  SyncLock (stringQueue )
    stringQueue.Add (String.Format ( "{0:0.0} rpm {1:0.000}  {2}",sender.rpm_current ,delta ,  Environment.NewLine ))
'Plotter1.addValue (sender.rpm_current )

  End SyncLock
End Sub

'ingame thread for updating textbox
Private Sub timer_Tick( sender As Object,  e As EventArgs) Handles timer.Tick
  SyncLock (stringQueue )
    If (Me.stringQueue.Count > 0 ) 
      For Each s As String In stringQueue 
        Label1.Text =  (s)
      Next
      stringQueue.Clear 
    End If
  End SyncLock
'Plotter1.Refresh 
End Sub


End Class
