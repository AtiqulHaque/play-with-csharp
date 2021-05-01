using System.Collections.Generic;

namespace problem_solving {
    public class LRUCache {

        Dictionary<int, int> hashMap = null;
        List<int> myQueue = null;
        int capacity = 0;

        public LRUCache (int capacity) {
            this.capacity = capacity;
            this.myQueue = new List<int> ();
            this.hashMap = new Dictionary<int, int> ();
        }

        public int Get (int key) {
           this.myQueue.ForEach(i =>  System.Console.WriteLine(i.ToString()));
            if (hashMap.ContainsKey (key)) {
                if (this.myQueue.Contains (key)) {
                    this.myQueue.Remove (key);
                }

                this.myQueue.Add(key);

                return hashMap[key];
            }

            return -1;
        }

        public void Put (int key, int value) {

            if (this.hashMap.Count >= this.capacity) {
                int deleteKey = this.myQueue[0];
                this.hashMap.Remove (deleteKey);
                System.Console.WriteLine(deleteKey);
            }

            
            this.myQueue.Add(key);
            this.hashMap[key] = value;
        }
    }
}