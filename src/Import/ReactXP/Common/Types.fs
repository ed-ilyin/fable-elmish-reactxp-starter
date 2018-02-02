// ts2fable 0.5.2
module rec ReactXP.Common.Types
open System
open Fable.Core
open Fable.Import.JS

// let [<Import("*","Types")>] Children: React.ReactChildren = jsNative
// let [<Import("*","Types")>] animated: Animated.IExports = jsNative

// type [<AllowNullLiteral>] IExports =
//     abstract AnimatedValue: AnimatedValueStatic
//     abstract InterpolatedValue: InterpolatedValueStatic

// type ReactNode =
//     React.ReactNode

// type ReactInterface =
//     obj

// type [<AllowNullLiteral>] FlexboxParentStyle =
//     abstract flexDirection: U4<string, string, string, string> option with get, set
//     abstract alignSelf: U5<string, string, string, string, string> option with get, set
//     abstract borderWidth: float option with get, set
//     abstract borderTopWidth: float option with get, set
//     abstract borderRightWidth: float option with get, set
//     abstract borderBottomWidth: float option with get, set
//     abstract borderLeftWidth: float option with get, set
//     abstract height: float option with get, set
//     abstract width: float option with get, set
//     abstract top: float option with get, set
//     abstract right: float option with get, set
//     abstract bottom: float option with get, set
//     abstract left: float option with get, set
//     abstract flexGrow: float option with get, set
//     abstract flexShrink: float option with get, set
//     abstract flexBasis: float option with get, set
//     abstract flex: float option with get, set
//     abstract maxHeight: float option with get, set
//     abstract maxWidth: float option with get, set
//     abstract minHeight: float option with get, set
//     abstract minWidth: float option with get, set
//     abstract margin: float option with get, set
//     abstract marginHorizontal: float option with get, set
//     abstract marginVertical: float option with get, set
//     abstract marginTop: float option with get, set
//     abstract marginRight: float option with get, set
//     abstract marginBottom: float option with get, set
//     abstract marginLeft: float option with get, set
//     abstract padding: float option with get, set
//     abstract paddingHorizontal: float option with get, set
//     abstract paddingVertical: float option with get, set
//     abstract paddingTop: float option with get, set
//     abstract paddingRight: float option with get, set
//     abstract paddingBottom: float option with get, set
//     abstract paddingLeft: float option with get, set
//     abstract position: U2<string, string> option with get, set

// type [<AllowNullLiteral>] FlexboxChildrenStyle =
//     abstract alignItems: U4<string, string, string, string> option with get, set
//     abstract alignContent: U5<string, string, string, string, string> option with get, set
//     abstract flexWrap: U2<string, string> option with get, set
//     abstract justifyContent: U5<string, string, string, string, string> option with get, set

// type [<AllowNullLiteral>] FlexboxStyle =
//     inherit FlexboxParentStyle
//     inherit FlexboxChildrenStyle

// type InterpolationConfig =
//     obj

// type [<AllowNullLiteral>] AnimatedValue =
//     abstract setValue: value: float -> unit
//     abstract interpolate: config: InterpolationConfig -> InterpolatedValue

// type [<AllowNullLiteral>] AnimatedValueStatic =
//     [<Emit "new $0($1...)">] abstract Create: ``val``: float -> AnimatedValue

// type [<AllowNullLiteral>] InterpolatedValue =
//     interface end

// type [<AllowNullLiteral>] InterpolatedValueStatic =
//     [<Emit "new $0($1...)">] abstract Create: unit -> InterpolatedValue

// type [<AllowNullLiteral>] AnimatedFlexboxStyle =
//     abstract height: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract width: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract top: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract right: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract bottom: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract left: U2<AnimatedValue, InterpolatedValue> option with get, set

// type [<AllowNullLiteral>] TransformStyle =
//     abstract transform: ResizeArray<obj> option with get, set

// type [<AllowNullLiteral>] AnimatedTransformStyle =
//     abstract transform: ResizeArray<obj> option with get, set

// type StyleRuleSet<'T> =
//     U2<'T, float> option

// [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
// module StyleRuleSet =
//     let ofTOption v: StyleRuleSet<'T> = v |> Option.map U2.Case1
//     let ofT v: StyleRuleSet<'T> = v |> U2.Case1 |> Some
//     let isT (v: StyleRuleSet<'T>) = match v with None -> false | Some o -> match o with U2.Case1 _ -> true | _ -> false
//     let asT (v: StyleRuleSet<'T>) = match v with None -> None | Some o -> match o with U2.Case1 o -> Some o | _ -> None
//     let ofFloatOption v: StyleRuleSet<'T> = v |> Option.map U2.Case2
//     let ofFloat v: StyleRuleSet<'T> = v |> U2.Case2 |> Some
//     let isFloat (v: StyleRuleSet<'T>) = match v with None -> false | Some o -> match o with U2.Case2 _ -> true | _ -> false
//     let asFloat (v: StyleRuleSet<'T>) = match v with None -> None | Some o -> match o with U2.Case2 o -> Some o | _ -> None

// type StyleRuleSetOrArray<'T> =
//     U2<StyleRuleSet<'T>, Array<StyleRuleSet<'T>>>

// [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
// module StyleRuleSetOrArray =
//     let ofStyleRuleSet v: StyleRuleSetOrArray<'T> = v |> U2.Case1
//     let isStyleRuleSet (v: StyleRuleSetOrArray<'T>) = match v with U2.Case1 _ -> true | _ -> false
//     let asStyleRuleSet (v: StyleRuleSetOrArray<'T>) = match v with U2.Case1 o -> Some o | _ -> None
//     let ofArray v: StyleRuleSetOrArray<'T> = v |> U2.Case2
//     let isArray (v: StyleRuleSetOrArray<'T>) = match v with U2.Case2 _ -> true | _ -> false
//     let asArray (v: StyleRuleSetOrArray<'T>) = match v with U2.Case2 o -> Some o | _ -> None

