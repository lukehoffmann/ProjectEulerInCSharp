using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class BoxTraverser
    {
        private int size;

        public BoxTraverser(int size)
        {
            this.size = size;
        }

        public int CountRoutesRecursive(int x = 0, int y = 0)
        {
            // Are we already out of bounds?
            if (x > size || y > size)
                return 0;

            // Have we completed a route?
            if (x == size && y == size)
                return 1;

            // Otherwise expand the search in both directions
            return CountRoutesRecursive(x + 1, y) + CountRoutesRecursive(x, y + 1);
        }

        // Starting in the top left corner of a 2×2 grid, and only being able to move
        // to the right and down, there are exactly 6 routes to the bottom right corner.
        public int CountRoutes()
        {
            // only count routes that stay within the square
            return AllRoutes().Count();
        }

        private List<Route> AllRoutes()
        {
            var lengthOfRoute = size * 2;
            var routes = new List<Route>{ new Route(lengthOfRoute) };

            // At each position, duplicate the route with the two options
            for (int i = 0; i < lengthOfRoute; i++)
            {
                var currentCount = routes.Count;
                for (int j = 0; j < currentCount; j++)
                {
                    if (routes[j].DownMoves < size)
                    {
                        var copy = Route.Copy(routes[j]);
                        copy.MoveDown(i);
                        routes.Add(copy);
                    }
                }
            }
            return routes.Where(r => r.DownMoves == size).ToList();
        }

        private class Route
        {
            public enum Direction { Right, Down }

            private readonly Direction[] moves;

            public Route(int length)
            {
                if (!length.IsMultipleOf(2))
                    throw new ArgumentException();

                this.moves = new Direction[length];
                for (int i = 0; i < length; i++)
                    this.moves[i] = Direction.Right;
            }

            public static Route Copy(Route route)
            {
                var copy = new Route(route.moves.Length);
                route.moves.CopyTo(copy.moves, 0);
                copy.DownMoves = route.DownMoves;
                return copy;
            }

            public Direction MoveAtPosition(int position) => moves[position];

            public void MoveDown(int position)
            {
                moves[position] = Direction.Down;
                ++DownMoves;
            }

            public int DownMoves { get; private set; } = 0;
        }

    }
}
