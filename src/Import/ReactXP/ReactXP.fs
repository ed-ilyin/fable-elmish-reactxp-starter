// ts2fable 0.5.2
module rec ReactXP
open System
open Fable.Core
open Fable.Import.JS

let [<Import("*","ReactXP")>] reactXP: ReactXP.IExports = jsNative

module ReactXP =

    type [<AllowNullLiteral>] IExports =
        // abstract Accessibility: ReactXP.Common.Interfaces.Accessibility
        // abstract ActivityIndicator: obj
        // abstract Alert: ReactXP.Common.Interfaces.Alert
        abstract App: ReactXP.Common.Interfaces.App
    //     abstract Button: obj
    //     abstract Picker: obj
    //     abstract Clipboard: ReactXP.Common.Interfaces.Clipboard
    //     abstract GestureView: obj
    //     abstract Image: ReactXP.Common.Interfaces.ImageConstructor
    //     abstract Input: ReactXP.Common.Interfaces.Input
    //     abstract International: ReactXP.Common.Interfaces.International
    //     abstract Link: obj
    //     abstract Linking: ReactXP.Common.Interfaces.Linking
    //     abstract Location: ReactXP.Common.Interfaces.Location
    //     abstract Modal: ReactXP.Common.Interfaces.Modal
    //     abstract Network: ReactXP.Common.Interfaces.Network
    //     abstract Platform: ReactXP.Common.Interfaces.Platform
    //     abstract Popup: ReactXP.Common.Interfaces.Popup
    //     abstract ScrollView: ReactXP.Common.Interfaces.ScrollViewConstructor
    //     abstract StatusBar: ReactXP.Common.Interfaces.StatusBar
    //     abstract Storage: ReactXP.Common.Interfaces.Storage
    //     abstract Styles: ReactXP.Common.Interfaces.Styles
    //     abstract Text: obj
    //     abstract TextInput: obj
    //     abstract UserInterface: ReactXP.Common.Interfaces.UserInterface
    //     abstract UserPresence: ReactXP.Common.Interfaces.UserPresence
    //     abstract View: obj
    //     abstract WebView: ReactXP.Common.Interfaces.WebViewConstructor
    //     abstract createElement: obj
    //     abstract Children: React.ReactChildren
    //     abstract __spread: obj option

    // type Accessibility =
    //     ReactXP.Common.Interfaces.Accessibility

    // type ActivityIndicator =
    //     ReactXP.Common.Interfaces.ActivityIndicator

    // type Alert =
    //     ReactXP.Common.Interfaces.Alert

    type App =
        ReactXP.Common.Interfaces.App

    // type Button =
    //     ReactXP.Common.Interfaces.Button

    // type Picker =
    //     ReactXP.Common.Interfaces.Picker

    // type Clipboard =
    //     ReactXP.Common.Interfaces.Clipboard

    // type GestureView =
    //     ReactXP.Common.Interfaces.GestureView

    // type Image =
    //     ReactXP.Common.Interfaces.Image

    // type Input =
    //     ReactXP.Common.Interfaces.Input

    // type International =
    //     ReactXP.Common.Interfaces.International

    // type Link =
    //     ReactXP.Common.Interfaces.Link

    // type Linking =
    //     ReactXP.Common.Interfaces.Linking

    // type Location =
    //     ReactXP.Common.Interfaces.Location

    // type Modal =
    //     ReactXP.Common.Interfaces.Modal

    // type Network =
    //     ReactXP.Common.Interfaces.Network

    // type Platform =
    //     ReactXP.Common.Interfaces.Platform

    // type Popup =
    //     ReactXP.Common.Interfaces.Popup

    // type ScrollView =
    //     ReactXP.Common.Interfaces.ScrollView

    // type StatusBar =
    //     ReactXP.Common.Interfaces.StatusBar

    // type Storage =
    //     ReactXP.Common.Interfaces.Storage

    // type Styles =
    //     ReactXP.Common.Interfaces.Styles

    // type Text =
    //     ReactXP.Common.Interfaces.Text

    // type TextInput =
    //     ReactXP.Common.Interfaces.TextInput

    // type UserInterface =
    //     ReactXP.Common.Interfaces.UserInterface

    // type UserPresence =
    //     ReactXP.Common.Interfaces.UserPresence

    // type View =
    //     ReactXP.Common.Interfaces.View

    // type WebView =
    //     ReactXP.Common.Interfaces.WebView
