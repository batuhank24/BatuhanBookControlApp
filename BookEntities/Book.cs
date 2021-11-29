using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntities
{
    public class Book
    {

    }

    public Book (string kitapadi, string yazari, string basimevi, int basimyili)
    {
        KitapAdi = kitapadi;

        
    }

    public string KitapAdi { get; set; }

}
