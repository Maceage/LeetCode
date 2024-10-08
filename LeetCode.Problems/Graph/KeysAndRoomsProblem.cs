namespace LeetCode.Problems.Graph;

public class KeysAndRoomsProblem
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        bool canVisitAllRooms = true;
        bool[] seenRooms = new bool[rooms.Count];

        seenRooms[0] = true;

        Stack<int> keyStack = new Stack<int>();

        keyStack.Push(0);

        while (keyStack.Count > 0)
        {
            int keyNode = keyStack.Pop();

            foreach (int i in rooms[keyNode])
            {
                if (!seenRooms[i])
                {
                    seenRooms[i] = true;

                    keyStack.Push(i);
                }
            }
        }

        foreach (bool room in seenRooms)
        {
            if (!room)
            {
                canVisitAllRooms = false;
            }
        }

        return canVisitAllRooms;
    }
}