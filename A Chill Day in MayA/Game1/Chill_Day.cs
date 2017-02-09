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
    List<FireBall> fireBallList;
    List<IceBall> iceBallList;

    public Chill_Day(Game1 game, Vector2 screen)
    {
        this.game = game;
        this.screen = screen;

        inputHandler = new InputHandler();

        background = game.Content.Load<Texture2D>("Le Sprites/The Real Beach2");

        shipList = new List<Ship>();
        AddShip();
        fireBallList = new List<FireBall>();
        iceBallList = new List<IceBall>();

        player = new Player(game, fireBallList);
    }

    public void AddShip()
    {
        Ship s = new Ship(game);
        shipList.Add(s);
    }

    public void Update(GameTime gameTime)
    {
        inputHandler.Update();

        foreach (Ship ship in shipList)
        {
            ship.Update();
        }

        player.Update(inputHandler, gameTime);

        foreach (FireBall f in fireBallList)
        {
            f.Update();
        }

        foreach(IceBall i in iceBallList)
        {
            i.Update();
        }
    }

    public void Draw(SpriteBatch s)
    {
        s.Draw(background, new Rectangle(0, 0, (int)screen.X, (int)screen.Y), Color.White);

        foreach (Ship ship in shipList)
        {
            ship.Draw(s);
        }

        player.Draw(s);

        foreach (FireBall f in fireBallList)
        {
            f.Draw(s);
        }

        foreach (IceBall i in iceBallList)
        {
            i.Draw(s);
        }
    }
}