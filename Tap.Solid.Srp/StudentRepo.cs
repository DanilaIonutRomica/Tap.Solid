using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Srp
{
    public class StudentRepo
    {
        
        public void AddStudent(Student studentObject)
        {
            var sqlCommand = $"INSERT INTO students (Name, Email, SocialSecurityNumber) values (@Name, @Email, @SocialSecurityNumber)";
            using (var connection = new SqliteConnection("Data Source=:memory:"))
            {
                var affectedRows = connection.Execute(sqlCommand);
            }

        }
    }
}
