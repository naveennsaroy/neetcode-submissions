public class Solution {
    void dfs(int node, int parent, int[] vis, List<int>[]adj){
        vis[node]=1;

        foreach(var it in adj[node]){
            if(vis[it]==0 && it!= node){
                dfs(it, node, vis, adj);
            }
        }
    }
    public int CountComponents(int n, int[][] edges) {
        List<int>[] adj=new List<int>[n];
        for(int i=0;i<n;i++){
            adj[i]=new List<int>();
        }

        for(int i=0;i<edges.Length;i++){
            adj[edges[i][0]].Add(edges[i][1]);
            adj[edges[i][1]].Add(edges[i][0]);
        }

        int ans=0;
        int[] vis=new int[n];

        for(int i=0;i<n;i++){
            if(vis[i]==0){
                dfs(i, -1, vis, adj);
                ans++;
            }
        }

        return ans;

    }
}
