class Solution {
public:
void solve(int i, int n, int target, vector<int>&path, vector<int>&nums, vector<vector<int>>&ans){
    if(target==0){
        ans.push_back(path);
        return;
    }

    if(i==n) return;

    if(nums[i]<=target){
        path.push_back(nums[i]);
        solve(i, n, target-nums[i], path, nums, ans);
        path.pop_back();
    }

    solve(i+1, n, target, path, nums, ans);
    return;
}
    vector<vector<int>> combinationSum(vector<int>& nums, int target) {
        vector<vector<int>>ans;
        vector<int>path;
        int n=nums.size();
        solve(0, n, target, path, nums, ans);
        return ans;
    }
};
