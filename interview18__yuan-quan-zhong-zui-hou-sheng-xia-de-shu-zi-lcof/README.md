# 面试题62. 圆圈中最后剩下的数字
0,1,,n-1这n个数字排成一个圆圈，从数字0开始，每次从这个圆圈里删除第m个数字。求出这个圆圈里剩下的最后一个数字。

例如，0、1、2、3、4这5个数字组成一个圆圈，从数字0开始每次删除第3个数字，则删除的前4个数字依次是2、0、4、1，因此最后剩下的数字是3。

 

示例 1：

> 输入: n = 5, m = 3
> 输出: 3

示例 2：

> 输入: n = 10, m = 17
> 输出: 2
 

限制：

> 1 <= n <= 10^5
> 1 <= m <= 10^6

# 代码
这题需要公式，题解里面看的一知半解，感觉另外一篇讲的不错。只不过这篇最后的代码有点问题，不需要 `return p+1;` `return p;`即可
https://blog.csdn.net/u011500062/article/details/72855826

最终就是记住这个公式，然后记住这段代码吧
```csharp
    public class Solution
    {
        public int LastRemaining(int n, int m)
        {
            int ans = 0;
            // 最后一轮剩下2个人，所以从2开始反推
            for (int i = 2; i <= n; i++)
            {
                ans = (ans + m) % i;
            }
            return ans;
        }
    }
```

# 测试

```csharp
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(5, 3, 3)]
        [DataRow(10, 17, 2)]
        public void TestMethod1(int n, int m, int expected)
        {
            var sut = new Solution();
            var actual = sut.LastRemaining(n, m);
            Assert.AreEqual(expected, actual);
        }
    }
```
