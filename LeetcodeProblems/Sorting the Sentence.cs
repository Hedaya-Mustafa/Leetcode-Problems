public class Solution {
    public string SortSentence(string s) {

        string[] words = s.Split(' ');
        string[] sortedWords = new string[words.Length]; //to store the sorted words

        foreach (string word in words) { //to iterate over the words
            int index = word[word.Length -1] - '0'; //convert char to int
            sortedWords[index - 1] = word.Substring(0, word.Length -1);
        } return string.Join(" ", sortedWords); //to join the sorted words with spaces between them
    }
}