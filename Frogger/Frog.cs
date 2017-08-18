using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frogger
{
    class Frog: SpriteGameObject   
    {
        public Frog()
        :base ("spr_frog")
        {
            Reset();
        }

        public override void HandleInput(InputHelper inputHelper)
        {

            if (inputHelper.IsKeyDown(Keys.Left))
                position.X = -40;
            else if (inputHelper.IsKeyDown(Keys.Right))
                position.X = 40;
            else if (inputHelper.IsKeyDown(Keys.Up))
                position.Y = -40;
            else if (inputHelper.IsKeyDown(Keys.Down))
                position.Y = 40;
        }
    
        public override void Reset(){
            position.X = 300;
            position.Y = 300;


        }
    
    
    
    
    }

}
