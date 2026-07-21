class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        D = {}

        for char in s:
            if char not in D:
                D[char] = 1
            elif char in D:
                D[char] = D.get(char, 0) + 1

        for char in t:
            if char not in D:
                D[char] = 1
            elif char in D:
                D[char] = D.get(char, 0) - 1

        for value in D.values():
            if value != 0:
                return False

        return True
