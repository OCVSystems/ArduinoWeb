<%@ Page Title="" Language="C#" MasterPageFile="~/Top.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArduinoWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button Text="OFF" runat="server" ID="btnOFF" Height="114px" Width="204px" OnClick="btnOFF_Click" />

    <asp:Button Text="Green" runat="server" ID="btnGreen" Height="114px" Width="204px" BackColor="Green" OnClick="btnGreen_Click" />

    <asp:Button Text="Red" runat="server" ID="btnRed" Height="114px" Width="204px" BackColor="Red" OnClick="btnRed_Click" />

    <asp:Button Text="Both" runat="server" ID="btnBoth" Height="114px" Width="204px" BackColor="Orange" OnClick="btnBoth_Click" />
</asp:Content>
