package main

func minimumTotal(triangle [][]int) int {
	len := len(triangle)
	if len == 0 {
		return 0
	}

	dp := make([]int, len)
	for i := 0; i < len; i++ {
		dp[i] = triangle[len-1][i]
	}

	for i := len - 2; i >= 0; i-- {
		for j := 0; j <= i; j++ {
			dp[j] = triangle[i][j] + min(dp[j], dp[j+1])
		}
	}

	return dp[0]
}
