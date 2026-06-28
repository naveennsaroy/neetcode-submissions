class Solution {
public:
int solve(int low, int high, int target, vector<int>&arr){
    while(low<=high){
        int mid=low+(high-low)/2;
        cout<<mid<<endl;
        if(arr[mid]==target){
            return mid;
        }
        else if(arr[low]<=arr[mid]){
            if(arr[low]<=target && target<=arr[mid]){
                high=mid-1;
            }
            else{
                low=mid+1;
            }
        }
        else{
            if(arr[mid]<=target && target<=arr[high]){
                low=mid+1;
            }
            else{
                high=mid-1;
            }
        }
    }

    return -1;
}
    int search(vector<int>& nums, int target) {
        int n=nums.size();
       return solve(0,n-1,target, nums); 
    }
};
