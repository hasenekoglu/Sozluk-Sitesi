namespace EFCoreTutorial.Data.Models
{
    public partial class Book
    {
        public class Course
        {
            public int Id { get; set; }

            public string Name { get; set; }


            public bool IsActive { get; set; }

            public virtual ICollection<Student> Students { get; set; }
        }
    }
}
