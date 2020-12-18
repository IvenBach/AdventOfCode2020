using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day11
{
    public class SeatingSystem
    {
        private readonly char[,] Inputs;
        private readonly char EmptySeat;
        private readonly char OccupiedSeat;
        private readonly char Floor;
        private const int AdjacentSeatLimit = 3;
        public SeatingSystem(char[,] inputs, char emptySeat = 'L', char occupiedSeat = '#', char floor = '.')
        {
            Inputs = inputs;
            EmptySeat = emptySeat;
            OccupiedSeat = occupiedSeat;
            Floor = floor;
        }

        /// <summary>
        /// Returns the total of all occupied seats as passengers fill in the empty seats and
        /// vacate seats that are too crowded until a balance is achieved.
        /// </summary>
        /// <returns>Total seats occupied</returns>
        public int OccupiedSeats()
        {
            var currentSeating = Inputs;
            int changeInSeats = 1;
            bool[,] needsUpdating;

            while (changeInSeats != 0)
            {
                (changeInSeats, needsUpdating) = SeatsToChange(currentSeating);
                UpdateSeating(currentSeating, needsUpdating);
            }

            int occupiedSeats = 0;
            foreach (var seat in currentSeating)
            {
                if (seat == OccupiedSeat)
                {
                    occupiedSeats++;
                }
            }

            return occupiedSeats;
        }

        private (int SeatsChanged, bool[,] NeedsUpdating) SeatsToChange(char[,] currentSeating)
        {
            bool[,] updates = new bool[Inputs.GetUpperBound(0) + 1, Inputs.GetUpperBound(1) + 1];
            int seatsChanged = UpdateCorners(currentSeating, updates);
            seatsChanged += UpdateNonCornerPerimeter(currentSeating, updates);
            seatsChanged += UpdateInterior(currentSeating, updates);
            // If a seat is empty(L) and there are no occupied seats adjacent to it, the seat becomes occupied.
            //If a seat is occupied(#) and four or more seats adjacent to it are also occupied, the seat becomes empty.
            // Otherwise, the seat's state does not change.

            return (seatsChanged, updates);
        }

        /// <summary>
        /// Checks each corner and updates the updatedSeating argument as needed.
        /// </summary>
        /// <param name="currentSeating">Current seating before any changes occur</param>
        /// <param name="updatedSeating">Updates where seating change will occur</param>
        /// <returns>Count of seats occupancy change</returns>
        private int UpdateCorners(char[,] currentSeating, bool[,] updatedSeating)
        {
            int seatsChanged = 0;
            int lastRow = currentSeating.GetUpperBound(0);
            int lastColumn = currentSeating.GetUpperBound(1);
            //Top Left
            if (currentSeating[0, 0] == EmptySeat && currentSeating[0, 1] != OccupiedSeat
                && currentSeating[1, 0] != OccupiedSeat && currentSeating[1, 1] != OccupiedSeat)
            {
                updatedSeating[0, 0] = true;
                seatsChanged++;
            }

            //TopRight
            if (currentSeating[0, lastColumn] == EmptySeat && currentSeating[0, lastColumn - 1] != OccupiedSeat
                && currentSeating[1, 0] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
            {
                updatedSeating[0, lastColumn] = true;
                seatsChanged++;
            }

            //Bottom Left
            if (currentSeating[lastRow, 0] == EmptySeat && currentSeating[lastRow, 1] != OccupiedSeat
                && currentSeating[lastRow - 1, 0] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
            {
                updatedSeating[lastRow, 0] = true;
                seatsChanged++;
            }

            //Bottom Right
            if (currentSeating[lastRow, lastColumn] == EmptySeat && currentSeating[lastRow, lastColumn - 1] != OccupiedSeat
                && currentSeating[lastRow - 1, lastColumn] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
            {
                updatedSeating[lastRow, lastColumn] = true;
                seatsChanged++;
            }

            return seatsChanged;
        }

        /// <summary>
        /// Checks each non-corner perimeter edges and updates the updatedSeating argument as needed.
        /// </summary>
        /// <param name="currentSeating">Current seating before any changes occur</param>
        /// <param name="updatedSeating">Updates where seating change will occur</param>
        /// <returns>Count of seats occupancy change</returns>
        private int UpdateNonCornerPerimeter(char[,] currentSeating, bool[,] updatedSeating)
        {
            int seatsChanged = 0;
            int lastRow = currentSeating.GetUpperBound(0);
            int lastColumn = currentSeating.GetUpperBound(1);

            //Top Row
            for (int i = 1; i < lastColumn; i++)
            {
                if (currentSeating[0, i] == EmptySeat && AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.TopRow))
                {
                    updatedSeating[0, i] = true;
                    seatsChanged++;
                }
                else if (currentSeating[0, i] == OccupiedSeat && AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.TopRow) > AdjacentSeatLimit)
                {
                    updatedSeating[0, i] = true;
                    seatsChanged--;

                }
            }

            //Left Column
            for (int i = 1; i < lastRow; i++)
            {
                if (currentSeating[i, 0] == EmptySeat && AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.LeftColumn))
                {
                    updatedSeating[i, 0] = true;
                    seatsChanged++;
                }
                else if (currentSeating[i, 0] == OccupiedSeat && AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.LeftColumn) > AdjacentSeatLimit)
                {
                    updatedSeating[i, 0] = true;
                    seatsChanged--;
                }
            }

            //Right Column
            for (int i = 1; i < lastRow; i++)
            {
                if (currentSeating[i, lastColumn] == EmptySeat && AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.RightColumn))
                {
                    updatedSeating[i, lastColumn] = true;
                    seatsChanged++;
                }
                else if (currentSeating[i, lastColumn] == OccupiedSeat && AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.RightColumn) > AdjacentSeatLimit)
                {
                    updatedSeating[i, lastColumn] = true;
                    seatsChanged++;
                }
            }

            //Bottom Row
            for (int i = 1; i < lastColumn; i++)
            {
                if (currentSeating[lastRow, i] == EmptySeat && AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.BottomRow))
                {
                    updatedSeating[lastRow, i] = true;
                    seatsChanged++;
                }
                else if (currentSeating[lastRow, i] == OccupiedSeat && AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.BottomRow) > AdjacentSeatLimit)
                {
                    updatedSeating[lastRow, i] = true;
                    seatsChanged--;
                }
            }

            return seatsChanged;            
        }

        private bool AllAdjacentSeatsUnoccupied(char[,] currentSeating, int index, PerimeterLocation location)
        {
            switch (location)
            {
                case PerimeterLocation.TopRow:
                    return currentSeating[0, index - 1] != OccupiedSeat
                        && currentSeating[0, index + 1] != OccupiedSeat
                        && currentSeating[1, index - 1] != OccupiedSeat
                        && currentSeating[1, index] != OccupiedSeat
                        && currentSeating[1, index + 1] != OccupiedSeat;
                case PerimeterLocation.LeftColumn:
                    return currentSeating[index - 1, 0] != OccupiedSeat
                        && currentSeating[index + 1, 0] != OccupiedSeat
                        && currentSeating[index - 1, 1] != OccupiedSeat
                        && currentSeating[index, 1] != OccupiedSeat
                        && currentSeating[index + 1, 1] != OccupiedSeat;
                case PerimeterLocation.RightColumn:
                    int lastColumn = currentSeating.GetUpperBound(1);
                    return currentSeating[index - 1, lastColumn] != OccupiedSeat
                        && currentSeating[index + 1, lastColumn] != OccupiedSeat
                        && currentSeating[index - 1, lastColumn - 1] != OccupiedSeat
                        && currentSeating[index, lastColumn - 1] != OccupiedSeat
                        && currentSeating[index + 1, lastColumn - 1] != OccupiedSeat;
                case PerimeterLocation.BottomRow:
                    int lastRow = currentSeating.GetUpperBound(0);
                    return currentSeating[lastRow, index - 1] != OccupiedSeat
                        && currentSeating[lastRow, index + 1] != OccupiedSeat
                        && currentSeating[lastRow - 1, index - 1] != OccupiedSeat
                        && currentSeating[lastRow - 1, index] != OccupiedSeat
                        && currentSeating[lastRow - 1, index + 1] != OccupiedSeat;
                default:
                    throw new ArgumentException();
            }
        }

        private int AdjacentOccupiedSeats(char[,] currentSeating, int index, PerimeterLocation location)
        {
            var occupancy = 0;
            switch (location)
            {
                case PerimeterLocation.TopRow:
                    occupancy += currentSeating[0, index - 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[0, index + 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[1, index - 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[1, index] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[1, index + 1] == OccupiedSeat ? 1 : 0;
                    break;
                case PerimeterLocation.LeftColumn:
                    occupancy += currentSeating[index - 1, 0] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index + 1, 0] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index - 1, 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index, 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index + 1, 1] == OccupiedSeat ? 1 : 0;
                    break;
                case PerimeterLocation.RightColumn:
                    int lastCol = currentSeating.GetUpperBound(1);
                    occupancy += currentSeating[index - 1, lastCol] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index + 1, lastCol] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index - 1, lastCol - 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index, lastCol] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[index + 1, lastCol - 1] == OccupiedSeat ? 1 : 0;
                    break;
                case PerimeterLocation.BottomRow:
                    int lastRow = currentSeating.GetUpperBound(0);
                    occupancy += currentSeating[lastRow, index - 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[lastRow, index + 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[lastRow - 1, index - 1] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[lastRow - 1, index] == OccupiedSeat ? 1 : 0;
                    occupancy += currentSeating[lastRow - 1, index + 1] == OccupiedSeat ? 1 : 0;
                    break;
                default:
                    throw new ArgumentException();
            }

            return occupancy;
        }

        private int UpdateInterior(char[,] currentSeating, bool[,] updatedSeating)
        {
            int seatsChanged = 0;
            int lastRow = currentSeating.GetUpperBound(0);
            int lastColumn = currentSeating.GetUpperBound(1);

            for (int row = 1; row < lastRow; row++)
            {
                for (int column = 1; column < lastColumn; column++)
                {
                    if (currentSeating[row, column] == EmptySeat && AllAdjacentSeatsUnoccupied(currentSeating, row, column))
                    {
                        updatedSeating[row, column] = true;
                        seatsChanged++;
                    }
                    else if (currentSeating[row,column]== OccupiedSeat && AdjacentOccupiedSeats(currentSeating, row, column) > AdjacentSeatLimit)
                    {
                        updatedSeating[row, column] = true;
                        seatsChanged--;
                    }
                }
            }

            return seatsChanged;
        }

        private bool AllAdjacentSeatsUnoccupied(char[,] currentSeating, int row, int column)
        {
            return currentSeating[row - 1, column - 1] != OccupiedSeat
                && currentSeating[row - 1, column] != OccupiedSeat
                && currentSeating[row - 1, column + 1] != OccupiedSeat
                && currentSeating[row, column - 1] != OccupiedSeat
                && currentSeating[row, column + 1] != OccupiedSeat
                && currentSeating[row + 1, column - 1] != OccupiedSeat
                && currentSeating[row + 1, column] != OccupiedSeat
                && currentSeating[row + 1, column + 1] != OccupiedSeat;
        }

        private int AdjacentOccupiedSeats(char[,] currentSeating, int row, int column)
        {
            int count = 0;
            count += currentSeating[row - 1, column - 1] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row - 1, column] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row - 1, column + 1] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row, column - 1] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row, column + 1] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row + 1, column - 1] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row + 1, column] == OccupiedSeat ? 1 : 0;
            count += currentSeating[row + 1, column + 1] == OccupiedSeat ? 1 : 0;;
            return count;
        }

        private void UpdateSeating(char[,] currentSeating, bool[,] needsUpdating)
        {
            for (int row = 0; row <= currentSeating.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= currentSeating.GetUpperBound(1); column++)
                {
                    if (needsUpdating[row,column])
                    {
                        if (currentSeating[row,column] == EmptySeat)
                        {
                            currentSeating[row, column] = OccupiedSeat;
                        }
                        else if (currentSeating[row, column] == OccupiedSeat)
                        {
                            currentSeating[row, column] = EmptySeat;
                        }
                    }
                }
            }
        }

        private enum PerimeterLocation
        {
            TopRow,
            LeftColumn,
            RightColumn,
            BottomRow
        }

        private enum IndexCategory
        {
            CornerPerimeter,
            NonCornerPerimeter,
            Interior
        }
    }
}
