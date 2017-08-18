using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Frogger
{
    class PlayingState: GameObjectList
    {

        private Frog frogObj = new Frog();
        

        public PlayingState()
        {

        SpriteGameObject background = new SpriteGameObject("spr_background", 0, "background");
        this.Add(background);
            this.Add(frogObj);


        }

       
    }
}
