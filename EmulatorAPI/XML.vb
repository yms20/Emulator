imports System
imports System.Collections.Generic
Imports System.Xml.Serialization
imports System.Text
imports System.IO 

Public Class XML
  Public Shared Function toXMLString(Of T)(data As T ) As String 
    Dim stringWriter As New StringWriter 
    dim writer As XmlSerializer = new XmlSerializer(gettype (T ))
    writer.Serialize (stringWriter ,data)
    stringWriter.Flush 
    Return stringWriter.ToString 
  End Function

  public Shared sub write(Of T) (filename As String , data As T )
        dim output As StreamWriter = new StreamWriter (filename )
        dim writer As XmlSerializer = new XmlSerializer(gettype (T ))
        writer.Serialize(output, data)
        output.Close()
      End Sub
  
  Public Shared Function readFromString (Of T)(xmlcoddedObject As String  ) As T 
    dim result   as T         
    dim input As StringReader   = new StringReader (xmlcoddedObject)
    dim reader  as XmlSerializer = new XmlSerializer ( gettype  (T) )

      result = CType (reader.Deserialize (input ), t)

    input.Close ()
    return result
  End Function

      public Shared Function  read(Of t) (filename As String ) as t 

        dim info As New FileInfo(filename )
        If not info.Exists 
          write (Of t)(filename , Nothing)
        End If

        dim result   as T 
        dim input As StreamReader  = new StreamReader (filename)
        dim reader  as XmlSerializer = new XmlSerializer ( gettype  (T) )
        result = CType (reader.Deserialize (input ), t)
        input.Close ()

       return result
      End Function 
End Class
