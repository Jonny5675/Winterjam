using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

class Player : Creature
{
    Texture2D fireBall;
    SoundEffect fireballsound;

    int chillDownTime;

    public Player(Game1 game) : base(game, game.Content.Load<Texture2D>("Le Sprites/Real Playerglasses"), new Rectangle(1000, 500, 500, 500), 0f, new Vector2(0, 0), 5)
    {
        fireBall = game.Content.Load<Texture2D>("Le Sprites/Fireball");

        //loads the fireball sound
        fireballsound = game.Content.Load<SoundEffect>("Sounds/fireballs");

        chillDownTime = 500;
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