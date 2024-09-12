using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        public string UserId { get; set; } = "";
        public string? Hoten { get; set; }
        public string? Manguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string? Manguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
