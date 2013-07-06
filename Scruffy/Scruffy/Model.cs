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
        
        public Model (String image)
        {
            imagePath = image;
            position = new Vector2(0.0f, 0.0f);
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Update(Vector2 pos)
        {
            //TODO: change this. This is for demo purposes only
            position.X = pos.X;
            position.Y = pos.Y; 
        }
    }
}
