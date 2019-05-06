using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Dlc { get; set; }

        public decimal Price { get; set; }

        public string Platform { get; set; }
    }
}
