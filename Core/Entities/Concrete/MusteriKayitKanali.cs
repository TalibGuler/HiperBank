using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class MusteriKayitKanali : IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int KayitTuruId { get; set; }
    }
}
