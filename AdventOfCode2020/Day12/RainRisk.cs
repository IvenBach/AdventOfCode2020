﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day12
{
    public class RainRisk
    {
        private readonly IEnumerable<string> Instructions;

        private int FacingDirection = 0;
        private int XAxis = 0;
        private int YAxis = 0;
        private Regex ordinalRegex = new Regex(@"^(N|S|E|W)\d+");
        private Regex turnRegex = new Regex(@"^(L|R)\d+");
        public RainRisk(IEnumerable<string> instructions)
        {
            Instructions = instructions;
        }

        private readonly (int XPosition, int YPosition) WaypointStart;
        public RainRisk(IEnumerable<string> instructions, (int xPosition, int yPosition) waypointStart)
        {
            Instructions = instructions;
            WaypointStart = waypointStart;
        }

        /// <summary>
        /// Calculates the distance traveled by moving relative to the waypount.
        /// </summary>
        /// <returns>Sum of the absolute value of x and y distance from the origin.</returns>
        public int WaypointMoving()
        {
            var waypoint = WaypointStart;

            foreach (var instruction in Instructions)
            {
                var firstChar = Convert.ToChar(instruction.Substring(0, 1));

                if (ordinalRegex.IsMatch(instruction))
                {
                    if (firstChar == 'N' || firstChar == 'S')
                    {
                        waypoint.YPosition += YAxisMovement(instruction);
                    }
                    else
                    {
                        waypoint.XPosition += XAxisMovement(instruction);
                    }

                    continue;
                }

                if (turnRegex.IsMatch(instruction))
                {
                    waypoint = RotateWaypoint(instruction, waypoint);

                    continue;
                }

                var distance = int.Parse(instruction.Remove(0, 1));
                XAxis += waypoint.XPosition * distance;
                YAxis += waypoint.YPosition * distance;
            }

            return Math.Abs(XAxis) + Math.Abs(YAxis);
        }

        private (int XPosition, int YPosition) RotateWaypoint(string instruction, (int x, int y) waypoint)
        {
            if (instruction == "L90" || instruction == "R270")
            {
                return (-1 * waypoint.y, waypoint.x);
            }
            else if (instruction == "L270" || instruction == "R90")
            {
                return (waypoint.y, -1 * waypoint.x);
            }

            return (waypoint.x * -1, waypoint.y * -1);
        }

        /// <summary>
        /// Calculates the distance from the origin by summing absolute difference of x and y from the origin.
        /// </summary>
        /// <returns>Sum of the absolute value of x and y distance from the origin.</returns>
        public int RectilinearDestance()
        {
            foreach (var instruction in Instructions)
            {
                var firstChar = Convert.ToChar(instruction.Substring(0, 1));
                
                if (ordinalRegex.IsMatch(instruction))
                {
                    if (firstChar == 'N' || firstChar == 'S')
                    {
                        YAxis += YAxisMovement(instruction);
                    }
                    else
                    {
                        XAxis += XAxisMovement(instruction);
                    }

                    continue;
                }

                if (turnRegex.IsMatch(instruction))
                {
                    FacingDirection = (FacingDirection + RotationMovement(instruction) + 360) % 360;
                    continue;
                }

                ForwardMovement(instruction);
            }

            return Math.Abs(XAxis) + Math.Abs(YAxis);
        }

        /// <summary>
        /// Updates the <see cref="XAxis"/> or <see cref="YAxis"/> value based on the current value of <see cref="FacingDirection"/>.
        /// </summary>
        /// <param name="instruction">Instruction for forward movement.</param>
        private void ForwardMovement(string instruction)
        {
            var distance = int.Parse(instruction.Substring(1));
            switch (FacingDirection)
            {
                case 0:
                    XAxis += distance;
                    break;
                case 90:
                    YAxis += distance;
                    break;
                case 180:
                    XAxis -= distance;
                    break;
                case 270:
                    YAxis -= distance;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// Rotates the ship according to the given instruction.
        /// </summary>
        /// <param name="instruction">Instruction for rocation.</param>
        /// <returns>Positive value for left rotations, negative value for right rotations.</returns>
        private int RotationMovement(string instruction)
        {
            var degrees = int.Parse(instruction.Substring(1));
            if (instruction.StartsWith("L"))
            {
                return int.Parse(instruction.Substring(1));
            }
            else
            {
                return -1 * int.Parse(instruction.Substring(1));
            }
        }

        /// <summary>
        /// Changes the instruction to <see cref="YAxis"/> distance.
        /// </summary>
        /// <param name="instruction">Instruction for movement.</param>
        /// <returns>Positive value for north movement, negative value for south movement.</returns>
        private int YAxisMovement(string instruction)
        {
            var distance = int.Parse(instruction.Substring(1));
            var direction = instruction.StartsWith("N")
                ? 1
                : -1;

            return direction * distance;
        }

        /// <summary>
        /// Changes the instruction to <see cref="XAxis"/> distance.
        /// </summary>
        /// <param name="instruction">Instruction for movement.</param>
        /// <returns>Positive value for east movement, negative value for west movement.</returns>
        private int XAxisMovement(string instruction)
        {
            var distance = int.Parse(instruction.Substring(1));
            var direction = instruction.StartsWith("E")
                ? 1
                : -1;

            return direction * distance;
        }
    }

    enum OridinalDirection
    {
        North,
        South,
        East,
        West
    }
}
