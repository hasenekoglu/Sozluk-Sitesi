namespace EFCoreTutorial.Data.Models
{
    public partial class Book
    {
        public class Teacher
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime BirthDate { get; set; }
        }
    }
}
