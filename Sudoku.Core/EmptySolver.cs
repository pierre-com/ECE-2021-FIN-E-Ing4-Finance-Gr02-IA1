using System;
using System.Collections.Generic;
using IronPython.Hosting;


namespace Sudoku.Core
{


    public class EmptySolver : ISudokuSolver
    {

        static void CallPython()
        {
            //string[] args

            //instance of python engine
            var engine = Python.CreateEngine();

            //reading code from file
            var source = engine.CreateScriptSourceFromFile(@"/Users/nicolasnahas/Desktop/nv/ECE/AI/Sudoku.Core/test.py");
            var scope = engine.CreateScope();

            //executing script in scope


            List<int> SudokuList  = new List<int>();
            SudokuList.Add(1);
            SudokuList.Add(3);
            SudokuList.Add(4);

            scope.SetVariable("results", SudokuList);

            source.Execute(scope);

        
        }



        public void Solve(Core.GrilleSudoku s)
        {
            CallPython();
        }
         

    }


}

