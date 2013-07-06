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
    class Cursor : DrawObject
    {
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

        //TODO: possibly remove these functions?
        public void setPositionX(float x)
        {
            position.X = x;
        }

        public void setPositionY(float y)
        {
            position.Y = y;
        }


        public override void Update()
        {
            var mouseState = Mouse.GetState();
            if (mouseState.X < 0)
            {
                position.X = 0;
            }
            else if (mouseState.X > width - sprite.Width)
            {
                position.X = width - sprite.Width;
            }
            else
            {
                position.X = mouseState.X;
            }

            if (mouseState.Y < 0)
            {
                position.Y = 0;
            }
            else if (mouseState.Y > height - sprite.Height)
            {
                position.Y = height - sprite.Height;
            }
            else
            {
                position.Y = mouseState.Y;
            }
        }
    }
}
