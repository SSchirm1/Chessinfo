namespace Chessinfo.Models
{
    public class Tournament
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }

        public int? Rounds { get; set; }

        public List<Player>? Players { get; set; }

        public string? Format { get; set; }


    }
}
