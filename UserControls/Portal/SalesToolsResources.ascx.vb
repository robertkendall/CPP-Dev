﻿Imports WSC.Extensions.ControlExtensions

Partial Class usercontrols_Portal_SalesToolsResources
    Inherits WSC.UserControlBase

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Me.ProtectPage("0", "1", "2", "3", "5")
        Me.Page.Title = "Resources - " & Me.Page.Title
    End Sub

    Protected Overrides Sub CreateChildControls()
        MyBase.CreateChildControls()
        Dim fb = Me.Page.LoadControl("/usercontrols/FileBrowser.ascx")
        fb.SetPropertyValue("DirectoryPath", "/media/website/Resources")
        Me.Controls.Add(fb)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub
End Class
