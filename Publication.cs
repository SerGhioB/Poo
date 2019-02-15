using System;
using System.Collections.Generic;

namespace Poo
{
    public abstract class Publication
    {
        private string title;
        private DateTime date;
        private string editorial;
        private List <string> autores = new List<string> ();

        public string Title
        {
            get {return title;}
            set{title = value;}
        }
    
        public DateTime Date
        {
            get {return date;}
            set{date = value;}
        }
        public string Editorial
        {
            get {return editorial;}
            set{editorial = value;}
        }

    }
}