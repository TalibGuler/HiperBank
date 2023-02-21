using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MusteriKayitKanaliResponseDto
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int KayitTuruId { get; set; }
        public string KayıtTuruAdı { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
