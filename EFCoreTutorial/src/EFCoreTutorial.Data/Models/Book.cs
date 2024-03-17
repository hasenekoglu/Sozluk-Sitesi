namespace EFCoreTutorial.Data.Models
{
    public partial class Book
    {
        public int Id { get; set; }

        public String Author { get; set; }

        public String Name { get; set; }


        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
