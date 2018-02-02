// ts2fable 0.5.2
module rec Interfaces
open System
open Fable.Core
open Fable.Import.JS


type [<AllowNullLiteral>] IExports =
    abstract ActivityIndicator: ActivityIndicatorStatic
    abstract Alert: AlertStatic
    abstract AnimatedComponent: AnimatedComponentStatic
    abstract AnimatedImage: AnimatedImageStatic
    abstract AnimatedText: AnimatedTextStatic
    abstract AnimatedTextInput: AnimatedTextInputStatic
    abstract AnimatedView: AnimatedViewStatic
    abstract App: AppStatic
    abstract UserInterface: UserInterfaceStatic
    abstract Modal: ModalStatic
    abstract Popup: PopupStatic
    abstract Linking: LinkingStatic
    abstract Accessibility: AccessibilityStatic
    abstract Button: ButtonStatic
    abstract Picker: PickerStatic
    abstract Component: ComponentStatic
    abstract ImageConstructor: ImageConstructorStatic
    abstract Image: ImageStatic
    abstract Clipboard: ClipboardStatic
    abstract Link: LinkStatic
    abstract Storage: StorageStatic
    abstract Location: LocationStatic
    abstract Network: NetworkStatic
    abstract Platform: PlatformStatic
    abstract Input: InputStatic
    abstract ScrollViewConstructor: ScrollViewConstructorStatic
    abstract StatusBar: StatusBarStatic
    abstract Styles: StylesStatic
    abstract Text: TextStatic
    abstract TextInput: TextInputStatic
    abstract UserPresence: UserPresenceStatic
    abstract ViewBase: ViewBaseStatic
    abstract View: ViewStatic
    abstract GestureView: GestureViewStatic
    abstract WebViewConstructor: WebViewConstructorStatic

type [<AllowNullLiteral>] ActivityIndicator =
    inherit React.Component<Types.ActivityIndicatorProps, obj option>

type [<AllowNullLiteral>] ActivityIndicatorStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActivityIndicator

type [<AllowNullLiteral>] Alert =
    abstract show: title: string * ?message: string * ?buttons: ResizeArray<Types.AlertButtonSpec> * ?options: Types.AlertOptions -> unit

type [<AllowNullLiteral>] AlertStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Alert

type [<AllowNullLiteral>] AnimatedComponent<'P, 'T> =
    inherit React.Component<'P, 'T>
    abstract setNativeProps: props: 'P -> unit

type [<AllowNullLiteral>] AnimatedComponentStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedComponent<'P, 'T>

type [<AllowNullLiteral>] AnimatedImage =
    inherit AnimatedComponent<Types.AnimatedImageProps, obj>

type [<AllowNullLiteral>] AnimatedImageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedImage

type [<AllowNullLiteral>] AnimatedText =
    inherit AnimatedComponent<Types.AnimatedTextProps, obj>

type [<AllowNullLiteral>] AnimatedTextStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedText

type [<AllowNullLiteral>] AnimatedTextInput =
    inherit AnimatedComponent<Types.AnimatedTextInputProps, obj>

type [<AllowNullLiteral>] AnimatedTextInputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedTextInput

type [<AllowNullLiteral>] AnimatedView =
    inherit AnimatedComponent<Types.AnimatedViewProps, obj>
    abstract focus: unit -> unit
    abstract setFocusRestricted: restricted: bool -> unit
    abstract setFocusLimited: limited: bool -> unit

type [<AllowNullLiteral>] AnimatedViewStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedView

type [<AllowNullLiteral>] App =
    abstract initialize: debug: bool * development: bool -> unit
    abstract getActivationState: unit -> Types.AppActivationState
    abstract activationStateChangedEvent: SubscribableEvent<(Types.AppActivationState -> unit)> with get, set
    abstract memoryWarningEvent: SubscribableEvent<(unit -> unit)> with get, set

type [<AllowNullLiteral>] AppStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> App

