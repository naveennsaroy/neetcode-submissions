public class Solution {
    bool dfs(int node, int[] pathvis, int[] vis, List<int>[] adj){
        vis[node]=1;
        pathvis[node]=1;
        foreach(var it in adj[node]){
            if(vis[it]==0){
                if(dfs(it, pathvis,vis, adj)==false) return false;
            }
            else if(pathvis[it]==1){
                return false;
            }
        }

        pathvis[node]=0;
        return true;
    }
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] adj= new List<int>[numCourses];
        for(int i=0;i<numCourses;i++){
            adj[i] = new List<int>();
        }
        for(int i=0;i<prerequisites.Length;i++){
            adj[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        int[] vis=new int[numCourses];
        int[] pathvis = new int[numCourses];
        Array.Fill(vis, 0);
        Array.Fill(pathvis, 0);
        for(int i=0;i<numCourses;i++){
            if(dfs(i,pathvis,vis,adj)==false) return false;
        }

        return true;
    }
}
