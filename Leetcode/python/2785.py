class Solution:
    def sortVowels(self, s: str) -> str:
        vowels = "AEIOUaeiou"
        vowel_list = []

        for c in s:
            if c in vowels:
                vowel_list.append(c)
            
        vowel_list.sort()

        result = []
        i = 0
        for c in s:
            if c in vowels:
                result.append(vowel_list[i])
                i += 1
            else:
                result.append(c)
        
        return "".join(result)