type [<AllowNullLiteral>] UserInterface =
    abstract setMainView: element: React.ReactElement<obj option> -> unit
    abstract registerRootView: viewKey: string * getComponentFunc: Function -> unit
    abstract useCustomScrollbars: ?enable: bool -> unit
    abstract isHighPixelDensityScreen: unit -> bool
    abstract getPixelRatio: unit -> float
    abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
    abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
    abstract measureWindow: unit -> Types.Dimensions
    abstract getContentSizeMultiplier: unit -> SyncTasks.Promise<float>
    abstract contentSizeMultiplierChangedEvent: SubscribableEvent<(float -> unit)> with get, set
    abstract setMaxContentSizeMultiplier: maxContentSizeMultiplier: float -> unit
    abstract dismissKeyboard: unit -> unit
    abstract enableTouchLatencyEvents: latencyThresholdMs: float -> unit
    abstract touchLatencyEvent: SubscribableEvent<(float -> unit)> with get, set
    abstract isNavigatingWithKeyboard: unit -> bool
    abstract keyboardNavigationEvent: SubscribableEvent<(bool -> unit)> with get, set

type [<AllowNullLiteral>] UserInterfaceStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> UserInterface

type [<AllowNullLiteral>] Modal =
    abstract isDisplayed: ?modalId: string -> bool
    abstract show: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
    abstract dismiss: modalId: string -> unit
    abstract dismissAll: unit -> unit

type [<AllowNullLiteral>] ModalStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Modal

type [<AllowNullLiteral>] Popup =
    abstract show: options: Types.PopupOptions * popupId: string * ?delay: float -> bool
    abstract autoDismiss: popupId: string * ?delay: float -> unit
    abstract dismiss: popupId: string -> unit
    abstract dismissAll: unit -> unit
    abstract isDisplayed: ?popupId: string -> bool

type [<AllowNullLiteral>] PopupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Popup

type [<AllowNullLiteral>] Linking =
    abstract getInitialUrl: unit -> SyncTasks.Promise<string option>
    abstract deepLinkRequestEvent: SubscribableEvent<(string -> unit)> with get, set
    abstract openUrl: url: string -> SyncTasks.Promise<unit>
    abstract launchSms: smsData: Types.SmsInfo -> SyncTasks.Promise<unit>
    abstract launchEmail: emailData: Types.EmailInfo -> SyncTasks.Promise<unit>
    abstract _createEmailUrl: emailInfo: Types.EmailInfo -> string

type [<AllowNullLiteral>] LinkingStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Linking

type [<AllowNullLiteral>] Accessibility =
    abstract isScreenReaderEnabled: unit -> bool
    abstract isHighContrastEnabled: unit -> bool
    abstract announceForAccessibility: announcement: string -> unit
    abstract screenReaderChangedEvent: SubscribableEvent<(bool -> unit)> with get, set
    abstract highContrastChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

type [<AllowNullLiteral>] AccessibilityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

type [<AllowNullLiteral>] Button =
    inherit React.Component<Types.ButtonProps, obj option>
    abstract focus: unit -> unit
    abstract blur: unit -> unit

type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Button

type [<AllowNullLiteral>] Picker =
    inherit React.Component<Types.PickerProps, obj>

type [<AllowNullLiteral>] PickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Picker

type [<AllowNullLiteral>] Component<'P, 'T> =
    inherit React.Component<'P, 'T>

type [<AllowNullLiteral>] ComponentStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Component<'P, 'T>

type [<AllowNullLiteral>] ImageConstructor =
    abstract prefetch: url: string -> SyncTasks.Promise<bool>

type [<AllowNullLiteral>] ImageConstructorStatic =
    [<Emit "new $0($1...)">] abstract Create: props: Types.ImageProps -> ImageConstructor

type [<AllowNullLiteral>] Image =
    inherit React.Component<Types.ImageProps, obj option>
    abstract getNativeWidth: unit -> float option
    abstract getNativeHeight: unit -> float option

type [<AllowNullLiteral>] ImageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Image

type [<AllowNullLiteral>] Clipboard =
    abstract setText: text: string -> unit
    abstract getText: unit -> SyncTasks.Promise<string>

type [<AllowNullLiteral>] ClipboardStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Clipboard

