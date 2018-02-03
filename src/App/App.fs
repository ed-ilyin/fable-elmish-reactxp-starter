module App

open Fable.Helpers.React
open Elmish
open Elmish.ReactXP

let init () = (), Cmd.none
let update msg model = model, Cmd.none
let root model dispatch = div [] [ str "bibu" ]
Program.mkProgram init update root
    |> Program.withReactXP
    |> Program.run