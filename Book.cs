using System;

namespace Poo
{
    public class Book : Publication
    {
        private int id;
        private string isbn;
        private Boolean readed;
        private int timeReaded;

        public int Id
        {
            get{return id;}
            set{id = value;}
        }
            
        public string Isbn
        {
            get{return isbn;}
            set{isbn = value;}
        }

        public Boolean Readed
        {
            get{return readed;}
            set{readed = value;}
        }
        public int TimeReaded
        {
            get{return timeReaded;}
            set{timeReaded = value;}
        }


    }
}
