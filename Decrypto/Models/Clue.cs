using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Decrypto.Models
{
    public class Clue
    {
        public int Id { get; set; }
        public int Word { get; set; }
        public string Hint { get; set; }
        public int Guess { get; set; }
    }
}