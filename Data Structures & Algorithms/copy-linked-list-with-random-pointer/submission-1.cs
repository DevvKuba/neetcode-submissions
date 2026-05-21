/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> valuesDict = new Dictionary<Node, Node>();

        var temp = head;
        while(temp != null){
            Node copy = new Node(temp.val);
            valuesDict[temp] = copy;
            temp = temp.next;
        }

        temp = head;
        while(temp != null){
            Node copy = valuesDict[temp];
            // need to set pointers
            copy.next = temp.next != null ? valuesDict[temp.next] : null;
            copy.random = temp.random != null ? valuesDict[temp.random]: null;
            temp = temp.next;
        }

        return head != null ? valuesDict[head]: null;
    }
}
