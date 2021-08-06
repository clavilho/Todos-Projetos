using System;
using System.Collections.Generic;
using System.Text;

namespace PostagemsProgram.Entities
{
    class Comentario
    {
        public string Text { get; set; }

        public Comentario() { }

        public Comentario(string text)
        {
            Text = text;
        }
    }
}
