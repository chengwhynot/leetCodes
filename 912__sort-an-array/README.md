# 912. 排序数组

给定一个整数数组 nums，将该数组升序排列。 

示例 1：

> 输入：[5,2,3,1]
> 输出：[1,2,3,5]

示例 2：

> 输入：[5,1,1,2,0,0]
> 输出：[0,0,1,1,2,5]
 

提示：

> 1 <= A.length <= 10000
> -50000 <= A[i] <= 50000

# 代码
先上一个非常偷懒的办法，直接用C#内置函数

```csharp
public class Solution
{
    public int[] SortArray(int[] nums)
    {
        Array.Sort(nums);
        return nums;
    }
}
```

再来一个比较有意思的计数排序。因为这个题目数组的范围比较小，从-50000 到 50000，基本认为是一个不大的范围，采用非比较排序会更快一些。

```csharp
public class Solution
{
    public int[] SortArray(int[] nums)
    {
        // 非比较排序，计数排序。
        var min = -50000;
        var max = 50000;
        foreach (var n in nums)
        {
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        var counter = new int[max - min + 1];
        foreach (var n in nums)
        {
            counter[n - min]++;
        }

        var res = new int[nums.Length];
        var idx = 0;
        for (int num = min; num <= max; num++)
        {
            while (counter[num-min] > 0)
            {
                counter[num - min]--;
                res[idx++] = num;
            }
        }
        return res;
    }
}            
```

# 测试

测试的时候，需要注意array的对比，不要直接用Assert.AreEqual，因为它会去对比是否同一个对象，而不是对比对象的值。

简单google一番，可以直接用CollectionAssert.AreEqual，完美。

其实灵感来源于一个扩展阅读[Assert.AreEqual in MSTest – done right](https://helpercode.com/2017/11/06/assert-areequal-in-mstest-done-right/)

```csharp
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] { 5, 2, 3, 1 }, new int[] { 1, 2, 3, 5 })]
        [DataRow(new int[] { 5, 1, 1, 2, 0, 0 }, new int[] { 0, 0, 1, 1, 2, 5 })]
        public void TestMethod1(int[] nums, int[] expected)
        {
            var sut = new Solution();
            var actual = sut.SortArray(nums);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
```