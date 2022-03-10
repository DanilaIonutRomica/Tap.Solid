using Dapper;
using Microsoft.Data.Sqlite;
using System.Net.Mail;

namespace Tap.Solid.Srp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SocialSecurityNumber { get; set; }
        private readonly EmailValidator emailValidatorObject;
        private readonly StudentRepo studentRepoObject;
        private readonly SendMail sendMailObject;
        public Student()
        {
            emailValidatorObject.email = Email;
            sendMailObject = new SendMail(this.Email);
            studentRepoObject=new StudentRepo();
        }
        public string AddStudent()
        {
            if (emailValidatorObject.isEmailValid())
                return "cc";
            if (SocialSecurityNumber.Length != 13)
                return "Invalid social security number!";
            studentRepoObject.AddStudent(this);
            sendMailObject.makeMessage(Name);
            sendMailObject.client.Send(sendMailObject.mailMessageObject);
            return "Student enroled!";
        }
    }
}