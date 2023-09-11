namespace HomeTasks_Pro_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document pdf = new PDFDocument();
            pdf.Print();

            Console.WriteLine(new string('-', 20));

            Document word = new WordDocument();
            word.Print();
        }
    }
}