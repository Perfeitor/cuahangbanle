using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Donvitinh")]
    public class Donvitinh
    {
        public string Madonvitinh { get; set; } = "";
        public string Donvile { get; set; } = "";
        public string Donvilon { get; set; } = "";
    }
}
