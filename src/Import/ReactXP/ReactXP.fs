// ts2fable 0.5.2
module rec Fable.Import.ReactXP

open Fable.Core

module R = Fable.Import.React


let [<Import("*","ReactXP")>] reactXP: IExports = jsNative


type [<AllowNullLiteral>] IExports =
    // abstract Accessibility: Interfaces.Accessibility
    // abstract ActivityIndicator: obj
    // abstract Alert: Interfaces.Alert
    abstract App: Interfaces.App
//     abstract Button: obj
//     abstract Picker: obj
//     abstract Clipboard: Interfaces.Clipboard
//     abstract GestureView: obj
//     abstract Image: Interfaces.ImageConstructor
//     abstract Input: Interfaces.Input
//     abstract International: Interfaces.International
//     abstract Link: obj
//     abstract Linking: Interfaces.Linking
//     abstract Location: Interfaces.Location
//     abstract Modal: Interfaces.Modal
//     abstract Network: Interfaces.Network
//     abstract Platform: Interfaces.Platform
//     abstract Popup: Interfaces.Popup
//     abstract ScrollView: Interfaces.ScrollViewConstructor
//     abstract StatusBar: Interfaces.StatusBar
//     abstract Storage: Interfaces.Storage
//     abstract Styles: Interfaces.Styles
    abstract Text: obj
//     abstract TextInput: obj
    abstract UserInterface: Interfaces.UserInterface
//     abstract UserPresence: Interfaces.UserPresence
//     abstract View: obj
//     abstract WebView: Interfaces.WebViewConstructor
//     abstract createElement: obj
//     abstract Children: React.ReactChildren
//     abstract __spread: obj option

// type Accessibility =
//     Interfaces.Accessibility

// type ActivityIndicator =
//     Interfaces.ActivityIndicator

// type Alert =
//     Interfaces.Alert

type App = Interfaces.App

// type Button =
//     Interfaces.Button

// type Picker =
//     Interfaces.Picker

// type Clipboard =
//     Interfaces.Clipboard

// type GestureView =
//     Interfaces.GestureView

// type Image =
//     Interfaces.Image

// type Input =
//     Interfaces.Input

// type International =
//     Interfaces.International

// type Link =
//     Interfaces.Link

// type Linking =
//     Interfaces.Linking

// type Location =
//     Interfaces.Location

// type Modal =
//     Interfaces.Modal

// type Network =
//     Interfaces.Network

// type Platform =
//     Interfaces.Platform

// type Popup =
//     Interfaces.Popup

// type ScrollView =
//     Interfaces.ScrollView

// type StatusBar =
//     Interfaces.StatusBar

// type Storage =
//     Interfaces.Storage

// type Styles =
//     Interfaces.Styles

type Text = Interfaces.Text

// type TextInput =
//     Interfaces.TextInput

type UserInterface = Interfaces.UserInterface

// type UserPresence =
//     Interfaces.UserPresence

// type View =
//     Interfaces.View

// type WebView =
//     Interfaces.WebView
