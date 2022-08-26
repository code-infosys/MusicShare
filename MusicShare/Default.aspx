<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MusicShare.Default" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        span
        {
            color: maroon;
        }
    </style>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Search Song"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" />
    <p>
        <span>»</span> <a href="/latest/single-tracks">Latest Single Tracks Albums</a>
    </p>
    <p>
        <span>»</span> <a href="/by-month/single-tracks">Single Tracks By Month</a>
    </p>
    <p>
        <span>»</span> <a href="/recommended/single-tracks">Recommended Tracks</a>
    </p> 
    <p>
        <span>»</span> <a href="/top20/weekly/single-tracks">Top 20 Single Tracks Songs</a> (Week)
    </p>
    <p>
        <span>»</span> <a href="/top20/monthly/single-tracks">Top 20 Single Tracks Songs</a> (Month)
    </p>
    <p>
        <span>»</span> <a href="/a-to-z/single-tracks">A-Z Single Tracks Albums</a>
    </p>

</asp:Content>
