using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MusicShare
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string main_path = Request.Path.ToLower();

            if (main_path.IndexOf("/single_track_list/") >= 0)
            { 
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                Context.RewritePath(String.Concat("~/FrontEndPages/SongDetail.aspx?songid=", page), false); 
            }
            if (main_path.IndexOf("/single_-tracks/") >= 0)
            { 
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                Context.RewritePath(String.Concat("~/FrontEndPages/ByMonthTracks.aspx?monthid=", page), false); 
            }
            

            if (main_path.IndexOf("/uploadsmf_") >= 0)
            {
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"_");
                String page = txt[txt.Length - 1];
                Context.RewritePath(String.Concat("~/SongUpload.aspx?songid=", page), false); 
                
            }


            if (main_path.IndexOf("/download48/") >= 0)
            {
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                DataTable dt = GetSong(page);
                if (dt.Rows.Count > 0)
                {
                       Context.RewritePath("~/48kb/" + dt.Rows[0]["SongUrl"].ToString());
                      
                }
                 

            }
            if (main_path.IndexOf("/download128/") >= 0)
            {
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                DataTable dt = GetSong(page);
                if (dt.Rows.Count > 0)
                {
                    Context.RewritePath("~/128kb/" + dt.Rows[0]["SongUrl"].ToString());
                }
                 

            }


            if (main_path.IndexOf("/download320/") >= 0)
            {
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                DataTable dt = GetSong(page);
                if (dt.Rows.Count > 0)
                {
                    Context.RewritePath("~/320kb/" + dt.Rows[0]["SongUrl"].ToString());
                }
                
               
            }







            if (Request.RawUrl.Contains("/login"))
            {
                Context.RewritePath("~/login.aspx");
            }
            if (Request.RawUrl.Contains("/register"))
            {
                Context.RewritePath("~/register.aspx");
            }
            if (Request.RawUrl.Contains("/Dashboard"))
            {
                Context.RewritePath("~/home.aspx");
            }
            if (Request.RawUrl.Contains("/Uploads"))
            {
                Context.RewritePath("~/SongUpload.aspx");
            }
            if (Request.RawUrl.Contains("/MyUploadsList"))
            {
                Context.RewritePath("~/MySongsList.aspx");
            }
            if (Request.RawUrl.Contains("/MyProfile"))
            {
                Context.RewritePath("~/ProfileUploader.aspx");
            }


            if (Request.RawUrl.Contains("/latest/single-tracks"))
            {
                Context.RewritePath("~/FrontEndPages/LatestTracks.aspx");
            }
            if (Request.RawUrl.Contains("/by-month/single-tracks"))
            {
                Context.RewritePath("~/FrontEndPages/ByMonthTracks.aspx");
            }
            if (Request.RawUrl.Contains("/recommended/single-tracks"))
            {
                Context.RewritePath("~/FrontEndPages/RecommendedTracks.aspx");
            }
            if (Request.RawUrl.Contains("/top20/weekly"))
            {
                Context.RewritePath("~/FrontEndPages/Top20WeeklyTracks.aspx");
            }
            if (Request.RawUrl.Contains("/top20/monthly"))
            {
                Context.RewritePath("~/FrontEndPages/Top20MonthlyTracks.aspx");
            }
            if (Request.RawUrl.Contains("/a-to-z/single-tracks"))
            {
                Context.RewritePath("~/FrontEndPages/AtoZTracks.aspx");
            }


            if (main_path.IndexOf("/a_to_z/") >= 0)
            { 
                String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                String page = txt[txt.Length - 2];

                Context.RewritePath(String.Concat("~/FrontEndPages/AtoZTracks.aspx?alphaid=", page), false); 
            }

            //backend 
            if (Request.RawUrl.Contains("/welcomestar"))
            {
                Context.RewritePath("~/BackEndStar/index.aspx");
            }
            if (Request.RawUrl.Contains("/adminlogin"))
            {
                Context.RewritePath("~/BackEndStar/Login.aspx");
            }
            if (Request.RawUrl.Contains("/dailyuploading"))
            {
                Context.RewritePath("~/BackEndStar/Uploadings.aspx");
            }
            if (Request.RawUrl.Contains("/skipeduploaded"))
            {
                Context.RewritePath("~/BackEndStar/pandingUploading.aspx");
            }
            

        }

        private static DataTable GetSong(String page)
        {
            StarMethods sm = new StarMethods();
            DataTable dt = new DataTable();
            dt = sm.GetTracksDownload(Convert.ToInt64(page));
            return dt;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}