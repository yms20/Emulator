Imports EmulatorAPI
Imports System.Runtime.Remoting

Public Class GUIServerMainWindow 
Inherits  Form

Dim a As Achse = Achse.config1

public shared achsen As New List(Of Achse)

Public Shared rightCommandQueue As New Queue(Of XYTCoord)
Public Shared rightSideMover As XYTMove 

Public Shared leftCommandQueue As New Queue(Of XYTCoord)
Public Shared leftSideMover As XYTMove 

Dim plotter As New EmulatorConfigurationTester.scenePlotter

Sub loadConfig(machineConfig As String)
 Try
      a.motor.powerOff()
      If machineConfig.Contains("<Achsen>") Then
        achsen = XML.readFromString(Of Achsen)(machineConfig).Achsen
        For Each a As Achse In achsen
          addAchse(a)
        Next
      Else
        a = XML.readFromString(Of Achse)(machineConfig)
        addAchse(a)
      End If

    Catch ex As Exception
      TextBox1.AppendText(ex.ToString)
    End Try
End Sub


'create achsen controller gui elements and signal handlers
Sub addAchse(a As Achse, Optional recursive As Boolean = False)
  a.setConnections()

  If a.geber.Plot.enabled Then
    'Zeichne nur hauptachsen in ScenePlotter
    If Not recursive Then
      plotter.achsen.Add(a)
    End If

  End If

  'get in deep recursivly
  For Each sa As Achse In a.geber.SubAchsen
    addAchse(sa, True)
  Next

End Sub



Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  TextBox2.Text = My.Settings.ConfigFilePath

'loadConfig (XML.toXMLString (Of Achse ) ( Achse.config1 ) ) 
  achsen = XML.read(Of Achsen)(My.Settings.ConfigFilePath).Achsen
  For Each a As Achse In achsen
    addAchse(a)
  Next

  plotter.Dock = DockStyle.Fill
  plotter.BackColor = Color.SteelBlue
  Me.Controls.Add(plotter)
 
  rightSideMover = New XYTMove (getAchse (4,achsen ),getAchse (5,achsen ),getAchse (8,achsen ))
  leftSideMover = New XYTMove (getAchse (2,achsen ),getAchse (3,achsen ),getAchse (6,achsen ))
  startServer

End Sub




Private Sub TextBox2_DoubleClick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
  OpenFileDialog1.ShowDialog()
  My.Settings.ConfigFilePath = OpenFileDialog1.FileName
  My.Settings.Save()
End Sub

Private Sub startServer()

    Dim exePath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
    TextBox1.AppendText( exePath & Environment.NewLine  )
    TextBox1.AppendText("Configuring remotable objects...." & Environment.NewLine )
    RemotingConfiguration.Configure(exePath & ".config", False)
    TextBox1.AppendText("Waiting for a request." & Environment.NewLine )
End Sub



public Shared Function getAchse(can_id As Integer, haystack As List(Of Achse)) As Achse
 For Each a As Achse In haystack
  Dim child As Achse = getAchse(can_id, a.geber.SubAchsen)
  If Not IsNothing(child) Then
    Return child
  End If

  If a.can_id = can_id Then
    Return a
  End If
 Next
  Return Nothing
End Function


Private Sub TimerRightSideCommands_Tick( sender As Object,  e As EventArgs) Handles TimerRightSideCommands.Tick
    TimerRightSideCommands.Stop 
  If rightCommandQueue.Count > 0 
    rightSideMover.beginMove (rightCommandQueue.Dequeue )

    Dim stw As New Stopwatch 
    stw.Start

    While rightSideMover.isMoving and stw.ElapsedMilliseconds < 5000
      Threading.Thread.Sleep (10)
      Application.DoEvents 
    End While

  End If
  TimerRightSideCommands.Start 
End Sub

Private Sub TimerLeftSideCommands_Tick( sender As Object,  e As EventArgs) Handles TimerLeftSideCommands.Tick
      TimerLeftSideCommands .Stop 
  If leftCommandQueue .Count > 0 
    leftSideMover .beginMove (leftCommandQueue.Dequeue )

    Dim stw As New Stopwatch 
    stw.Start

    While leftSideMover.isMoving  and stw.ElapsedMilliseconds < 5000
      Threading.Thread.Sleep (10)
      Application.DoEvents 
    End While

  End If
  TimerLeftSideCommands .Start 
End Sub

End Class

''' <summary>
''' This Class is showcased as Remoting Object in a singleton manor.
''' The specific line in the APP Config.xml : 
''' <system.runtime.remoting>
'''  <application name="GUIServer">
'''    <service>
'''      <wellknown mode="Singleton"
'''                type="GUIServer.TheServerSideimplementationOfTheRemoteAccessibleInterface, GUIServer"
'''                 objectUri="Machine" />
'''    </service>
'''    <channels>
'''      <channel ref="tcp" port="1337" >
'''        <serverProviders>
'''          <provider ref="wsdl" />
'''          <formatter ref="soap" typeFilterLevel="Full" />
'''          <formatter ref="binary" typeFilterLevel="Full" />
'''        </serverProviders>
'''      </channel>
'''    </channels>
'''  </application>
'''</system.runtime.remoting>
''' </summary>
''' <remarks></remarks>
 Public  Class TheServerSideimplementationOfTheRemoteAccessibleInterface
  Inherits MarshalByRefObject
  Implements EmulatorAPI.ICommands
 


Public Sub place(can_id As Integer, location As Double) Implements ICommands.place
  GUIServerMainWindow.getAchse(can_id, GUIServerMainWindow.achsen).geber.location = location

End Sub

Public Sub drive(can_id As Integer, target As Double) Implements ICommands.drive

End Sub



Public Function getCurrentMovingAxis() As Integer Implements ICommands.getCurrentMovingAxis
  Return 0
End Function



  Public Sub driveLeft(target As XYTCoord) Implements ICommands.driveLeft
    GUIServerMainWindow.leftCommandQueue .Enqueue (target )  
End Sub

Public Sub driveRight(target As XYTCoord) Implements ICommands.driveRight
  GUIServerMainWindow.rightCommandQueue.Enqueue (target ) 
End Sub
  End Class
