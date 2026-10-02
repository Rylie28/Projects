using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_loginForm
{
    public class clsDocument
    {
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Format { get; set; }

        //constructor
        public clsDocument(string title, string content, string format)
        {
            Title = title;
            Content = content;
            Format = format;
        }

        //default constructor
        public clsDocument() { }
    }
}
