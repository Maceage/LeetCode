namespace LeetCode.Problems;

public class Dota2SenateProblem
{
    public string PredictPartyVictory(string senate)
    {
        int count = senate.Length;

        Queue<int> radiantQueue = new Queue<int>();
        Queue<int> direQueue = new Queue<int>();

        for (int i = 0; i < senate.Length; i++)
        {
            char charAt = senate[i];

            if (charAt == 'R')
            {
                radiantQueue.Enqueue(i);
            }
            else
            {
                direQueue.Enqueue(i);
            }
        }

        while ((radiantQueue.Count > 0) && (direQueue.Count > 0))
        {
            int radiantTurn = radiantQueue.Dequeue();
            int direTurn = direQueue.Dequeue();

            if (direTurn < radiantTurn)
            {
                direQueue.Enqueue(direTurn + count);
            }
            else
            {
                radiantQueue.Enqueue(radiantTurn + count);
            }
        }

        return radiantQueue.Count == 0 ? "Dire" : "Radiant";
    }
}