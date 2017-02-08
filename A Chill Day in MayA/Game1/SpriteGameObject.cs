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
    Rectangle rectangle;

    public SpriteGameObject(Texture2D sprite, Rectangle rectangle)
    {
        this.sprite = sprite;
        this.rectangle = rectangle;
    }

    public virtual void Update()
    {

    }

    public virtual void Draw(SpriteBatch s)
    {
        s.Draw(sprite, rectangle, Color.White);
    }
}