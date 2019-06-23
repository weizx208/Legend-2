local Player = {}

-- 初始化此实例
function Player:Initialize() -- 0: gameObject[自身]
	-- gameObject: Player.InitializeArgs[0]
end

-- 组件更新
function Player:Update()	-- 0:gameTime
	-- gameTime: Player.UpdateArgs[0]
end

-- 组件绘制
function Player:Draw() -- 0: gameTime	1: spriteBatch
	-- gameTime: Player.DrawArgs[0]
	-- spriteBatch: Player.DrawArgs[1]
end

-- 引发碰撞输入事件。
-- 当另一个对象与此游戏对象碰撞模型边界碰撞时抛出此事件。
function Player:OnCollisionEnter()	-- 0: other
	-- other: Player.OnCollisionEnterArgs[0]
end

-- 引发鼠标单击事件。
-- 当在此游戏对象碰撞模型边界内点击鼠标时抛出此事件。
function Player:OnMouseClick()	-- 0: buttonPressed
	-- buttonPressed: Player.OnMouseClickArgs[0]
end

-- 引发鼠标单击事件。
-- 当此游戏对象碰撞模型边界内有鼠标按下时，抛出此事件
function Player:OnMouseDown()	-- 0: Player.args[0]
	-- buttonPressed: Player.OnMouseDownArgs[0]
end

-- 引发鼠标单击事件。
-- 当鼠标移动到此游戏对象碰撞模型边界内时，抛出此事件
function Player:OnMouseMove()

end

return Player