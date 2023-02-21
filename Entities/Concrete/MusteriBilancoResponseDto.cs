using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MusteriBilancoResponseDto
    {
        //public int Id { get; set; }
        //public int MusteriNo { get;set; }
        //public int MusteriId { get; set; }
        public string Unvan { get; set; }
        public string Yetkili { get; set; }
        public int BilancoTutari { get; set; }
        public DateTime BilancoTarihi { get; set; }
    }
}