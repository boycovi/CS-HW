namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter DocumentWorker key: ");
            string key = Console.ReadLine();

            DocumentWorker docWorker;

            if (key == "pro")
                docWorker = new ProDocumentWorker();
            else if (key == "exp")
                docWorker = new ExpertDocumentWorker();
            else
                docWorker = new DocumentWorker();

            docWorker.OpenDocument();
            docWorker.EditDocument();
            docWorker.SaveDocument();

            Console.ReadKey();
        }
    }
}