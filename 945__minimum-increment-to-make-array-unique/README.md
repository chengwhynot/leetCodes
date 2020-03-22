# 945. 使数组唯一的最小增量

给定整数数组 A，每次 move 操作将会选择任意 A[i]，并将其递增 1。

返回使 A 中的每个值都是唯一的最少操作次数。

示例 1:

> 输入：[1,2,2]
> 输出：1
> 解释：经过一次 move 操作，数组将变为 [1, 2, 3]。

示例 2:

> 输入：[3,2,1,2,1,7]
> 输出：6
> 解释：经过 6 次 move 操作，数组将变为 [3, 4, 1, 2, 5, 7]。
可以看出 5 次或 5 次以下的 move 操作是不能让数组的每个值唯一的。

提示：

> 1. 0 <= A.length <= 40000
> 2. 0 <= A[i] < 40000

---

# 题解

## 方法二：先计数再遍历

我们尝试不进行排序的方法。

例如输入 [3, 2, 1, 2, 1, 7]，计数之后有两个 1 和两个 2。

我们先看最小的数，两个 1 重复了，需要有一个增加到 2，这样 2 的数量变成了三个。在三个 2 中，又有两个需要增加到 3，然后又出现了两个 3…… 以此类推，可以计算出需要增加的次数。

我们可以用 map（如 C++ 的 unordered_map，Java 的 HashMap）来做计数。不过既然题目中说明了整数的范围在 0 到 40000 之间，我们不妨直接用一个大小为 40000 的数组做计数。

需要注意的是，虽然整数的范围是 0 到 40000，但是由于整数还会因为增加而变大，超出 40000 的范围。例如极端的情况：所有数都是 39999。所以需要对整数中最大的数单独处理。代码如下：

```csharp
public int minIncrementForUnique(int[] A)
        {
            int[] count = new int[40000];
            int max = 0;
            foreach (var a in A)
            {
                count[a]++; // 计数
                max = Math.Max(max, a); // 计算数组中的最大值
            }

            int res = 0;
            for (int j = 0; j < max; j++)
            {
                if (count[j] > 1)
                {
                    // 有 count[j] - 1 个数需要增加
                    res += count[j] - 1;
                    count[j + 1] += count[j] - 1; // 后面的一位，又有 count[j] - 1 个数多出来了，所以也加上。
                }
            }

            // count[max] 单独计算，是因为可能超出 40000 的边界
            if (count[max] > 1)
            {
                int d = count[max] - 1;
                // 有 d 个数需要增加
                // 分别增加为 max + 1, max + 2, ... max + d
                // 使用等差数列公式求和
                res += (1 + d) * d / 2;
            }

            return res;
        }
```

测试代码如下：

```csharp
    [TestClass()]
    public class minimum_increment_to_make_array_unique_tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            var A = new int[] { 1, 2, 2 };
            var expected = 1;
            var sut = new Solution();
            var actual = sut.minIncrementForUnique(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            var A = new int[] { 3, 2, 1, 2, 1, 7 };
            var expected = 6;
            var sut = new Solution();
            var actual = sut.minIncrementForUnique(A);
            Assert.AreEqual(expected, actual);
        }
    }
```
