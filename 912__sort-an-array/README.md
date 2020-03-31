# 912. ��������

����һ���������� nums�����������������С� 

ʾ�� 1��

> ���룺[5,2,3,1]
> �����[1,2,3,5]

ʾ�� 2��

> ���룺[5,1,1,2,0,0]
> �����[0,0,1,1,2,5]
 

��ʾ��

> 1 <= A.length <= 10000
> -50000 <= A[i] <= 50000

# ����
����һ���ǳ�͵���İ취��ֱ����C#���ú���

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

����һ���Ƚ�����˼�ļ���������Ϊ�����Ŀ����ķ�Χ�Ƚ�С����-50000 �� 50000��������Ϊ��һ������ķ�Χ�����÷ǱȽ���������һЩ��

```csharp
public class Solution
{
    public int[] SortArray(int[] nums)
    {
        // �ǱȽ����򣬼�������
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

# ����

���Ե�ʱ����Ҫע��array�ĶԱȣ���Ҫֱ����Assert.AreEqual����Ϊ����ȥ�Ա��Ƿ�ͬһ�����󣬶����ǶԱȶ����ֵ��

��googleһ��������ֱ����CollectionAssert.AreEqual��������

��ʵ�����Դ��һ����չ�Ķ�[Assert.AreEqual in MSTest �C done right](https://helpercode.com/2017/11/06/assert-areequal-in-mstest-done-right/)

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