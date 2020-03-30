# ������62. ԲȦ�����ʣ�µ�����
0,1,,n-1��n�������ų�һ��ԲȦ��������0��ʼ��ÿ�δ����ԲȦ��ɾ����m�����֡�������ԲȦ��ʣ�µ����һ�����֡�

���磬0��1��2��3��4��5���������һ��ԲȦ��������0��ʼÿ��ɾ����3�����֣���ɾ����ǰ4������������2��0��4��1��������ʣ�µ�������3��

 

ʾ�� 1��

> ����: n = 5, m = 3
> ���: 3

ʾ�� 2��

> ����: n = 10, m = 17
> ���: 2
 

���ƣ�

> 1 <= n <= 10^5
> 1 <= m <= 10^6

# ����
������Ҫ��ʽ��������濴��һ֪��⣬�о�����һƪ���Ĳ���ֻ������ƪ���Ĵ����е����⣬����Ҫ `return p+1;` `return p;`����
https://blog.csdn.net/u011500062/article/details/72855826

���վ��Ǽ�ס�����ʽ��Ȼ���ס��δ����
```csharp
    public class Solution
    {
        public int LastRemaining(int n, int m)
        {
            int ans = 0;
            // ���һ��ʣ��2���ˣ����Դ�2��ʼ����
            for (int i = 2; i <= n; i++)
            {
                ans = (ans + m) % i;
            }
            return ans;
        }
    }
```

# ����

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
