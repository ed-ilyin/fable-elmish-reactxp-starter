module Fable.Helpers.ReactXP

module HR = Fable.Helpers.React
module R = Fable.Import.React


let RX = Fable.Import.ReactXP.reactXP


// let inline text (props:TextProperties list) text : R.ReactElement =
let inline text (props:_ list) text : R.ReactElement =
    HR.createElement(RX.Text, props, [ HR.str text ])