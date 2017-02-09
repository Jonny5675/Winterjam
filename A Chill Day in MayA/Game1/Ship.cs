using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Ship : SpriteGameObject
{
      public int lives = 4;

    Texture2D shipfine, shipfire1, shipfire2;
    Texture2D shipother, shipotherfire1, shipotherfire2;




    
        public Ship(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/The real boat"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
    {
        //if (lives>2) not flames if lives<2 burning, if we have time 
        shipfine  = game.Content.Load<Texture2D>("Le Sprites/The real boat");
        shipfire1 = game.Content.Load<Texture2D>("Le Sprites/The real boat burning");
        shipfire2 = game.Content.Load<Texture2D>("Le Sprites/The real boat burnig 2");
        shipother = game.Content.Load<Texture2D>("Le Sprites/ship");
        shipotherfire1 = game.Content.Load<Texture2D>("Le Sprites/ship burning yay");
        shipotherfire2 = game.Content.Load<Texture2D>("Le Sprites/ship burning yay2");
    }

    /*Was Trying to Create A method/case switch to load a different ship tile so if you hit it enough it start starts to burn
     * , also have no idea how make it pick both of the burning so it would look like it has moving flames.
     * 
    public Shipb(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/The real boat burning"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
    {


    }



    public Shipb(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/The real boat burnig 2"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
    {


    }
    */






    public override void Update()
    {
        //trying to make a bool for shit is hit, so yeah collision, did some lives for the ship, more or less
        //if (Shipishit==true)
        {
            lives = -1;
        }
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);

        if (lives ==0)
        {
            
        }
    }
}