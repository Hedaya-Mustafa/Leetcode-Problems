public class Solution {
    public bool IsPalindrome(int x) {
        int test =0;
        if( x%10 == 0 && x != 0 )return false;
            while(x>test)
            {
                test = test *10 + x % 10;
                x/=10;
            }   
            return x == test | x== test/10;

    }
}
