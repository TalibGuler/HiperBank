using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BilancoRequestDto
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int BilancoTutari { get; set; }
        public DateTime BilancoTarihi { get; set; }
        public bool SilindiMi { get; set; }
    }
}
