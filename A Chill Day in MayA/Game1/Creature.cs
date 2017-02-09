using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Creature : SpriteGameObject
{
    int maxHP;
    protected int hitPoints;

    Texture2D hp_red, hp_black;

    public Creature(Game game, Texture2D sprite, Rectangle rectangle, float speed, Vector2 direction, int maxHP) : base(sprite, rectangle, speed, direction)
    {
        hp_red = game.Content.Load<Texture2D>("Le Sprites/hp_red");
        hp_black = game.Content.Load<Texture2D>("Le Sprites/hp_black");

        this.maxHP = maxHP;
        hitPoints = maxHP;
    }

    public int HitPoints
    {
        get { return hitPoints; }
    }

    public override void Update()
    {
        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);

        s.Draw(hp_red, new Rectangle(rectangle.X, rectangle.Y, (int)(hitPoints / (float)maxHP * 250), 50), new Rectangle(0, 0, (int)(hitPoints / (float)maxHP * 250), 50), Color.White);
        s.Draw(hp_black, new Rectangle(rectangle.X, rectangle.Y, 250, 50), Color.White);
    }
}