using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//Class to manage an individual model. Should have a list of attributes, and a history of actions
namespace Scruffy
{
    //TODO: integrate with unit class.
    //TODO: make a base class that unit and cursor inherit from?\

    class Model : DrawObject
    {


        public Model (String image, Cursor myCursor, float mWidth, float mHeight)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
            cursor = myCursor;
            width = mWidth;
            height = mHeight;
        }

        public override void Update()
        {
            //TODO: change this. This is for demo purposes only
            var mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                //TODO: Change this. It kinda ruins everything
                var mousePos = new Point(mouseState.X, mouseState.Y);
                if (position.X < 0)
                {
                    position.X = 0;
                    cursor.setPositionX(position.X + sprite.Width / 2);
                }
                else if ((position.X + sprite.Width) > width)
                {
                    position.X = width - sprite.Width;
                    cursor.setPositionX(position.X + sprite.Width / 2);
                }
                else
                {
                    position.X = cursor.getPosition().X - sprite.Width / 2;
                }

                if (position.Y < 0)
                {
                    position.Y = 0;
                    cursor.setPositionY(position.Y + sprite.Height / 2);
                }
                else if ((position.Y + sprite.Height) > height)
                {
                    position.Y = height - sprite.Height;
                    cursor.setPositionY(position.Y + sprite.Height / 2);
                }
                else
                {
                    position.Y = cursor.getPosition().Y - sprite.Height / 2;
                }    
            }
        }


    }
}
