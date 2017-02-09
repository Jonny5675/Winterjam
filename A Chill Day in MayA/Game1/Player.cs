using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.Xna.Framework.Audio;
=======
>>>>>>> 496998d5caf4c94c815997837a77360d6d44e8df
=======
using System.Media;
>>>>>>> cbdca843e60d67c88d19ba08ba0b07f2a9c76527

class Player : Creature
{
    Texture2D fireBall;
<<<<<<< HEAD
<<<<<<< HEAD
    SoundEffect fireballsound;
=======
  
=======
    SoundPlayer fireballsound;

>>>>>>> cbdca843e60d67c88d19ba08ba0b07f2a9c76527
    List<FireBall> fireBallList;
>>>>>>> 496998d5caf4c94c815997837a77360d6d44e8df

    int chillDownTime;
    int lives;

    public Player(Game1 game) : base(game, game.Content.Load<Texture2D>("Le Sprites/Real Playerglasses"), new Rectangle(1000, 500, 500, 500), 0f, new Vector2(0, 0), 5)
    {
        fireBall = game.Content.Load<Texture2D>("Le Sprites/Fireball");

<<<<<<< HEAD
<<<<<<< HEAD
        //loads the fireball sound
        fireballsound = game.Content.Load<SoundEffect>("Sounds/fireballs");

        chillDownTime = 500;
=======
        
       
=======
        /* this one seems to the closest to working
        fireballsound = game.Content.Load<SoundPlayer>("Sounds/fireballs");
        */
>>>>>>> cbdca843e60d67c88d19ba08ba0b07f2a9c76527

        // System.Media.SoundPlayer fireballs = new System.Media.SoundPlayer("Sounds/fireballs");
        // fireballs.Play();
        chillDownTime = 500;
<<<<<<< HEAD
     
>>>>>>> 496998d5caf4c94c815997837a77360d6d44e8df
=======
       // SoundPlayer fireballsound = new SoundPlayer();
      //  player.SoundLocation = open
>>>>>>> cbdca843e60d67c88d19ba08ba0b07f2a9c76527
    }

    public void Update(InputHandler inputHandler, GameTime gameTime, List<FireBall> fireBallList, List<IceBall> iceBallList)
    {
        chillDownTime += gameTime.ElapsedGameTime.Milliseconds;

        //shoot fireballs
        if (inputHandler.IsMouseClicked && chillDownTime >= 500)
        {
            Vector2 mousePosition = inputHandler.MousePosition;
            Vector2 origin = new Vector2(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2);

            Vector2 direction = mousePosition - origin;
            direction.Normalize();

            FireBall f = new FireBall(fireBall, origin, direction);
            fireBallList.Add(f);

            chillDownTime = 0;

            //plays the fireball sound
            fireballsound.Play();
        }

        //check whether the player is hit by iceballs
        try
        {
            if (iceBallList.Count > 0)
            {
                for (int i = iceBallList.Count; i > 0; i--)
                {
                    if (iceBallList.ElementAt(i - 1).Rect.Intersects(rectangle))
                    {
                        //remove the iceball
                        iceBallList.RemoveAt(i - 1);

                        //lower the player's hp
                        hitPoints--;
                    }
                }
            }
        }
        catch (Exception e) { }

        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}