using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
namespace MusicShare
{
    /// <summary>
    /// Summary description for Upload
    /// </summary>
    public class Upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Expires = -1;
            try
            {
                HttpPostedFile postedFile = context.Request.Files["Filedata"];
               

                    if (postedFile.ContentLength >= 4048576)
                    {
                        string savepath = "";
                        string tempPath = "";
                        //tempPath = System.Configuration.ConfigurationManager.AppSettings["FolderPath"];
                        savepath = context.Server.MapPath("~/320kb");
                        string filename = string.Empty;

                        string ext = Path.GetExtension(postedFile.FileName);
                        string fname = Path.GetFileNameWithoutExtension(postedFile.FileName);
                        filename = ReplaceName(fname) + "_-(Apna.fm)" + ext;
                         
                        postedFile.SaveAs(savepath + @"\" + filename);
                        context.Response.Write(tempPath + "/" + filename);
                        context.Response.StatusCode = 200;
                        //update query

                        String[] txt = Regex.Split(context.Request.Url.ToString(), @"/");

                        String page = txt[txt.Length - 1];


                        MSContextDataContext objMs = new MSContextDataContext();

                        TracksWraper objtrack = objMs.TracksWrapers.Single(i => i.ID == Convert.ToInt64(page));
                        objtrack.SongUrl = filename;
                        objMs.SubmitChanges();

                        //



                    }
               
            }
            catch (Exception ex)
            {
                context.Response.Write("Error: " + ex.Message);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
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
    }
}