class Solution {
public:
int delrow[4]={-1,0,+1,0};
int delcol[4]={0,+1,0,-1};
void dfs(int r, int c, int n, int m, vector<vector<int>>&vis, vector<vector<char>>&grid){
    vis[r][c]=1;
    for(int i=0;i<4;i++){
        int nr=r+delrow[i];
        int nc=c+delcol[i];

        if(nr>=0 && nr<n && nc>=0 && nc<m && !vis[nr][nc] && grid[nr][nc]=='1'){
            // vis[nr][nc]=1;
            dfs(nr,nc,n,m,vis,grid);
        }
    }
}
    int numIslands(vector<vector<char>>& grid) {
        int n=grid.size();
        int m=grid[0].size();
        int count=0;

        vector<vector<int>>vis(n, vector<int>(m,0));
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]=='1' && !vis[i][j]){
                    count++;
                    dfs(i,j,n,m,vis,grid);
                }
            }
        }

        return count;
    }
};
