<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RecommendedTracks.aspx.cs" Inherits="MusicShare.FrontEndPages.RecommendedTracks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="hcontrol">Recommended Single Tracks</h1>

     <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">
         
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
         
        <ItemTemplate> 
             <span class="arr">»</span>
               <a class="aresfe" href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"> <%#Eval("SongTitle") %> </a>
            <span class="ssname">(<%#Eval("SingerName") %>)</span> <br />
        </ItemTemplate>


        <LayoutTemplate>

            <div id="itemPlaceholderContainer" runat="server" style=""><span runat="server" id="itemPlaceholder" /></div>
            <div style="margin-top:10px;">
                <asp:DataPager runat="server" ID="DataPager2">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                        <asp:NumericPagerField></asp:NumericPagerField>
                        <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager> 
            </div>
        </LayoutTemplate>

        
    </asp:ListView>

     
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTracksRecAndTop20weekAndTop20month" TypeName="MusicShare.StarMethods">
            <SelectParameters>
                <asp:Parameter Type="String" DefaultValue="Recommended" Name="action" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
     

</asp:Content>
