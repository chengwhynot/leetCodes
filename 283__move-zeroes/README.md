# 283. 移动零

给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

示例:

输入: [0,1,0,3,12]  
输出: [1,3,12,0,0]  

说明:  

必须在原数组上操作，不能拷贝额外的数组。

尽量减少操作次数。

---
双指针，左指针指向已处理的队列末尾，右指针指向待处理队列列头。右指针如果不为零，交换左右指针数值，然后递增左指针；递增右指针；
```
public void MoveZeroes(int[] nums)
{
    if (nums == null)
        return;
    int i = 0;
    int j = 0;
    while (j < nums.Length)
    {
        if (nums[j] != 0)
        {
            int tmp = nums[j];
            nums[j] = nums[i];
            nums[i] = tmp;
            i++;
        }
        j++;
    }
}
```