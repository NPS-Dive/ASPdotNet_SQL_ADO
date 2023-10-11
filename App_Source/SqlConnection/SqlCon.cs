
using System;
using System.Data;
using System.Data.SqlClient;

public class SqlCon
{

		private   String StrCon;
		private   SqlConnection Con;


	public SqlConnection OpenCon()
	{
 
		StrCon =System.Configuration.ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
		Con = new SqlConnection(StrCon);
		Con.Open();
		return Con;
	}

	 public void CloseCon()
	{

		  if (Con != null)
		{
			  if (Con.State == ConnectionState.Open)
			{
			    Con.Close();
			}
		}
	}
}

