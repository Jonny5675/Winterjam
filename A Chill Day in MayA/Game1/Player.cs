using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Player : SpriteGameObject
{
    public Player(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/Playerish"), new Rectangle(1000, 500, 500, 500), 0f, new Vector2(0, 0))
    {

    }

    public void Update(InputHandler inputHandler)
    {
        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}