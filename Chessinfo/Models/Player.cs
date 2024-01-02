using Humanizer;

namespace Chessinfo.Models
{
    public class Player
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        
        public int? CountryId { get; set; }

        public Country? Country { get; set; }
        public bool IsMale { get; set; }
        public float? classicalRating { get; set; }
        public float? rapidRating { get; set; }
        public float? blitzRating { get; set; }

         public int? TitleId { get; set; }  

    }
}
