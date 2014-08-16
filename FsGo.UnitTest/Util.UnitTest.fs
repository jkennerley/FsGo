namespace FsGo.UnitTest

open Xunit
open FsUnit.Xunit

open Util
open System.Diagnostics.CodeAnalysis

[<ExcludeFromCodeCoverage>]
type ``Util UnitTest``() = 

    [<Fact>]
    member this.``i2s 0 should -> "0"``() = 

        // Assert
        i2s 0 |> should equal "0" 
        ()

    [<Fact>]
    member this.``i2s 1 should -> "!0"``() = 
    
        // Assert
        i2s 1 |> should equal "!0" 
        ()
