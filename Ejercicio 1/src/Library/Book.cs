using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
      /*public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }*/

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        //no es necesario que la clase "book" tenga un metodo para conocer donde se ubica el libro
        //la responsabilidad le corresponderia a otra clase x.
        
        /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/
        
        //comento los parametros relativos al metodo y el metodo en si para quitarlo del codigo y que cumpla con el principio SRP.
    }
}
