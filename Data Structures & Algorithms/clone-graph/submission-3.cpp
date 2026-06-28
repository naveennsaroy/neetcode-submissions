/*
// Definition for a Node.
class Node {
public:
    int val;
    vector<Node*> neighbors;
    Node() {
        val = 0;
        neighbors = vector<Node*>();
    }
    Node(int _val) {
        val = _val;
        neighbors = vector<Node*>();
    }
    Node(int _val, vector<Node*> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
};
*/

class Solution {
public:

Node* dfs(Node* currnode, map<Node*, Node*> &mp){
    if(currnode==NULL) return NULL;

    if(mp.find(currnode)!=mp.end()) return mp[currnode];

    Node* newnode=new Node(currnode->val);
    mp[currnode]=newnode;

    for(auto it: currnode->neighbors){
        newnode->neighbors.push_back(dfs(it, mp));
    }

    return newnode;
}
    Node* cloneGraph(Node* node) {
        map<Node*, Node*>mp;
        if(node==NULL) return NULL;

        Node* newnode=new Node(node->val);
        mp[node]=newnode;
        queue<Node*>q;
        q.push(node);
        while(!q.empty()){
            Node *currnode=q.front();
            q.pop();

            for(auto it:currnode->neighbors){
                if(mp.find(it)==mp.end()){
                    mp[it]=new Node(it->val);
                    q.push(it);
                }

                mp[currnode]->neighbors.push_back(mp[it]);
            }
        }

        return mp[node];
    }
};
