using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//a singleton class for managing a selection of units.
namespace Scruffy
{
    public class Selection
    {
        private static Selection instance;
        private DrawObject selectedObject;
        private float width;
        private float height;
        private Cursor cursor;


        private Selection(){}

        public void setScreenDimensions(float mWidth, float mHeight)
        {
            width = mWidth;
            height = mHeight;
        }

        //set a new selection
        public void setSelection (DrawObject newSelection)
        {
            selectedObject = newSelection;
        }

        public void setCursor(Cursor myCursor)
        {
            cursor = myCursor;
        }

        //handle logic for selected objects
        //TODO: Fix case where DrawObject stops updating if it goes offscreen
        public void Update()
        {
            Vector2 newPos = new Vector2();
            float spriteWidth = selectedObject.getSpriteWidth()/2;
            float spriteHeight = selectedObject.getSpriteHeight() / 2;

            if (cursor.getPosition().X >= spriteWidth && cursor.getPosition().X <= width - spriteWidth &&
                cursor.isLeftClick())
            {
                newPos.X = cursor.getPosition().X - spriteWidth;   
            }
            else
            {
                newPos.X = selectedObject.getPosition().X;
            }
               
            if (cursor.getPosition().Y >= spriteHeight && cursor.getPosition().Y <= height - spriteHeight &&
                cursor.isLeftClick())
            {
                newPos.Y = cursor.getPosition().Y - spriteHeight;
            }
            else
            {
                newPos = selectedObject.getPosition();
            }
                
            selectedObject.Update(newPos);
        }

        public void Draw(SpriteBatch mySpriteBatch)
        {
            selectedObject.Draw(mySpriteBatch);
        }

        //make the selection a singleton
        public static Selection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Selection();
                }
                return instance;
            }
        }
    }
}
