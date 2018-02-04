namespace Elmish.ReactXP

open Fable.Core
open Elmish


module Components =
    module R = Fable.Import.React
    
    type [<Pojo>] AppState = {
        render : unit -> R.ReactElement
        setState : AppState -> unit
    }

    let mutable appState = None

    type App(props) as this =
        inherit R.Component<obj,AppState>(props)
        do
            match appState with
            | Some state ->
                appState <- Some { state with AppState.setState = this.setInitState }
                this.setInitState state
            | _ -> failwith "was Elmish.ReactNative.Program.withReactXP called?"

        override this.componentDidMount() =
            appState <- Some { appState.Value with setState = this.setState }

        override this.componentWillUnmount() =
            appState <- Some { appState.Value with setState = ignore; render = this.state.render }

        override this.render () =
            this.state.render()


[<RequireQualifiedAccess>]
module Program =
    open Elmish.React
    open Components

    module HR = Fable.Helpers.React

    let RX = Fable.Import.ReactXP.reactXP

    /// Setup rendering of root ReactNative component
    let withReactXP (program:Program<_,_,_,_>) =
        do RX.App.initialize(true, true)
        do RX.UserInterface.setMainView(HR.ofType<App,_,_> () [])

        let render dispatch =
            let viewWithDispatch = program.view dispatch
            fun model ->
                match appState with
                | Some state ->
                    state.setState { state with render = fun () -> viewWithDispatch model }
                | _ ->
                    appState <- Some { render = fun () -> viewWithDispatch model
                                       setState = ignore }
                                       
        { program with setState = render }