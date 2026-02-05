namespace lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		[TestMethod]
        public void TestBookCreation()
        {
			Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
		[TestMethod]
		public void TestMagazineCreation()
		{
            Magazine magazine = new Magazine { Title = "Tech Weekly", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }
    }
}
