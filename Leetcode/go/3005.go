package main

func maxFrequencyElements(nums []int) int {
	var dict = make(map[int]int)

	for _, num := range nums {
		dict[num]++
	}

	max := -1
	for _, num := range dict {
		if num > max {
			max = num
		}
	}

	res := 0
	for _, num := range dict {
		if num == max {
			res++
		}
	}

	return res * max
}