// type [<AllowNullLiteral>] StyleRuleSetRecursiveArray<'T> =
//     inherit Array<U2<StyleRuleSetOrArray<'T>, StyleRuleSetRecursiveArray<'T>>>

// type StyleRuleSetRecursive<'T> =
//     U2<StyleRuleSet<'T>, StyleRuleSetRecursiveArray<'T>>

// [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
// module StyleRuleSetRecursive =
//     let ofStyleRuleSet v: StyleRuleSetRecursive<'T> = v |> U2.Case1
//     let isStyleRuleSet (v: StyleRuleSetRecursive<'T>) = match v with U2.Case1 _ -> true | _ -> false
//     let asStyleRuleSet (v: StyleRuleSetRecursive<'T>) = match v with U2.Case1 o -> Some o | _ -> None
//     let ofStyleRuleSetRecursiveArray v: StyleRuleSetRecursive<'T> = v |> U2.Case2
//     let isStyleRuleSetRecursiveArray (v: StyleRuleSetRecursive<'T>) = match v with U2.Case2 _ -> true | _ -> false
//     let asStyleRuleSetRecursiveArray (v: StyleRuleSetRecursive<'T>) = match v with U2.Case2 o -> Some o | _ -> None

// type [<AllowNullLiteral>] ViewAndImageCommonStyle =
//     inherit FlexboxStyle
//     inherit TransformStyle
//     abstract borderWidth: float option with get, set
//     abstract borderColor: string option with get, set
//     abstract borderRadius: float option with get, set
//     abstract borderTopRightRadius: float option with get, set
//     abstract borderBottomRightRadius: float option with get, set
//     abstract borderBottomLeftRadius: float option with get, set
//     abstract borderTopLeftRadius: float option with get, set
//     abstract overflow: U2<string, string> option with get, set
//     abstract backgroundColor: string option with get, set
//     abstract opacity: float option with get, set

// type [<AllowNullLiteral>] AnimatedViewAndImageCommonStyle =
//     inherit AnimatedFlexboxStyle
//     inherit AnimatedTransformStyle
//     abstract borderRadius: U2<AnimatedValue, InterpolatedValue> option with get, set
//     abstract backgroundColor: InterpolatedValue option with get, set
//     abstract opacity: U2<AnimatedValue, InterpolatedValue> option with get, set

// type [<AllowNullLiteral>] ShadowOffset =
//     abstract width: float with get, set
//     abstract height: float with get, set

// type [<AllowNullLiteral>] ViewStyle =
//     inherit ViewAndImageCommonStyle
//     abstract borderStyle: U4<string, string, string, string> option with get, set
//     abstract wordBreak: U2<string, string> option with get, set
//     abstract appRegion: U2<string, string> option with get, set
//     abstract cursor: U2<string, string> option with get, set
//     abstract shadowOffset: ShadowOffset option with get, set
//     abstract shadowOpacity: float option with get, set
//     abstract shadowRadius: float option with get, set
//     abstract shadowColor: string option with get, set
//     abstract elevation: float option with get, set
//     abstract acrylicOpacityUWP: float option with get, set
//     abstract acrylicSourceUWP: U2<string, string> option with get, set
//     abstract acrylicTintColorUWP: string option with get, set

// type ViewStyleRuleSet =
//     StyleRuleSet<ViewStyle>

// type [<AllowNullLiteral>] AnimatedViewStyle =
//     inherit AnimatedViewAndImageCommonStyle

// type AnimatedViewStyleRuleSet =
//     StyleRuleSet<AnimatedViewStyle>

// type [<AllowNullLiteral>] ScrollViewStyle =
//     inherit FlexboxParentStyle
//     inherit TransformStyle
//     abstract overflow: U2<string, string> option with get, set
//     abstract backgroundColor: string option with get, set
//     abstract opacity: float option with get, set

// type ScrollViewStyleRuleSet =
//     StyleRuleSet<ScrollViewStyle>

// type [<AllowNullLiteral>] ButtonStyle =
//     inherit ViewStyle

// type ButtonStyleRuleSet =
//     StyleRuleSet<ButtonStyle>

// type [<AllowNullLiteral>] WebViewStyle =
//     inherit ViewStyle

// type WebViewStyleRuleSet =
//     StyleRuleSet<WebViewStyle>

// type [<AllowNullLiteral>] ActivityIndicatorStyle =
//     inherit ViewStyle

// type ActivityIndicatorStyleRuleSet =
//     StyleRuleSet<ActivityIndicatorStyle>

// type [<AllowNullLiteral>] FontInfo =
//     abstract fontFamily: string option with get, set
//     abstract fontStyle: U2<string, string> option with get, set
//     abstract fontWeight: obj option with get, set

// type [<AllowNullLiteral>] TextStyle =
//     inherit ViewStyle
//     abstract color: string option with get, set
//     abstract fontFamily: string option with get, set
//     abstract fontSize: float option with get, set
//     abstract fontStyle: U2<string, string> option with get, set
//     abstract fontWeight: obj option with get, set
//     abstract font: FontInfo option with get, set
//     abstract letterSpacing: float option with get, set
//     abstract lineHeight: float option with get, set
//     abstract textAlign: U5<string, string, string, string, string> option with get, set
//     abstract textDecorationLine: U4<string, string, string, string> option with get, set
//     abstract textDecorationStyle: U4<string, string, string, string> option with get, set
//     abstract textDecorationColor: string option with get, set
//     abstract writingDirection: U3<string, string, string> option with get, set
//     abstract textAlignVertical: U4<string, string, string, string> option with get, set
//     abstract includeFontPadding: bool option with get, set

