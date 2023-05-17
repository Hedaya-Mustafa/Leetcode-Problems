class Solution(object):
    def checkIfPangram(self, sentence):
        alphabet = [False] * 26  # initialize all elements to false
        for i in range(len(sentence)):
            alphabet[ord(sentence[i]) - ord('a')] = True
        for i in range(26):
            if not alphabet[i]:
                return False
        return True

        