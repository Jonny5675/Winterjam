﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Ship : SpriteGameObject
{
    public Ship(Game1 game) : base(game.Content.Load<Texture2D>("Le Sprites/The real boat"), new Rectangle(0, 0, 500, 500), 0f, new Vector2(0, 0))
    {
        
    }

    public override void Update()
    {

    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}