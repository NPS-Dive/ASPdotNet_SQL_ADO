
using System.Data;


class StudentBusiness
{

	public int Insert(Student  ObjStudent) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataInsertStudent(ObjStudent);
	}

	public int Update(Student  ObjStudent) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataUpdateStudent(ObjStudent);
	}

	public int Delete(Student  ObjStudent) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataDeleteStudent(ObjStudent);
	}

	public  DataTable GetList( ) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataGetListStudent();
	}

	public  DataTable Details(Student  ObjStudent) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataDetailsStudent(ObjStudent);
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		DataStudent  objData = new DataStudent();
		return  objData.DataDetailsByFieldStudent(FieldName,value);
	}

}// End Class

