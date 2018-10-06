using System;
using System.Collections.Generic;
using System.Text;

namespace EPI2018.Solutions
{
    public static class IsTreeABstSolution
    {
        public static bool IsTreeABst(TreeNode<int> root){
            var queue = new Queue<QueueEntry>();
            queue.Enqueue(new QueueEntry(root, int.MinValue, int.MaxValue));

            while(queue.Count > 0){
                var entry = queue.Dequeue();
                if (entry.Node.Data < entry.Lower || entry.Node.Data > entry.Upper){
                    return false;
                }

                if (entry.Node.Left != null){
                    queue.Enqueue(new QueueEntry(entry.Node.Left, entry.Lower, entry.Node.Data));
                }

                if (entry.Node.Right != null){
                    queue.Enqueue(new QueueEntry(entry.Node.Right, entry.Node.Data, entry.Upper));
                }
            }

            return true;
        }
    }

    public class QueueEntry{
        public TreeNode<int> Node;
        public int Upper;
        public int Lower;

        public QueueEntry(TreeNode<int> node, int lower, int upper){
            Node = node;
            Lower = lower;
            Upper = upper;
        }
    }

    
}
