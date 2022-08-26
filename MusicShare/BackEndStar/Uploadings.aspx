<%@ Page Title="" Language="C#" MasterPageFile="~/BEadmin.Master" AutoEventWireup="true" CodeBehind="Uploadings.aspx.cs" Inherits="MusicShare.BackEndStar.Uploadings" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="hcontrol">All Uploadings</h1>
    
    

    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="LinqDataSource1" AllowSorting="True" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
        <Columns>
           <asp:TemplateField>
               <ItemTemplate>
                    <asp:CheckBox ID="chkApprove" runat="server" />
                    <asp:HiddenField ID="hideIdd" runat="server" Value='<%#Eval("ID") %>' />
                    <asp:HiddenField ID="hideSongTitle" Value='<%#Bind("SongTitle") %>' runat="server" />
                    <asp:HiddenField ID="hideAlbumName" Value='<%#Bind("AlbumName") %>' runat="server" />
                    <asp:HiddenField ID="HideSingerName" Value='<%#Bind("SingerName") %>' runat="server" />
               </ItemTemplate>
           </asp:TemplateField>
            <asp:BoundField DataField="ID" Visible="false" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
            <asp:CommandField ShowEditButton="True" ControlStyle-BorderWidth="1" ControlStyle-BorderStyle="Solid"></asp:CommandField>
            
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

            <asp:TemplateField HeaderText="FileName">
                <ItemTemplate>
                    <%#Eval("SongUrl") %>
                </ItemTemplate>
                <EditItemTemplate>
                     <asp:HiddenField ID="hideOldUrlName" Value='<%#Eval("SongUrl") %>' runat="server" />
                    <asp:TextBox ID="txtUrlNameSong" runat="server" Text='<%#Bind("SongUrl") %>'></asp:TextBox>
                     
                </EditItemTemplate>
            </asp:TemplateField>

           
             
            <asp:BoundField DataField="SongTitle" HeaderText="SongTitle" SortExpression="SongTitle"></asp:BoundField>
            <asp:BoundField DataField="AlbumName" HeaderText="AlbumName" SortExpression="AlbumName"></asp:BoundField>
            <asp:BoundField DataField="SingerName" HeaderText="SingerName" SortExpression="SingerName"></asp:BoundField> 
           
            
             <asp:BoundField DataField="MetaTags" ItemStyle-Wrap="true"   HeaderText="MetaTags" SortExpression="MetaTags"></asp:BoundField>
            <asp:BoundField DataField="MetaDescription" HeaderText="MetaDescription" SortExpression="MetaDescription"></asp:BoundField>
            
            <asp:TemplateField HeaderText="CoverImage">
                <ItemTemplate>
                    <img src="320kb/Cover/<%#Eval("CoverImage") %>" style="width:100px;" />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:BoundField DataField="AlbumReleaseOn" ReadOnly="true"  DataFormatString="{0:dd MMM yyyy}" HeaderText="AlbumReleaseOn" SortExpression="AlbumReleaseOn"></asp:BoundField>
            
            
            
             

            <%--<asp:BoundField DataField="SongUrl" HeaderText="SongUrl" SortExpression="SongUrl"></asp:BoundField>--%>
          
            <asp:BoundField DataField="DateAdded" ReadOnly="true"  DataFormatString="{0:dd MMM yyyy}" HeaderText="DateAdded" SortExpression="DateAdded"></asp:BoundField>
           
            
            
             <asp:TemplateField Visible="false" HeaderText="Uploader"> 
                 <ItemTemplate>
                     <a href="<%#Eval("UsrId") %>">View</a>
                 </ItemTemplate>
             </asp:TemplateField>
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

    <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSource1" ContextTypeName="MusicShare.MSContextDataContext" OrderBy="DateAdded desc" TableName="TracksWrapers" Where="IsApproved == null" EnableDelete="True" EnableInsert="True" EnableUpdate="True"> </asp:LinqDataSource>
    <br />

    <asp:Button ID="btnApprive" runat="server" OnClick="btnApprive_Click" Text="Approve" />

    <asp:Button ID="Button1" Visible="false" runat="server" OnClick="Button1_Click" Text="Button" />

</asp:Content>
