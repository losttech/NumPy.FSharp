module LostTech.Gradient.PyList

open LostTech.Gradient.BuiltIns

// TODO: return unativeint
let length (list: _ PythonList) = list.DynamicInvoke<int>("__len__")
let isEmpty (list: _ PythonList) = length list = 0

let ofSeq seq = PythonList(seq)
let ofArray (array: _ array) = PythonList(array)

let toList (list: _ PythonList) = List.ofSeq list
let toArray (list: _ PythonList) =
    let result = Array.zeroCreate list.Count
    list.CopyTo(result, 0)
    result