// type TextStyleRuleSet =
//     StyleRuleSet<TextStyle>

// type [<AllowNullLiteral>] AnimatedTextStyle =
//     inherit AnimatedViewAndImageCommonStyle
//     abstract color: InterpolatedValue option with get, set
//     abstract fontSize: U2<AnimatedValue, InterpolatedValue> option with get, set

// type AnimatedTextStyleRuleSet =
//     StyleRuleSet<AnimatedTextStyle>

// type [<AllowNullLiteral>] TextInputStyle =
//     inherit TextStyle

// type TextInputStyleRuleSet =
//     StyleRuleSet<TextInputStyle>

// type [<AllowNullLiteral>] AnimatedTextInputStyle =
//     inherit AnimatedViewAndImageCommonStyle
//     abstract color: InterpolatedValue option with get, set
//     abstract fontSize: U2<AnimatedValue, InterpolatedValue> option with get, set

// type AnimatedTextInputStyleRuleSet =
//     StyleRuleSet<AnimatedTextInputStyle>

// type [<AllowNullLiteral>] LinkStyle =
//     inherit TextStyle

// type LinkStyleRuleSet =
//     StyleRuleSet<LinkStyle>

// type [<AllowNullLiteral>] ImageStyle =
//     inherit ViewAndImageCommonStyle
//     inherit FlexboxStyle
//     abstract overlayColor: string option with get, set

// type ImageStyleRuleSet =
//     StyleRuleSet<ImageStyle>

// type [<AllowNullLiteral>] AnimatedImageStyle =
//     inherit AnimatedViewAndImageCommonStyle
//     inherit AnimatedFlexboxStyle

// type AnimatedImageStyleRuleSet =
//     StyleRuleSet<AnimatedImageStyle>

// type [<AllowNullLiteral>] PickerStyle =
//     inherit ViewStyle
//     abstract color: string option with get, set

// type PickerStyleRuleSet =
//     StyleRuleSet<PickerStyle>

// type ComponentBase =
//     React.Component<obj option, obj option>

// type [<AllowNullLiteral>] CommonProps =
//     abstract ref: U2<string, (ComponentBase option -> unit)> option with get, set
//     abstract key: U2<string, float> option with get, set
//     abstract ``type``: obj option option with get, set
//     abstract children: U2<ReactNode, ResizeArray<ReactNode>> option with get, set

// type [<AllowNullLiteral>] Stateless =
//     interface end

// type [<AllowNullLiteral>] CommonAccessibilityProps =
//     abstract importantForAccessibility: ImportantForAccessibility option with get, set
//     abstract accessibilityLabel: string option with get, set
//     abstract accessibilityTraits: U2<AccessibilityTrait, ResizeArray<AccessibilityTrait>> option with get, set
//     abstract tabIndex: float option with get, set
//     abstract accessibilityActions: ResizeArray<string> option with get, set
//     abstract onAccessibilityAction: (SyntheticEvent -> unit) option with get, set

// type [<RequireQualifiedAccess>] ImportantForAccessibility =
//     | Auto = 1
//     | Yes = 2
//     | No = 3
//     | NoHideDescendants = 4

// type [<StringEnum>] [<RequireQualifiedAccess>] AriaLive =
//     | Off
//     | Assertive
//     | Polite

// type [<AllowNullLiteral>] AccessibilityHtmlAttributes =
//     inherit React.HTMLAttributes<obj option>
//     abstract ``aria-label``: string option with get, set
//     abstract ``aria-live``: AriaLive option with get, set
//     abstract ``aria-hidden``: bool option with get, set
//     abstract ``aria-disabled``: bool option with get, set
//     abstract ``aria-selected``: bool option with get, set
//     abstract ``aria-checked``: bool option with get, set
//     abstract ``aria-haspopup``: bool option with get, set
//     abstract ``aria-controls``: string option with get, set
//     abstract ``aria-labelledby``: string option with get, set
//     abstract ``aria-roledescription``: string option with get, set

// type [<RequireQualifiedAccess>] AccessibilityLiveRegion =
//     | None = 0
//     | Polite = 1
//     | Assertive = 2

// type [<RequireQualifiedAccess>] AccessibilityTrait =
//     | Summary = 0
//     | Adjustable = 1
//     | Button = 2
//     | Tab = 3
//     | Selected = 4
//     | Radio_button_checked = 5
//     | Radio_button_unchecked = 6
//     | Link = 7
//     | Header = 8
//     | Search = 9
//     | Image = 10
//     | Plays = 11
//     | Key = 12
//     | Text = 13
//     | Disabled = 14
//     | FrequentUpdates = 15
//     | StartsMedia = 16
//     | AllowsDirectInteraction = 17
//     | PageTurn = 18
//     | Menu = 19
//     | MenuItem = 20
//     | MenuBar = 21
//     | TabList = 22
//     | List = 23
//     | ListItem = 24
//     | ListBox = 25
//     | Group = 26
//     | CheckBox = 27
//     | Checked = 28
//     | ComboBox = 29
//     | Log = 30
//     | Status = 31
//     | Dialog = 32
//     | HasPopup = 33
//     | Option = 34
//     | Switch = 35
//     | None = 36

// type [<AllowNullLiteral>] CommonStyledProps<'T> =
//     inherit CommonProps
//     abstract style: StyleRuleSetRecursive<'T> option with get, set

