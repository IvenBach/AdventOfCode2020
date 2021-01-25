using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day17
{
    public class ConwayCube
    {
        private readonly HashSet<Point3D> InitiallyActiveCubes = new HashSet<Point3D>();
        private (int Rows, int Columns) PlaneDimensions = (0, 0);

        public ConwayCube(char[,] initialState)
        {
            InitiallyActiveCubes = ActiveCubesFromPlane(initialState);
            PlaneDimensions = (initialState.GetUpperBound(0) + 1, initialState.GetUpperBound(1) + 1);
        }

        public static int ActiveCubes(Dictionary<int, char[,]> state)
        {
            var count = 0;
            foreach (var kvp in state)
            {
                foreach (var value in kvp.Value)
                {
                    if (value == '#')
                    {
                        count++;
                    }
                }

            }

            return count;
        }

        private HashSet<Point3D> ActiveCubesFromPlane(char[,] plane)
        {
            var hash = new HashSet<Point3D>();

            for (int row = 0; row <= plane.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= plane.GetUpperBound(1); column++)
                {
                    if (plane[row, column] == '#')
                    {
                        hash.Add(new Point3D(row, column, 0));
                    }
                }
            }

            return hash;
        }

        public Dictionary<int, char[,]> ProcessCycles(int cycles)
        {
            var currentActiveCubes = InitiallyActiveCubes;
            var processed = 0;
            while (processed < cycles)
            {
                var toUpdate = UpdateCubes(currentActiveCubes);
                var nextActiveCubes = new HashSet<Point3D>();
                foreach (var point in toUpdate)
                {
                    var activeNeighbors = ActiveNeighbors(point, currentActiveCubes);
                    if (currentActiveCubes.Contains(point))
                    {
                        if (activeNeighbors == 2 || activeNeighbors == 3)
                        {
                            nextActiveCubes.Add(point.NextCyclePoints());
                        }
                    }
                    else
                    {
                        if (activeNeighbors == 3)
                        {
                            nextActiveCubes.Add(point.NextCyclePoints());
                        }
                    }
                }

                currentActiveCubes = nextActiveCubes;
                processed++;
            }

            return ConvertToMap(currentActiveCubes,
                PlaneDimensions.Columns + 2 * cycles,
                PlaneDimensions.Rows + 2 * cycles);
        }

        private Dictionary<int, char[,]> ConvertToMap(HashSet<Point3D> activePoints, int rows, int columns)
        {
            var retVal = new Dictionary<int, char[,]>();

            foreach (var point in activePoints)
            {
                if (!retVal.ContainsKey(point.PlaneElevation))
                {
                    retVal.Add(point.PlaneElevation, NewMap());
                }

                retVal[point.PlaneElevation][point.Row, point.Column] = '#';
            }

            return retVal;

            char[,] NewMap()
            {
                var map = new char[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        map[row, column] = '.';
                    }
                }

                return map;
            }
        }

        /// <summary>
        /// Count of the neighboring points that are active.
        /// </summary>
        /// <param name="neighbors"></param>
        /// <param name="activeCubes"></param>
        /// <returns></returns>
        private int ActiveNeighbors(Point3D point, HashSet<Point3D> activeCubes)
        {
            var neighbors = NeighborsOf(point);
            var count = 0;
            foreach (var neighbor in neighbors)
            {
                if (activeCubes.Contains(neighbor))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Returns the 8 points on the XY-plane which surround the provided <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point">Point which the other 8 points enclose.</param>
        /// <returns>Collection with the enclosing points.</returns>
        private ICollection<Point3D> XYPlanarNeighborsOf(Point3D point)
        {
            var neighbors = new List<Point3D>(8)
            {
                new Point3D(point.Row - 1, point.Column + 1, point.PlaneElevation),
                new Point3D(point.Row, point.Column + 1, point.PlaneElevation),
                new Point3D(point.Row + 1, point.Column + 1, point.PlaneElevation),

                new Point3D(point.Row - 1, point.Column, point.PlaneElevation),
                new Point3D(point.Row + 1, point.Column, point.PlaneElevation),

                new Point3D(point.Row - 1, point.Column - 1, point.PlaneElevation),
                new Point3D(point.Row, point.Column - 1, point.PlaneElevation),
                new Point3D(point.Row + 1, point.Column - 1, point.PlaneElevation),
            };

            return neighbors;
        }

        /// <summary>
        /// Returns the 9 points, on the XY-plane, above/below the provided <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point">Point</param>
        /// <param name="isAbove">Determines whether the returned values are those above or below the point.</param>
        /// <returns>Collection of points on the XY-plane above/below the referenced point.</returns>
        private ICollection<Point3D> XYNonPlanarNeighborsOf(Point3D point, bool isAbove)
        {
            var zMod = isAbove ? 1 : -1;
            var z = point.PlaneElevation + zMod;

            var neighbors = new List<Point3D>(8)
            {
                new Point3D(point.Row - 1, point.Column + 1, z),
                new Point3D(point.Row, point.Column + 1, z),
                new Point3D(point.Row + 1, point.Column + 1, z),

                new Point3D(point.Row - 1, point.Column, z),
                new Point3D(point.Row, point.Column, z),
                new Point3D(point.Row + 1, point.Column, z),

                new Point3D(point.Row - 1, point.Column - 1, z),
                new Point3D(point.Row, point.Column - 1, z),
                new Point3D(point.Row + 1, point.Column - 1, z),
            };

            return neighbors;
        }

        /// <summary>
        /// Returns the 26 points that are adjacent (distance of 1 away in the X, Y, and Z directions)
        /// to the referenced point. The argument point is not included
        /// as part of the returned collection.
        /// </summary>
        /// <param name="point">Center around which all the points reside.</param>
        /// <returns>Collection of points immediately surrounding the referenced point.</returns>
        private ICollection<Point3D> NeighborsOf(Point3D point)
        {
            var neighbors = new List<Point3D>(26);
            neighbors.AddRange(XYNonPlanarNeighborsOf(point, true));
            neighbors.AddRange(XYPlanarNeighborsOf(point));
            neighbors.AddRange(XYNonPlanarNeighborsOf(point, false));

            return neighbors;
        }

        /// <summary>
        /// Returns new collection of points for all active cubes and their neighbors.
        /// </summary>
        /// <param name="activeCubes">A collection containing the points of active cubes in the current cycle.</param>
        /// <returns>Collection of all points to check for activation/inactivation.</returns>
        private ICollection<Point3D> UpdateCubes(IEnumerable<Point3D> activeCubes)
        {
            var updates = new HashSet<Point3D>(activeCubes);

            foreach (var activeCube in activeCubes)
            {
                var neighbors = NeighborsOf(activeCube);

                foreach (var cube in neighbors)
                {
                    if (!updates.Contains(cube))
                    {
                        updates.Add(cube);
                    }
                }
            }

            return updates;
        }
    }
}
