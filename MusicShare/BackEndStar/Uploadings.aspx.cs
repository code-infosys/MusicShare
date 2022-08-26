using Mp3Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicShare.BackEndStar
{
    public partial class Uploadings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Update")
                {
                    
                    TextBox txtUrlNameSong = (TextBox)GridView1.Rows[Convert.ToInt32(e.CommandArgument)].FindControl("txtUrlNameSong");
                    HiddenField hideOldUrlName = (HiddenField)GridView1.Rows[Convert.ToInt32(e.CommandArgument)].FindControl("hideOldUrlName");

                    string oldFilePath = Path.Combine(Server.MapPath("~/320kb"), hideOldUrlName.Value);
                    string newFilePath = Path.Combine(Server.MapPath("~/320kb"), txtUrlNameSong.Text);

                    File.Move(oldFilePath, newFilePath);

                }
            }
            catch (Exception)
            { 
                throw;
            }
        }

        protected void btnApprive_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERDIID"] != null)
                {
                    MSContextDataContext conTxt = new MSContextDataContext();
                    Mp3File fstar;
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {
                        CheckBox chkApprove = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("chkApprove");
                        HiddenField hideID = (HiddenField)GridView1.Rows[i].FindControl("hideIdd");
                        HiddenField hidesongurl = (HiddenField)GridView1.Rows[i].FindControl("hidesongurl");

                        HiddenField hideSongTitle = (HiddenField)GridView1.Rows[i].FindControl("hideSongTitle");
                        HiddenField hideAlbumName = (HiddenField)GridView1.Rows[i].FindControl("hideAlbumName");
                        HiddenField HideSingerName = (HiddenField)GridView1.Rows[i].FindControl("HideSingerName");  

                        TracksWraper trak = conTxt.TracksWrapers.Single(j => j.ID == Convert.ToDecimal(hideID.Value));
                        trak.DateApproved = DateTime.Now;
                        trak.ApprovedBy = 1; // Convert.ToInt64(Session["USERDIID"]);
                        if (chkApprove.Checked == true)
                        {
                            string s = hideID.Value;
                            

                            try
                            { 
                                fstar = new Mp3File(Server.MapPath("~/320kb/" + hidesongurl.Value));

                                fstar.TagHandler.Album = hideAlbumName.Value.ToString() + " (Apna.fm)";
                                fstar.TagHandler.Artist = HideSingerName.Value.ToString() + " (Apna.fm)";
                                fstar.TagHandler.Title = hideSongTitle.Value.ToString() + " (Apna.fm)";
                                fstar.TagHandler.Track = hideSongTitle.Value.ToString();
                                fstar.TagHandler.Year = "2014";
                                fstar.TagHandler.Comment = "Apna.fm the best website for download and share music online";
                                fstar.TagHandler.Genre = "Music Share free Apna.fm";

                                fstar.TagHandler.Picture = System.Drawing.Image.FromFile(Server.MapPath("~/apna.fm.png"));

                                fstar.Update();
                                 
                                NewMethod(AppDomain.CurrentDomain.BaseDirectory + "320kb\\" + hidesongurl.Value, AppDomain.CurrentDomain.BaseDirectory + "128kb\\" + hidesongurl.Value, "128");


                                NewMethod(AppDomain.CurrentDomain.BaseDirectory + "320kb\\" + hidesongurl.Value, AppDomain.CurrentDomain.BaseDirectory + "48kb\\" + hidesongurl.Value, "48");
                                trak.IsApproved = true;
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            trak.IsApproved = false; 
                        }
                        conTxt.SubmitChanges();
                         
                    }
                }
                btnApprive.Text = "Approved Successfully.";
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       
        private static void NewMethod(string srcFileLocation, string destFileLocation, string formats)
        {
            string fileLocation = AppDomain.CurrentDomain.BaseDirectory + "\\320kb\\lame\\lame.exe";
            //maxLen is in ms (1000 = 1 second)
            string outfile = "-b " + formats + " --resample 22.05 -m m \"" + srcFileLocation + "\" \"" + destFileLocation.Replace(".mp3", ".mp3") + "\"";
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = fileLocation;
            psi.Arguments = outfile;
            psi.UseShellExecute = false;

            //psi.WorkingDirectory = pworkingDir;
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
 
        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Mp3File file = new Mp3File(Server.MapPath("~/128kb/Saiyaara.mp3"));
            
            file.TagHandler.Album = "Pata ni";
            file.TagHandler.Artist = "gippy";
            file.TagHandler.Title = "Wajjde Wajje jatt.fm";
            file.TagHandler.Track = "star track";
            file.TagHandler.Year = "2015";
            file.TagHandler.Comment = "Jatt.fm the best website for download free music";
            file.TagHandler.Genre = "Single Tracks(Jatt.fm)";
           
            file.TagHandler.Picture = System.Drawing.Image.FromFile(Server.MapPath("~/apna.fm.png"));

            file.Update();
        }
        
    }
}