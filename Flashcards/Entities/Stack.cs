using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards.Entities
{
    internal class Stack
    {
        public int StackID { get; set; }
        public required string Subject { get; set; }
        public int HighScore { get; set; }
    }
}
