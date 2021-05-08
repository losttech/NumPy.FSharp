[<NUnit.Framework.SetUpFixture>]
module LostTech.NumPy.Setup

open System

open LostTech.Gradient

[<NUnit.Framework.OneTimeSetUp>]
let SetUp () =
    let envSetting = Environment.GetEnvironmentVariable("GRADIENT_TEST_PYTHON_ENVIRONMENT")
    if envSetting <> null then
        GradientEngine.UseEnvironmentFromVariable("GRADIENT_TEST_PYTHON_ENVIRONMENT") |> ignore
    GradientEngine.EnsureInitialized() |> ignore
