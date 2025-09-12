class Solution:
    def doesAliceWin(self, s: str) -> bool:
        vowels = "auieo"
        for i in s:
            if i in vowels:
                return True
        return False