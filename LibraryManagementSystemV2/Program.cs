
namespace LibraryManagementSystemV2
{
    interface Downloadable
    {
        // 
    }

    class Book
    {
        public Book(string title, string auhtor, string iSBN, decimal price, int id, bool status, string type, string about)
        {
            Title = title;
            Auhtor = auhtor;
            ISBN = iSBN;
            Price = price;
            Id = id;
            Status = status;
            Type = type;
            About = about;
        }

        public string Title { get; set; }
        public string Auhtor { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public string About { get; set; }
    }

    class PhysicalBook : Book
    {
        public PhysicalBook(string title, string auhtor, string iSBN, decimal price, int id, bool status, string type, string about, string address) 
            : base(title, auhtor, iSBN, price, id, status, type, about)
        {
            Address = address;
        }

        public string Address { get; set; }
    }

    class EBook : Book, Downloadable
    {
        public EBook(string title, string auhtor, string iSBN, decimal price, int id, bool status, string type, string about) : base(title, auhtor, iSBN, price, id, status, type, about)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PhysicalBook physicalBook = new("Book 1", "Ali", "4348923", 1, 1, true, "PhysicalBook", "any thing", "Oman");
        }
    }
}