type [<AllowNullLiteral>] Link =
    inherit React.Component<Types.LinkProps, obj option>

type [<AllowNullLiteral>] LinkStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Link

type [<AllowNullLiteral>] Storage =
    abstract getItem: key: string -> SyncTasks.Promise<string option>
    abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
    abstract removeItem: key: string -> SyncTasks.Promise<unit>
    abstract clear: unit -> SyncTasks.Promise<unit>

type [<AllowNullLiteral>] StorageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Storage

type [<AllowNullLiteral>] Location =
    abstract isAvailable: unit -> bool
    abstract setConfiguration: config: LocationConfiguration -> unit
    abstract getCurrentPosition: ?options: PositionOptions -> SyncTasks.Promise<Position>
    abstract watchPosition: successCallback: Types.LocationSuccessCallback * ?errorCallback: Types.LocationFailureCallback * ?options: PositionOptions -> SyncTasks.Promise<Types.LocationWatchId>
    abstract clearWatch: watchID: Types.LocationWatchId -> unit

type [<AllowNullLiteral>] LocationStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Location

type [<AllowNullLiteral>] LocationConfiguration =
    abstract skipPermissionRequests: bool with get, set

type [<AllowNullLiteral>] Network =
    abstract isConnected: unit -> SyncTasks.Promise<bool>
    abstract getType: unit -> SyncTasks.Promise<Types.DeviceNetworkType>
    abstract connectivityChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

type [<AllowNullLiteral>] NetworkStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Network

type [<AllowNullLiteral>] Platform =
    abstract getType: unit -> Types.PlatformType

type [<AllowNullLiteral>] PlatformStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Platform

type [<AllowNullLiteral>] Input =
    abstract backButtonEvent: SubscribableEvent<(unit -> bool)> with get, set
    abstract keyDownEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set
    abstract keyUpEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set

type [<AllowNullLiteral>] InputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Input

type [<AllowNullLiteral>] ScrollViewConstructor =
    interface end

type [<AllowNullLiteral>] ScrollViewConstructorStatic =
    [<Emit "new $0($1...)">] abstract Create: props: Types.ScrollViewProps -> ScrollViewConstructor

type [<AllowNullLiteral>] ScrollView =
    inherit React.Component<Types.ScrollViewProps, obj option>
    abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
    abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit
    abstract addToScrollTop: deltaTop: float * ?animate: bool -> unit
    abstract addToScrollLeft: deltaLeft: float * ?animate: bool -> unit

type [<AllowNullLiteral>] StatusBar =
    abstract isOverlay: unit -> bool
    abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
    abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
    abstract setNetworkActivityIndicatorVisible: value: bool -> unit
    abstract setBackgroundColor: color: string * animated: bool -> unit
    abstract setTranslucent: translucent: bool -> unit

type [<AllowNullLiteral>] StatusBarStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

type [<AllowNullLiteral>] Styles =
    abstract combine: ruleSet1: Types.StyleRuleSetRecursive<'T> option * ?ruleSet2: Types.StyleRuleSetRecursive<'T> -> Types.StyleRuleSetOrArray<'T> option
    abstract createViewStyle: ruleSet: Types.ViewStyle * ?cacheStyle: bool -> Types.ViewStyleRuleSet
    abstract createAnimatedViewStyle: ruleSet: Types.AnimatedViewStyle -> Types.AnimatedViewStyleRuleSet
    abstract createScrollViewStyle: ruleSet: Types.ScrollViewStyle * ?cacheStyle: bool -> Types.ScrollViewStyleRuleSet
    abstract createButtonStyle: ruleSet: Types.ButtonStyle * ?cacheStyle: bool -> Types.ButtonStyleRuleSet
    abstract createWebViewStyle: ruleSet: Types.WebViewStyle * ?cacheStyle: bool -> Types.WebViewStyleRuleSet
    abstract createTextStyle: ruleSet: Types.TextStyle * ?cacheStyle: bool -> Types.TextStyleRuleSet
    abstract createAnimatedTextStyle: ruleSet: Types.AnimatedTextStyle -> Types.AnimatedTextStyleRuleSet
    abstract createTextInputStyle: ruleSet: Types.TextInputStyle * ?cacheStyle: bool -> Types.TextInputStyleRuleSet
    abstract createAnimatedTextInputStyle: ruleSet: Types.AnimatedTextInputStyle -> Types.AnimatedTextInputStyleRuleSet
    abstract createImageStyle: ruleSet: Types.ImageStyle * ?cacheStyle: bool -> Types.ImageStyleRuleSet
    abstract createAnimatedImageStyle: ruleSet: Types.AnimatedImageStyle -> Types.AnimatedImageStyleRuleSet
    abstract createLinkStyle: ruleSet: Types.LinkStyleRuleSet * ?cacheStyle: bool -> Types.LinkStyleRuleSet
    abstract createPickerStyle: ruleSet: Types.PickerStyle * ?cacheStyle: bool -> Types.PickerStyleRuleSet
    abstract getCssPropertyAliasesCssStyle: unit -> obj

