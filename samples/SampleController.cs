using System;
using CLEngine.Core;

namespace Samples
{
    /// <summary>
    /// 控制器例子.
    /// 
    /// 注意:
    /// 如果要在编辑器中更新/绘制控制器
    /// 则继承ExtendedObjectComponent.
    /// </summary>
    class SampleController : ObjectComponent
    {
        #region fields

        private string anotherDummyValue = "Dummy Value";

        #endregion

        #region properties

        /// <summary>
        /// 获取或设置虚拟值。
        /// 可以在编辑器中编辑该值。
        /// </summary>
        /// <value>The dummy value.</value>
        public int DummyValue { get; set; }

        /// <summary>
        /// 获取或设置另一个虚拟值。
        /// 可以在编辑器中编辑该值
        /// </summary>
        /// <value>Another dummy value.</value>
        public string AnotherDummyValue
        {
            get
            {
                return anotherDummyValue;
            }
            set
            {
                anotherDummyValue = value;
            }
        }

        #endregion

        #region methods

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

        /// <summary>
        /// 引发碰撞输入事件。
        /// 当另一个对象与此游戏对象碰撞模型边界碰撞时抛出此事件。
        /// </summary>
        /// <param name="other">The other object</param>
        public override void OnCollisionEnter(GameObject other)
        {
            base.OnCollisionEnter(other);

            // TODO: 处理你的物体碰撞

        }

        /// <summary>
        /// 引发鼠标单击事件。
        /// 当在此游戏对象碰撞模型边界内点击鼠标时抛出此事件。
        /// </summary>
        /// <param name="buttonPressed">Button pressed.</param>
        public override void OnMouseClick(MouseEventButton buttonPressed)
        {
            base.OnMouseClick(buttonPressed);

            // TODO: 处理鼠标点击

        }

        /// <summary>
        /// 引发鼠标单击事件。
        /// 当此游戏对象碰撞模型边界内有鼠标按下时，抛出此事件。
        /// </summary>
        /// <param name="buttonPressed">Button pressed.</param>
        public override void OnMouseDown(MouseEventButton buttonPressed)
        {
            base.OnMouseDown(buttonPressed);

            // TODO: 处理鼠标

        }

        /// <summary>
        /// 引发鼠标单击事件。
        /// 当鼠标移动到此游戏对象碰撞模型边界内时，抛出此事件
        /// </summary>
        public override void OnMouseMove()
        {
            base.OnMouseMove();

            // TODO: 处理鼠标移动

        }

        #endregion
    }
}