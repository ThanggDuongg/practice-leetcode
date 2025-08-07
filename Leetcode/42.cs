namespace Leetcode
{
    class _42
    {
        public int Trap(int[] height)
        {
            var res = 0;
            int leftIndex = 0,
                rightIndex = height.Length - 1;
            int leftMax = height[leftIndex],
                rightMax = height[rightIndex];

            while (leftIndex < rightIndex)
            {
                if (leftMax < rightMax)
                {
                    leftIndex++;
                    if (height[leftIndex] < leftMax)
                    {
                        res += leftMax - height[leftIndex];
                    }
                    else
                    {
                        leftMax = height[leftIndex];
                    }
                }
                else
                {
                    rightIndex--;
                    if (height[rightIndex] < rightMax)
                    {
                        res += rightMax - height[rightIndex];
                    }
                    else
                    {
                        rightMax = height[rightIndex];
                    }
                }
            }

            return res;
        }

        public int Trap2(int[] height)
        {
            var res = 0;
            var leftIndex = 0;

            while (leftIndex < height.Length - 1)
            {
                int rightIndex = leftIndex + 1;
                int maxRight = rightIndex;

                while (rightIndex < height.Length && height[rightIndex] < height[leftIndex])
                {
                    if (height[rightIndex] > height[maxRight])
                    {
                        maxRight = rightIndex;
                    }
                    rightIndex++;
                }

                if (rightIndex < height.Length)
                {
                    int boundaryHeight = Math.Min(height[leftIndex], height[rightIndex]);
                    for (int i = leftIndex + 1; i < rightIndex; i++)
                    {
                        res += boundaryHeight - height[i];
                    }
                    leftIndex = rightIndex;
                }
                else
                {
                    int boundaryHeight = Math.Min(height[leftIndex], height[maxRight]);
                    for (int i = leftIndex + 1; i < maxRight; i++)
                    {
                        res += boundaryHeight - height[i];
                    }
                    leftIndex = maxRight;
                }
            }

            return res;
        }
    }
}
