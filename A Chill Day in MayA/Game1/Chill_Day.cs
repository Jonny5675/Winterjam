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
    Vector2 screen;

    InputHandler inputHandler;

    Texture2D background;

    List<Ship> shipList;
    Player player;

    public Chill_Day(Game1 game, Vector2 screen)
    {
        this.game = game;
        this.screen = screen;

        inputHandler = new InputHandler();

        background = game.Content.Load<Texture2D>("Le Sprites/The Real Beach");

        shipList = new List<Ship>();
        AddShip();

        player = new Player(game);
    }

    public void AddShip()
    {
        Ship s = new Ship(game);
        shipList.Add(s);
    }

    public void Update()
    {
        inputHandler.Update();

        foreach (Ship ship in shipList)
        {
            ship.Update();
        }

        player.Update();
    }

    public void Draw(SpriteBatch s)
    {
        s.Draw(background, new Rectangle(0, 0, (int)screen.X, (int)screen.Y), Color.White);

        foreach (Ship ship in shipList)
        {
            ship.Draw(s);
        }

        player.Draw(s);
    }
}