namespace LeetCode.Problems.Graph;

/// <summary>
/// https://leetcode.com/problems/evaluate-division
/// </summary>
public class EvaluateDivisionProblem
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        Dictionary<string, Dictionary<string, double>> graph = new();

        for (int i = 0; i < equations.Count; i++)
        {
            IList<string> equation = equations[i];

            string dividend = equation[0];
            string divisor = equation[1];

            double quotient = values[i];

            if (!graph.ContainsKey(dividend))
            {
                graph.Add(dividend, new Dictionary<string, double>());
            }

            if (!graph.ContainsKey(divisor))
            {
                graph.Add(divisor, new Dictionary<string, double>());
            }

            graph[dividend].Add(divisor, quotient);
            graph[divisor].Add(dividend, 1 / quotient);
        }

        double[] results = new double[queries.Count];

        for (int i = 0; i < queries.Count; i++)
        {
            IList<string> query = queries[i];

            string dividend = query[0];
            string divisor = query[1];

            if (!graph.ContainsKey(dividend) || !graph.ContainsKey(divisor))
            {
                results[i] = -1.0;
            }
            else if (dividend == divisor)
            {
                results[i] = 1.0;
            }
            else
            {
                HashSet<string> visited = new HashSet<string>();
                results[i] = BacktrackEvaluate(graph, dividend, divisor, 1, visited);
            }
        }

        return results;
    }

    private static double BacktrackEvaluate(Dictionary<string, Dictionary<string, double>> graph, string currentNode, string targetNode, double accProduct, HashSet<string> visited)
    {
        visited.Add(currentNode);

        double result = -1.0;

        Dictionary<string, double> neighbours = graph[currentNode];

        if (neighbours.TryGetValue(targetNode, out var neighbour))
        {
            result = accProduct * neighbour;
        }
        else
        {
            foreach (var (nextNode, value) in neighbours)
            {
                if (visited.Contains(nextNode))
                {
                    continue;
                }

                result = BacktrackEvaluate(graph, nextNode, targetNode, accProduct * value, visited);

                if (result != -1.0)
                {
                    break;
                }
            }
        }

        visited.Remove(currentNode);

        return result;
    }
}