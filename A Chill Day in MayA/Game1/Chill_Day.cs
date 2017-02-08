using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Chill_Day
{
    Game1 game;
    List<Ship> shipList;

    public Chill_Day(Game1 game)
    {
        this.game = game;
        shipList = new List<Ship>();
        AddShip();
    }

    public void AddShip()
    {
        Ship s = new Ship(game);
        shipList.Add(s);
    }

    public void Update()
    {
        foreach(Ship ship in shipList)
        {
            ship.Update();
        }
    }

    public void Draw(SpriteBatch s)
    {
        foreach(Ship ship in shipList)
        {
            ship.Draw(s);
        }
    }
}