public class Solution {
    bool solve(int idx, int n, string s, List<string>dict, Dictionary<int,bool>dp){
        if(idx==n){
            return true;
        }

        if(dp.ContainsKey(idx)) return dp[idx];
        string temp="";
        bool ans=false;
        for(int i=idx;i<n;i++){
            temp+=s[i];
            if(dict.Contains(temp)){
                // bool sn=(solve(i+1, n, s, dict,dp) == 1)? true:false;
                ans = ans || solve(i+1, n, s, dict,dp);
            }
        }

        return dp[idx]= ans;
    }
    public bool WordBreak(string s, List<string> wordDict) {
        int n=s.Length;
        Dictionary<int,bool> dp=new();
        return solve(0,n,s,wordDict,dp);
    }
}
