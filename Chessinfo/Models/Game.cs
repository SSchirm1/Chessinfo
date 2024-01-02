﻿namespace Chessinfo.Models
{
   
    public class Game
    {
        
        public int Id { get; set; }
        public int? WhiteId {  get; set; }
        public int? BlackId { get; set; }
        public DateTime Date { get; set; }

        public string? Result { get; set; }

      

    }
}