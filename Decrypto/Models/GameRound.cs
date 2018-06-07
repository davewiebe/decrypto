using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Decrypto.Models
{
    public class GameRound
    {
        public int Id { get; set; }
        
        public virtual Clue Clue1 { get; set; }
        public virtual Clue Clue2 { get; set; }
        public virtual Clue Clue3 { get; set; }
    }
}