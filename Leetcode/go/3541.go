package main

func maxFreqSum(s string) int {
	var lowerAlphabet [26]int

	for _, c := range s {
		lowerAlphabet[c-'a']++
	}

	maxConsonant, maxVowel := 0, 0
	for i, count := range lowerAlphabet {
		c := 'a' + byte(i)
		if c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' {
			if count > maxVowel {
				maxVowel = count
			}
		} else {
			if count > maxConsonant {
				maxConsonant = count
			}
		}
	}

	return maxConsonant + maxVowel
}
