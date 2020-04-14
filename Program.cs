using System;
using system.Data.sqlClient;

namespace sqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            const string conString=@"Data sourse=localhost; Initial catalog=schoolAlif; Integrated security=true"
            SqlConnection con=new sql(conString);
        }
        con.Open();
        if(con.State==SqlConnection.Open)
        {
            
            
        }
    }
}