// type [<AllowNullLiteral>] ButtonProps =
//     inherit CommonStyledProps<ButtonStyleRuleSet>
//     inherit CommonAccessibilityProps
//     abstract title: string option with get, set
//     abstract disabled: bool option with get, set
//     abstract delayLongPress: float option with get, set
//     abstract onAccessibilityTapIOS: Function option with get, set
//     abstract onContextMenu: (SyntheticEvent -> unit) option with get, set
//     abstract onPress: (SyntheticEvent -> unit) option with get, set
//     abstract onPressIn: (SyntheticEvent -> unit) option with get, set
//     abstract onPressOut: (SyntheticEvent -> unit) option with get, set
//     abstract onLongPress: (SyntheticEvent -> unit) option with get, set
//     abstract onHoverStart: (SyntheticEvent -> unit) option with get, set
//     abstract onHoverEnd: (SyntheticEvent -> unit) option with get, set
//     abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
//     abstract onFocus: (FocusEvent -> unit) option with get, set
//     abstract onBlur: (FocusEvent -> unit) option with get, set
//     abstract shouldRasterizeIOS: bool option with get, set
//     abstract disableTouchOpacityAnimation: bool option with get, set
//     abstract activeOpacity: float option with get, set
//     abstract underlayColor: string option with get, set
//     abstract id: string option with get, set
//     abstract ariaControls: string option with get, set

// type [<AllowNullLiteral>] PickerPropsItem =
//     abstract label: string with get, set
//     abstract value: string with get, set

// type [<AllowNullLiteral>] PickerProps =
//     inherit CommonProps
//     abstract items: ResizeArray<PickerPropsItem> with get, set
//     abstract selectedValue: string with get, set
//     abstract onValueChange: (string -> float -> unit) with get, set
//     abstract style: StyleRuleSetRecursive<PickerStyleRuleSet> option with get, set
//     abstract mode: U2<string, string> option with get, set

// type [<AllowNullLiteral>] ImagePropsShared =
//     inherit CommonProps
//     abstract source: string with get, set
//     abstract headers: obj option with get, set
//     abstract accessibilityLabel: string option with get, set
//     abstract resizeMode: U5<string, string, string, string, string> option with get, set
//     abstract resizeMethod: U3<string, string, string> option with get, set
//     abstract title: string option with get, set
//     abstract onLoad: (Dimensions -> unit) option with get, set
//     abstract onError: (Error -> unit) option with get, set
//     abstract shouldRasterizeIOS: bool option with get, set

// type [<AllowNullLiteral>] ImageProps =
//     inherit ImagePropsShared
//     abstract style: StyleRuleSetRecursive<ImageStyleRuleSet> option with get, set

// type [<AllowNullLiteral>] AnimatedImageProps =
//     inherit ImagePropsShared
//     abstract style: StyleRuleSetRecursive<U2<AnimatedImageStyleRuleSet, ImageStyleRuleSet>> option with get, set

// type [<AllowNullLiteral>] TextPropsShared =
//     inherit CommonProps
//     abstract selectable: bool option with get, set
//     abstract numberOfLines: float option with get, set
//     abstract allowFontScaling: bool option with get, set
//     abstract maxContentSizeMultiplier: float option with get, set
//     abstract ellipsizeMode: U3<string, string, string> option with get, set
//     abstract textBreakStrategy: U3<string, string, string> option with get, set
//     abstract importantForAccessibility: ImportantForAccessibility option with get, set
//     abstract onPress: (SyntheticEvent -> unit) option with get, set
//     abstract id: string option with get, set
//     abstract onContextMenu: (SyntheticEvent -> unit) option with get, set

// type [<AllowNullLiteral>] TextProps =
//     inherit TextPropsShared
//     abstract style: StyleRuleSetRecursive<TextStyleRuleSet> option with get, set

// type [<AllowNullLiteral>] AnimatedTextProps =
//     inherit TextPropsShared
//     abstract style: StyleRuleSetRecursive<U2<AnimatedTextStyleRuleSet, TextStyleRuleSet>> option with get, set

// type [<StringEnum>] [<RequireQualifiedAccess>] ViewLayerType =
//     | None
//     | Software
//     | Hardware

// type [<AllowNullLiteral>] ViewPropsShared =
//     inherit CommonProps
//     inherit CommonAccessibilityProps
//     abstract title: string option with get, set
//     abstract ignorePointerEvents: bool option with get, set
//     abstract blockPointerEvents: bool option with get, set
//     abstract shouldRasterizeIOS: bool option with get, set
//     abstract viewLayerTypeAndroid: ViewLayerType option with get, set
//     abstract restrictFocusWithin: bool option with get, set
//     abstract limitFocusWithin: bool option with get, set
//     abstract importantForLayout: bool option with get, set
//     abstract id: string option with get, set
//     abstract ariaLabelledBy: string option with get, set
//     abstract ariaRoleDescription: string option with get, set
//     abstract accessibilityLiveRegion: AccessibilityLiveRegion option with get, set
//     abstract animateChildEnter: bool option with get, set
//     abstract animateChildLeave: bool option with get, set
//     abstract animateChildMove: bool option with get, set
//     abstract onAccessibilityTapIOS: Function option with get, set
//     abstract onLayout: (ViewOnLayoutEvent -> unit) option with get, set
//     abstract onMouseEnter: (MouseEvent -> unit) option with get, set
//     abstract onMouseLeave: (MouseEvent -> unit) option with get, set
//     abstract onDragEnter: (DragEvent -> unit) option with get, set
//     abstract onDragOver: (DragEvent -> unit) option with get, set
//     abstract onDragLeave: (DragEvent -> unit) option with get, set
//     abstract onDrop: (DragEvent -> unit) option with get, set
//     abstract onMouseOver: (MouseEvent -> unit) option with get, set
//     abstract onMouseMove: (MouseEvent -> unit) option with get, set
//     abstract onPress: (SyntheticEvent -> unit) option with get, set
//     abstract onLongPress: (SyntheticEvent -> unit) option with get, set
//     abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
//     abstract onFocus: (FocusEvent -> unit) option with get, set
//     abstract onBlur: (FocusEvent -> unit) option with get, set
//     abstract disableTouchOpacityAnimation: bool option with get, set
//     abstract activeOpacity: float option with get, set
//     abstract underlayColor: string option with get, set

