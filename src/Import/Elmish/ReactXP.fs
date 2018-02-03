namespace Elmish.ReactXP

open Fable.Core
open Elmish
open ReactXP
open Fable.Helpers.React

module R = Fable.Import.React


module Components =
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
            | _ -> failwith "was Elmish.ReactNative.Program.withReactNative called?"

        override this.componentDidMount() =
            appState <- Some { appState.Value with setState = this.setState }

        override this.componentWillUnmount() =
            appState <- Some { appState.Value with setState = ignore; render = this.state.render }

        override this.render () =
            this.state.render()

// [<Import("AppRegistry","react-native")>]
// type AppRegistry =
//     static member registerComponent(appKey:string, getComponentFunc:unit->R.ComponentClass<_>) : unit =
//         failwith "JS only"

[<RequireQualifiedAccess>]
module Program =
    open Elmish.React
    open Components

    /// Setup rendering of root ReactNative component
    let withReactXP (program:Program<_,_,_,_>) =
        do reactXP.App.initialize(true, true)
        do reactXP.UserInterface.setMainView(ofType<App,_,_> () [])

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