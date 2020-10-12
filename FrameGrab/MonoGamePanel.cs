using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FrameGrab
{
    class MonoGamePanel : MonoGameControl
    {
        private SpriteBatch spriteBatch { get; set; }
        public Texture2D SpriteSheet { get; set; }               
       
        protected override void Initialize()
        {
            base.Initialize();
  
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        public bool LoadImage(string filename)
        {
            using(var fs = File.OpenRead(filename))
            {
                try
                {
                    SpriteSheet = Texture2D.FromStream(GraphicsDevice, fs);
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
            }

            return true;
        }

        //Runs when Image Sheet Handler gets invoked





        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            
        }

        protected override void Draw()
        {
            base.Draw();
            if (SpriteSheet == null) return;
            
            spriteBatch.Begin();
            spriteBatch.Draw(SpriteSheet, Vector2.Zero, Color.White);
            spriteBatch.End();
        }
    }
}
