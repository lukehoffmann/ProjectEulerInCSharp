using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class BoxTraverser
    {
        private readonly int size;
        private int threads = 4;

        public BoxTraverser(int size)
        {
            this.size = size;
        }

        public long CountRoutesRecursive(int x = 1, int y = 0)
        {
            // The board is symetrical, so we can cheat by starting at x = 1 and
            // doubling the result

            if (x >= size)
            {
                // Have we completed a route?
                if (y >= size)
                    return 2;

                // Otherwise expand the search down
                return CountRoutesRecursive(x, y + 1);
            }

            // Expand the search right
            if (y >= size)
                return CountRoutesRecursive(x + 1, y);

            // Expand the search right and down
            return CountRoutesRecursive(x + 1, y) + CountRoutesRecursive(x, y + 1);
        }

        // Starting in the top left corner of a 2×2 grid, and only being able to move
        // to the right and down, there are exactly 6 routes to the bottom right corner.
        public long CountRoutesDepthFirst()
        {
            long count = 0;
            var stack = new Stack<Route>();

            // we only need to count routes that start by moving right (and then double it)
            var route = new Route();
            route.MoveRight();
            stack.Push(route);

            Route route1, route2;
            do
            {
                route1 = stack.Pop();

                while (true)
                {
                    // Are we already out of bounds?
                    if (route1.RightCount > size || route1.DownCount > size)
                    {
                        break;
                    }

                    // Do we have completed a route?
                    if (route1.RightCount == size && route1.DownCount == size)
                    {
                        ++count;
                        break;
                    }

                    // Add a copy with the next move Down
                    route2 = Route.Copy(route1);
                    route2.MoveDown();
                    stack.Push(route2);

                    // Meanwhile, make our move Right
                    route1.MoveRight();
                    // Console.WriteLine(stack.Count);
                }
            } while (stack.Any());

            return count * 2;
        }

        private class Route
        {
            public enum Direction { Right, Down }

            public int DownCount { get; private set; } = 0;
            public int RightCount { get; private set; } = 0;

            public void MoveDown()
            {
                ++DownCount;
            }

            public void MoveRight()
            {
                ++RightCount;
            }

            public static Route Copy(Route route)
            {
                return new Route
                {
                    DownCount = route.DownCount,
                    RightCount = route.RightCount
                };
            }
        }
    }
}
