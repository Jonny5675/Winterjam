using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

class Ship : Creature
{
    public int lives = 4;

    Texture2D shipfine, shipfire1, shipfire2;
    Texture2D shipother, shipotherfire1, shipotherfire2;
    Texture2D iceBall;

    SoundEffect iceballSound;

    int chillDownTime;
    
<<<<<<< HEAD
<<<<<<< HEAD
    public Ship(Game1 game) : base(game, game.Content.Load<Texture2D>("Le Sprites/The real boat"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0), 5)
=======
        public Ship(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/bigpin"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
>>>>>>> 496998d5caf4c94c815997837a77360d6d44e8df
=======
        public Ship(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/The real boat"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
>>>>>>> cbdca843e60d67c88d19ba08ba0b07f2a9c76527
    {
        //if (lives>2) not flames if lives<2 burning, if we have time 
        shipfine  = game.Content.Load<Texture2D>("Le Sprites/The real boat");
        shipfire1 = game.Content.Load<Texture2D>("Le Sprites/The real boat burning");
        shipfire2 = game.Content.Load<Texture2D>("Le Sprites/The real boat burnig 2");
        shipother = game.Content.Load<Texture2D>("Le Sprites/ship");
        shipotherfire1 = game.Content.Load<Texture2D>("Le Sprites/ship burning yay");
        shipotherfire2 = game.Content.Load<Texture2D>("Le Sprites/ship burning yay2");

        iceBall = game.Content.Load<Texture2D>("Le Sprites/IceBall");
        iceballSound = game.Content.Load<SoundEffect>("Sounds/iceball");

        chillDownTime = 500;
    }

    public void Update(InputHandler inputHandler, GameTime gameTime, List<FireBall> fireBallList, List<IceBall> iceBallList, Vector2 playerPos)
    {
        chillDownTime += gameTime.ElapsedGameTime.Milliseconds;

        //shoot iceballs
        if (chillDownTime >= 2000)
        {
            Vector2 origin = new Vector2(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2);

            Vector2 direction = playerPos - origin;
            direction.Normalize();

            IceBall i = new IceBall(iceBall, origin, direction);
            iceBallList.Add(i);

            chillDownTime = 0;

            //plays the fireball sound
            iceballSound.Play();
        }

        //check whether the ship is hit by fireballs
        try
        {
            if (fireBallList.Count > 0)
            {
                for (int i = fireBallList.Count; i > 0; i--)
                {
                    if (rectangle.Contains(fireBallList.ElementAt(i - 1).Rect))
                    {
                        //remove the fireball
                        fireBallList.RemoveAt(i - 1);

                        //lower the ship's hp
                        hitPoints--;
                    }
                }
            }
        }
        catch(Exception e) { }

        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}