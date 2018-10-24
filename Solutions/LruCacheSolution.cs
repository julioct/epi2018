using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public class LruCacheSolution
    {
        private readonly int CacheSize;
        private readonly Dictionary<int, LinkedListNode> map;
        private LinkedListNode head; 
        private LinkedListNode tail;

        public LruCacheSolution(int size){
            CacheSize = size;
            map = new Dictionary<int, LinkedListNode>();
        }

        public bool Erase(int isbn){
            if (map.ContainsKey(isbn)){
                RemoveNode(map[isbn]);
                map.Remove(isbn);
                return true;
            }

            return false;
        }

        public int LookUp(int isbn){
            if (map.ContainsKey(isbn)){
                RemoveNode(map[isbn]);
                InsertNode(map[isbn]);
                return map[isbn].Price;
            } else {
                return -1;
            }
        }

        public void Insert(int isbn, int price){
            Erase(isbn);

            if (map.Count == CacheSize && tail != null){
                Erase(tail.Isbn);
            }

            var node = new LinkedListNode(isbn, price);
            map.Add(isbn, node);
            InsertNode(node);
        }

        private void InsertNode(LinkedListNode node){
            if (head == null){
                head = node;
                tail = node;
            } else {
                node.Next = head;
                head.Previous = node;
                head = node;
            }
        }        

        private void RemoveNode(LinkedListNode node){
            if (node.Previous != null){
                node.Previous.Next = node.Next;
            }
            if (node.Next != null){                
                node.Next.Previous = node.Previous;
            } 
            if (node == head) {
                head = node.Next;
            }            
            if (node == tail) {
                tail = node.Previous;
            }
        }

        public class LinkedListNode
        {
            public int Isbn;
            public int Price;
            public LinkedListNode Next;
            public LinkedListNode Previous;

            public LinkedListNode(int isbn, int price){
                Isbn = isbn;
                Price = price;
            }
        }        
    }    
}
