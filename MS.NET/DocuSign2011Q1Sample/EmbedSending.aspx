﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Tabs.Master" AutoEventWireup="true" CodeBehind="EmbedSending.aspx.cs" Inherits="DocuSign2011Q1Sample.EmbedSending" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="hostedSending">
<iframe runat="server" id="sendingFrame" width="100%" height="720px"></iframe>
</div>
</asp:Content>
