public class Solution {
    public int[] delrow={-1,0,+1,0};
    public int[] delcol={0,+1,0,-1};
    bool bfs(int r, int c, int n, int m, int [,] vis, int[][]heights){
        Queue<(int, int)>q = new Queue<(int,int)>();
        q.Enqueue((r,c));

        bool t1=false,t2=false;

        while(q.Count!=0){
            var p = q.Peek();
            int row=p.Item1;
            int col=p.Item2;
            q.Dequeue();

            vis[row,col]=1;

            for(int i=0;i<4;i++){
                int nrow=row+delrow[i];
                int ncol=col+delcol[i];

                if(t1 && t2) return true;

                if(nrow<0 || ncol<0){
                    t1=true;
                    continue;
                }
                
                if(nrow==n || ncol==m){
                    t2=true;
                    continue;
                }

                if(nrow>=0 && nrow<n && ncol>=0 && ncol< m && vis[nrow,ncol] == 0 && heights[nrow][ncol]<=heights[row][col]){
                    q.Enqueue((nrow, ncol));
                    vis[nrow, ncol]=1;
                }
            }
        }

        return t1 && t2;

    }
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int n = heights.Length;
        int m = heights[0].Length;
        int[,] vis=new int[n,m];

        List<List<int>> ans = new List<List<int>>();
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                vis=new int[n,m];
                if(bfs(i,j,n,m,vis,heights)){
                   ans.Add(new List<int> { i, j });
                }
            }
        }

        return ans;


    }
}
