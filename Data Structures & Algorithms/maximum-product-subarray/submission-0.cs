public class Solution {
    public int MaxProduct(int[] nums) {
        int pre=1, suff=1, ans=int.MinValue;
        int n=nums.Length;
        for(int i=0;i<n;i++){
            if(pre==0) pre=1;
            if(suff==0) suff=1;

            pre = pre * nums[i];
            suff=suff * nums[n-1-i];

            ans=Math.Max(ans, Math.Max(pre, suff));
        }

        return ans;
    }
}
