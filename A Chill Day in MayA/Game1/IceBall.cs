using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


class IceBall : SpriteGameObject

{
    public IceBall(Texture2D iceBall, Vector2 origin, Vector2 direction): base(iceBall, new Rectangle ((int)origin.X, (int)origin.Y, 50, 50), 7.5f, direction)
    {

    }

    public override void Update()
    {
        base.Update();
    }

    public override void Draw(SpriteBatch s)
    {
        base.Draw(s);
    }
}




