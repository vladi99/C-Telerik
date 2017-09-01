using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DLabyrint
{
    class _3DLabyrint
    {
        static void Main(string[] args)
        {
            string[] startCoordinates = Console.ReadLine().Split();
            string[] dimensions = Console.ReadLine().Split();

            int x = int.Parse(startCoordinates[0]);
            int y = int.Parse(startCoordinates[1]);
            int z = int.Parse(startCoordinates[2]);

            int levels = int.Parse(dimensions[0]);
            int rows = int.Parse(dimensions[1]);
            int cols = int.Parse(dimensions[2]);

            char[,,] matrix = new char[levels, rows, cols];

            for (int level = 0; level < levels; level++)
            {
                for (int row = 0; row < rows; row++)
                {
                    string line = Console.ReadLine();
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[level, row, col] = line[col];
                    }
                }
            }

            var deltaRow = new int[] { 1, -1, 0, 0 };
            var deltaCol = new int[] { 0, 0, -1, 1 };

            var visited = new bool[levels, rows, cols];

            Queue<Room> q = new Queue<Room>();
            q.Enqueue(new Room(x, y, z, 0));

            while (q.Count > 0)
            {
                var currentPoint = q.Dequeue();
                visited[currentPoint.Level, currentPoint.Row, currentPoint.Col] = true;

                for (int i = 0; i < deltaRow.Length; i++)
                {
                    var newRow = currentPoint.Row + deltaRow[i];
                    var newCol = currentPoint.Col + deltaCol[i];
                    var newLevel = currentPoint.Level;

                    if (matrix[currentPoint.Level, currentPoint.Row, currentPoint.Col] == 'U')
                    {
                        newLevel++;
                        if (newLevel >= levels)
                        {
                            Console.WriteLine(currentPoint.Steps + 1);
                            return;
                        }
                        if (matrix[newLevel, currentPoint.Row, currentPoint.Col] != '#' && !visited[newLevel, currentPoint.Row, currentPoint.Col])
                        {
                            var newCell = new Room(newLevel, currentPoint.Row, currentPoint.Col, currentPoint.Steps + 1);
                            visited[newLevel, currentPoint.Row, currentPoint.Col] = true;
                            q.Enqueue(newCell);
                        }
                    }
                    else if(matrix[currentPoint.Level, currentPoint.Row, currentPoint.Col] == 'D')
                    {
                        newLevel--;
                        if (newLevel < 0)
                        {
                            Console.WriteLine(currentPoint.Steps + 1);
                            return;
                        }
                        if (matrix[newLevel, currentPoint.Row, currentPoint.Col] != '#' && !visited[newLevel, currentPoint.Row, currentPoint.Col])
                        {
                            var newCell = new Room(newLevel, currentPoint.Row, currentPoint.Col, currentPoint.Steps + 1);
                            visited[newLevel, currentPoint.Row, currentPoint.Col] = true;
                            q.Enqueue(newCell);
                        }
                    }
                    else
                    {
                        if (IsInRange(newRow, newCol, rows, cols) && matrix[newLevel, newRow, newCol] != '#' && !visited[newLevel, newRow, newCol])
                        {
                            var newCell = new Room(newLevel, newRow, newCol, currentPoint.Steps + 1);
                            visited[newLevel, newRow, newCol] = true;
                            q.Enqueue(newCell);
                        }
                    }
                }
            }

        }

        public static bool IsInRange(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }

        public class Room
        {
            public int Row { get; set; }

            public int Col { get; set; }

            public int Level { get; set; }

            public int Steps { get;  set; }

            public Room(int level, int row, int col, int steps)
            {
                this.Row = row;
                this.Col = col;
                this.Level = level;
                this.Steps = steps;
            }
        }
    }
}
