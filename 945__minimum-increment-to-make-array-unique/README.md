# 945. ʹ����Ψһ����С����

������������ A��ÿ�� move ��������ѡ������ A[i]����������� 1��

����ʹ A �е�ÿ��ֵ����Ψһ�����ٲ���������

ʾ�� 1:

> ���룺[1,2,2]
> �����1
> ���ͣ�����һ�� move ���������齫��Ϊ [1, 2, 3]��

ʾ�� 2:

> ���룺[3,2,1,2,1,7]
> �����6
> ���ͣ����� 6 �� move ���������齫��Ϊ [3, 4, 1, 2, 5, 7]��
���Կ��� 5 �λ� 5 �����µ� move �����ǲ����������ÿ��ֵΨһ�ġ�

��ʾ��

> 1. 0 <= A.length <= 40000
> 2. 0 <= A[i] < 40000

---

# ���

## ���������ȼ����ٱ���

���ǳ��Բ���������ķ�����

�������� [3, 2, 1, 2, 1, 7]������֮�������� 1 ������ 2��

�����ȿ���С���������� 1 �ظ��ˣ���Ҫ��һ�����ӵ� 2������ 2 ����������������������� 2 �У�����������Ҫ���ӵ� 3��Ȼ���ֳ��������� 3���� �Դ����ƣ����Լ������Ҫ���ӵĴ�����

���ǿ����� map���� C++ �� unordered_map��Java �� HashMap������������������Ȼ��Ŀ��˵���������ķ�Χ�� 0 �� 40000 ֮�䣬���ǲ���ֱ����һ����СΪ 40000 ��������������

��Ҫע����ǣ���Ȼ�����ķ�Χ�� 0 �� 40000��������������������Ϊ���Ӷ���󣬳��� 40000 �ķ�Χ�����缫�˵���������������� 39999��������Ҫ�����������������������������£�

```csharp
public int minIncrementForUnique(int[] A)
        {
            int[] count = new int[40000];
            int max = 0;
            foreach (var a in A)
            {
                count[a]++; // ����
                max = Math.Max(max, a); // ���������е����ֵ
            }

            int res = 0;
            for (int j = 0; j < max; j++)
            {
                if (count[j] > 1)
                {
                    // �� count[j] - 1 ������Ҫ����
                    res += count[j] - 1;
                    count[j + 1] += count[j] - 1; // �����һλ������ count[j] - 1 ����������ˣ�����Ҳ���ϡ�
                }
            }

            // count[max] �������㣬����Ϊ���ܳ��� 40000 �ı߽�
            if (count[max] > 1)
            {
                int d = count[max] - 1;
                // �� d ������Ҫ����
                // �ֱ�����Ϊ max + 1, max + 2, ... max + d
                // ʹ�õȲ����й�ʽ���
                res += (1 + d) * d / 2;
            }

            return res;
        }
```

���Դ������£�

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
