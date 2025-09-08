package main

import "fmt"

func getNoZeroIntegers(n int) []int {
    for i := 1; i < n; i++ {
        if !containsZero(i) && !containsZero(n - i) {
            return []int{i, n - i}
        }
    }
    return []int{}
}

func containsZero(n int) bool {
	for n > 0 {
		if n % 10 == 0 {
			return true
		}
		n /= 10
	}
	return false
}

func main() {
    fmt.Println(getNoZeroIntegers(2))
}
