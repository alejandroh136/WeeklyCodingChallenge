namespace Intersection{
    public class Solution<T>{
        //needs a list and a starting node
        public Node<T> CheckIntersection(MyLinkedList<T> alist1, MyLinkedList<T> alist2){
            //get the head from both lists
            Node<T> currentNode = alist1.Head;
            Node<T> otherListNode = alist2.Head;
            for(int alistcount = 0; alistcount < alist1.Count; alistcount++){
                //while list 2 node not null
                while(otherListNode != null){
                    if(currentNode.Equals(otherListNode)){
                        return currentNode;
                    }
                    //next node will be null start over with another node from list 1
                    if(otherListNode.Next == null){
                        otherListNode = alist2.Head;
                        break;
                    }
                    else{
                        otherListNode = otherListNode.Next;
                    }
                }
                if(currentNode.Next == null){
                    //if next node is null then we looped throught all of them
                    return null;
                }
                currentNode = currentNode.Next;
                
            }
            return null;
        }
    }
}