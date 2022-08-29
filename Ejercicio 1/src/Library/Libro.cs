using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*public void ShelveBook(String sector, String shelve)
            deberia ser una clase aparte por si cambia el metodo de almacenamiento de libros, sea más facil de modificar,
            ej: la biblioteca se expande y ya no solo se necesita 1 sector y 1 estante, sino que hay libros almacenados en central y otros en mulling,
            y se necesita identificar con una "c" o una "m"
        
        {
            
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/
    }
    public class ShelveBook(Book Book2Shelve)
    {
    
    }
    
    
}
