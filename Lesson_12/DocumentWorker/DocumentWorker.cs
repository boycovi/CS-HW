using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing available in pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving available in pro version");
        }
    }
}
