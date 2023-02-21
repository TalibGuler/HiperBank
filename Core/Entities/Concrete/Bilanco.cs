using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Bilanco : IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int BilancoTutari { get; set; }
        public DateTime BilancoTarihi { get; set; }
    }
}
