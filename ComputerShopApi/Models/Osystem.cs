using System.ComponentModel.DataAnnotations;

namespace ComputerShopApi.Models
{
    public class Osystem
    {
        [MaxLength(36)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
