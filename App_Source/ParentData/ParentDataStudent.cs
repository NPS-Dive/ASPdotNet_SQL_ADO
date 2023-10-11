using System.Data;
using System.Data.SqlClient;

 class ParentDataStudent
{

	 protected int PDInsertStudent(long ID ,string Name ,string Lastname )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertStudent";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@Lastname",Lastname);
		Sqlcom.Connection = Scon.OpenCon();
		int R=0;
		Sqlcom.ExecuteNonQuery();
		R = int.Parse(Sqlcom.Parameters["@ID"].Value.ToString());
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 protected int PDDeleteStudent(long ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteStudent";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 protected int PDUpdateStudent(long ID ,string Name ,string Lastname )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateStudent";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@Lastname",Lastname);
		Sqlcom.Connection = Scon.OpenCon();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.CloseCon();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 protected DataTable PDGetListStudent()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListStudent",Scon.OpenCon());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 protected DataTable PDDetailsStudent(long ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsStudent",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}

	 protected DataTable PDDetailsByFieldStudent(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldStudent",Scon.OpenCon());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.CloseCon();
		return DTable; 
	}
}// End Class

