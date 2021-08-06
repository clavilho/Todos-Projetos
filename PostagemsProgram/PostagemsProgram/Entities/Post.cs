using System;
using System.Collections.Generic;
using System.Text;

namespace PostagemsProgram.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comments { get; set; } = new List<Comentario>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comments.Add(comentario);
        }

        public void RemoveComent(Comentario comentario)
        {
            Comments.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");
            foreach (Comentario c in Comments)
            {
                sb.AppendLine(c.Text);

            }

            return sb.ToString();
        }
    }
}
