﻿<%@ Application Language="C#" Inherits="System.Web.HttpApplication" %>

<script runat="server">
    public override void Init()
    {
        PostAuthenticateRequest += (sender, e) =>
        {
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
        };
        base.Init();
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
</script>
