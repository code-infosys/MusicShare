using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MusicShare
{
    public class StarMethods
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["SqlConnectionString"].ToString());

        public DataTable GetTracksDetail(Int64 songid)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "selectDetail");
                cmd.Parameters.Add("@songid", songid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                 
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }

            
        }

        public DataTable GetTracksDownload(Int64 songid)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "download");
                cmd.Parameters.Add("@songid", songid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
             
        }

        public DataTable GetTracksByMonth(int month)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "bymonth");
                cmd.Parameters.Add("@monthid", month);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public DataTable GetTracksAtoZ(string albpa)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "namewise");
                cmd.Parameters.Add("@alphabit", albpa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetTracksRecAndTop20weekAndTop20month(string action)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action",action); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        MSContextDataContext conTxt = new MSContextDataContext();


        public TracksWraper[] trackLatest()
        {
            return conTxt.TracksWrapers.Where(i => i.IsApproved == null).OrderByDescending(i => i.DateAdded).ToArray();
        }

    }
}