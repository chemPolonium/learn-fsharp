﻿// 62 active patterns 对数据进行变形

open System.Drawing

let (|RGB|) (col: Color) = (col.R, col.G, col.B)

let (|HSB|) (col: Color) =
    (col.GetHue(), col.GetSaturation(), col.GetBrightness())

let printRGB (col: Color) =
    match col with
    | RGB(r, g, b) -> printfn "Red: %d Green: %d Blue: %d" r g b

let printHSB (col: Color) =
    match col with
    | HSB(h, s, b) -> printfn "Hue: %f Saturation: %f Brightness: %f" h s b

let printAll col colorString =
    printfn "%s" colorString
    printRGB col
    printHSB col

printAll Color.Red "Red"
printAll Color.Black "Black"
