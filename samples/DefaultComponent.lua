local NAME = {}

-- 初始化此实例
function NAME:Initialize() -- 0: gameObject[自身]
	-- gameObject: NAME.InitializeArgs[0]
end

-- 组件更新
function NAME:Update()	-- 0:gameTime
	-- gameTime: NAME.UpdateArgs[0]
end

-- 组件绘制
function NAME:Draw() -- 0: gameTime	1: spriteBatch
	-- gameTime: NAME.DrawArgs[0]
	-- spriteBatch: NAME.DrawArgs[1]
end

-- 引发碰撞输入事件。
-- 当另一个对象与此游戏对象碰撞模型边界碰撞时抛出此事件。
function NAME:OnCollisionEnter()	-- 0: other
	-- other: NAME.OnCollisionEnterArgs[0]
end

-- 引发鼠标单击事件。
-- 当在此游戏对象碰撞模型边界内点击鼠标时抛出此事件。
function NAME:OnMouseClick()	-- 0: buttonPressed
	-- buttonPressed: NAME.OnMouseClickArgs[0]
end

-- 引发鼠标单击事件。
-- 当此游戏对象碰撞模型边界内有鼠标按下时，抛出此事件
function NAME:OnMouseDown()	-- 0: NAME.args[0]
	-- buttonPressed: NAME.OnMouseDownArgs[0]
end

-- 引发鼠标单击事件。
-- 当鼠标移动到此游戏对象碰撞模型边界内时，抛出此事件
function NAME:OnMouseMove()

end

return NAME