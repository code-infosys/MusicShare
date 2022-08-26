using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;

namespace MusicShare.FrontEndPages
{
    public partial class SongDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["songid"] != null)
            {
               
                BindInfo(Request.QueryString["songid"]);
                BindSeo(Request.QueryString["songid"]);
            }
        }

        private void BindSeo(string p)
        {
            try
            {
                StarMethods sm = new StarMethods();
                DataTable dt = new DataTable();
                dt = sm.GetTracksDetail(Convert.ToInt64(p));
                if (dt.Rows.Count > 0)
                {
                   
                    Page.MetaDescription = dt.Rows[0]["MetaDescription"].ToString();
                    Page.Title = dt.Rows[0]["SongTitle"].ToString();
                    Page.MetaKeywords = dt.Rows[0]["MetaTags"].ToString();


                    string meta = "<link href=\"https://plus.google.com/" + dt.Rows[0]["GmailUrl"].ToString() + "\" rel=\"author\" />";
                    Literal cssLiteral2 = new Literal();
                    cssLiteral2.Text = meta;
                    Page.Header.Controls.Add(cssLiteral2);
                     
                    HtmlMeta tagadmins = new HtmlMeta();
                    tagadmins.Attributes.Add("property", "fb:admins");
                    tagadmins.Content = dt.Rows[0]["FacebookUrl"].ToString();
                    Page.Header.Controls.Add(tagadmins);

                    HtmlMeta tag = new HtmlMeta();
                    tag.Attributes.Add("property", "og:title");
                    tag.Content = dt.Rows[0]["SongTitle"].ToString();
                    Page.Header.Controls.Add(tag);

                    HtmlMeta tagType = new HtmlMeta();
                    tagType.Attributes.Add("property", "og:type");
                    tagType.Content = "song";
                    Page.Header.Controls.Add(tagType);

                    HtmlMeta tagSiteName = new HtmlMeta();
                    tagSiteName.Attributes.Add("property", "og:site_name");
                    tagSiteName.Content = "jatt.fm";
                    Page.Header.Controls.Add(tagSiteName);

                    HtmlMeta tag1 = new HtmlMeta();
                    tag1.Attributes.Add("property", "og:description");
                    tag1.Content = dt.Rows[0]["MetaDescription"].ToString();
                    Page.Header.Controls.Add(tag1);

                    HtmlMeta tagurl = new HtmlMeta();
                    tagurl.Attributes.Add("property", "og:url");
                    tagurl.Content = Request.RawUrl.ToString();
                    Page.Header.Controls.Add(tagurl);

                    HtmlMeta tagimg = new HtmlMeta();
                    tagimg.Attributes.Add("property", "og:img");
                    tagimg.Content = Page.ResolveUrl("~/320kb/Cover/" + dt.Rows[0]["CoverImage"].ToString());
                    Page.Header.Controls.Add(tagimg);
                }
        
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindInfo(string p)
        {
            try
            {
                StarMethods sm = new StarMethods();
                DataTable dt = new DataTable();
                dt = sm.GetTracksDetail(Convert.ToInt64(p));
                if (dt.Rows.Count > 0)
                {
                   
                    StringBuilder sb = new StringBuilder();
                     
                    sb.Append("<div class=\"head\"> " + dt.Rows[0]["SongTitle"].ToString() + " </div> <div class=\"albumCover\">");
                    sb.Append("<img alt=\"\" src=\"" + Page.ResolveUrl("~/320kb/Cover/" + dt.Rows[0]["CoverImage"].ToString() + "") + "\" /> <div class=\"clear\"></div> </div>");
                  
                    sb.Append("<div class=\"albumInfo\"> ");
                    if (dt.Rows[0]["AlbumName"].ToString() != "")
                    {
                        sb.Append("<p class=\"style18\"> <b>Album</b>:<span class=\"style24\"> " + dt.Rows[0]["AlbumName"].ToString() + "</span></p>");
                    }
                    sb.Append(" <p class=\"style18\">  <b>Singer</b>:<span class=\"style24\"> " + dt.Rows[0]["SingerName"].ToString() + "</span> </p>");
                    sb.Append("<p class=\"style18\"> <b>Tracks</b>:<span class=\"style24\"> " + dt.Rows[0]["TrackCount"].ToString() + "</span> </p>");
                    sb.Append("<p class=\"style18\"> <b>Released</b>:<span class=\"style24\"> " + Convert.ToDateTime(dt.Rows[0]["AlbumReleaseOn"].ToString()).ToString("dd-MMM-yyyy") + "  </span>  </p>");
                    string dcound = dt.Rows[0]["DownloadCount"].ToString().Length > 0 ? dt.Rows[0]["DownloadCount"].ToString() : "0";
                    sb.Append("<p class=\"style18\"> <b>Downloads</b>:<span class=\"style24\"> (" + dcound + ") </span> </p>");
                    sb.Append("<div class=\"clear\"></div> </div>");
                     
                    LitTopInfo.Text= sb.ToString();
                    ///////////////////////////////////////////

                    sb = null;
                    sb = new StringBuilder();
                    decimal S320 = 0;
                    decimal S128 = 0;
                    decimal S48 = 0;

                    FileInfo fi320 = new FileInfo(Server.MapPath("~/320kb/" + dt.Rows[0]["SongUrl"].ToString()));
                    try { S320 = fi320.Length; } catch (Exception)  { }
                    FileInfo fi128 = new FileInfo(Server.MapPath("~/128kb/" + dt.Rows[0]["SongUrl"].ToString()));
                    try { S128 = fi128.Length; }
                    catch (Exception) { }
                    FileInfo fi48 = new FileInfo(Server.MapPath("~/48kb/" + dt.Rows[0]["SongUrl"].ToString()));
                    try { S48 = fi48.Length; }
                    catch (Exception) { }
                    //lblMsg.Text = SizeGet(numberOfBytes.ToString());  

                    sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                    sb.Append("<a href=\"/download48/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download in 48 kbps </a><small><span style=\"color: #339900;\">(" + SizeGet(S48.ToString()) + ")</span></small> </p>");
                    sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                    sb.Append("<a href=\"/download128/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download in 128 kbps</a> <small><span style=\"color: #339900;\">(" + SizeGet(S128.ToString()) + ")</span></small>  </p>");
                   
                    sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                    sb.Append("<a href=\"/download320/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download in 320 kbps</a> <small><span style=\"color: #339900;\">(" + SizeGet(S320.ToString()) + ")</span></small>  </p>");
                 

                    litSongBind.Text = sb.ToString();

                    sb = null;

                    sb = new StringBuilder();

                    if (hideSongPlay.Value.Length > 0)
                    {
                        //sb.Append("<object type=\"application/x-shockwave-flash\" data=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("~/320kb/" + dt.Rows[0]["SongUrl"])) + "\" width=\"200\" height=\"20\" id=\"dewplayer\">");
                        sb.Append("<object type=\"application/x-shockwave-flash\" data=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download320/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" width=\"200\" height=\"20\" id=\"dewplayer\">");
                        sb.Append("<param name=\"wmode\" value=\"transparent\" />");
                        sb.Append("<param name=\"movie\" value=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download320/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" /> </object>");

                        LitPlayer.Text = sb.ToString();
                    }
                    ///////////////////////////////////////
                    sb = null;
                    sb = new StringBuilder();
                      
                    sb.Append("<div class=\"head\">Song Posted By</div> <div> <table> <tr> <td>");
                    sb.Append("<img src=\"" + Page.ResolveUrl("~/userimg/" + dt.Rows[0]["UserImage"].ToString()) + "\" style=\"width: 60px;\" /> </td> <td>");
                    sb.Append("<table> <tr> <td>Name:</td><td> " + dt.Rows[0]["UserName"].ToString() + "</td> </tr> <tr> <td>Email ID: </td><td>" + dt.Rows[0]["EmailID"].ToString() + " </td>");
                    sb.Append("</tr> </table>  </td> </tr> </table> <div class=\"clear\"></div> </div>");
                     
                    litPostedByINFO.Text = sb.ToString();



                }
            }
            catch (Exception EX)
            {
                
            }
        }

        public string SizeGet(string value)
        {
            string size = "0 KB";

            if (value != null)
            {

                double byteCount = 0;

                byteCount = System.Convert.ToDouble(value);

                if (byteCount >= 1073741824)
                    size = String.Format("{0:##.##}", byteCount / 1073741824) + " GB";
                else if (byteCount >= 1048576)
                    size = String.Format("{0:##.##}", byteCount / 1048576) + " MB";
                else if (byteCount >= 1024)
                    size = String.Format("{0:##.##}", byteCount / 1024) + " KB";
                else if (byteCount > 0 && byteCount < 1024)
                    size = "1 KB";    //Bytes are unimportant ;)            
            }

            return size;
        }

        protected void lbtnPlay_Click(object sender, EventArgs e)
        {
            hideSongPlay.Value = "202";
            if (Request.QueryString["songid"] != null)
            {
                BindInfo(Request.QueryString["songid"]);
            }
        }
    }
}