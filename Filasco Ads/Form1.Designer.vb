<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.globalVOIP = New System.Windows.Forms.WebBrowser()
        Me.btnSetData = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFit = New System.Windows.Forms.Button()
        Me.calltermination = New System.Windows.Forms.WebBrowser()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.goBack = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBoxSubject = New System.Windows.Forms.ComboBox()
        Me.voiphelp = New System.Windows.Forms.WebBrowser()
        Me.bestVoip = New System.Windows.Forms.WebBrowser()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGlobalVoipUser = New System.Windows.Forms.Label()
        Me.lblGlobalVoipPass = New System.Windows.Forms.Label()
        Me.LabelPass2 = New System.Windows.Forms.Label()
        Me.LabelUser2 = New System.Windows.Forms.Label()
        Me.forumVoip = New System.Windows.Forms.WebBrowser()
        Me.voiptraffic = New System.Windows.Forms.WebBrowser()
        Me.times = New System.Windows.Forms.Button()
        Me.lblForumVoipPass = New System.Windows.Forms.Label()
        Me.lblForumVoipUser = New System.Windows.Forms.Label()
        Me.lblVoipHelpPass = New System.Windows.Forms.Label()
        Me.lblVoipHelpUser = New System.Windows.Forms.Label()
        Me.lblBestVoipPass = New System.Windows.Forms.Label()
        Me.lblBestVoipUser = New System.Windows.Forms.Label()
        Me.lblVoipTrafficPass = New System.Windows.Forms.Label()
        Me.lblVoipTrafficUser = New System.Windows.Forms.Label()
        Me.btnSaveAds = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.lvlSubjectLength = New System.Windows.Forms.Label()
        Me.lvlBodyLength = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.voipForum = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Label()
        Me.lvlTimes = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbInterval = New System.Windows.Forms.ComboBox()
        Me.lvlcounter = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.lblMAC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'globalVOIP
        '
        Me.globalVOIP.Location = New System.Drawing.Point(15, 217)
        Me.globalVOIP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.globalVOIP.MinimumSize = New System.Drawing.Size(15, 16)
        Me.globalVOIP.Name = "globalVOIP"
        Me.globalVOIP.Size = New System.Drawing.Size(573, 284)
        Me.globalVOIP.TabIndex = 1
        Me.globalVOIP.Url = New System.Uri("https://globalvoipforum.com/forums/i-buy-voip-routes.4/post-thread", System.UriKind.Absolute)
        '
        'btnSetData
        '
        Me.btnSetData.Location = New System.Drawing.Point(16, 29)
        Me.btnSetData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSetData.Name = "btnSetData"
        Me.btnSetData.Size = New System.Drawing.Size(86, 31)
        Me.btnSetData.TabIndex = 2
        Me.btnSetData.Text = "Set Data"
        Me.btnSetData.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Location = New System.Drawing.Point(106, 29)
        Me.btnPost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(86, 31)
        Me.btnPost.TabIndex = 2
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(196, 29)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(450, 32)
        Me.txtSubject.TabIndex = 3
        '
        'txtBody
        '
        Me.txtBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBody.Location = New System.Drawing.Point(16, 65)
        Me.txtBody.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(630, 131)
        Me.txtBody.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1018, 29)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Zoom +"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnFit
        '
        Me.btnFit.Location = New System.Drawing.Point(1155, 29)
        Me.btnFit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFit.Name = "btnFit"
        Me.btnFit.Size = New System.Drawing.Size(64, 24)
        Me.btnFit.TabIndex = 6
        Me.btnFit.Text = "Fit"
        Me.btnFit.UseVisualStyleBackColor = True
        '
        'calltermination
        '
        Me.calltermination.Location = New System.Drawing.Point(608, 217)
        Me.calltermination.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.calltermination.MinimumSize = New System.Drawing.Size(15, 16)
        Me.calltermination.Name = "calltermination"
        Me.calltermination.Size = New System.Drawing.Size(577, 284)
        Me.calltermination.TabIndex = 7
        Me.calltermination.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1087, 29)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 24)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Zoom -"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'goBack
        '
        Me.goBack.Location = New System.Drawing.Point(847, 87)
        Me.goBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(64, 24)
        Me.goBack.TabIndex = 9
        Me.goBack.Text = "+1"
        Me.goBack.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(950, 30)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(64, 24)
        Me.btnReload.TabIndex = 10
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1156, 58)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 24)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Start"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 6)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1444, 19)
        Me.ProgressBar1.TabIndex = 14
        '
        'ComboBoxSubject
        '
        Me.ComboBoxSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubject.FormattingEnabled = True
        Me.ComboBoxSubject.Items.AddRange(New Object() {"Algeria,Albania,Afghan,Armenia,BD,Belarus,Chad,Cuba,Camerron", "DRC,Ethiopia,Ghana,Gambia,Haiti,Indonesia,Iran,Iraq,Jamaica", "Libya,Mali,Mozambique,Mauritania,Morocco,Nigeria,Nepal,Pak", "Russia,Spain,SA,Sudan,Turkey,Tunisia,Uganda,UAE,Yemen,Zambia"})
        Me.ComboBoxSubject.Location = New System.Drawing.Point(814, 59)
        Me.ComboBoxSubject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxSubject.Name = "ComboBoxSubject"
        Me.ComboBoxSubject.Size = New System.Drawing.Size(338, 25)
        Me.ComboBoxSubject.TabIndex = 16
        '
        'voiphelp
        '
        Me.voiphelp.Location = New System.Drawing.Point(16, 522)
        Me.voiphelp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.voiphelp.MinimumSize = New System.Drawing.Size(15, 16)
        Me.voiphelp.Name = "voiphelp"
        Me.voiphelp.ScriptErrorsSuppressed = True
        Me.voiphelp.Size = New System.Drawing.Size(572, 284)
        Me.voiphelp.TabIndex = 17
        Me.voiphelp.Url = New System.Uri("http://voiphelp24.com/posting.php?mode=post&f=5", System.UriKind.Absolute)
        '
        'bestVoip
        '
        Me.bestVoip.Location = New System.Drawing.Point(608, 522)
        Me.bestVoip.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bestVoip.MinimumSize = New System.Drawing.Size(15, 16)
        Me.bestVoip.Name = "bestVoip"
        Me.bestVoip.ScriptErrorsSuppressed = True
        Me.bestVoip.Size = New System.Drawing.Size(577, 284)
        Me.bestVoip.TabIndex = 18
        Me.bestVoip.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'lblGlobalVoipUser
        '
        Me.lblGlobalVoipUser.AutoSize = True
        Me.lblGlobalVoipUser.Location = New System.Drawing.Point(5, 200)
        Me.lblGlobalVoipUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGlobalVoipUser.Name = "lblGlobalVoipUser"
        Me.lblGlobalVoipUser.Size = New System.Drawing.Size(79, 13)
        Me.lblGlobalVoipUser.TabIndex = 19
        Me.lblGlobalVoipUser.Text = "Jacob Hoffman"
        '
        'lblGlobalVoipPass
        '
        Me.lblGlobalVoipPass.AutoSize = True
        Me.lblGlobalVoipPass.Location = New System.Drawing.Point(122, 200)
        Me.lblGlobalVoipPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGlobalVoipPass.Name = "lblGlobalVoipPass"
        Me.lblGlobalVoipPass.Size = New System.Drawing.Size(67, 13)
        Me.lblGlobalVoipPass.TabIndex = 19
        Me.lblGlobalVoipPass.Text = "1111412555"
        '
        'LabelPass2
        '
        Me.LabelPass2.AutoSize = True
        Me.LabelPass2.Location = New System.Drawing.Point(889, 197)
        Me.LabelPass2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPass2.Name = "LabelPass2"
        Me.LabelPass2.Size = New System.Drawing.Size(67, 13)
        Me.LabelPass2.TabIndex = 20
        Me.LabelPass2.Text = "1111412555"
        '
        'LabelUser2
        '
        Me.LabelUser2.AutoSize = True
        Me.LabelUser2.Location = New System.Drawing.Point(743, 197)
        Me.LabelUser2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUser2.Name = "LabelUser2"
        Me.LabelUser2.Size = New System.Drawing.Size(79, 13)
        Me.LabelUser2.TabIndex = 21
        Me.LabelUser2.Text = "Jacob Hoffman"
        '
        'forumVoip
        '
        Me.forumVoip.Location = New System.Drawing.Point(1208, 217)
        Me.forumVoip.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.forumVoip.MinimumSize = New System.Drawing.Size(15, 16)
        Me.forumVoip.Name = "forumVoip"
        Me.forumVoip.Size = New System.Drawing.Size(573, 284)
        Me.forumVoip.TabIndex = 22
        Me.forumVoip.Url = New System.Uri("", System.UriKind.Relative)
        '
        'voiptraffic
        '
        Me.voiptraffic.Location = New System.Drawing.Point(1208, 522)
        Me.voiptraffic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.voiptraffic.MinimumSize = New System.Drawing.Size(15, 16)
        Me.voiptraffic.Name = "voiptraffic"
        Me.voiptraffic.ScriptErrorsSuppressed = True
        Me.voiptraffic.Size = New System.Drawing.Size(573, 284)
        Me.voiptraffic.TabIndex = 23
        Me.voiptraffic.Url = New System.Uri("", System.UriKind.Relative)
        '
        'times
        '
        Me.times.Location = New System.Drawing.Point(1003, 87)
        Me.times.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.times.Name = "times"
        Me.times.Size = New System.Drawing.Size(64, 24)
        Me.times.TabIndex = 24
        Me.times.Text = "Times"
        Me.times.UseVisualStyleBackColor = True
        '
        'lblForumVoipPass
        '
        Me.lblForumVoipPass.AutoSize = True
        Me.lblForumVoipPass.Location = New System.Drawing.Point(1345, 200)
        Me.lblForumVoipPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForumVoipPass.Name = "lblForumVoipPass"
        Me.lblForumVoipPass.Size = New System.Drawing.Size(67, 13)
        Me.lblForumVoipPass.TabIndex = 26
        Me.lblForumVoipPass.Text = "1111412555"
        '
        'lblForumVoipUser
        '
        Me.lblForumVoipUser.AutoSize = True
        Me.lblForumVoipUser.Location = New System.Drawing.Point(1217, 200)
        Me.lblForumVoipUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForumVoipUser.Name = "lblForumVoipUser"
        Me.lblForumVoipUser.Size = New System.Drawing.Size(79, 13)
        Me.lblForumVoipUser.TabIndex = 27
        Me.lblForumVoipUser.Text = "Jacob Hoffman"
        '
        'lblVoipHelpPass
        '
        Me.lblVoipHelpPass.AutoSize = True
        Me.lblVoipHelpPass.Location = New System.Drawing.Point(175, 503)
        Me.lblVoipHelpPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVoipHelpPass.Name = "lblVoipHelpPass"
        Me.lblVoipHelpPass.Size = New System.Drawing.Size(90, 13)
        Me.lblVoipHelpPass.TabIndex = 28
        Me.lblVoipHelpPass.Text = "4B27KM7SISE42"
        '
        'lblVoipHelpUser
        '
        Me.lblVoipHelpUser.AutoSize = True
        Me.lblVoipHelpUser.Location = New System.Drawing.Point(34, 503)
        Me.lblVoipHelpUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVoipHelpUser.Name = "lblVoipHelpUser"
        Me.lblVoipHelpUser.Size = New System.Drawing.Size(79, 13)
        Me.lblVoipHelpUser.TabIndex = 29
        Me.lblVoipHelpUser.Text = "Jacob Hoffman"
        '
        'lblBestVoipPass
        '
        Me.lblBestVoipPass.AutoSize = True
        Me.lblBestVoipPass.Location = New System.Drawing.Point(894, 507)
        Me.lblBestVoipPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBestVoipPass.Name = "lblBestVoipPass"
        Me.lblBestVoipPass.Size = New System.Drawing.Size(93, 13)
        Me.lblBestVoipPass.TabIndex = 30
        Me.lblBestVoipPass.Text = "1111412555jacob"
        '
        'lblBestVoipUser
        '
        Me.lblBestVoipUser.AutoSize = True
        Me.lblBestVoipUser.Location = New System.Drawing.Point(738, 507)
        Me.lblBestVoipUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBestVoipUser.Name = "lblBestVoipUser"
        Me.lblBestVoipUser.Size = New System.Drawing.Size(79, 13)
        Me.lblBestVoipUser.TabIndex = 31
        Me.lblBestVoipUser.Text = "Jacob Hoffman"
        '
        'lblVoipTrafficPass
        '
        Me.lblVoipTrafficPass.AutoSize = True
        Me.lblVoipTrafficPass.Location = New System.Drawing.Point(1345, 507)
        Me.lblVoipTrafficPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVoipTrafficPass.Name = "lblVoipTrafficPass"
        Me.lblVoipTrafficPass.Size = New System.Drawing.Size(93, 13)
        Me.lblVoipTrafficPass.TabIndex = 32
        Me.lblVoipTrafficPass.Text = "1111412555jacob"
        '
        'lblVoipTrafficUser
        '
        Me.lblVoipTrafficUser.AutoSize = True
        Me.lblVoipTrafficUser.Location = New System.Drawing.Point(1217, 507)
        Me.lblVoipTrafficUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVoipTrafficUser.Name = "lblVoipTrafficUser"
        Me.lblVoipTrafficUser.Size = New System.Drawing.Size(79, 13)
        Me.lblVoipTrafficUser.TabIndex = 33
        Me.lblVoipTrafficUser.Text = "Jacob Hoffman"
        '
        'btnSaveAds
        '
        Me.btnSaveAds.Location = New System.Drawing.Point(735, 29)
        Me.btnSaveAds.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveAds.Name = "btnSaveAds"
        Me.btnSaveAds.Size = New System.Drawing.Size(74, 24)
        Me.btnSaveAds.TabIndex = 34
        Me.btnSaveAds.Text = "Insert Ads"
        Me.btnSaveAds.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(735, 58)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(74, 24)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update Ads."
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(735, 88)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(74, 24)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete Ads."
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(1156, 88)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(64, 24)
        Me.btnStop.TabIndex = 37
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnSwitch
        '
        Me.btnSwitch.Location = New System.Drawing.Point(1087, 88)
        Me.btnSwitch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(64, 24)
        Me.btnSwitch.TabIndex = 38
        Me.btnSwitch.Text = "Switch"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'lvlSubjectLength
        '
        Me.lvlSubjectLength.AutoSize = True
        Me.lvlSubjectLength.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lvlSubjectLength.Location = New System.Drawing.Point(620, 38)
        Me.lvlSubjectLength.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvlSubjectLength.Name = "lvlSubjectLength"
        Me.lvlSubjectLength.Size = New System.Drawing.Size(19, 13)
        Me.lvlSubjectLength.TabIndex = 39
        Me.lvlSubjectLength.Text = "00"
        '
        'lvlBodyLength
        '
        Me.lvlBodyLength.AutoSize = True
        Me.lvlBodyLength.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lvlBodyLength.Location = New System.Drawing.Point(605, 69)
        Me.lvlBodyLength.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvlBodyLength.Name = "lvlBodyLength"
        Me.lvlBodyLength.Size = New System.Drawing.Size(25, 13)
        Me.lvlBodyLength.TabIndex = 40
        Me.lvlBodyLength.Text = "000"
        '
        'Timer3
        '
        '
        'voipForum
        '
        Me.voipForum.Location = New System.Drawing.Point(16, 1033)
        Me.voipForum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.voipForum.MinimumSize = New System.Drawing.Size(15, 16)
        Me.voipForum.Name = "voipForum"
        Me.voipForum.Size = New System.Drawing.Size(2256, 80)
        Me.voipForum.TabIndex = 41
        Me.voipForum.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(847, 116)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.AutoSize = True
        Me.start.Location = New System.Drawing.Point(912, 94)
        Me.start.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(13, 13)
        Me.start.TabIndex = 43
        Me.start.Text = "0"
        '
        'lvlTimes
        '
        Me.lvlTimes.AutoSize = True
        Me.lvlTimes.Location = New System.Drawing.Point(986, 94)
        Me.lvlTimes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvlTimes.Name = "lvlTimes"
        Me.lvlTimes.Size = New System.Drawing.Size(13, 13)
        Me.lvlTimes.TabIndex = 44
        Me.lvlTimes.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(929, 91)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 25)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbInterval
        '
        Me.cmbInterval.FormattingEnabled = True
        Me.cmbInterval.Items.AddRange(New Object() {"Default Interval", "20 Minutes Interval", "25 Minutes Interval", "30 Minutes Interval"})
        Me.cmbInterval.Location = New System.Drawing.Point(823, 32)
        Me.cmbInterval.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbInterval.Name = "cmbInterval"
        Me.cmbInterval.Size = New System.Drawing.Size(116, 21)
        Me.cmbInterval.TabIndex = 46
        '
        'lvlcounter
        '
        Me.lvlcounter.Location = New System.Drawing.Point(695, 42)
        Me.lvlcounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvlcounter.Name = "lvlcounter"
        Me.lvlcounter.Size = New System.Drawing.Size(19, 12)
        Me.lvlcounter.TabIndex = 0
        Me.lvlcounter.Text = "0"
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Items.AddRange(New Object() {"Aaron", "Daniel", "Roger", "Jacob"})
        Me.cmbUser.Location = New System.Drawing.Point(730, 151)
        Me.cmbUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(92, 21)
        Me.cmbUser.TabIndex = 47
        '
        'lblMAC
        '
        Me.lblMAC.AutoSize = True
        Me.lblMAC.Location = New System.Drawing.Point(684, 120)
        Me.lblMAC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMAC.Name = "lblMAC"
        Me.lblMAC.Size = New System.Drawing.Size(39, 13)
        Me.lblMAC.TabIndex = 48
        Me.lblMAC.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(2280, 862)
        Me.Controls.Add(Me.lblMAC)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.lvlcounter)
        Me.Controls.Add(Me.cmbInterval)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lvlTimes)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.voipForum)
        Me.Controls.Add(Me.lvlBodyLength)
        Me.Controls.Add(Me.lvlSubjectLength)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSaveAds)
        Me.Controls.Add(Me.lblVoipTrafficPass)
        Me.Controls.Add(Me.lblVoipTrafficUser)
        Me.Controls.Add(Me.lblBestVoipPass)
        Me.Controls.Add(Me.lblBestVoipUser)
        Me.Controls.Add(Me.lblVoipHelpPass)
        Me.Controls.Add(Me.lblVoipHelpUser)
        Me.Controls.Add(Me.lblForumVoipPass)
        Me.Controls.Add(Me.lblForumVoipUser)
        Me.Controls.Add(Me.times)
        Me.Controls.Add(Me.voiptraffic)
        Me.Controls.Add(Me.forumVoip)
        Me.Controls.Add(Me.LabelPass2)
        Me.Controls.Add(Me.LabelUser2)
        Me.Controls.Add(Me.lblGlobalVoipPass)
        Me.Controls.Add(Me.lblGlobalVoipUser)
        Me.Controls.Add(Me.bestVoip)
        Me.Controls.Add(Me.voiphelp)
        Me.Controls.Add(Me.ComboBoxSubject)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.goBack)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.calltermination)
        Me.Controls.Add(Me.btnFit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnSetData)
        Me.Controls.Add(Me.globalVOIP)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Aaron"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents globalVOIP As WebBrowser
    Friend WithEvents btnSetData As Button
    Friend WithEvents btnPost As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnFit As Button
    Friend WithEvents calltermination As WebBrowser
    Friend WithEvents Button5 As Button
    Friend WithEvents goBack As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ComboBoxSubject As ComboBox
    Friend WithEvents voiphelp As WebBrowser
    Friend WithEvents bestVoip As WebBrowser
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblGlobalVoipUser As Label
    Friend WithEvents lblGlobalVoipPass As Label
    Friend WithEvents LabelPass2 As Label
    Friend WithEvents LabelUser2 As Label
    Friend WithEvents forumVoip As WebBrowser
    Friend WithEvents voiptraffic As WebBrowser
    Friend WithEvents times As Button
    Friend WithEvents lblForumVoipPass As Label
    Friend WithEvents lblForumVoipUser As Label
    Friend WithEvents lblVoipHelpPass As Label
    Friend WithEvents lblVoipHelpUser As Label
    Friend WithEvents lblBestVoipPass As Label
    Friend WithEvents lblBestVoipUser As Label
    Friend WithEvents lblVoipTrafficPass As Label
    Friend WithEvents lblVoipTrafficUser As Label
    Friend WithEvents btnSaveAds As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnSwitch As Button
    Friend WithEvents lvlSubjectLength As Label
    Friend WithEvents lvlBodyLength As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents voipForum As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents start As Label
    Friend WithEvents lvlTimes As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbInterval As ComboBox
    Friend WithEvents lvlcounter As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents lblMAC As Label
End Class
