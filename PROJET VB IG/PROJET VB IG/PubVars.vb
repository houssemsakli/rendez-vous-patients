Module PubVars
    Public cnxemail As String
    Public cnxmdp As String
    Public cnxcin As String
    Public cnxnom As String
    Public cnxprenom As String
    Public cnxgenre As String
    Public cnxdateajout As Date
    Public cnxid As Integer
    Public cnxtype As String
    Public cnxdaterendezvous As Date
    Public cnxnomcompte As String
    Public cnxprenomcompte As String
    Public cnxgenrecompte As String
    Public cnxdatenaissance As Date
    Public Patht As String = Environment.CurrentDirectory
    Public x As Integer = Patht.Length
    Public d As String = Patht
    Public Path As String = d.Substring(0, x - 10)
End Module
