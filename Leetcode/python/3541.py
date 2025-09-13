class Solution:
    def maxFreqSum(self, s: str) -> int:
        lowerAlphabet = [0] * 26

        for i in s:
            lowerAlphabet[ord(i) - ord('a')] += 1
        
        maxConsonant, maxVowel = 0, 0
        vowels = "aeiou"
        for i in range(len(lowerAlphabet)):
            if chr(i + ord('a')) in vowels:
                maxVowel = max(maxVowel, lowerAlphabet[i])
            else:
                maxConsonant = max(maxConsonant, lowerAlphabet[i])
        
        return maxConsonant + maxVowel