// type [<AllowNullLiteral>] ViewProps =
//     inherit ViewPropsShared
//     abstract style: StyleRuleSetRecursive<ViewStyleRuleSet> option with get, set
//     abstract onContextMenu: (SyntheticEvent -> unit) option with get, set
//     abstract onStartShouldSetResponder: (SyntheticEvent -> bool) option with get, set
//     abstract onMoveShouldSetResponder: (SyntheticEvent -> bool) option with get, set
//     abstract onStartShouldSetResponderCapture: (SyntheticEvent -> bool) option with get, set
//     abstract onMoveShouldSetResponderCapture: (SyntheticEvent -> bool) option with get, set
//     abstract onResponderGrant: (SyntheticEvent -> unit) option with get, set
//     abstract onResponderReject: (SyntheticEvent -> unit) option with get, set
//     abstract onResponderRelease: (SyntheticEvent -> unit) option with get, set
//     abstract onResponderStart: (TouchEvent -> unit) option with get, set
//     abstract onResponderMove: (TouchEvent -> unit) option with get, set
//     abstract onResponderEnd: (TouchEvent -> unit) option with get, set
//     abstract onResponderTerminate: (SyntheticEvent -> unit) option with get, set
//     abstract onResponderTerminationRequest: (SyntheticEvent -> bool) option with get, set

// type [<AllowNullLiteral>] AnimatedViewProps =
//     inherit ViewPropsShared
//     abstract style: StyleRuleSetRecursive<U2<AnimatedViewStyleRuleSet, ViewStyleRuleSet>> option with get, set

// type [<AllowNullLiteral>] GestureState =
//     abstract timeStamp: float with get, set

// type [<AllowNullLiteral>] MultiTouchGestureState =
//     inherit GestureState
//     abstract initialCenterClientX: float with get, set
//     abstract initialCenterClientY: float with get, set
//     abstract initialCenterPageX: float with get, set
//     abstract initialCenterPageY: float with get, set
//     abstract initialWidth: float with get, set
//     abstract initialHeight: float with get, set
//     abstract initialDistance: float with get, set
//     abstract initialAngle: float with get, set
//     abstract centerClientX: float with get, set
//     abstract centerClientY: float with get, set
//     abstract centerPageX: float with get, set
//     abstract centerPageY: float with get, set
//     abstract velocityX: float with get, set
//     abstract velocityY: float with get, set
//     abstract width: float with get, set
//     abstract height: float with get, set
//     abstract distance: float with get, set
//     abstract angle: float with get, set
//     abstract isComplete: bool with get, set

// type [<AllowNullLiteral>] ScrollWheelGestureState =
//     inherit GestureState
//     abstract clientX: float with get, set
//     abstract clientY: float with get, set
//     abstract pageX: float with get, set
//     abstract pageY: float with get, set
//     abstract scrollAmount: float with get, set

// type [<AllowNullLiteral>] PanGestureState =
//     inherit GestureState
//     abstract initialClientX: float with get, set
//     abstract initialClientY: float with get, set
//     abstract initialPageX: float with get, set
//     abstract initialPageY: float with get, set
//     abstract clientX: float with get, set
//     abstract clientY: float with get, set
//     abstract pageX: float with get, set
//     abstract pageY: float with get, set
//     abstract velocityX: float with get, set
//     abstract velocityY: float with get, set
//     abstract isComplete: bool with get, set

// type [<AllowNullLiteral>] TapGestureState =
//     inherit GestureState
//     abstract clientX: float with get, set
//     abstract clientY: float with get, set
//     abstract pageX: float with get, set
//     abstract pageY: float with get, set

// type [<RequireQualifiedAccess>] GestureMouseCursor =
//     | Default = 0
//     | Pointer = 1
//     | Grab = 2
//     | Move = 3

// type [<RequireQualifiedAccess>] PreferredPanGesture =
//     | Horizontal = 0
//     | Vertical = 1

// type [<AllowNullLiteral>] GestureViewProps =
//     inherit CommonStyledProps<ViewStyleRuleSet>
//     inherit CommonAccessibilityProps
//     abstract onPinchZoom: (MultiTouchGestureState -> unit) option with get, set
//     abstract onRotate: (MultiTouchGestureState -> unit) option with get, set
//     abstract onScrollWheel: (ScrollWheelGestureState -> unit) option with get, set
//     abstract mouseOverCursor: GestureMouseCursor option with get, set
//     abstract onPan: (PanGestureState -> unit) option with get, set
//     abstract onPanVertical: (PanGestureState -> unit) option with get, set
//     abstract onPanHorizontal: (PanGestureState -> unit) option with get, set
//     abstract onTap: (TapGestureState -> unit) option with get, set
//     abstract onDoubleTap: (TapGestureState -> unit) option with get, set
//     abstract preferredPan: PreferredPanGesture option with get, set
//     abstract panPixelThreshold: float option with get, set
//     abstract releaseOnRequest: bool option with get, set

