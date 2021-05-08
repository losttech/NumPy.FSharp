module LostTech.NumPy.NpTests

open NUnit.Framework

open numpy

[<Test>]
let ShapeZero () =
    let arr = new float32(42.)

    let shape = np.shape arr

    Assert.AreEqual([], shape)

[<Test>]
let ShapeSingle () =
    let arr = np.zeros<int>(2)

    let shape = np.shape arr

    Assert.AreEqual([2n], shape)

[<Test>]
let ShapeMultiple () =
    let arr = np.zeros<int>(2,2)

    let shape = np.shape arr

    Assert.AreEqual([2n;2n], shape)

[<Test>]
let Reshape() =
    let arr = np.zeros<int>(2,2)

    let reshaped = np.reshape [4;1] arr

    Assert.AreEqual([4;1], np.shape32 reshaped)
