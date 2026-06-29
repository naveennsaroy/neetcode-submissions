public class Solution {
    bool dfs(int node, int parent, int[] vis, List<int>[] adj){
        if(vis[node]==1) return false;

        vis[node]=1;
        foreach(var it in adj[node]){
            if(it != parent){
                if(dfs(it, node, vis, adj)==false) return false;
            }
        }

        return true;
    }
    public bool ValidTree(int n, int[][] edges) {
        List<int>[] adj=new List<int>[n];
        for(int i=0;i<n;i++){
            adj[i]=new List<int>();
        }
        for(int i=0;i<edges.Length;i++){
            adj[edges[i][0]].Add(edges[i][1]);
            adj[edges[i][1]].Add(edges[i][0]);
        }

        int[] vis=new int[n];

        if(!dfs(0,-1,vis,adj)) return false;

        for(int i=0;i<n;i++){
            if(vis[i]==0) return false;
        }

        return true;
    }
}
