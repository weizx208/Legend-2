using System;
using CLEngine.Core;
using FairyGUI;
using Microsoft.Xna.Framework;

namespace Scripts
{
    public class NAME : ObjectComponent
    {
        /// <summary>
        /// 初始化此实例
        /// </summary>
        public override void Initialize()
        {
            base.Initialize();

            // TODO：初始化您的组件成员

        }

        /// <summary>
        /// 组件更新
        /// </summary>
        /// <param name="gameTime">Game time.</param>
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);

            // TODO：更新组件逻辑

        }

        /// <summary>
        /// 组件绘制
        /// </summary>
        /// <param name="gameTime">Game time.</param>
        /// <param name="spriteBatch">Sprite batch.</param>
        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);

            // TODO: 绘制组件成员

        }
    }
}
