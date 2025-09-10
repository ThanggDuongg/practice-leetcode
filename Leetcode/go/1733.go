package main
	
import (
    "fmt"
    "github.com/samber/lo"
)

func minimumTeachings(n int, languages [][]int, friendships [][]int) int {
    needToTeach := make(map[int]bool)

    for _, friendship := range friendships {
        f1, f2 := friendship[0] - 1, friendship[1] - 1

        if !canCommunicate(languages[f1], languages[f2]) {
            needToTeach[f1] = true
            needToTeach[f2] = true
        }
    }

    if len(needToTeach) == 0 {
        return 0
    }

    minTeach := len(needToTeach)
    for i := 1; i <= n; i++ {
        count := 0
        for friend := range needToTeach {
            // if !lo.Contains(languages[friend], i) {
            if !contains(languages[friend], i) {
                count++
            }
        }

        if count < minTeach {
            minTeach = count
        }
    }

    return minTeach
}

func canCommunicate(langFriend1, langFriend2 []int) bool {
    set := make(map[int]bool)

    for _, lang := range langFriend1 {
        set[lang] = true
    }

    for _, lang := range langFriend2 {
        if set[lang] {
            return true
        }
    }

    return false
}

func contains(slice []int, x int) bool {
    for _, v := range slice {
        if v == x {
            return true
        }
    }
    return false
}

func main() {
    fmt.Println(minimumTeachings(2, [][]int{{1}, {2}, {1, 2}}, [][]int{{1, 2}, {1, 3}, {2, 3}}))
}