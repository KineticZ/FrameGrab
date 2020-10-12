using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameGrab
{
    public abstract class Sprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        Color Tint { get; set; }
        public Sprite(Texture2D texture, Vector2 position, Color tint)
        {
            Texture = texture;
            Position = position;
            Tint = tint;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Tint);
        }
    }
}
