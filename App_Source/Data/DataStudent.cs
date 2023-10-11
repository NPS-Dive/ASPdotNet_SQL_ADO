
using System.Data;


 class DataStudent:ParentDataStudent
{
	 public int DataInsertStudent(Student  ObjStudent) 
	{
		return PDInsertStudent( ObjStudent.ID , ObjStudent.Name , ObjStudent.Lastname );
	}

	 public int DataDeleteStudent(Student  ObjStudent) 
	{
		return PDDeleteStudent(  ObjStudent.ID );
	}


	 public DataTable DataDetailsStudent(Student  ObjStudent) 
	{
		return PDDetailsStudent(  ObjStudent.ID );
	}

	 public int DataUpdateStudent(Student  ObjStudent) 
	{
		return PDUpdateStudent( ObjStudent.ID , ObjStudent.Name , ObjStudent.Lastname );
	}

	 public DataTable DataGetListStudent() 
	{
		return PDGetListStudent();
	}

	 public DataTable DataDetailsByFieldStudent(string FieldName,string  value) 
	{
		return PDDetailsByFieldStudent(FieldName,value);
	}

}// End Class

