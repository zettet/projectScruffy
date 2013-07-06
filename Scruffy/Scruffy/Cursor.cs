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
    public class Cursor : DrawObject
    {
        public Cursor (String image, float mWidth, float mHeight)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
            width = mWidth;
            height = mHeight;
        }

        //TODO: create capability to drag a rectangle on screen.

        //TODO: handle logic for updating a new selection. If a model is clicked on, it should become the selection.
        //      if an area is dragged, then a unit should be created based on models that the area touches.

        //TODO: possibly remove these functions?
        public void setPositionX(float x)
        {
            position.X = x;
        }

        public void setPositionY(float y)
        {
            position.Y = y;
        }

        public Boolean isLeftClick()
        {
            var mouseState = Mouse.GetState();
            return mouseState.LeftButton == ButtonState.Pressed;
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

        public override void Update(Vector2 newPos)
        {
            throw new NotImplementedException();
        }
    }
}
