// https://leetcode.com/problems/longest-palindromic-substring/description/
// credits to  https://www.youtube.com/watch?v=9M-cgCVt1d0
/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function(s) {
    if(s.length < 2) return s;
    let start = 0, maxlength=1;

    function expandAroundCenter(left,right){
        while(s[left] === s[right] && left >= 0 && right < s.length)
        {
            if(right - left + 1 >  maxlength){
                start = left;
                maxlength = right - left + 1;
            }
            left -= 1;
            right += 1;
        }
    }
    for(let i = 0; i<s.length; i+=1){
        expandAroundCenter(i-1, i+1);
        expandAroundCenter(i, i+1);
    }
    return s.substring(start, start+maxlength);
};
