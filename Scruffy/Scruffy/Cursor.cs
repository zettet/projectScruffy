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
    class Cursor
    {
        private Texture2D mouseSprite;
        private String imagePath;
        private Vector2 position;
        private float width;
        private float height;
        public Cursor (String image, float mWidth, float mHeight)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
            width = mWidth;
            height = mHeight;
        }

        public Vector2 getPosition()
        {
            return position;
        }

        public void loadContent(ContentManager myContent)
        {
            mouseSprite = myContent.Load<Texture2D>(imagePath);
        }

        public void Update()
        {
            var mouseState = Mouse.GetState();
            if (mouseState.X < 0)
            {
                position.X = 0;
            }
            else if (mouseState.X > width - mouseSprite.Width)
            {
                position.X = width - mouseSprite.Width;
            }
            else
            {
                position.X = mouseState.X;
            }

            if (mouseState.Y < 0)
            {
                position.Y = 0;
            }
            else if (mouseState.Y > height - mouseSprite.Height)
            {
                position.Y = height - mouseSprite.Height;
            }
            else
            {
                position.Y = mouseState.Y;
            }
        }

        public void Draw(SpriteBatch mySpriteBatch)
        {
            mySpriteBatch.Draw(mouseSprite, position, Color.White);
        }

    }
}
