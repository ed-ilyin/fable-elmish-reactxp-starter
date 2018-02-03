module App

open ReactXP
open Fable.Helpers.React


do reactXP.App.initialize(true, true)
do reactXP.UserInterface.setMainView(div [] [ str "abba" ])