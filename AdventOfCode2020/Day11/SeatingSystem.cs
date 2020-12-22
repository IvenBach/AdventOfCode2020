using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day11
{
    public class SeatingSystem
    {
        private readonly char[,] Inputs;
        private readonly char EmptySeat;
        private readonly char Floor;
        private readonly char OccupiedSeat;
        private readonly int AdjacentSeatLimit;
        private readonly OccupancyConcern OccupancyConcern;

        public SeatingSystem(char[,] inputs, OccupancyConcern occupancyConcern, int adjacentSeatLimit, char emptySeat = 'L', char occupiedSeat = '#', char floor = '.')
        {
            Inputs = inputs;
            EmptySeat = emptySeat;
            Floor = floor;
            OccupiedSeat = occupiedSeat;
            AdjacentSeatLimit = adjacentSeatLimit;
            OccupancyConcern = occupancyConcern;
        }

        /// <summary>
        /// Returns the total of all occupied seats as passengers fill in the empty seats and
        /// vacate seats that are too crowded until a balance is achieved.
        /// </summary>
        /// <returns>Total seats occupied</returns>
        public int OccupiedSeats()
        {
            var currentSeating = (char[,])Inputs.Clone();
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
            if (currentSeating[0, 0] == EmptySeat)
            {
                if (OccupancyConcern == OccupancyConcern.Adjacent)
                {
                    if (currentSeating[0, 1] != OccupiedSeat && currentSeating[1, 0] != OccupiedSeat && currentSeating[1, 1] != OccupiedSeat)
                    {
                        updatedSeating[0, 0] = true;
                        seatsChanged++;
                    }
                }
                else
                {
                    var tuple = (Row: 0, Column: 0);
                    if (!CanSeeOccupiedSeat(tuple, currentSeating, Direction.Right)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndDown)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Down))
                    {
                        updatedSeating[tuple.Row, tuple.Column] = true;
                        seatsChanged++;
                    }
                }
            }

            //TopRight
            if (currentSeating[0, lastColumn] == EmptySeat)
            {
                if (OccupancyConcern == OccupancyConcern.Adjacent)
                {
                    if (currentSeating[0, lastColumn - 1] != OccupiedSeat && currentSeating[1, 0] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
                    {
                        updatedSeating[0, lastColumn] = true;
                        seatsChanged++;
                    }
                }
                else
                {
                    var tuple = (Row: 0, Column: lastColumn);
                    if (!CanSeeOccupiedSeat(tuple, currentSeating, Direction.Left)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndDown)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Down))
                    {
                        updatedSeating[tuple.Row, tuple.Column] = true;
                        seatsChanged++;
                    }
                }
            }

            //Bottom Left
            if (currentSeating[lastRow, 0] == EmptySeat)
            {
                if (OccupancyConcern == OccupancyConcern.Adjacent)
                {
                    if (currentSeating[lastRow, 1] != OccupiedSeat && currentSeating[lastRow - 1, 0] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
                    {
                        updatedSeating[lastRow, 0] = true;
                        seatsChanged++;
                    }
                }
                else
                {
                    var tuple = (Row: lastRow, Column: 0);
                    if (!CanSeeOccupiedSeat(tuple, currentSeating, Direction.Up)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndUp)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Right))
                    {
                        updatedSeating[tuple.Row, tuple.Column] = true;
                        seatsChanged++;
                    }
                }
            }

            //Bottom Right
            if (currentSeating[lastRow, lastColumn] == EmptySeat)
            {
                if (OccupancyConcern == OccupancyConcern.Adjacent)
                {
                    if (currentSeating[lastRow, lastColumn - 1] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn] != OccupiedSeat && currentSeating[lastRow - 1, lastColumn - 1] != OccupiedSeat)
                    {
                        updatedSeating[lastRow, lastColumn] = true;
                        seatsChanged++;
                    }
                }
                else
                {
                    var tuple = (Row: lastRow, Column: lastColumn);
                    if (!CanSeeOccupiedSeat(tuple, currentSeating, Direction.Up)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndUp)
                        && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Left))
                    {
                        updatedSeating[tuple.Row, tuple.Column] = true;
                        seatsChanged++;
                    }
                }
            }

            return seatsChanged;
        }

        private bool CanSeeOccupiedSeat((int initialRow, int initialColumn) tuple, char[,] currentSeating, Direction direction)
        {
            var row = tuple.initialRow;
            var column = tuple.initialColumn;
            var lastRow = currentSeating.GetUpperBound(0);
            var lastColumn = currentSeating.GetUpperBound(1);
            switch (direction)
            {
                case Direction.Left:
                    if (column == 0)
                    {
                        return false;
                    }

                    do
                    {
                        column--;
                    } while (currentSeating[row, column] == Floor && column > 0) ;

                    break;

                case Direction.LeftAndUp:
                    if (column == 0 || row == 0)
                    {
                        return false;
                    }
                    
                    do
                    {
                        row--;
                        column--;
                    } while (currentSeating[row, column] == Floor && row > 0 && column > 0) ;

                    break;

                case Direction.Up:
                    if (row == 0)
                    {
                        return false;
                    }

                    do
                    {
                        row--;
                    } while (currentSeating[row, column] == Floor && row > 0) ;

                    break;

                case Direction.RightAndUp:
                    if (row == 0 || column == lastColumn)
                    {
                        return false;
                    }

                    do
                    {
                        row--;
                        column++;
                    } while (currentSeating[row, column] == Floor && row > 0 && column < lastColumn) ;

                    break;

                case Direction.Right:
                    if (column == lastColumn)
                    {
                        return false;
                    }

                    do
                    {
                        column++;
                    } while (currentSeating[row, column] == Floor && column < lastColumn) ;

                    break;

                case Direction.RightAndDown:
                    if (row == lastRow || column == lastColumn)
                    {
                        return false;
                    }

                    do
                    {
                        row++;
                        column++;
                    } while (currentSeating[row, column] == Floor && row < lastRow && column < lastColumn) ;

                    break;

                case Direction.Down:
                    if (row == lastRow)
                    {
                        return false;
                    }

                    do
                    {
                        row++;
                    } while (currentSeating[row, column] == Floor && row < lastRow) ;

                    break;

                case Direction.LeftAndDown:
                    if (row == lastRow || column == 0)
                    {
                        return false;
                    }

                    do
                    {
                        row++;
                        column--;
                    } while (currentSeating[row, column] == Floor && row < lastRow && column > 0) ;
                    
                    break;
            }
                    
            return currentSeating[row, column] == OccupiedSeat;
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
                var tuple = (Row: 0, Column: i);
                if (currentSeating[0, i] == EmptySeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.TopRow))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged++;
                        }
                    }
                    else
                    {
                        if (AllVisibleDirectionalSeatsUnoccupied(tuple, currentSeating))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged++;
                        }
                    }
                }
                else if (currentSeating[0, i] == OccupiedSeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.TopRow) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                    else
                    {
                        if (VisibleOccupiedSeats(tuple, currentSeating) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                }
            }

            //Left Column
            for (int i = 1; i < lastRow; i++)
            {
                var tuple = (Row: i, Column: 0);
                if (currentSeating[i, 0] == EmptySeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.LeftColumn))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged++;
                        }
                    }
                    else
                    {
                        if (AllVisibleDirectionalSeatsUnoccupied(tuple, currentSeating))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged++;
                        }
                    }
                }
                else if (currentSeating[i, 0] == OccupiedSeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.LeftColumn) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row,tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                    else
                    {
                        if (VisibleOccupiedSeats(tuple, currentSeating) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                }
            }

            //Right Column
            for (int i = 1; i < lastRow; i++)
            {
                var tuple = (Row: i, Column: lastColumn);
                if (currentSeating[tuple.Row, tuple.Column] == EmptySeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AllAdjacentSeatsUnoccupied(currentSeating, tuple.Row, PerimeterLocation.RightColumn))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged++;
                        }
                    }
                    else
                    {
                        if (AllVisibleDirectionalSeatsUnoccupied(tuple, currentSeating))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                        }
                    }
                }
                else if (currentSeating[i, lastColumn] == OccupiedSeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.RightColumn) >= AdjacentSeatLimit)
                        {
                            updatedSeating[i, lastColumn] = true;
                            seatsChanged++;
                        }
                    }
                    else
                    {
                        if (VisibleOccupiedSeats(tuple, currentSeating) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                }
            }

            //Bottom Row
            for (int i = 1; i < lastColumn; i++)
            {
                var tuple = (Row: lastRow, Column: i);
                if (currentSeating[lastRow, i] == EmptySeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AllAdjacentSeatsUnoccupied(currentSeating, i, PerimeterLocation.BottomRow))
                        {
                            updatedSeating[lastRow, i] = true;
                            seatsChanged++;
                        }
                    }
                    else
                    {
                        if (AllVisibleDirectionalSeatsUnoccupied(tuple, currentSeating))
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                        }
                    }
                }
                else if (currentSeating[lastRow, i] == OccupiedSeat)
                {
                    if (OccupancyConcern == OccupancyConcern.Adjacent)
                    {
                        if (AdjacentOccupiedSeats(currentSeating, i, PerimeterLocation.BottomRow) >= AdjacentSeatLimit)
                        {
                            updatedSeating[lastRow, i] = true;
                            seatsChanged--;
                        }
                    }
                    else
                    {
                        if (VisibleOccupiedSeats(tuple, currentSeating) >= AdjacentSeatLimit)
                        {
                            updatedSeating[tuple.Row, tuple.Column] = true;
                            seatsChanged--;
                        }
                    }
                }
            }

            return seatsChanged;
        }

        /// <summary>
        /// Visible is defined as all members of <see cref="Direction"/> being checked for a non-floor seat.
        /// </summary>
        /// <param name="tuple">Tuple containing the row and columm pair.</param>
        /// <param name="currentSeating">Seating checked as part of each move cycle.</param>
        /// <returns></returns>
        private int VisibleOccupiedSeats((int row, int column) tuple, char[,] currentSeating)
        {
            var count = CanSeeOccupiedSeat(tuple, currentSeating, Direction.Up) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndUp) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.Right) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndDown) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.Down) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndDown) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.Left) ? 1 : 0;
            count += CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndUp) ? 1 : 0;

            return count;
        }

        private bool AllVisibleDirectionalSeatsUnoccupied((int row, int column) tuple, char[,] currentSeating)
        {
            return !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Up)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndUp)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Right)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.RightAndDown)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Down)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndDown)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.Left)
                && !CanSeeOccupiedSeat(tuple, currentSeating, Direction.LeftAndUp);
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
                    if (currentSeating[row, column] == EmptySeat)
                    {
                        if (OccupancyConcern == OccupancyConcern.Adjacent)
                        {
                            if (AllAdjacentSeatsUnoccupied(currentSeating, row, column))
                            {
                                updatedSeating[row, column] = true;
                                seatsChanged++;
                            }
                        }
                        else
                        {
                            var tuple = (Row: row, Column: column);
                            if (AllVisibleDirectionalSeatsUnoccupied(tuple, currentSeating))
                            {
                                updatedSeating[tuple.Row, tuple.Column] = true;
                                seatsChanged++;
                            }
                        }
                    }
                    else if (currentSeating[row, column] == OccupiedSeat)
                    {
                        if (OccupancyConcern == OccupancyConcern.Adjacent)
                        {
                            if (AdjacentOccupiedSeats(currentSeating, row, column) >= AdjacentSeatLimit)
                            {
                                updatedSeating[row, column] = true;
                                seatsChanged--;
                            }
                        }
                        else
                        {
                            var tuple = (Row: row, Column: column);
                            if (VisibleOccupiedSeats(tuple,currentSeating) >= AdjacentSeatLimit)
                            {
                                updatedSeating[tuple.Row, tuple.Column] = true;
                                seatsChanged++;
                            }
                        }
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
            count += currentSeating[row + 1, column + 1] == OccupiedSeat ? 1 : 0;
            return count;
        }

        private void UpdateSeating(char[,] currentSeating, bool[,] needsUpdating)
        {
            for (int row = 0; row <= currentSeating.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= currentSeating.GetUpperBound(1); column++)
                {
                    if (needsUpdating[row, column])
                    {
                        if (currentSeating[row, column] == EmptySeat)
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

        private enum Direction
        {
            Left,
            LeftAndUp,
            Up,
            RightAndUp,
            Right,
            RightAndDown,
            Down,
            LeftAndDown
        }
    }

    public enum OccupancyConcern
    {
        Adjacent,
        Visible
    }
}
