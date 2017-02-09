using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class SpriteGameObject
{
    Texture2D sprite;
    protected Rectangle rectangle;
    float speed;
    Vector2 direction;

    public SpriteGameObject(Texture2D sprite, Rectangle rectangle, float speed, Vector2 direction)
    {
        this.sprite = sprite;
        this.rectangle = rectangle;
        this.speed = speed;
        this.direction = direction;
    }

    public Rectangle Rect
    {
        get { return rectangle; }
    }

    public virtual void Update()
    {
        rectangle.X += (int)(direction.X * speed);
        rectangle.Y += (int)(direction.Y * speed);
    }

    public virtual void Draw(SpriteBatch s)
    {
        s.Draw(sprite, rectangle, Color.White);
    }
}