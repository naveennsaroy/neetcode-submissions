public class Solution {
    int []delrow={-1,0,+1,0};
    int [] delcol={0,+1,0,-1};
    bool dfs(int r, int c, int k, int n, int m, string word, int [][] vis, char[][] board){
        if(k==word.Length) return true;

        vis[r][c]=1;
        for(int i=0;i<4;i++){
            int nr=r+delrow[i];
            int nc=c+delcol[i];

            if(nr>=0 && nr<n && nc>=0 && nc<m && vis[nr][nc]==0 && board[nr][nc]==word[k]){
                if(dfs(nr,nc,k+1,n,m,word,vis,board)) return true;
            }
        }

        vis[r][c]=0;

        return false;

    }
    public bool Exist(char[][] board, string word) {
        int n=board.Length;
        int m=board[0].Length;

        int[][] vis=new int[n][];
        for(int i=0;i<n;i++){
            vis[i]=new int[m];
        }

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(board[i][j]==word[0]){
                    if(dfs(i,j,1,n,m,word,vis,board)==true) return true;
                }
            }
        }

        return false;
    }
}
