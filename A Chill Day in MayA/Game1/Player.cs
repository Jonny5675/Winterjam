using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Media;

class Player : SpriteGameObject
{
    Texture2D fireBall;
    SoundPlayer fireballsound;

    List<FireBall> fireBallList;

    int chillDownTime;
    int lives;

    public Player(Game1 game, List<FireBall> fireBallList) : base(game.Content.Load<Texture2D>("Le Sprites/Real Playerglasses"), new Rectangle(1000, 500, 500, 500), 0f, new Vector2(0, 0))
    {
        this.fireBallList = fireBallList;

        fireBall = game.Content.Load<Texture2D>("Le Sprites/Fireball");

        /* this one seems to the closest to working
        fireballsound = game.Content.Load<SoundPlayer>("Sounds/fireballs");
        */

        // System.Media.SoundPlayer fireballs = new System.Media.SoundPlayer("Sounds/fireballs");
        // fireballs.Play();
        chillDownTime = 500;
       // SoundPlayer fireballsound = new SoundPlayer();
      //  player.SoundLocation = open
    }

    public void Update(InputHandler inputHandler, GameTime gameTime)
    {
        chillDownTime += gameTime.ElapsedGameTime.Milliseconds;

        if (inputHandler.IsMouseClicked && chillDownTime >= 500)
        {
            Vector2 mousePosition = inputHandler.MousePosition;
            Vector2 origin = new Vector2(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2);

            Vector2 direction = mousePosition - origin;
            direction.Normalize();

            FireBall f = new FireBall(fireBall, origin, direction);
            fireBallList.Add(f);

            chillDownTime = 0;
        }

        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}