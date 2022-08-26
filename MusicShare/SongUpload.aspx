<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="SongUpload.aspx.cs" Inherits="MusicShare.SongUpload" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="css/uploadify.css" />
    <script type="text/javascript" src="scripts/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.uploadify.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <%-- <a href="javascript:$('#<%=FileUpload1.ClientID%>').fileUploadStart()">Start Upload</a>&nbsp; 
           |&nbsp;<a href="javascript:$('#<%=FileUpload1.ClientID%>').fileUploadClearQueue()">Clear</a>
        <div style="padding: 40px">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>--%>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
        <h1 class="hcontrol">Upload Song Here</h1>
        <h3 style="color: red;">Note: Mp3 File Should Be.</h3>
        <ul style="color: red;">
            <li>Follow 2 Step Must
                <ul>
                    <li>
                        Song Detail
                    </li>
                     <li>
                        Song Upload
                    </li>
                </ul>
            </li>
            <li>Size Above 4mb</li>
            <li>Bitrate 320kbps </li>
            <li>Upload Just Mp3 File </li>
            <li>File Name (Just Song Name) </li>
            <li>Cover Image Is Must </li>

        </ul>


        <asp:TabContainer ID="TabContainer1"  runat="server" ActiveTabIndex="0" >
            <asp:TabPanel runat="server" HeaderText="Song Detail" ID="tabDetail">
                <ContentTemplate>

                    <table>
                        <tr>
                            <td>Song Name: </td>
                            <td>
                                <asp:TextBox ID="txtSongName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Album Name:</td>
                            <td>
                                <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Singer Name: </td>
                            <td>
                                <asp:TextBox ID="txtSingerName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Number Of Track: </td>
                            <td>
                                <asp:DropDownList ID="ddlNumberOfTracks" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Album/Song Release Date:</td>
                            <td>
                                <asp:TextBox ID="txtSongReleaseDate" placeholder="mm/dd/yyyy" runat="server"></asp:TextBox>
                                <asp:CalendarExtender runat="server" Enabled="True" TargetControlID="txtSongReleaseDate" ID="txtSongReleaseDate_CalendarExtender"></asp:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Song/Album Cover Image:</td>
                            <td>
                                <div class="file-uploader-button">

                                    <img src="images/file-uploader-icon.png" />

                                    <asp:FileUpload ID="FUimgCover" runat="server" CssClass="file-upload" />
                                    Select Image
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>Song Tags:</td>
                            <td>
                                <asp:TextBox ID="txtTags" TextMode="MultiLine" placeholder="Eg: song name , singer, title etc" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Song Description:</td>
                            <td>
                                <asp:TextBox ID="txtDescription" placeholder="Describe about singer and song" TextMode="MultiLine" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <script>
                                    function fungo() {
                                        document.getElementById('<%=btnUPload.ClientID%>').style.display = "none";
                                        document.getElementById('fbtn').style.display = 'block';

                                    }
                                </script>



                                <asp:Button ID="btnUPload" OnClick="btnUPload_Click" OnClientClick="fungo()" runat="server" Text="Upload" />
                                <span style="display: none; border-bottom: 1px solid; width: 100px;" id="fbtn" class="fackbutton">
                                    <img src="images/loading.gif" />
                                    <br />
                                    Uploading...</span>

                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                <asp:HiddenField ID="HideQsID" runat="server" />
                            </td>
                        </tr>

                    </table>

                </ContentTemplate>
            </asp:TabPanel>


            <asp:TabPanel runat="server" HeaderText="Song Upload" ID="tabUpload">

                <ContentTemplate>
                    <table>
                        <tr>
                            <td>Select Song: </td>
                            <td>
                                 

                                <script>
                                    function sto() {
                                        var s = 1;
                                        var w = document.getElementById('<%=HiddenField1.ClientID%>').value;
                                        if (s == w) {
                                            javascript: $('#<%=FileUpSong.ClientID%>').fileUploadStart();
                                        }
                                    }
                                </script>

                                <asp:FileUpload ID="FileUpSong" runat="server" CssClass="file-upload" />



                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <span class="fackbutton" style="width:100px;" onclick="sto();">Upload Song</span>
                                 
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>

    </div>

    <script type="text/javascript">
        $(window).load(
            function () {
                $("#<%=FileUpSong.ClientID%>").fileUpload({
                    'uploader': 'scripts/uploader.swf',
                    'cancelImg': 'images/cancel.png',
                    'buttonText': 'Browse Files',
                    'script': 'Upload.ashx',
                    'folder': '<%=HideQsID.Value%>',
                    'fileDesc': 'Image Files',
                    'fileExt': '*.mp3;',
                    'multi': false,
                    'auto': false
                });
            }
);
    </script>


</asp:Content>
