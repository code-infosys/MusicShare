using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.IO;

namespace MusicShare
{
    public partial class SongUpload : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["songid"] != null)
            {
                TabContainer1.ActiveTabIndex = 1;
                HiddenField1.Value = "1";
                HideQsID.Value = Request.QueryString["songid"].ToString();
            }
        }

        

        public string ReplaceName(string value)
        {
            if (value.ToLower().Contains("/"))
            {
                value = value.Replace("/", "-");
            }
            if (value.ToLower().Contains("."))
            {
                value = value.Replace(".", "-");
            }
            if (value.ToLower().Contains("com"))
            {
                value = value.Replace("com", "");
            }
            if (value.ToLower().Contains("in"))
            {
                value = value.Replace("in", "");
            }
            if (value.ToLower().Contains("org"))
            {
                value = value.Replace("org", "");
            }
            if (value.ToLower().Contains("mobi"))
            {
                value = value.Replace("mobi", "");
            }
            if (value.ToLower().Contains("info"))
            {
                value = value.Replace("info", "");
            }
            if (value.Contains("[") || value.Contains("]"))
            {
                value = value.Replace("[", "");
                value = value.Replace("]", "");
            }
            if (value.Contains("(") || value.Contains(")"))
            {
                value = value.Replace("(", "");
                value = value.Replace(")", "");
            }
            return value;
        }

        protected void btnUPload_Click(object sender, EventArgs e)
        {
            if (Session["USERDIID"] != null)
            { 
                //FileUpSong.FileName.Length > 0 &&

                if (FUimgCover.FileName.Length > 0 && txtSingerName.Text.Length > 0 && txtSongName.Text.Length > 0 && txtSongReleaseDate.Text.Length > 0 && txtDescription.Text.Length>0 && txtTags.Text.Length>0)
                {
                    if (FUimgCover.PostedFile.ContentType == "image/jpeg" || FUimgCover.PostedFile.ContentType == "image/jpeg" || FUimgCover.PostedFile.ContentType == "image/gif" || FUimgCover.PostedFile.ContentType == "image/png")
                    {
                        //cover upload begin
                        string coverext = Path.GetExtension(FUimgCover.FileName);
                        string coverfname = Path.GetFileNameWithoutExtension(FUimgCover.FileName);
                        string d = DateTime.Now.ToString("ddmmyyyyhhmmss");
                        string imgpath = Server.MapPath("~/320kb/Cover/" + ReplaceName(coverfname) + d + coverext);
                        FUimgCover.SaveAs(imgpath);
                        //cover upload end 

                        //song upload begin
                        string ext = Path.GetExtension(FileUpSong.FileName);
                        string fname = Path.GetFileNameWithoutExtension(FileUpSong.FileName);
                        //string path = Server.MapPath("~/320kb/" + ReplaceName(fname) + "_-(Jatt.fm)" + ext);
                        //FileUpSong.SaveAs(path);

                        //song upload end
                        MSContextDataContext objMs = new MSContextDataContext();

                        TracksWraper objtrack = new TracksWraper();
                        objtrack.CoverImage = ReplaceName(coverfname) + d + coverext;
                        objtrack.AlbumName = txtAlbumName.Text;
                        objtrack.AlbumReleaseOn = Convert.ToDateTime(txtSongReleaseDate.Text);
                        objtrack.DateAdded = DateTime.Now;
                        objtrack.MetaDescription = txtDescription.Text;
                        objtrack.MetaTags = txtTags.Text;
                        objtrack.SingerName = txtSingerName.Text;
                        objtrack.SongTitle = txtSongName.Text;
                        //objtrack.SongUrl = ReplaceName(fname) + "_-(Jatt.fm)" + ext;
                        objtrack.SongUrl = "";
                        objtrack.TrackCount = Convert.ToInt32(ddlNumberOfTracks.SelectedItem.Text);

                        objtrack.UsrId = Convert.ToInt64(Session["USERDIID"]);

                        objMs.TracksWrapers.InsertOnSubmit(objtrack);
                        objMs.SubmitChanges();

                        lblMsg.Text = "Upload Successfully";
                        TabContainer1.ActiveTabIndex = 1;
                        HiddenField1.Value = "1";

                        txtSingerName.Attributes.Add("style", "border:1px solid silver;");
                        txtSongName.Attributes.Add("style", "border:1px solid silver;");
                        txtSongReleaseDate.Attributes.Add("style", "border:1px solid silver;");
                        txtTags.Attributes.Add("style", "border:1px solid silver;");
                        txtDescription.Attributes.Add("style", "border:1px solid silver;");

                        Response.Redirect("/uploadsmf_" + objtrack.ID);
                    }
                    else
                    {
                        lblMsg.Text = "Select Cover Type Just .jpg , .png or gif";
                        lblMsg.ForeColor = System.Drawing.Color.Red;
                    }

                }
                else
                {
                    lblMsg.Text = "Select album cover Image File First";
                    lblMsg.ForeColor = System.Drawing.Color.Red;

                    txtSingerName.Attributes.Add("style", "border:1px solid red;");
                    txtSongName.Attributes.Add("style", "border:1px solid red;");
                    txtSongReleaseDate.Attributes.Add("style", "border:1px solid red;");
                    txtTags.Attributes.Add("style", "border:1px solid red;");
                    txtDescription.Attributes.Add("style", "border:1px solid red;");
                    
                }
            }
        }

        
    }
}