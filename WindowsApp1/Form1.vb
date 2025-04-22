Imports System.Threading
Public Class Form1
    Dim MyVar As String
    Dim APP As String = Application.StartupPath
    Dim dm As Object
    Dim strKey() As String = {"熱鍵選擇", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}
    Dim hwnd As Object
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short
    Public Declare Function GetKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Dim o蓋亞, oDesperado, o湛盧BUG, o極道滅殺, o瞬狙, o閃擊斯特恩, o刷1槍, o雙王者, o卡空, oGS, oSGS As Boolean
    Dim 蓋亞, Desperado, 湛盧BUG, 極道滅殺, 瞬狙, 閃擊斯特恩, 刷1槍, 雙王者, 卡空, GS, SGS As String
    Dim rndNum As New Random()
    Dim kmode As String
    Public mkeyL As String = "["
    Public mkeyR As String = "]"
    Public afk護甲Key As String = "]"
    Dim RunTimeS, RunTimeM, RunTimeH As Integer
    Dim EndTime As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IE()
        TabSetting()
        MyVar = GetVar
        APP = Application.StartupPath
        Shell("regsvr32 /s " & APP & "\1.dll")
        DmCheck()
        VarCheck()
        Text = System.Guid.NewGuid.ToString("N")
        GameCheck()
        CenterToScreen()
        AddHotKey()
        cmbdf()
        ThreadStart()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Shell("regsvr32 /u /s " & APP & "\1.dll")
        MessageBox.Show("本次運作時間 : " & RunTimeH & "時" & RunTimeM & "分" & RunTimeS & "秒")
        End
    End Sub

    '------------HotKey-------------
    Private Sub tmrHotKey_Tick(sender As Object, e As EventArgs) Handles tmrHotKey.Tick
        If chk蓋亞.CheckState = CheckState.Checked Then
            If rdb蓋亞1.Checked Then
                HotKey(1, cmb蓋亞key.Text, o蓋亞)
            ElseIf rdb蓋亞2.Checked Then
                HotKey(2, cmb蓋亞key.Text, o蓋亞)
            End If
        End If
        If chkDesperado.CheckState = CheckState.Checked Then
            If rdbDesperado1.Checked Then
                HotKey(1, cmbDesperadoKey.Text, oDesperado)
            ElseIf rdbDesperado2.Checked Then
                HotKey(2, cmbDesperadoKey.Text, oDesperado)
            End If
        End If
        If chk湛盧BUG.CheckState = CheckState.Checked Then
            If rdb湛盧BUG1.Checked Then
                HotKey(1, cmb湛盧BUGkey.Text, o湛盧BUG)
            ElseIf rdb湛盧BUG2.Checked Then
                HotKey(2, cmb湛盧BUGkey.Text, o湛盧BUG)
            End If
        End If
        If chk極道滅殺.CheckState = CheckState.Checked Then
            If rdb極道滅殺1.Checked Then
                HotKey(1, cmb極道滅殺key.Text, o極道滅殺)
            ElseIf rdb極道滅殺2.Checked Then
                HotKey(2, cmb極道滅殺key.Text, o極道滅殺)
            End If
        End If
        If chk瞬狙.CheckState = CheckState.Checked Then
            HotKey(1, cmb瞬狙key.Text, o瞬狙)
        End If
        If chk閃擊斯特恩.CheckState = CheckState.Checked Then
            If rdb閃擊斯特恩1.Checked Then
                HotKey(1, cmb閃擊斯特恩key.Text, o閃擊斯特恩)
            ElseIf rdb閃擊斯特恩2.Checked Then
                HotKey(2, cmb閃擊斯特恩key.Text, o閃擊斯特恩)
            End If
        End If
        If chk刷1槍.CheckState = CheckState.Checked Then
            If rdb刷1槍1.Checked Then
                HotKey(1, cmb刷1槍key.Text, o刷1槍)
            ElseIf rdb刷1槍2.Checked Then
                HotKey(2, cmb刷1槍key.Text, o刷1槍)
            End If
        End If
        If chk雙王者.CheckState = CheckState.Checked Then
            HotKey(1, cmb雙王者key.Text, o雙王者)
            If o雙王者 = True Then
                雙王者T()
            End If
        End If
        If chk卡空.CheckState = CheckState.Checked Then
            HotKey(1, cmb卡空key.Text, o卡空)
            tmr卡空.Enabled = True
        Else
            tmr卡空.Enabled = False
        End If
        If chkGS.CheckState = CheckState.Checked Then
            If rdbGS1.Checked Then
                HotKey(1, cmbGSkey.Text, oGS)
            ElseIf rdbGS2.Checked Then
                HotKey(2, cmbGS.Text, oGS)
            End If
        End If
        If chkSGS.CheckState = CheckState.Checked Then
            If rdbSGS1.Checked Then
                HotKey(1, cmbSGSkey.Text, oSGS)
            ElseIf rdbSGS2.Checked Then
                HotKey(2, cmbSGS.Text, oSGS)
            End If
        End If
    End Sub

    Private Sub tmrValUpdate_Tick(sender As Object, e As EventArgs) Handles tmrValUpdate.Tick
        蓋亞 = cmb蓋亞.Text
        Desperado = cmbDesperado.Text
        湛盧BUG = cmb湛盧BUG.Text
        極道滅殺 = cmb極道滅殺.Text
        瞬狙 = cmb瞬狙.Text
        閃擊斯特恩 = cmb閃擊斯特恩.Text
        刷1槍 = cmb刷1槍.Text
        雙王者 = cmb雙王者.Text
        GS = cmbGS.Text
        SGS = cmbSGS.Text
        afk護甲Key = cmbAfk護甲key.Text
        lblRunTime.Text = "運作時間: " & RunTimeH & "時" & RunTimeM & "分" & RunTimeS & "秒"
    End Sub

    Private Sub AddHotKey()
        AddKeyItem_LA(cmb蓋亞key)
        AddKeyItem_LA(cmbDesperadoKey)
        AddKeyItem_LA(cmb湛盧BUGkey)
        AddKeyItem_LA(cmb極道滅殺key)
        AddKeyItem_LA(cmb瞬狙key)
        AddKeyItem_LA(cmb閃擊斯特恩key)
        AddKeyItem_LA(cmb刷1槍key)
        AddKeyItem_LA(cmb雙王者key)
        AddKeyItem_LA(cmb卡空key)
        AddKeyItem_LA(cmbGSkey)
        AddKeyItem_LA(cmbSGSkey)
        AddKeyItem_LA2(cmbAfkKey1)
        AddKeyItem_LA2(cmbAfkKey2)
        AddKeyItem_LA2(cmbAfkKey3)
        AddKeyItem_LA2(cmbAfkKey4)
    End Sub

    Private Sub HotKey(ByVal OnF As String, ByVal KeyCode As String, ByRef Vel As String)
        Select Case OnF
            Case 1
                If GetAsyncKeyState(toKeyValue(KeyCode)) Then
                    Vel = True
                Else
                    Vel = False
                End If
            Case 2
                If GetKeyState(toKeyValue(KeyCode)) Then
                    Vel = True
                Else
                    Vel = False
                End If
            Case Else
                Vel = False
        End Select
    End Sub

    Private Function toKeyValue(ByVal KeyCode As String) As Integer
        Dim intKey() As Integer = {0, &HD, &H10, &H11, &H12, &H20, &H21, &H22, &H2D, &H2E, &H24, &H23, &H25, &H26, &H27, &H28, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H1B, &H4, &H5, &H6, &HDB, &HDD, &H1, &H2}
        For i = 0 To strKey.Length - 1
            If strKey(i) = KeyCode Then Return intKey(i)
        Next
        Return False
    End Function

    Dim 蓋亞Thread As New Thread(AddressOf 蓋亞T)
    Sub 蓋亞T()
        Do
            If o蓋亞 = True Then
                If 蓋亞 = "蓋亞" Then
                    dm.KeyDownChar("q")
                    dm.KeyDownChar(3)
                    dm.KeyUpChar("q")
                    dm.KeyUpChar(3)
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt蓋亞1.Text)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                    Threading.Thread.Sleep(txt蓋亞2.Text)
                ElseIf 蓋亞 = "蓋亞刀戰" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(txt蓋亞1.Text / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(txt蓋亞1.Text / 2)
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt蓋亞2.Text)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                ElseIf 蓋亞 = "蓋亞購買區" Then
                    dm.KeyPressChar("F2")
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt蓋亞1.Text)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                    Threading.Thread.Sleep(txt蓋亞2.Text)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim DesperadoThread As New Thread(AddressOf DesperadoT)
    Sub DesperadoT()
        Do
            If oDesperado = True Then
                If Desperado = "Desperado左" Then
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txtDesperado1.Text)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                    MouseKey("R", "Up")
                ElseIf Desperado = "Desperado右" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txtDesperado1.Text)
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                    MouseKey("L", "Up")
                ElseIf Desperado = "Desperado左右" Then
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txtDesperado1.Text)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txtDesperado1.Text)
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(txtDesperado2.Text / 2)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 湛盧BUGThread As New Thread(AddressOf 湛盧BUGT)
    Dim 湛盧BUGLoop As Integer = 0
    Sub 湛盧BUGT()
        Do
            If o湛盧BUG = True Then
                If 湛盧BUGLoop = 0 Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(5)
                    MouseKey("R", "Up")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txt湛盧BUG1.Text)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(txt湛盧BUG2.Text)
                    湛盧BUGLoop = 1
                ElseIf 湛盧BUGLoop = 1 Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt湛盧BUG3.Text)
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(txt湛盧BUG4.Text)
                End If
            Else
                湛盧BUGLoop = 0
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 極道滅殺Thread As New Thread(AddressOf 極道滅殺T)
    Sub 極道滅殺T()
        Do
            If o極道滅殺 = True Then
                If 極道滅殺 = "極道滅殺動作左" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(txt極道滅殺2.Text / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(txt極道滅殺2.Text / 2)
                    dm.KeyDownChar("3")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txt極道滅殺1.Text)
                    MouseKey("L", "Up")
                    dm.KeyUpChar("3")
                ElseIf 極道滅殺 = "極道滅殺動作右" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(txt極道滅殺2.Text / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(txt極道滅殺2.Text / 2)
                    dm.KeyDownChar("3")
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt極道滅殺1.Text)
                    MouseKey("R", "Up")
                    dm.KeyUpChar("3")
                ElseIf 極道滅殺 = "極道滅殺右快砍" Then
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    dm.KeyDownChar("3")
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt極道滅殺1.Text)
                    MouseKey("R", "Up")
                    dm.KeyUpChar("3")
                    Threading.Thread.Sleep(txt極道滅殺2.Text)
                ElseIf 極道滅殺 = "極道滅殺購買區左" Then
                    dm.KeyDownChar("3")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txt極道滅殺1.Text)
                    MouseKey("L", "Up")
                    dm.KeyUpChar("3")
                    dm.KeyPressChar("F2")
                    Threading.Thread.Sleep(txt極道滅殺2.Text)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 瞬狙Thread As New Thread(AddressOf 瞬狙T)
    Sub 瞬狙T()
        Do
            If o瞬狙 = True Then
                If 瞬狙 = "瞬狙1" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt瞬狙1.Text)
                    MouseKey("R", "Up")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txt瞬狙2.Text)
                    MouseKey("L", "Up")
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    Threading.Thread.Sleep(100)
                ElseIf 瞬狙 = "瞬狙2" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt瞬狙1.Text)
                    MouseKey("L", "Down")
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(txt瞬狙2.Text)
                    MouseKey("L", "Up")
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    Threading.Thread.Sleep(100)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 閃擊斯特恩Thread As New Thread(AddressOf 閃擊斯特恩T)
    Sub 閃擊斯特恩T()
        Do
            If o閃擊斯特恩 = True Then
                dm.KeyDownChar("r")
                Threading.Thread.Sleep(txt閃擊斯特恩1.Text)
                dm.KeyUpChar("r")
                Threading.Thread.Sleep(20)
                dm.KeyDownChar("q")
                dm.KeyUpChar("q")
                dm.KeyDownChar("1")
                dm.KeyUpChar("1")
                Threading.Thread.Sleep(txt閃擊斯特恩2.Text)
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 刷1槍Thread As New Thread(AddressOf 刷1槍T)
    Sub 刷1槍T()
        Do
            If o刷1槍 = True Then
                If 刷1槍 = "刷_槍左鍵(龍炮)" Then
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(txt刷1槍1.Text)
                    MouseKey("L", "Up")
                    dm.KeyDownChar("g")
                    dm.KeyUpChar("g")
                    dm.KeyDownChar("f2")
                    Threading.Thread.Sleep(50)
                    dm.KeyUpChar("f2")
                    Threading.Thread.Sleep(txt刷1槍2.Text)
                ElseIf 刷1槍 = "刷_槍右鍵(轉輪)" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(txt刷1槍1.Text)
                    MouseKey("R", "Up")
                    dm.KeyDownChar("g")
                    dm.KeyUpChar("g")
                    dm.KeyDownChar("f2")
                    Threading.Thread.Sleep(50)
                    dm.KeyUpChar("f2")
                    Threading.Thread.Sleep(txt刷1槍2.Text)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim 雙王者Thread As New Thread(AddressOf 雙王者T)
    Sub 雙王者T()
        If o雙王者 = True Then
            If 雙王者 = "雙王者" Then
                dm.UnBindWindow()
                'Dim wx1, wy1, wx2, wy2, ww, wh
                'dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
                'dm.GetClientSize(hwnd, ww, wh)
                'Threading.Thread.Sleep(100)
                'dm.LeftClick
                'Threading.Thread.Sleep(5)
                'dm.RightDown
                'dm.KeyPressChar("g")
                'Threading.Thread.Sleep(1200)
                'dm.LeftDown
                'dm.RightUp
                'Threading.Thread.Sleep(900)
                'dm.LeftUp
                'dm.KeyPressChar("space")
                'dm.KeyPressChar("h")
                'Threading.Thread.Sleep(50)
                'dm.MoveTo(wx1 + ww - 5, wy1 - 5)
                'Threading.Thread.Sleep(30)
                'dm.LeftDown
                'Threading.Thread.Sleep(30)
                'dm.MoveTo(wx1 + ww / 2, wy1 + 100)
                'Threading.Thread.Sleep(2800)
                'dm.LeftUp
                'dm.LeftClick
                'Threading.Thread.Sleep(10)
                'dm.KeyPressChar("h")
                Dim wx1, wy1, wx2, wy2, ww, wh
                dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
                dm.GetClientSize(hwnd, ww, wh)
                dm.RightDown
                Threading.Thread.Sleep(640)
                dm.RightUp
                dm.LeftDown
                Threading.Thread.Sleep(645)
                dm.LeftUp
                dm.KeyPressChar("G")
                dm.KeyPressChar("f2")
                dm.RightDown
                Threading.Thread.Sleep(1080)
                dm.RightUp
                dm.LeftDown
                Threading.Thread.Sleep(1025)
                dm.LeftUp
                dm.KeyPressChar("H")
                Threading.Thread.Sleep(25)
                dm.KeyPressChar("space")
                Threading.Thread.Sleep(25)
                dm.MoveTo(wx1 + ww - 5, wy1 - 5)
                Threading.Thread.Sleep(10)
                dm.LeftDown
                Threading.Thread.Sleep(10)
                dm.MoveTo(wx1 + ww / 2, wy1 + 100)
                Threading.Thread.Sleep(3000)
                dm.LeftUp
                dm.LeftClick
                Threading.Thread.Sleep(10)
                dm.KeyPressChar("h")
                Threading.Thread.Sleep(10)
                dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
            ElseIf 雙王者 = "雙王者帶槍" Then
                dm.UnBindWindow()
                'Dim wx1, wy1, wx2, wy2, ww, wh
                'dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
                'dm.GetClientSize(hwnd, ww, wh)
                'Threading.Thread.Sleep(100)
                'dm.LeftClick
                'Threading.Thread.Sleep(10)
                'dm.KeyPressChar("g")
                'Threading.Thread.Sleep(800)
                'dm.RightDown
                'Threading.Thread.Sleep(800)
                'dm.RightUp
                'dm.LeftDown
                'Threading.Thread.Sleep(600)
                'dm.LeftUp
                'Threading.Thread.Sleep(5)
                'dm.KeyPressChar("g")
                'dm.KeyPressChar("space")
                'dm.KeyPressChar("h")
                'Threading.Thread.Sleep(30)
                'dm.MoveTo(wx1 + ww - 5, wy1 - 5)
                'Threading.Thread.Sleep(30)
                'dm.LeftDown
                'Threading.Thread.Sleep(30)
                'dm.MoveTo(wx1 + ww / 2, wy1 + 100)
                'Threading.Thread.Sleep(3100)
                'dm.LeftUp
                'dm.LeftClick
                'Threading.Thread.Sleep(10)
                'dm.KeyPressChar("h")
                Dim wx1, wy1, wx2, wy2, ww, wh
                dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
                dm.GetClientSize(hwnd, ww, wh)
                dm.RightDown
                Threading.Thread.Sleep(640)
                dm.RightUp
                dm.LeftDown
                Threading.Thread.Sleep(645)
                dm.LeftUp
                dm.KeyPressChar("G")
                dm.KeyPressChar("f2")
                dm.RightDown
                Threading.Thread.Sleep(1080)
                dm.RightUp
                dm.LeftDown
                Threading.Thread.Sleep(1025)
                dm.LeftUp
                dm.KeyPressChar("H")
                Threading.Thread.Sleep(25)
                dm.KeyPressChar("g")
                dm.KeyPressChar("space")
                Threading.Thread.Sleep(25)
                dm.MoveTo(wx1 + ww - 5, wy1 - 5)
                Threading.Thread.Sleep(10)
                dm.LeftDown
                Threading.Thread.Sleep(10)
                dm.MoveTo(wx1 + ww / 2, wy1 + 100)
                Threading.Thread.Sleep(3000)
                dm.LeftUp
                dm.LeftClick
                Threading.Thread.Sleep(10)
                dm.KeyPressChar("h")
                Threading.Thread.Sleep(10)
                dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
            End If
        Else
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Dim GSThread As New Thread(AddressOf GST)
    Sub GST()
        Do
            If oGS = True Then
                If GS = "有基因GS" Or GS = "無基因GS" Or GS = "有基因GS2" Or GS = "無基因GS2" Or GS = "通用GS" Then
                    dm.KeyDownChar("ctrl")
                    Threading.Thread.Sleep(txtGS1.Text)
                    dm.KeyUpChar("ctrl")
                    Threading.Thread.Sleep(txtGS2.Text)
                ElseIf GS = "滾輪上有基因GS" Or GS = "滾輪上無基因GS" Then
                    Threading.Thread.Sleep(txtGS1.Text)
                    dm.WheelUp()
                    Threading.Thread.Sleep(txtGS2.Text)
                ElseIf GS = "滾輪下有基因GS" Or GS = "滾輪下無基因GS" Then
                    Threading.Thread.Sleep(txtGS1.Text)
                    dm.WheelDown()
                    Threading.Thread.Sleep(txtGS2.Text)
                End If
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim SGSThread As New Thread(AddressOf SGST)
    Sub SGST()
        Do
            If oSGS = True Then
                dm.KeyDownChar("ctrl")
                Threading.Thread.Sleep(txtSGS1.Text)
                dm.KeyUpChar("ctrl")
                Threading.Thread.Sleep(txtSGS2.Text)
                dm.KeyDownChar("ctrl")
                Threading.Thread.Sleep(txtSGS3.Text)
                dm.KeyUpChar("ctrl")
                Threading.Thread.Sleep(txtSGS4.Text)
            Else
                Threading.Thread.Sleep(100)
            End If
        Loop
    End Sub

    Dim RunTimeThread As New Thread(AddressOf RunTImeT)
    Sub RunTImeT()
        Do
            RunTimeS += 1
            If RunTimeS = 60 Then
                RunTimeM += 1
                RunTimeS = 0
            End If
            If RunTimeM = 60 Then
                RunTimeH += 1
                RunTimeM = 0
            End If
            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Private Sub ThreadStart()
        蓋亞Thread.Start()
        DesperadoThread.Start()
        湛盧BUGThread.Start()
        極道滅殺Thread.Start()
        瞬狙Thread.Start()
        閃擊斯特恩Thread.Start()
        刷1槍Thread.Start()
        雙王者Thread.Start()
        RunTimeThread.Start()
        GSThread.Start()
        SGSThread.Start()
    End Sub

    Private Sub ChkBJ_CheckedChanged(sender As Object, e As EventArgs) Handles chkBJ.CheckedChanged
        If chkBJ.CheckState = CheckState.Checked Then
            tmrBJ.Enabled = True
        Else
            tmrBJ.Enabled = False
        End If
    End Sub
    Private Sub TmrBJ_Tick(sender As Object, e As EventArgs) Handles tmrBJ.Tick
        tmrBJ.Interval = txtBJ.Text
        If GetAsyncKeyState(Keys.Space) <> 0 Then
            dm.KeyPressChar("space")
        End If
    End Sub
    Private Sub 閃燈_CheckedChanged(sender As Object, e As EventArgs) Handles chk閃燈.CheckedChanged
        If chk閃燈.CheckState = CheckState.Checked Then
            tmr閃燈.Enabled = True
        Else
            tmr閃燈.Enabled = False
        End If
    End Sub

    Private Sub 閃燈_Tick(sender As Object, e As EventArgs) Handles tmr閃燈.Tick
        tmr閃燈.Interval = txt閃燈.Text
        If GetAsyncKeyState(Keys.F) <> 0 Then
            dm.KeyPressChar("F")
        End If
    End Sub

    Private Sub 連抽_Tick(sender As Object, e As EventArgs) Handles tmr連抽.Tick
        tmr連抽.Interval = txt連抽.Text
        If chk連抽.CheckState = CheckState.Checked Then
            If GetAsyncKeyState(Keys.Enter) <> 0 Then
                dm.LeftClick
            End If
        End If
    End Sub

    Private Sub 連抽_CheckedChanged(sender As Object, e As EventArgs) Handles chk連抽.CheckedChanged
        If chk連抽.CheckState = CheckState.Checked Then
            tmr連抽.Enabled = True
        Else
            tmr連抽.Enabled = False
        End If
    End Sub

    Private Sub 透明_CheckedChanged(sender As Object, e As EventArgs) Handles chk透明.CheckedChanged
        If chk透明.CheckState = CheckState.Checked Then
            dm.SetWindowTransparent(hwnd, trb透明)
        Else
            dm.SetWindowTransparent(hwnd, 255)
        End If
    End Sub

    Private Sub Trb透明_Scroll(sender As Object, e As EventArgs) Handles trb透明.Scroll
        If chk透明.Checked Then
            dm.SetWindowTransparent(hwnd, trb透明)
        End If
    End Sub

    Private Sub 頂置CSO_CheckedChanged(sender As Object, e As EventArgs) Handles chk頂置CSO.CheckedChanged
        If chk頂置CSO.CheckState = CheckState.Checked Then
            dm.SetWindowState(hwnd, 8)
        Else
            dm.SetWindowState(hwnd, 9)
        End If
    End Sub
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles chk頂置程式.CheckedChanged
        If chk頂置程式.CheckState = CheckState.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    '--------------cmb按鍵----------------
    Private Sub Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb蓋亞.KeyPress, cmb蓋亞key.KeyPress, cmbDesperado.KeyPress, cmbDesperadoKey.KeyPress, cmb湛盧BUG.KeyPress, cmb湛盧BUGkey.KeyPress, cmb極道滅殺.KeyPress, cmb極道滅殺key.KeyPress, cmb瞬狙.KeyPress, cmb瞬狙key.KeyPress, cmb閃擊斯特恩.KeyPress, cmb閃擊斯特恩key.KeyPress, cmb刷1槍.KeyPress, cmb刷1槍key.KeyPress, cmbGS.KeyPress, cmbGSkey.KeyPress, cmbSGS.KeyPress, cmbSGSkey.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbdf()
        For Each tp In TabControl1.TabPages
            For Each ctrl In tp.Controls
                If TypeOf ctrl Is ComboBox Then
                    ctrl.selectedIndex = 0
                End If
            Next
            For Each ctrl2 In tp.Controls
                If TypeOf ctrl2 Is GroupBox Then
                    For Each ctrl3 In ctrl2.Controls
                        If TypeOf ctrl3 Is ComboBox Then
                            ctrl3.selectedIndex = 0
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Public Sub AddKeyItem_LA(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey.Length - 1
            cbo.Items.Add(strKey(i))
        Next
        cbo.SelectedIndex = 0
    End Sub

    Private Sub GameCheck()
        hwnd = dm.FindWindow("", "Counter-Strike Online")
        If hwnd = 0 Then
            MsgBox("CSO未開啟 程式關閉")
            Shell("regsvr32 /u /s " & APP & "\1.dll")
            End
        Else
            dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
            dm.SetKeypadDelay("normal", 0)
            dm.SetKeypadDelay("windows", 0)
            dm.SetKeypadDelay("dx", 0)
        End If
    End Sub

    Private Sub VarCheck()
        Dim VVer As New Ver("https://drive.google.com/uc?export=download&id=1vmgnpUqXpnt3u2xdu_dzMoBk_pM76CF7", "Ver")
        VVer.Ver()
        Select Case VVer.GetCheckConsequence '取得更新結果
            Case 0 '沒有更新
                MsgBox("目前版本是最新的", MsgBoxStyle.Information)
            Case 1 '有更新
                MsgBox("有新版本！" & vbCrLf & "目前版本號碼：" & VVer.GetMyVersion & vbCrLf & "最新版本號碼：" & VVer.GetCheckConsequenceNumber, MsgBoxStyle.Information)
                'MsgBox("可按最新版本下載 獲取下載網址")
                Dim ret1 = MsgBox("是否立即打開最新版本的下載頁面?", 4 + 32, "更新")
                If ret1 = 6 Then
                    Process.Start("https://www.google.com")
                End If
            Case 2 '更新失敗
                MsgBox("獲取版本失敗！", MsgBoxStyle.Critical)
            Case 99 'beta
                MsgBox("測試版本", MsgBoxStyle.Information)
        End Select
        lblMyVar.Text = "目前版本：" & MyVar
        lblNewVar.Text = "最新版本：" & VVer.GetCheckConsequenceNumber
    End Sub

    Private Sub TmrEndCheck_Tick(sender As Object, e As EventArgs) Handles tmrEndCheck.Tick
        If GetAsyncKeyState(Keys.F9) <> 0 And GetAsyncKeyState(Keys.F10) <> 0 Then
            EndTime += 1
            If EndTime > 0 Then
                StopAll()
            End If
            Label30.Text = "程式關閉計時 : " & EndTime
            If EndTime = 10 Then
                o蓋亞 = False
                oDesperado = False
                o湛盧BUG = False
                o極道滅殺 = False
                o瞬狙 = False
                o閃擊斯特恩 = False
                o刷1槍 = False
                o雙王者 = False
                o卡空 = False
                oGS = False
                oSGS = False
                Me.Close()
            End If
        Else
            EndTime = 0
            Label30.Text = "按住F9+F10關閉程式"
        End If

    End Sub
    Sub StopAll()
        o蓋亞 = False
        oDesperado = False
        o湛盧BUG = False
        o極道滅殺 = False
        o瞬狙 = False
        o閃擊斯特恩 = False
        o刷1槍 = False
        o雙王者 = False
        o卡空 = False
        oGS = False
        oSGS = False
        dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
    End Sub

    Private Sub Btn掛機說明_Click(sender As Object, e As EventArgs) Handles btn掛機說明.Click
        掛機說明.Show()
    End Sub

    Private Sub DmCheck()
        Try
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            MsgBox("錯誤訊息 ： 自動註冊DLL失敗 " & vbCrLf & "請確保壓縮檔完整解壓在同一資料夾 和資料夾名稱沒有空格",, "Error")
            Shell("regsvr32 /u /s " & APP & "\1.dll")
            End
        End Try
        Dim ver
        ver = dm.ver()
        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
        Else
            MsgBox("此程式供免費使用" & vbCrLf & "切勿轉售" & vbCrLf & "使用任何輔助都有風險" & vbCrLf & "如使用此程式而被封鎖" & vbCrLf & "本人不負任何責任", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Tmr卡空_Tick(sender As Object, e As EventArgs) Handles tmr卡空.Tick
        If o卡空 = True Then
            dm.UnBindWindow()
            Dim wx1, wy1, wx2, wy2, ww, wh
            dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
            dm.GetClientSize(hwnd, ww, wh)
            dm.KeyPressChar("h")
            Threading.Thread.Sleep(10)
            dm.MoveTo(wx1 + ww - 5, wy1 - 5)
            Threading.Thread.Sleep(30)
            dm.LeftDown
            Threading.Thread.Sleep(30)
            dm.MoveTo(wx1 + ww / 2, wy1 + 100)
            Threading.Thread.Sleep(3100)
            dm.LeftUp
            dm.LeftClick
            Threading.Thread.Sleep(10)
            dm.KeyPressChar("h")
            dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
        End If
    End Sub

    Private ReadOnly Property GetVar()
        Get
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build '取得版本號碼
        End Get
    End Property

    Private Sub Btn雙王者說明_Click(sender As Object, e As EventArgs) Handles btn雙王者說明.Click
        frm雙王者說明.Show()
    End Sub

    Private Sub TabSetting()
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.Alignment = TabAlignment.Left
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.Multiline = True
        TabControl1.ItemSize = New Size(50, 210)
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics = e.Graphics
        Dim Font As Font = New Font("微軟正黑體", 16.0F, FontStyle.Bold)
        Dim Brush As SolidBrush = New SolidBrush(Color.Black)
        Dim tRectangleF As RectangleF = TabControl1.GetTabRect(e.Index)
        Dim sf As StringFormat = New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        'sf.Alignment = StringAlignment.Near
        g.DrawString(TabControl1.Controls(e.Index).Text, Font, Brush, tRectangleF, sf)
    End Sub


    Private Sub IE()
        Dim AppName As String = My.Application.Info.AssemblyName

        Dim VersionCode As Integer
        Dim Version As String = ""
        Dim ieVersion As Object = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Internet Explorer").GetValue("svcUpdateVersion")
        If ieVersion Is Nothing Then
            ieVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Internet Explorer").GetValue("Version")
        End If
        If ieVersion IsNot Nothing Then
            Version = ieVersion.ToString.Substring(0, ieVersion.ToString.IndexOf("."c))
            Select Case Version
                Case "7"
                    VersionCode = 7000
                Case "8"
                    VersionCode = 8888
                Case "9"
                    VersionCode = 9999
                Case "10"
                    VersionCode = 10001
                Case Else
                    If CInt(Version) >= 11 Then
                        VersionCode = 11001
                    Else
                        Throw New Exception("IE Version not supported")
                    End If
            End Select
        Else
            Throw New Exception("Registry error")
        End If
        'Check if the right emulation is set
        'if not, Set Emulation to highest level possible on the user machine
        Dim Root As String = "HKEY_CURRENT_USER\"
        Dim Key As String = "Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"
        Dim CurrentSetting As String = CStr(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Key).GetValue(AppName & ".exe"))
        If CurrentSetting Is Nothing OrElse CInt(CurrentSetting) <> VersionCode Then
            Microsoft.Win32.Registry.SetValue(Root & Key, AppName & ".exe", VersionCode)
            Microsoft.Win32.Registry.SetValue(Root & Key, AppName & ".vshost.exe", VersionCode)
        End If
    End Sub

    Private Sub trb_Scroll(sender As Object, e As EventArgs) Handles trb熱鍵偵測相隔.Scroll, trb變數更新相隔.Scroll
        tmrHotKey.Interval = trb熱鍵偵測相隔.Value
        tmrValUpdate.Interval = trb變數更新相隔.Value
        lbl熱鍵偵測相隔.Text = trb熱鍵偵測相隔.Value & "ms"
        lbl變數更新相隔.Text = trb變數更新相隔.Value & "ms"
    End Sub

    Private Sub KP(sender As Object, e As KeyPressEventArgs) Handles txt蓋亞1.KeyPress, txt蓋亞2.KeyPress, txt蓋亞隨機延遲1.KeyPress, txt蓋亞隨機延遲2.KeyPress, txt蓋亞隨機延遲3.KeyPress, txt蓋亞隨機延遲4.KeyPress, txtDesperado1.KeyPress, txtDesperado2.KeyPress, txt湛盧BUG1.KeyPress, txt湛盧BUG2.KeyPress, txt湛盧BUG3.KeyPress, txt湛盧BUG4.KeyPress, txt極道滅殺1.KeyPress, txt極道滅殺2.KeyPress, txt瞬狙1.KeyPress, txt瞬狙2.KeyPress, txt閃擊斯特恩1.KeyPress, txt閃擊斯特恩2.KeyPress, txt刷1槍1.KeyPress, txt刷1槍2.KeyPress, txt閃燈.KeyPress, txt連抽.KeyPress, txtGS1.KeyPress, txtGS2.KeyPress, txtSGS1.KeyPress, txtSGS2.KeyPress, txtSGS3.KeyPress, txtSGS4.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
        If e.KeyChar = "." Then
            If sender.text.indexOf(".") = -1 And sender.text.length > 0 Then
                e.Handled = False
            End If
        End If
        noNull()
    End Sub

    Private Sub 蓋亞隨機延遲_Tick(sender As Object, e As EventArgs) Handles 蓋亞隨機延遲.Tick
        If chk蓋亞隨機延遲.CheckState = CheckState.Checked Then
            蓋亞隨機延遲.Interval = CInt(txt蓋亞1.Text) + CInt(txt蓋亞2.Text)
            txt蓋亞1.Text = rndNum.Next(txt蓋亞隨機延遲1.Text, txt蓋亞隨機延遲2.Text)
            txt蓋亞2.Text = rndNum.Next(txt蓋亞隨機延遲3.Text, txt蓋亞隨機延遲4.Text)
        End If
    End Sub

    Private Sub chk蓋亞隨機延遲_CheckedChanged(sender As Object, e As EventArgs) Handles chk蓋亞隨機延遲.CheckedChanged
        If chk蓋亞隨機延遲.CheckState = CheckState.Checked Then
            蓋亞隨機延遲.Enabled = True
        Else
            蓋亞隨機延遲.Enabled = False
        End If
    End Sub

    Private Sub BtnUpdata_Click(sender As Object, e As EventArgs) Handles btnUpdata.Click
        Process.Start("https://sites.google.com/view/yutinglia/home/download")
    End Sub


    Private Sub noNull()
        For Each tp In TabControl1.TabPages
            For Each ctrl In tp.Controls
                If TypeOf ctrl Is TextBox Then
                    If ctrl.text.Length = 0 Then
                        ctrl.text = 1
                    End If
                End If
            Next
            For Each ctrl2 In tp.Controls
                If TypeOf ctrl2 Is GroupBox Then
                    For Each ctrl3 In ctrl2.Controls
                        If TypeOf ctrl3 Is TextBox Then
                            If ctrl3.text.Length = 0 Then
                                ctrl3.text = 1
                            End If
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub txt蓋亞隨機延遲_TextChanged(sender As Object, e As EventArgs) Handles txt蓋亞隨機延遲1.TextChanged, txt蓋亞隨機延遲2.TextChanged, txt蓋亞隨機延遲3.TextChanged, txt蓋亞隨機延遲4.TextChanged
        noNull()
        If CInt(txt蓋亞隨機延遲1.Text) > CInt(txt蓋亞隨機延遲2.Text) Then
            If CInt(txt蓋亞隨機延遲2.Text) <> 0 Then
                txt蓋亞隨機延遲1.Text = txt蓋亞隨機延遲2.Text - 1
            Else
                txt蓋亞隨機延遲1.Text = 0
            End If
        End If
        If CInt(txt蓋亞隨機延遲3.Text) > CInt(txt蓋亞隨機延遲4.Text) Then
            If CInt(txt蓋亞隨機延遲4.Text) <> 0 Then
                txt蓋亞隨機延遲3.Text = txt蓋亞隨機延遲4.Text - 1
            Else
                txt蓋亞隨機延遲3.Text = 0
            End If
        End If
    End Sub

    Private Sub cmb蓋亞_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb蓋亞.SelectedIndexChanged
        Select Case cmb蓋亞.SelectedIndex
            Case 0, 1
                txt蓋亞1.Text = 370
                txt蓋亞2.Text = 280
            Case 2
                txt蓋亞1.Text = 500
                txt蓋亞2.Text = 70
        End Select
    End Sub

    Private Sub cmb極道滅殺_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb極道滅殺.SelectedIndexChanged
        Select Case cmb極道滅殺.SelectedIndex
            Case 0
                txt極道滅殺1.Text = 660
                txt極道滅殺2.Text = 200
            Case 1
                txt極道滅殺1.Text = 460
                txt極道滅殺2.Text = 200
            Case 2
                txt極道滅殺1.Text = 200
                txt極道滅殺2.Text = 20
            Case 3
                txt極道滅殺1.Text = 700
                txt極道滅殺2.Text = 20
        End Select
    End Sub

    Private Sub cmb湛盧BUG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb湛盧BUG.SelectedIndexChanged
        Select Case cmb湛盧BUG.SelectedIndex
            Case 0
                txt湛盧BUG1.Text = 2380
                txt湛盧BUG2.Text = 300
                txt湛盧BUG3.Text = 200
                txt湛盧BUG4.Text = 320
            Case 1
                txt湛盧BUG1.Text = 2390
                txt湛盧BUG2.Text = 300
                txt湛盧BUG3.Text = 160
                txt湛盧BUG4.Text = 280
        End Select
    End Sub
    Private Sub cmbGS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGS.SelectedIndexChanged
        Select Case cmbGS.SelectedIndex
            Case 0, 2, 4
                txtGS1.Text = 0
                txtGS2.Text = 242
            Case 1, 3, 5
                txtGS1.Text = 0
                txtGS2.Text = 221
            Case 6
                txtGS1.Text = 0
                txtGS2.Text = 50
            Case 7
                txtGS1.Text = 10
                txtGS2.Text = 232
            Case 8
                txtGS1.Text = 10
                txtGS2.Text = 211
            Case Else
                txtGS1.Text = 0
                txtGS2.Text = 0
        End Select
    End Sub

    Private Sub cmbSGS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSGS.SelectedIndexChanged
        Select Case cmbSGS.SelectedIndex
            Case 0
                txtSGS1.Text = 10
                txtSGS2.Text = 50
                txtSGS3.Text = 200
                txtSGS4.Text = 100
            Case 1
                txtSGS1.Text = 10
                txtSGS2.Text = 50
                txtSGS3.Text = 200
                txtSGS4.Text = 70
            Case 2
                txtSGS1.Text = 10
                txtSGS2.Text = 50
                txtSGS3.Text = 50
                txtSGS4.Text = 50
        End Select
    End Sub

    Private Sub rdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdb前台.CheckedChanged, rdb後台.CheckedChanged
        If rdb前台.Checked Then
            kmode = 1
            lbl模式.Text = "模式 : 前台"
        ElseIf rdb後台.Checked Then
            kmode = 2
            lbl模式.Text = "模式 : 後台"
        End If
    End Sub

    Public Sub MouseKey(ByVal LR As String, ByVal DU As String)
        If kmode = 1 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.LeftDown
                        Case "Up"
                            dm.LeftUp
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.RightDown
                        Case "Up"
                            dm.RightUp
                    End Select
            End Select
        End If
        If kmode = 2 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkeyL)
                        Case "Up"
                            dm.KeyUpChar(mkeyL)
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkeyR)
                        Case "Up"
                            dm.KeyUpChar(mkeyR)
                    End Select
            End Select
        End If
    End Sub

    Private Sub btnMKS_Click(sender As Object, e As EventArgs) Handles btnMKS.Click
        ModeKeySet.Show()
    End Sub


    Private Sub BtnLockGame_Click(sender As Object, e As EventArgs) Handles btnLockGame.Click
        dm.SetWindowState(hwnd, 1)
        dm.BindWindow(hwnd, "gdi2", "dx", "dx", 4)
        rdb前台.Enabled = False
        rdb後台.Enabled = False
    End Sub
    Private Sub BtnUnlockGame_Click(sender As Object, e As EventArgs) Handles btnUnlockGame.Click
        dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
    End Sub

    Dim hkey As Boolean = False
    Dim 掛機Thread As New Thread(AddressOf 掛機T)
    Sub 掛機T()
        Do
            If chkAfk.CheckState = CheckState.Unchecked Then
                If hkey = True Then
                    dm.KeyUpChar("h")
                    dm.KeyUpChar("alt")
                    hkey = False
                End If
            End If

            If chkAfk.CheckState = CheckState.Checked Then
                '////////////////////////////////////////////////////////////
                'If CheckBox31.CheckState = CheckState.Checked Then
                '    Dim dmret3 = dm.GetWindowState(hwnd, 6)
                '    If dmret3 = 1 Then
                '        Threading.Thread.Sleep(1000)
                '        GoTo aa
                '    End If
                'End If

                If chkAfkScreen.CheckState = CheckState.Checked Then
                    dm.KeyDownChar("h")
                    dm.KeyDownChar("alt")
                    hkey = True
                End If

                Threading.Thread.Sleep(100)
                If chkAfk護甲key.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                Threading.Thread.Sleep(100)
                dm.MoveTo(927, 540)

                If chkAfkScreen.CheckState = CheckState.Unchecked Then
                    dm.KeyPressChar("0")
                    dm.KeyPressChar("g")
                End If

                If chkAfkScreen.CheckState = CheckState.Checked Then
                    dm.KeyDownChar("h")
                    hkey = True
                    dm.KeyPressChar("b")
                End If

                Threading.Thread.Sleep(100)
                LeftClick()


                Threading.Thread.Sleep(100)
                dm.MoveTo(705, 620)
                Threading.Thread.Sleep(100)
                LeftClick()

                If chkAfkScreen.CheckState = CheckState.Checked Then
                    Threading.Thread.Sleep(100)
                    dm.MoveTo(510, 420)
                    Threading.Thread.Sleep(100)
                    LeftClick()

                    dm.KeyPressChar("b")

                End If

                Threading.Thread.Sleep(100)
                dm.MoveTo(620, 570)

                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hkey = True

                    dm.KeyPressChar("b")

                End If

                If chkAfkScreen.CheckState = CheckState.Unchecked Then
                    dm.KeyPressChar("0")
                    dm.KeyPressChar("g")
                End If

                dm.MoveTo(200, 650)
                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)

                dm.MoveTo(643, 606)
                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)


                If chkAfk5key.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("5")
                End If
                If chkAfk6key.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("6")
                End If
                If chkAfkRkey.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("R")
                End If

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hkey = True

                    dm.KeyPressChar("b")

                End If


                If chkAfk護甲key.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                If chkAfkLike.CheckState = CheckState.Checked Then
                    dm.MoveTo(985, 210)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 230)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 250)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 270)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 290)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 310)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 330)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 350)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 370)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 390)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 410)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 430)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 450)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                End If

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hkey = True

                    dm.KeyPressChar("b")

                End If


                If chkAfk5key.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("5")
                End If
                If chkAfk6key.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("6")
                End If
                If chkAfkRkey.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("R")
                End If

                If chkAfk護甲key.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                dm.MoveTo(906, 700)
                Threading.Thread.Sleep(100)

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hkey = True

                    dm.KeyPressChar("b")

                End If

                LeftClick()
                Threading.Thread.Sleep(100)
                dm.MoveTo(515, 400)
                Threading.Thread.Sleep(100)

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hkey = True

                    dm.KeyPressChar("b")

                End If

                LeftClick()
                Threading.Thread.Sleep(100)
                If chkAfk護甲key.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                '///////////////////////////////////////////////////////////////

                If chkAfkScreen.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    dm.KeyUpChar("h")
                    dm.KeyDownChar("alt")
                    hkey = True

                    dm.KeyPressChar("b")

                End If

                If chkMouseMoveR.CheckState = CheckState.Checked Then
                    MouseMoveR()
                    Threading.Thread.Sleep(100)
                End If

            End If

        Loop
    End Sub

    '/////////////////////////////購買護甲///////////////////////////////
    Public Function 購買護甲()
        dm.KeyPressChar("b")
        Threading.Thread.Sleep(50)
        dm.KeyPressChar("8")
        Threading.Thread.Sleep(50)
        dm.KeyPressChar(afk護甲Key)
        Threading.Thread.Sleep(50)
        dm.KeyPressChar("0")
        dm.KeyPressChar("0")
        Threading.Thread.Sleep(50)
        dm.MoveTo(513, 422)
        Threading.Thread.Sleep(50)
        dm.LeftClick
        dm.KeyPressChar("0")
        dm.KeyPressChar("0")
    End Function
    '///////////////////////////////////////////////////////////////////////
    '/////////////////////////////LeftClick///////////////////////////////
    Public Function LeftClick()
        dm.LeftDown
        Threading.Thread.Sleep(50)
        dm.LeftUp
    End Function
    '///////////////////////////////////////////////////////////////////////
    '/////////////////////////////MouseMoveR///////////////////////////////
    Public Function MouseMoveR()
        dm.MoveR(50, 50)
        Threading.Thread.Sleep(txtMouseMoveR.Text)
        dm.MoveR(-50, -50)
        Threading.Thread.Sleep(txtMouseMoveR.Text)
    End Function
    '///////////////////////////////////////////////////////////////////////

    Dim strKey2() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "[", "]", ",", ".", ";", "'", "-", "="}

    Public Sub AddKeyItem_LA2(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey2.Length - 1
            cbo.Items.Add(strKey2(i))
        Next
        cbo.SelectedIndex = 0
    End Sub


End Class














Public Class Ver '檢查更新
    '字串常數
    Private Const DefaultInfoCode As String = "UTF-8" '儲存預設編碼為「UTF-8」
    Private Const DefaultInfoFeature As String = "Ver" '儲存預設更新版本資訊的特徵為「電腦不難」
    Private Const DefaultInfoSeparator As String = "|" '儲存預設更新版本資訊的分隔字元符號為「|」
    Private Const DefaultNotCheckReturn As String = "Not yet." '儲存還沒檢查更新時所傳回的字串訊息
    Private Const DefaultCheckErrorReturn As String = "Error." '儲存檢查更新失敗時所傳回的字串訊息


    '更新資訊組態
    Private sInfoURL As String '儲存更新版本資訊的網址
    Private sInfoCode As String = DefaultInfoCode '編碼
    Private sInfoFeature As String = DefaultInfoFeature '儲存更新版本資訊的特徵，預設為「電腦不難」

    '檢查結果
    Private shInfoConsequence As Short = -1 '0為沒有新版本；1為有新版本；2為檢查更新失敗；-1為尚未檢查
    Private sInfoNumber As String '儲存取得的版本號碼

    Public Sub New(ByVal SetInfoURL As String) 'CheckNew建構子(多載1)。引數為SetInfoURL，載入更新版本資訊的網址。
        sInfoURL = SetInfoURL '設定更新版本資訊的網址
    End Sub

    Public Sub New(ByVal SetInfoURL As String, ByVal SetInfoFeature As String) 'CheckNew建構子(多載2)。引數為SetInfoURL和SetInfoFeature，載入更新版本資訊的網址和判斷特徵。
        sInfoURL = SetInfoURL '設定更新版本資訊的網址
        sInfoFeature = SetInfoFeature '設定更新版本資訊的特徵
    End Sub

    Public WriteOnly Property SetInfoCode() As String '設定更新版本資訊的編碼
        Set(ByVal Code As String)
            sInfoCode = Code
        End Set
    End Property

    Public WriteOnly Property SetInfoURL() As String '設定網址
        Set(ByVal URL As String)
            sInfoURL = URL
        End Set
    End Property

    Public WriteOnly Property SetInfoFeature() As String '設定特徵
        Set(ByVal Feature As String)
            sInfoFeature = Feature
        End Set
    End Property

    Public ReadOnly Property GetMyVersion() As String '取得程式的版本號碼(格式：X.X.X)
        Get
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build '取得版本號碼
        End Get
    End Property

    Public ReadOnly Property GetCheckConsequence() As String '取得檢查更新的結果
        Get
            Return shInfoConsequence
        End Get
    End Property

    Public ReadOnly Property GetCheckConsequenceNumber() As String '取得最新版本號碼
        Get
            If shInfoConsequence = -1 Then '如果還沒檢查
                Return DefaultNotCheckReturn
            ElseIf shInfoConsequence = 2 Then '如果檢查失敗
                Return DefaultCheckErrorReturn
            Else '如果檢查成功
                Return sInfoNumber
            End If
        End Get
    End Property

    Public Sub Ver() '檢查更新
        On Error Resume Next
        Dim CheckNewClient As New Net.WebClient() '宣告CheckNewClient為WebClient物件
        Dim Encode As System.Text.Encoding = System.Text.Encoding.GetEncoding(sInfoCode) '設定編碼
        Dim Info As IO.StreamReader = New IO.StreamReader(CheckNewClient.OpenRead(sInfoURL), Encode) '取得更新資訊
        Dim sInfoData As String = Info.ReadLine '儲存更新資訊

        Debug.Print("InfoData = """ & sInfoData & """") '(除錯用)顯示出從網路上下載的字串

        If Strings.InStr(1, sInfoData, sInfoFeature) > 0 Then '若能找到識別關鍵字(InfoFeature)，則更新資訊取得成功
            Dim InfoArr() As String = Split(sInfoData, DefaultInfoSeparator) '分解字串為版本號碼(0)和識別關鍵字(1)
            sInfoNumber = InfoArr(0) '儲存最新版本號碼
            If InfoArr(0) > GetMyVersion() Then '比對版本號碼，若不相同，代表有新版本
                shInfoConsequence = 1
            ElseIf InfoArr(0) < GetMyVersion() Then
                shInfoConsequence = 99
            Else '若版本號碼相同，則代表沒有新版本
                shInfoConsequence = 0
            End If
        Else '若未能找到識別關鍵字(專案名稱)，則更新資訊取得失敗
            shInfoConsequence = 2
        End If
    End Sub












End Class