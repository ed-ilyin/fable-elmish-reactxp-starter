module App

open ReactXP
open Fable.Helpers.React
open Elmish.ReactXP

let init () = (), Cmd.none
let update msg model = model, Cmd.none
let root model dispatch = div [] [ str "bibu" ]
Program.mkProgram init update root
    |> Program.withReactXP
    |> Program.run