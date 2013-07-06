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

        private Cursor cursor;
        public Model (String image, Cursor myCursor)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
            cursor = myCursor;
        }

        public override void Update()
        {
            //TODO: change this. This is for demo purposes only
            var mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                //TODO: Change this. It kinda ruins everything
                var mousePos = new Point(mouseState.X, mouseState.Y);
                position.X = mouseState.X;
                position.Y = mouseState.Y;

               
            }
        }


    }
}
