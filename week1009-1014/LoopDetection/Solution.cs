namespace LoopDetection{
    public class Solution<T>{
        //needs a list and a starting node
        public Node<T> Beginning(MyLinkedList<T> alist, Node<T> aNode){
            List<Node<T>> list = new List<Node<T>>();
            Node<T> currentNode = aNode;
            //run until we went around once i.e. we met count since the last element 
            //points to a previous element
            for(int alistcount = 0; alistcount <= alist.Count; alistcount++){
                list.Add(currentNode);
                for(int j = 0; j < list.Count && currentNode.Next != null; j++){
                    if(currentNode.Next.Equals(list[j])){
                        return currentNode;
                    }
                }
                if(currentNode.Next == null){
                    return null;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }
    }
}