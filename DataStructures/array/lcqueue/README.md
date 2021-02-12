# 实现队列

请参照课程内容，用循环数组或者链表实现一个队列，包括：

- push(int n) - 在队尾插入新元素 n，无需返回
- pop() - 队首出队
- front() - 获取队首元素
- size() - 获取队列大小

题目保证所给操作均合法。

示例：

> 输入：  
> ["LCQueue", "size", "push", "front", "push", "front", "size", "pop", "front", "pop", "size"]  
> [[], [], [52], [], [22], [], [], [], [], [], []]  

> 输出：  
> [null,0,null,52,null,52,2,null,22,null,0]  

> 解释：  
> LCStack l = LCQueue()  
> l.size()        // 获取队列长度，此时栈为空，返回 0  
> l.push(52) // 放入新元素 52，返回 null  
> l.front()    // 当前队首为 52，返回 52  
> l.push(22)        // 放入新元素 22，返回 null  
> l.front() // 当前队首仍然为 52，返回 52  
> l.size()        // 获取队列长度，返回 2  
> l.pop()         // 52 出队  
> l.front()      // 当前队首为 22，返回 22  
> l.pop()     // 22 出队  
> l.size()    // 当前队列长度为 0  