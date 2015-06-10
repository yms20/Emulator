Imports System.Runtime.Remoting

Public Class ManualControlClientMainWindow



  Dim commads As EmulatorAPI.ICommands

Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
  Dim exePath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
    Console.WriteLine(exePath)
    Console.WriteLine("Configuring remotable objects....")
    RemotingConfiguration.Configure(exePath & ".config", False)

    commads = Activator.GetObject(GetType(EmulatorAPI.ICommands), "tcp://127.0.0.1:1337/Machine")

    ButtonConnect.Enabled = False

'TODO readout Side Config  before enableing controls
    XytTupleInputRight.Enabled = True 
    ButtonSendRight.Enabled = True 

XytTupleInputLeft .Enabled = True 
    ButtonSendLeft.Enabled = True 

End Sub

Private Sub ButtonSendLeft_Click( sender As Object,  e As EventArgs) Handles ButtonSendLeft.Click
  If Not IsNothing (commads ) 
    commads.driveLeft (XytTupleInputLeft.Value ) 

  End If
End Sub

Private Sub ButtonSendRight_Click_1( sender As Object,  e As EventArgs) Handles ButtonSendRight.Click
  If Not IsNothing (commads ) 
    commads.driveRight (XytTupleInputRight.Value ) 
  End If
End Sub
End Class
