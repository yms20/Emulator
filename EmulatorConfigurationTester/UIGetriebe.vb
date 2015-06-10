imports EmulatorAPI

Public Class UIGetriebe
Implements IFromAchse

  Dim g As Getriebe 

Public sub setFromAchse ( a As Achse ) Implements IFromAchse.setFromAchse 
  setGetriebe (a.getriebe )
End Sub

  public Sub setGetriebe (tr As Getriebe)
    Me.g =tr 
    tbTranslation.Text = g.traslation 
  End Sub

End Class
