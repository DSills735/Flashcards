using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards.Entities
{
    internal class Flaschard
    {
        public int Id { get; set; }
        public required string Question { get; set; }
        public required string Answer { get; set; }
        public int StackID { get; set; }
    }
}
