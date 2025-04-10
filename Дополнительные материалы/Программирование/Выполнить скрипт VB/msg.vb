Dim Msg, Style, Title, Help, Ctxt, Response, MyString
Msg = "Do you want to continue ?"    ' Define message.
Style = vbYesNo Or vbCritical Or vbDefaultButton2    ' Define buttons.
Title = "MsgBox Demonstration"    ' Define title.
Help = "DEMO.HLP"    ' Define Help file.
Ctxt = 1000    ' Define topic context. 
        ' Display message.
Response = MsgBox(Msg, Style, Title, Help, Ctxt)