using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStringBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        //Builder
        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
