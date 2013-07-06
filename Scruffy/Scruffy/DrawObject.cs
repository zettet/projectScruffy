using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Scruffy
{
    public abstract class DrawObject
    {
        protected Texture2D sprite;
        protected String imagePath;
        protected Vector2 position;
        protected float width;
        protected float height;

        public Vector2 getPosition()
        {
            return position;
        }

        public float getSpriteWidth()
        {
            return sprite.Width;
        }

        public float getSpriteHeight()
        {
            return sprite.Height;
        }

        public void loadContent(ContentManager myContent)
        {
           sprite = myContent.Load<Texture2D>(imagePath);
        }

        public abstract void Update();
        public abstract void Update(Vector2 newPos);
        
        public void Draw(SpriteBatch mySpriteBatch)
        {
            mySpriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
