// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

// a simple version of a cell for a sudoku game
type Cell =
  | Value of int
  | Possibles of int list
  | None


// definition of a board
let input = [
    [ None;    None;    None;      None;    Value 6; None;      Value 4; None;    None ];
    [ None;    Value 5; None;      None;    None;    Value 3;   Value 6; None;    None ];
    [ Value 1; None;    None;      None;    None;    Value 5;   None;    None;    None ];

    [ None;    Value 4; Value 1;   None;    None;    None;      None;    None;    None ];
    [ None;    Value 9; None;      None;    None;    None;      None;    Value 2; None ];
    [ Value 5; None;    Value 2;   None;    None;    None;      Value 3; Value 4; None ];

    [ Value 3; None;    None;      Value 7; None;    None;      None;    None;    None ];
    [ None;    None;    Value 6;   Value 5; None;    None;      None;    Value 9; None ];
    [ None;    None;    Value 4;   None;    Value 1; None;      None;    None;    None ]
]

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code


