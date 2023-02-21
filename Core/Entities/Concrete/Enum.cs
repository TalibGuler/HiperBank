using System.ComponentModel.DataAnnotations;


namespace Core.Entities.Concrete
{
    public enum MusteriKayitTuru
    {
        [Display(Name = "Şube")]
        Sube = 1,
        [Display(Name = "Mobil")]
        Mobil = 2,
        [Display(Name = "İnternet")]
        Internet = 3,
    }
}
#if false
#endif