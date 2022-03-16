using Tap.Solid.Dip.Entities;

namespace Tap.Solid.Dip
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
    }
}