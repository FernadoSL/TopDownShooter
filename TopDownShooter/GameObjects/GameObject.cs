using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TopDownShooter.GameObjects
{
    public class GameObject
    {
        public Texture2D Texture { get; private set; }

        public Vector2 Position { get; private set; }

        public GameObject(Texture2D texture, Vector2 position)
        {
            this.Texture = texture;
            this.Position = position;
        }

        public virtual void MoveOnX(int pixels)
        {
            Vector2 position = this.Position;
            position.X = this.Position.X + pixels;

            this.Position = position;
        }

        public virtual void MoveOnY(int pixel)
        {
            Vector2 position = this.Position;
            position.Y = this.Position.Y + pixel;

            this.Position = position;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, this.Texture.Width, this.Texture.Height);
            Vector2 origin = new Vector2(this.Texture.Width / 2, this.Texture.Height / 2);

            spriteBatch.Draw(this.Texture, this.Position, sourceRectangle, Color.White, 0, origin, 1.0f, SpriteEffects.None, 1);
        }
    }
}
