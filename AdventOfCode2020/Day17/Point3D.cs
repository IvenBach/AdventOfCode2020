using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdventOfCode2020.Day17
{
    [DebuggerDisplay("{Row}, {Column}, {PlaneElevation}")]
    public struct Point3D
    {
        public int Row { get; }
        public int Column { get; }
        public int PlaneElevation { get; }

        public Point3D(int row, int column, int PlaneElevation)
        {
            Row = row;
            Column = column;
            this.PlaneElevation = PlaneElevation;
        }

        public Point3D NextCyclePoints()
        {
            return new Point3D(Row + 1, Column + 1, PlaneElevation);
        }
    }
}
