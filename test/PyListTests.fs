module LostTech.Gradient.PyListTests

open LostTech.Gradient.BuiltIns
open NUnit.Framework

[<Test>]
let Length () =
    let list = PythonList<int>()

    Assert.AreEqual(0, PyList.length list)
    Assert.IsTrue(PyList.isEmpty list)

    list.Add(42)

    Assert.AreEqual(1, PyList.length list)
    Assert.IsFalse(PyList.isEmpty list)
