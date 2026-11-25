public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int,int>();

        foreach (int stone in stones) {
            maxHeap.Enqueue(stone, -stone);
        }

        while (maxHeap.Count > 1) {
            int first = maxHeap.Dequeue();
            int second = maxHeap.Dequeue();
            
            if (first != second) {
                int diff = first - second;
                maxHeap.Enqueue(diff, -diff);
            }
        }

        return maxHeap.Count == 1 ? maxHeap.Peek() : 0;
    }
}
