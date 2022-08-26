<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="MySongsList.aspx.cs" Inherits="MusicShare.MySongsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <h1 class="hcontrol">My Uploaded Song Detail</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="LinqDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
        <EmptyDataTemplate>
            <h3>No Uploaded File</h3>
        </EmptyDataTemplate>
        <Columns>
            <asp:TemplateField HeaderText="SNo.">
                  <ItemTemplate>
                          <%#Container.DataItemIndex+1 %>
                   </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="false" InsertVisible="False" SortExpression="ID"></asp:BoundField>
            <asp:BoundField DataField="SongTitle" HeaderText="Song Title" SortExpression="SongTitle"></asp:BoundField>
            <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName"></asp:BoundField>
            <asp:BoundField DataField="SingerName" HeaderText="Singer Name" SortExpression="SingerName"></asp:BoundField> 
            <asp:BoundField DataField="AlbumReleaseOn" DataFormatString="{0:dd MMM yyyy}" HeaderText="Release On" SortExpression="AlbumReleaseOn"></asp:BoundField>
           
             <asp:TemplateField HeaderText="CoverImage">
                  <ItemTemplate>
                      <img src="320kb/Cover/<%#Eval("CoverImage") %>" style="width:70px;border:1px solid;padding:3px;" />
                  </ItemTemplate>
            </asp:TemplateField>
              
             <asp:TemplateField HeaderText="Song File">
                  <ItemTemplate>
                      <asp:HiddenField ID="hidesongurl" runat="server" Value='<%#Eval("SongUrl") %>' />
                        <asp:Panel ID="pnlShow" runat="server" Visible='<%#Eval("SongUrl").ToString().Length > 0 ? true : false %>'>
 
                         <object type="application/x-shockwave-flash" data="dewplayer.swf?mp3=320kb/<%#Eval("SongUrl") %>" width="200" height="20" id="dewplayer">
                             <param name="wmode" value="transparent" />
                             <param name="movie" value="dewplayer.swf?mp3=320kb/<%#Eval("SongUrl") %>" />
                          </object>
                      </asp:Panel>

                      <asp:Panel ID="Panel1" runat="server" Visible='<%#Eval("SongUrl").ToString().Length > 0 ? false : true %>'>
                          <a href="/uploadsmf_<%#Eval("ID") %>">Upload</a>
                      </asp:Panel>

                  </ItemTemplate>
            </asp:TemplateField>
              
            <asp:BoundField DataField="DateAdded" DataFormatString="{0:dd MMM yyyy}" HeaderText="Uploaded On" SortExpression="DateAdded"></asp:BoundField> 
            <asp:BoundField DataField="DateApproved" DataFormatString="{0:dd MMM yyyy}" HeaderText="Approved On" SortExpression="DateApproved"></asp:BoundField>
            <asp:CheckBoxField DataField="IsApproved" HeaderText="Status Approve" SortExpression="IsApproved"></asp:CheckBoxField> 
            <asp:BoundField DataField="DownloadCount" HeaderText="Download" SortExpression="DownloadCount"></asp:BoundField>
        </Columns>
        <EditRowStyle BackColor="#2461BF"></EditRowStyle>

        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

        <RowStyle BackColor="#EFF3FB"></RowStyle>

        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
    </asp:GridView>


    <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSource1" ContextTypeName="MusicShare.MSContextDataContext" EnableUpdate="True" OrderBy="DateAdded desc" TableName="TracksWrapers" Where="UsrId == @UsrId">
        <WhereParameters>
            <asp:SessionParameter SessionField="USERDIID" DefaultValue="0" Name="UsrId" Type="Decimal"></asp:SessionParameter>
        </WhereParameters>
    </asp:LinqDataSource>
 


</asp:Content>
