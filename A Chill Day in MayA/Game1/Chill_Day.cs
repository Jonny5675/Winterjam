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

    bool gameOver;

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

        gameOver = false;

        shipList = new List<Ship>();
        AddShip();
        fireBallList = new List<FireBall>();
        iceBallList = new List<IceBall>();

        player = new Player(game);
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
            ship.Update(inputHandler, gameTime, fireBallList, iceBallList, new Vector2(player.Rect.X, player.Rect.Y));
        }

        player.Update(inputHandler, gameTime, fireBallList, iceBallList);

        foreach (FireBall f in fireBallList)
        {
            f.Update();
        }

        foreach(IceBall i in iceBallList)
        {
            i.Update();
        }

        //when player has no hitpoints left, it's gameOver
        if (player.HitPoints <= 0)
        {
            gameOver = true;
        }

        //remove ships that have no hitpoints left
        for (int i = shipList.Count; i > 0; i--)
        {
            if (shipList.ElementAt(i - 1).HitPoints <= 0)
            {
                shipList.RemoveAt(i - 1);
            }
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