[<NUnit.Framework.SetUpFixture>]
module LostTech.Gradient.Setup

open System
open Python.Runtime

[<NUnit.Framework.OneTimeSetUp>]
let SetUp () =
    let envSetting = Environment.GetEnvironmentVariable("GRADIENT_TEST_PYTHON_ENVIRONMENT")
    if envSetting <> null then
        GradientEngine.UseEnvironmentFromVariable("GRADIENT_TEST_PYTHON_ENVIRONMENT") |> ignore
    GradientEngine.EnsureInitialized() |> ignore
    PythonEngine.BeginAllowThreads() |> ignore