namespace EPI2018.Solutions
{
    public class TreeNode<T>
    {
       public T Data;
       public TreeNode<T> Left;
       public TreeNode<T> Right;

       public TreeNode(T data){
           Data = data;
       }
    }
}