// type [<AllowNullLiteral>] ScrollIndicatorInsets =
//     abstract top: float with get, set
//     abstract left: float with get, set
//     abstract bottom: float with get, set
//     abstract right: float with get, set

// type [<AllowNullLiteral>] ScrollViewProps =
//     inherit ViewProps
//     abstract style: StyleRuleSetRecursive<ScrollViewStyleRuleSet> option with get, set
//     abstract children: ReactNode option with get, set
//     abstract vertical: bool option with get, set
//     abstract horizontal: bool option with get, set
//     abstract justifyEnd: bool option with get, set
//     abstract onLayout: (ViewOnLayoutEvent -> unit) option with get, set
//     abstract onContentSizeChange: (float -> float -> unit) option with get, set
//     abstract onScroll: (float -> float -> unit) option with get, set
//     abstract onScrollBeginDrag: (unit -> unit) option with get, set
//     abstract onScrollEndDrag: (unit -> unit) option with get, set
//     abstract showsHorizontalScrollIndicator: bool option with get, set
//     abstract showsVerticalScrollIndicator: bool option with get, set
//     abstract scrollEnabled: bool option with get, set
//     abstract keyboardDismissMode: U3<string, string, string> option with get, set
//     abstract keyboardShouldPersistTaps: bool option with get, set
//     abstract scrollEventThrottle: float option with get, set
//     abstract bounces: bool option with get, set
//     abstract pagingEnabled: bool option with get, set
//     abstract snapToInterval: float option with get, set
//     abstract scrollsToTop: bool option with get, set
//     abstract overScrollMode: U3<string, string, string> option with get, set
//     abstract scrollIndicatorInsets: ScrollIndicatorInsets option with get, set
//     abstract tabNavigation: U3<string, string, string> option with get, set

// type [<AllowNullLiteral>] LinkProps =
//     inherit CommonStyledProps<LinkStyleRuleSet>
//     abstract title: string option with get, set
//     abstract url: string with get, set
//     abstract children: ReactNode option with get, set
//     abstract selectable: bool option with get, set
//     abstract numberOfLines: float option with get, set
//     abstract allowFontScaling: bool option with get, set
//     abstract maxContentSizeMultiplier: float option with get, set
//     abstract tabIndex: float option with get, set
//     abstract onPress: (RX.Types.SyntheticEvent -> string -> unit) option with get, set
//     abstract onLongPress: (RX.Types.SyntheticEvent -> string -> unit) option with get, set
//     abstract onHoverStart: (SyntheticEvent -> unit) option with get, set
//     abstract onHoverEnd: (SyntheticEvent -> unit) option with get, set

// type [<AllowNullLiteral>] TextInputPropsShared =
//     inherit CommonProps
//     inherit CommonAccessibilityProps
//     abstract autoCapitalize: U4<string, string, string, string> option with get, set
//     abstract autoCorrect: bool option with get, set
//     abstract autoFocus: bool option with get, set
//     abstract blurOnSubmit: bool option with get, set
//     abstract defaultValue: string option with get, set
//     abstract editable: bool option with get, set
//     abstract keyboardType: U4<string, string, string, string> option with get, set
//     abstract maxLength: float option with get, set
//     abstract multiline: bool option with get, set
//     abstract placeholder: string option with get, set
//     abstract placeholderTextColor: string option with get, set
//     abstract secureTextEntry: bool option with get, set
//     abstract value: string option with get, set
//     abstract allowFontScaling: bool option with get, set
//     abstract maxContentSizeMultiplier: float option with get, set
//     abstract keyboardAppearance: U3<string, string, string> option with get, set
//     abstract returnKeyType: U5<string, string, string, string, string> option with get, set
//     abstract disableFullscreenUI: bool option with get, set
//     abstract spellCheck: bool option with get, set
//     abstract selectionColor: string option with get, set
//     abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
//     abstract onFocus: (FocusEvent -> unit) option with get, set
//     abstract onBlur: (FocusEvent -> unit) option with get, set
//     abstract onPaste: (ClipboardEvent -> unit) option with get, set
//     abstract onChangeText: (string -> unit) option with get, set
//     abstract onSelectionChange: (float -> float -> unit) option with get, set
//     abstract onSubmitEditing: (unit -> unit) option with get, set
//     abstract onScroll: (float -> float -> unit) option with get, set

// type [<AllowNullLiteral>] TextInputProps =
//     inherit TextInputPropsShared
//     abstract style: StyleRuleSetRecursive<TextInputStyleRuleSet> option with get, set

// type [<AllowNullLiteral>] AnimatedTextInputProps =
//     inherit TextInputPropsShared
//     abstract style: StyleRuleSetRecursive<U2<AnimatedTextInputStyleRuleSet, TextInputStyleRuleSet>> option with get, set

// type [<AllowNullLiteral>] ActivityIndicatorProps =
//     inherit CommonStyledProps<ActivityIndicatorStyleRuleSet>
//     abstract color: string with get, set
//     abstract size: U4<string, string, string, string> option with get, set
//     abstract deferTime: float option with get, set

// type [<AllowNullLiteral>] WebViewNavigationState =
//     inherit Event
//     abstract canGoBack: bool with get, set
//     abstract canGoForward: bool with get, set
//     abstract loading: bool with get, set
//     abstract url: string with get, set
//     abstract title: string with get, set

// type [<AllowNullLiteral>] WebViewErrorState =
//     inherit WebViewNavigationState
//     abstract description: string with get, set
//     abstract domain: string with get, set
//     abstract code: string with get, set

