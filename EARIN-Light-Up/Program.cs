﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EARIN_Light_Up.Algorithm;

namespace EARIN_Light_Up
{
    class Program
    {
        static void Main()
        {
            var board = new Board("testboard22.txt");

	        var DFSbox = new DFS();

			DFSbox.Perform(board, board.size * board.size, board.size * board.size);
        }
    }
}
