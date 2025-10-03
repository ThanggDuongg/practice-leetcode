package main

func triangularSum(nums []int) int {
	n := len(nums) - 1
	i := n - 1
	for i >= 0 {
		for j := 0; j <= i; j++ {
			nums[j] = (nums[j] + nums[j+1]) % 10
		}
		i--
	}

	return nums[0]
}
