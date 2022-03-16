using Tap.Solid.Dip.Entities;

namespace Tap.Solid.Dip
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student> GetAll()
        {
            return new List<Student>();
        }
    }
    
}