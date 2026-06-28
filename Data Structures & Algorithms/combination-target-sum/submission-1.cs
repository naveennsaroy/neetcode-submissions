public class Solution {

    void solve(int i, int n, int target, List<int>path, int[] nums, List<List<int>> ans){
        if(target==0){
            ans.Add(new List<int>(path));
            return;
        }

        if(i==n) return;

        if(nums[i]<=target){
            path.Add(nums[i]);
            solve(i, n, target-nums[i], path, nums, ans);
            path.Remove(nums[i]);
        }

        solve(i+1, n, target, path, nums, ans);
        return;
    }
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>>ans=new List<List<int>>();
        List<int>path = new List<int>();
        int n=nums.Length;

        solve(0,n,target, path,nums, ans);
        return ans;

    }
}
