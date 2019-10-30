using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TopDownShooter.GameObjects.Characters
{
    public class PlayerCharacter : BaseCharacter
    {
        public float Rotation { get; private set; }

        public PlayerCharacter(Texture2D texture, Vector2 position, int speed) 
            : base (texture, position, speed)
        {

        }

        public override void Update()
        {
            this.UpdateRotation();

            this.UpdateKeyUp();

            this.UpdateKeyDown();
        }

        protected virtual void UpdateKeyUp()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 0.1 && this.Rotation < 1.4))
            {
                this.MoveUp();
                this.MoveRight();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 1.6 && this.Rotation < 2.9))
            {
                this.MoveDown();
                this.MoveRight();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 3.1 && this.Rotation < 4.4))
            {
                this.MoveDown();
                this.MoveLeft();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 4.6 && this.Rotation < 5.9))
            {
                this.MoveUp();
                this.MoveLeft();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 5.9 || this.Rotation < 0.1))
                this.MoveUp();

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 1.4 && this.Rotation < 1.6))
                this.MoveRight();

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 2.9 && this.Rotation < 3.1))
                this.MoveDown();

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && (this.Rotation > 4.4 && this.Rotation < 4.6))
                this.MoveLeft();
        }

        protected virtual void UpdateKeyDown()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Down) && (this.Rotation > 0 && this.Rotation < 1.5))
            {
                this.MoveDown();
                this.MoveLeft();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down) && (this.Rotation > 1.5 && this.Rotation < 3))
            {
                this.MoveUp();
                this.MoveLeft();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down) && (this.Rotation > 3 && this.Rotation < 4.5))
            {
                this.MoveUp();
                this.MoveRight();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down) && (this.Rotation > 4.5 && this.Rotation < 6))
            {
                this.MoveDown();
                this.MoveRight();
            }
        }

        private void UpdateRotation()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                this.RotateLeft();

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                this.RotateRight();

            if (this.Rotation > 5.99)
                this.Rotation = 0;

            if (this.Rotation < 0)
                this.Rotation = 5.99F;
        }

        protected void RotateLeft()
        {
            this.Rotation -= (0.1F * this.Speed);
        }

        protected void RotateRight()
        {
            this.Rotation += (0.1F * this.Speed);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, this.Texture.Width, this.Texture.Height);
            Vector2 origin = new Vector2(this.Texture.Width / 2, this.Texture.Height / 2);

            spriteBatch.Draw(this.Texture, this.Position, sourceRectangle, Color.White, this.Rotation, origin, 1.0f, SpriteEffects.None, 1);
        }
    }
}