type [<AllowNullLiteral>] StylesStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Styles

type [<AllowNullLiteral>] Text =
    inherit React.Component<Types.TextProps, obj option>
    abstract focus: unit -> unit
    abstract blur: unit -> unit

type [<AllowNullLiteral>] TextStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Text

type [<AllowNullLiteral>] TextInput =
    inherit React.Component<Types.TextInputProps, obj option>
    abstract blur: unit -> unit
    abstract focus: unit -> unit
    abstract setAccessibilityFocus: unit -> unit
    abstract isFocused: unit -> bool
    abstract selectAll: unit -> unit
    abstract selectRange: start: float * ``end``: float -> unit
    abstract getSelectionRange: unit -> obj
    abstract setValue: value: string -> unit

type [<AllowNullLiteral>] TextInputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TextInput

type [<AllowNullLiteral>] UserPresence =
    abstract isUserPresent: unit -> bool
    abstract userPresenceChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

type [<AllowNullLiteral>] UserPresenceStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> UserPresence

type [<AllowNullLiteral>] ViewBase<'P, 'S> =
    inherit React.Component<'P, 'S>

type [<AllowNullLiteral>] ViewBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ViewBase<'P, 'S>

type [<AllowNullLiteral>] View =
    inherit ViewBase<Types.ViewProps, obj option>
    abstract focus: unit -> unit
    abstract setFocusRestricted: restricted: bool -> unit
    abstract setFocusLimited: limited: bool -> unit

type [<AllowNullLiteral>] ViewStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> View

type [<AllowNullLiteral>] GestureView =
    inherit ViewBase<Types.GestureViewProps, obj option>

type [<AllowNullLiteral>] GestureViewStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> GestureView

type [<AllowNullLiteral>] WebViewConstructor =
    interface end

type [<AllowNullLiteral>] WebViewConstructorStatic =
    [<Emit "new $0($1...)">] abstract Create: props: Types.WebViewProps -> WebViewConstructor

type [<AllowNullLiteral>] WebView =
    inherit ViewBase<Types.WebViewProps, obj option>
    abstract postMessage: message: string * ?targetOrigin: string -> unit
    abstract reload: unit -> unit
    abstract goBack: unit -> unit
    abstract goForward: unit -> unit

type [<AllowNullLiteral>] Animated =
    abstract Image: obj with get, set
    abstract Text: obj with get, set
    abstract TextInput: obj with get, set
    abstract View: obj with get, set
    abstract Easing: Types.Animated.Easing with get, set
    abstract timing: Types.Animated.TimingFunction with get, set
    abstract ``parallel``: Types.Animated.ParallelFunction with get, set
    abstract sequence: Types.Animated.SequenceFunction with get, set
    abstract Value: obj with get, set
    abstract createValue: (float -> Types.AnimatedValue) with get, set
    abstract interpolate: (Types.AnimatedValue -> ResizeArray<float> -> ResizeArray<string> -> Types.InterpolatedValue) with get, set

type [<AllowNullLiteral>] International =
    abstract allowRTL: allow: bool -> unit
    abstract forceRTL: force: bool -> unit
    abstract isRTL: unit -> bool
