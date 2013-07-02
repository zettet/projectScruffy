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

    class Model
    {
        private Texture2D modelSprite;
        private String imagePath;
        private Vector2 position;
        private Cursor cursor;
        public Model (String image, Cursor myCursor)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
            cursor = myCursor;
        }

        public void loadContent(ContentManager myContent)
        {
            modelSprite = myContent.Load<Texture2D>(imagePath);
        }

        public void Update()
        {
            //TODO: change this. This is for demo purposes only
            var mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                var mousePos = new Point(mouseState.X, mouseState.Y);
                position.X = cursor.getPosition().X - modelSprite.Width / 2;
                position.Y = cursor.getPosition().Y - modelSprite.Height / 2;
            }
        }

        public void Draw(SpriteBatch mySpriteBatch)
        {
            mySpriteBatch.Draw(modelSprite, position, Color.White);
        }
    }
}
