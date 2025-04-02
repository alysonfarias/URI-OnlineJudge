LT500
Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

Note that the strings are case-insensitive, both lowercased and uppercased of the same letter are treated as if they are at the same row.

In the American keyboard:

the first row consists of the characters "qwertyuiop",
the second row consists of the characters "asdfghjkl", and
the third row consists of the characters "zxcvbnm".
Example 1:

Input: words = ["Hello","Alaska","Dad","Peace"]

Output: ["Alaska","Dad"]

Explanation:

Both "a" and "A" are in the 2nd row of the American keyboard due to case insensitivity.

Example 2:

Input: words = ["omk"]

Output: []

Example 3:

Input: words = ["adsdf","sfd"]

Output: ["adsdf","sfd"]

 

/**
 * @param {string[]} words
 * @return {string[]}
 */
var findWords = function(words) {
   const keyboardRows = new Set([
        new Set('qwertyuiop'),
        new Set('asdfghjkl'),
        new Set('zxcvbnm')
   ])

   const validWords = [];

   for(const word of words){
    const lowerCaseWord = word.toLowerCase();
    let wordRow = null;

    for(const row of keyboardRows){
        let isWordInRow = true;
        for(const char of lowerCaseWord){
            if(!row.has(char)){
                isWordInRow = false
                break;
            }
        }
        if(isWordInRow){
            wordRow = row;
            break;
        }
    }
    if(wordRow) {
        validWords.push(word);
    }
   }
   return validWords;
};
