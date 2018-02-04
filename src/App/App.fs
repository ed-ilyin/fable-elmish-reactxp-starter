module App

open Elmish
open Elmish.ReactXP

module RX = Fable.Helpers.ReactXP


let init () = (), Cmd.none
let update msg model = model, Cmd.none
let root model dispatch = RX.text [] "bibu"
Program.mkProgram init update root
    |> Program.withReactXP
    |> Program.run