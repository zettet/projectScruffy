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


        //handle logic for selected objects
        //TODO: Fix case where DrawObject stops updating if it goes offscreen
        public void Update()
        {
            if ((selectedObject.getPosition().X >= 0) && (selectedObject.getPosition().Y >= 0) &&
                 (selectedObject.getPosition().X + selectedObject.getSpriteWidth() < width) &&
                 (selectedObject.getPosition().Y + selectedObject.getSpriteHeight() < height))
            {

                selectedObject.Update();
            }
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
