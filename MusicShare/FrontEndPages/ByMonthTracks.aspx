<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ByMonthTracks.aspx.cs" Inherits="MusicShare.FrontEndPages.ByMonthTracks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="hcontrol">By Month Single Tracks</h1>

    <asp:Panel ID="PNLmonths" runat="server">


        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/1/January 2014">January </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/2/February 2014">February </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/3/March 2014">March </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/4/April 2014">April </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/5/May 2014">May </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/6/June 2014">June </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/7/July 2014">July </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/8/August 2014">August </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/9/September 2014">September </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/10/October 2014">October </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/11/November 2014">November </a>
        <br />
        <span class="arr">»</span>
        <a class="aresfe" href="/single_-tracks/12/December 2014">December </a>
        <br />

    </asp:Panel>
    <asp:Panel ID="pnlSongs" runat="server" Visible="false">
    
     
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



        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTracksByMonth" TypeName="MusicShare.StarMethods">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="monthid" DefaultValue="0" Name="month" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:ObjectDataSource>
        

    </asp:Panel>
</asp:Content>
