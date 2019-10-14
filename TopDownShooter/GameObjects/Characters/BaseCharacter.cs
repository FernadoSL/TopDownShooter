using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TopDownShooter.GameObjects.Characters
{
    public class BaseCharacter : GameObject
    {
        public int Speed { get; private set; }

        public BaseCharacter(Texture2D texture, Vector2 position, int speed) : this (texture, position)
        {
            this.Speed = speed;
        }

        public BaseCharacter(Texture2D texture, Vector2 position) : base (texture, position)
        {
            this.Speed = 1;
        }

        public virtual void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                this.MoveUp();

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                this.MoveDown();

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                this.MoveRight();

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                this.MoveLeft();
        }

        public virtual void SetSpeed(int speed)
        {
            this.Speed = speed;
        }

        protected void MoveUp()
        {
            this.MoveOnY((10 * this.Speed) * -1);
        }

        protected void MoveDown()
        {
            this.MoveOnY(10 * this.Speed);
        }

        protected void MoveLeft()
        {
            this.MoveOnX((10 * this.Speed) * -1);
        }

        protected void MoveRight()
        {
            this.MoveOnX(10 * this.Speed);
        }
    }
}
