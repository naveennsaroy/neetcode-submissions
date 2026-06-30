public class Solution {
    int solve(int idx, int n, string s, List<string>dict, int[] dp){
        if(idx==n){
            return 1;
        }

        if(dp[idx]!=-1) return dp[idx];

        string temp="";
        bool ans=false;
        for(int i=idx;i<n;i++){
            temp+=s[i];
            if(dict.Contains(temp)){
                bool sn=(solve(i+1, n, s, dict,dp) == 1)? true:false;
                ans = ans || sn;
            }
        }

        return dp[idx]= (ans==true)?1:0;
    }
    public bool WordBreak(string s, List<string> wordDict) {
        int n=s.Length;
        int[] dp=new int [n];
        for(int i=0;i<n;i++){
            dp[i]=-1;
        }
        int a= solve(0,n,s,wordDict,dp);
        return (a==1)? true:false;
    }
}