// type [<RequireQualifiedAccess>] WebViewSandboxMode =
//     | None = 0
//     | AllowForms = 1
//     | AllowModals = 2
//     | AllowOrientationLock = 4
//     | AllowPointerLock = 8
//     | AllowPopups = 16
//     | AllowPopupsToEscapeSandbox = 32
//     | AllowPresentation = 64
//     | AllowSameOrigin = 128
//     | AllowScripts = 256
//     | AllowTopNavigation = 512

// type [<AllowNullLiteral>] WebViewSource =
//     abstract html: string with get, set
//     abstract baseUrl: string option with get, set

// type [<AllowNullLiteral>] WebViewProps =
//     inherit CommonStyledProps<WebViewStyleRuleSet>
//     abstract url: string option with get, set
//     abstract source: WebViewSource option with get, set
//     abstract headers: obj option with get, set
//     abstract onLoad: (SyntheticEvent -> unit) option with get, set
//     abstract onNavigationStateChange: (WebViewNavigationState -> unit) option with get, set
//     abstract scalesPageToFit: bool option with get, set
//     abstract injectedJavaScript: string option with get, set
//     abstract javaScriptEnabled: bool option with get, set
//     abstract startInLoadingState: bool option with get, set
//     abstract domStorageEnabled: bool option with get, set
//     abstract onShouldStartLoadWithRequest: (WebViewShouldStartLoadEvent -> bool) option with get, set
//     abstract onLoadStart: (SyntheticEvent -> unit) option with get, set
//     abstract onError: (SyntheticEvent -> unit) option with get, set
//     abstract onMessage: (WebViewMessageEvent -> unit) option with get, set
//     abstract sandbox: WebViewSandboxMode option with get, set

// type [<StringEnum>] [<RequireQualifiedAccess>] PopupPosition =
//     | Top
//     | Right
//     | Bottom
//     | Left

// type [<AllowNullLiteral>] PopupOptions =
//     abstract getAnchor: (unit -> React.Component<obj option, obj option>) with get, set
//     abstract renderPopup: (PopupPosition -> float -> float -> float -> ReactNode) with get, set
//     abstract getElementTriggeringPopup: (unit -> React.Component<obj option, obj option>) option with get, set
//     abstract onDismiss: (unit -> unit) option with get, set
//     abstract positionPriorities: ResizeArray<PopupPosition> option with get, set
//     abstract useInnerPositioning: bool option with get, set
//     abstract onAnchorPressed: (RX.Types.SyntheticEvent -> unit) option with get, set
//     abstract dismissIfShown: bool option with get, set
//     abstract preventDismissOnPress: bool option with get, set
//     abstract rootViewId: string option with get, set

// type [<AllowNullLiteral>] ModalOptions =
//     abstract rootViewId: string option with get, set

// type [<AllowNullLiteral>] AlertButtonSpec =
//     abstract text: string option with get, set
//     abstract onPress: (unit -> unit) option with get, set
//     abstract style: U3<string, string, string> option with get, set

// type [<AllowNullLiteral>] AlertModalTheme =
//     abstract bodyStyle: StyleRuleSet<ViewStyle> option with get, set
//     abstract titleTextStyle: StyleRuleSet<TextStyle> option with get, set
//     abstract messageTextStyle: StyleRuleSet<TextStyle> option with get, set
//     abstract buttonStyle: StyleRuleSet<ButtonStyle> option with get, set
//     abstract buttonHoverStyle: StyleRuleSet<ButtonStyle> option with get, set
//     abstract buttonTextStyle: StyleRuleSet<TextStyle> option with get, set
//     abstract cancelButtonStyle: StyleRuleSet<ButtonStyle> option with get, set
//     abstract cancelButtonHoverStyle: StyleRuleSet<ButtonStyle> option with get, set
//     abstract cancelButtonTextStyle: StyleRuleSet<TextStyle> option with get, set

// type [<AllowNullLiteral>] AlertOptions =
//     abstract icon: string option with get, set
//     abstract theme: AlertModalTheme option with get, set

// type [<RequireQualifiedAccess>] LocationErrorType =
//     | PermissionDenied = 1
//     | PositionUnavailable = 2
//     | Timeout = 3

// type LocationWatchId =
//     float

// type LocationSuccessCallback =
//     (Position -> unit)

// type LocationFailureCallback =
//     (LocationErrorType -> unit)

// module Animated =

//     type [<AllowNullLiteral>] IExports =
//         abstract timing: TimingFunction
//         abstract sequence: SequenceFunction
//         abstract ``parallel``: ParallelFunction

//     type ValueListenerCallback =
//         (U2<float, string> -> unit)

//     type EndResult =
//         obj

//     type EndCallback =
//         (EndResult -> unit)

//     type CompositeAnimation =
//         obj

//     type [<AllowNullLiteral>] LoopConfig =
//         abstract restartFrom: float with get, set

//     type [<AllowNullLiteral>] AnimationConfig =
//         abstract useNativeDriver: bool option with get, set
//         abstract isInteraction: bool option with get, set

//     type [<AllowNullLiteral>] TimingAnimationConfig =
//         inherit AnimationConfig
//         abstract toValue: float with get, set
//         abstract easing: EasingFunction option with get, set
//         abstract duration: float option with get, set
//         abstract delay: float option with get, set
//         abstract loop: LoopConfig option with get, set

//     type [<AllowNullLiteral>] InterpolationConfigType =
//         abstract inputRange: ResizeArray<float> with get, set
//         abstract outputRange: ResizeArray<U2<float, string>> with get, set

//     type TimingFunction =
//         (U2<RX.Types.AnimatedValue, RX.Types.InterpolatedValue> -> TimingAnimationConfig -> CompositeAnimation)

