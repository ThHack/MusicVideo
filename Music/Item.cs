using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Item
    {
        public Image img;
        public String text;
        public Image Img { get => img; set => img = value; }
        public string Text { get => text; set => text = value; }

        public Item(Image img, string text)
        {
            this.img = img;
            this.text = text;
        }
    }
}
