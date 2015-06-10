Imports System.Runtime.Remoting

public Module Main

  Public  Sub Main()
 

    Dim exePath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
    Console.WriteLine( exePath )
    Console.WriteLine("Configuring remotable objects....")
    RemotingConfiguration.Configure(exePath &".config", False)

    Console.WriteLine("Waiting for a request.")
    Console.WriteLine("Press any key to exit the application.")

' The CLR will monitor for requests as long as this application is running. When the user presses Enter, it will end.
    Console.ReadLine()
    End Sub

End Module
