using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

class InputHandler
{
    private MouseState previousMouseState;

    private bool isMouseClicked;

    private Vector2 mousePosition;

    private bool left;
    private bool right;
    private bool up;
    private bool down;

    public InputHandler()
    {
        previousMouseState = Mouse.GetState();

        mousePosition = new Vector2(previousMouseState.Position.X, previousMouseState.Position.Y);
    }

    public bool Left
    {
        get { return left; }
    }

    public bool Right
    {
        get { return right; }
    }

    public bool Up
    {
        get { return up; }
    }

    public bool Down
    {
        get { return down; }
    }

    public bool IsMouseClicked
    {
        get { return isMouseClicked; }
    }

    public Vector2 MousePosition
    {
        get { return mousePosition; }
    }

    public void Update()
    {
        //get new mouse state and check for mouse click and get the new mouse position

        MouseState currentMouseState = Mouse.GetState();

        isMouseClicked = (currentMouseState.LeftButton == ButtonState.Pressed && previousMouseState.LeftButton == ButtonState.Released);

        mousePosition = new Vector2(currentMouseState.Position.X, currentMouseState.Y);

        previousMouseState = currentMouseState;

        //check whether the WASD- or arrow-buttons are pressed

        KeyboardState currentKeyBoardState = Keyboard.GetState();

        left = (currentKeyBoardState.IsKeyDown(Keys.Left) || currentKeyBoardState.IsKeyDown(Keys.A));
        right = (currentKeyBoardState.IsKeyDown(Keys.Right) || currentKeyBoardState.IsKeyDown(Keys.D));
        up = (currentKeyBoardState.IsKeyDown(Keys.Up) || currentKeyBoardState.IsKeyDown(Keys.W));
        down = (currentKeyBoardState.IsKeyDown(Keys.Down) || currentKeyBoardState.IsKeyDown(Keys.S));
    }
}