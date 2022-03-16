namespace Tap.Solid.Dip.Entities
{
    public class Student:StudentEntity
    {
        public override string Name { get; set; }
        public override decimal FinalGrade { get; set; }
    }
    public abstract class StudentEntity
    {
        public abstract string Name { get; set; }
        public abstract decimal FinalGrade { get; set; }    
    }
}