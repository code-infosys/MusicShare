<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" EnableViewState="false" CodeBehind="SongDetail.aspx.cs" Inherits="MusicShare.FrontEndPages.SongDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Literal ID="LitTopInfo" runat="server"></asp:Literal>


    <div class="clear"></div>
    <div class="head">Track List</div>


    <asp:Literal ID="litSongBind" runat="server"></asp:Literal>

    <p class="track">
        <span class="arr">»</span>   <asp:LinkButton ID="lbtnPlay" OnClick="lbtnPlay_Click" runat="server">Play Online</asp:LinkButton>
    </p>
    <asp:HiddenField ID="hideSongPlay" runat="server" />
    <asp:Literal ID="LitPlayer" runat="server"></asp:Literal>


    <p class="track">
        <span class="arr">»</span>  <a href="">Share And Like Script</a>
    </p>

    <asp:Literal ID="litPostedByINFO" runat="server"></asp:Literal>

    <div class="head">User Comments</div>
    <div>



        <div class="clear"></div>
    </div>

</asp:Content>
