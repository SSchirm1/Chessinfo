namespace Chessinfo.Models
{
    public class Game
    {
      public enum Result { White, Black, Draw };
        public int Id { get; set; }
        public Player? White {  get; set; }
        public Player? Black { get; set; }
        public DateTime Date { get; set; }

    }
}