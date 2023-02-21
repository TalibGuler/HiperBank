using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class GercekMusteri : IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string KayitliOlduguIl { get; set; }
        public string DogumYeri { get; set; }
    }
}