//     type SequenceFunction =
//         (Array<CompositeAnimation> -> CompositeAnimation)

//     type ParallelFunction =
//         (Array<CompositeAnimation> -> CompositeAnimation)

//     type EasingFunction =
//         obj

//     type [<AllowNullLiteral>] Easing =
//         abstract Default: unit -> EasingFunction
//         abstract Linear: unit -> EasingFunction
//         abstract Out: unit -> EasingFunction
//         abstract In: unit -> EasingFunction
//         abstract InOut: unit -> EasingFunction
//         abstract InBack: unit -> EasingFunction
//         abstract OutBack: unit -> EasingFunction
//         abstract InOutBack: unit -> EasingFunction
//         abstract StepStart: unit -> EasingFunction
//         abstract StepEnd: unit -> EasingFunction
//         abstract Steps: intervals: float * ?``end``: bool -> EasingFunction
//         abstract CubicBezier: x1: float * y1: float * x2: float * y2: float -> EasingFunction

// type SyntheticEvent =
//     obj

// type [<AllowNullLiteral>] ClipboardEvent =
//     inherit SyntheticEvent
//     abstract clipboardData: DataTransfer with get, set

// type FocusEvent =
//     SyntheticEvent

// type FormEvent =
//     SyntheticEvent

// type MouseEvent =
//     SyntheticEvent

// type [<AllowNullLiteral>] DragEvent =
//     inherit MouseEvent
//     abstract dataTransfer: DataTransfer with get, set

// type [<AllowNullLiteral>] Touch =
//     abstract identifier: float with get, set
//     abstract target: EventTarget with get, set
//     abstract locationX: float with get, set
//     abstract locationY: float with get, set
//     abstract screenX: float with get, set
//     abstract screenY: float with get, set
//     abstract clientX: float with get, set
//     abstract clientY: float with get, set
//     abstract pageX: float with get, set
//     abstract pageY: float with get, set

// type [<AllowNullLiteral>] TouchList =
//     [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> Touch with get, set
//     abstract length: float with get, set
//     abstract item: index: float -> Touch
//     abstract identifiedTouch: identifier: float -> Touch

// type [<AllowNullLiteral>] TouchEvent =
//     inherit SyntheticEvent
//     abstract altKey: bool with get, set
//     abstract changedTouches: TouchList with get, set
//     abstract ctrlKey: bool with get, set
//     abstract getModifierState: key: string -> bool
//     abstract metaKey: bool with get, set
//     abstract shiftKey: bool with get, set
//     abstract targetTouches: TouchList with get, set
//     abstract locationX: float option with get, set
//     abstract locationY: float option with get, set
//     abstract pageX: float option with get, set
//     abstract pageY: float option with get, set
//     abstract touches: TouchList with get, set

// type [<AllowNullLiteral>] WheelEvent =
//     inherit SyntheticEvent
//     abstract deltaMode: float with get, set
//     abstract deltaX: float with get, set
//     abstract deltaY: float with get, set
//     abstract deltaZ: float with get, set

// type [<AllowNullLiteral>] WebViewShouldStartLoadEvent =
//     inherit SyntheticEvent
//     abstract url: string with get, set

// type [<AllowNullLiteral>] WebViewNavigationEvent =
//     inherit SyntheticEvent
//     abstract nativeEvent: WebViewNavigationState with get, set

// type [<AllowNullLiteral>] WebViewErrorEvent =
//     inherit SyntheticEvent
//     abstract nativeEvent: WebViewErrorState with get, set

// type ViewOnLayoutEvent =
//     obj

// type [<AllowNullLiteral>] KeyboardEvent =
//     inherit SyntheticEvent
//     abstract ctrlKey: bool with get, set
//     abstract altKey: bool with get, set
//     abstract shiftKey: bool with get, set
//     abstract keyCode: float with get, set
//     abstract metaKey: bool with get, set
//     abstract key: string with get, set

// type [<AllowNullLiteral>] WebViewMessageEvent =
//     inherit SyntheticEvent
//     abstract data: string with get, set
//     abstract origin: string with get, set

// type Dimensions =
//     obj

// type [<AllowNullLiteral>] EmailInfo =
//     abstract ``to``: ResizeArray<string> option with get, set
//     abstract cc: ResizeArray<string> option with get, set
//     abstract bcc: ResizeArray<string> option with get, set
//     abstract subject: string option with get, set
//     abstract body: string option with get, set

// type [<AllowNullLiteral>] SmsInfo =
//     abstract phoneNumber: string option with get, set
//     abstract body: string option with get, set

// type [<RequireQualifiedAccess>] LinkingErrorCode =
//     | NoAppFound = 0
//     | UnexpectedFailure = 1
//     | Blocked = 2
//     | InitialUrlNotFound = 3

// type [<AllowNullLiteral>] LinkingErrorInfo =
//     abstract code: LinkingErrorCode with get, set
//     abstract url: string with get, set
//     abstract description: string option with get, set

type [<RequireQualifiedAccess>] AppActivationState =
    | Active = 1
    | Background = 2
    | Inactive = 3
    | Extension = 4

// type [<AllowNullLiteral>] LayoutInfo =
//     abstract x: float with get, set
//     abstract y: float with get, set
//     abstract width: float with get, set
//     abstract height: float with get, set

// type [<StringEnum>] [<RequireQualifiedAccess>] PlatformType =
//     | Web
//     | Ios
//     | Android
//     | Windows
//     | Macos

// type [<RequireQualifiedAccess>] DeviceNetworkType =
//     | Unknown = 0
//     | None = 1
//     | Wifi = 2
//     | Mobile2G = 3
//     | Mobile3G = 4
//     | Mobile4G = 5
