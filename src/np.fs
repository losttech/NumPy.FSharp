module numpy.np

open System.Collections.Generic

open LostTech.Gradient

open numpy

let private tupleToList<'a> tuple =
    let result = List<'a>(capacity=8)
    let tuples = Queue(capacity=1)
    tuples.Enqueue(tuple)

    while tuples.Count > 0 do
        let current = tuples.Dequeue()
        for field in current.GetType().GetFields() do
            let value = field.GetValue(current)
            if field.Name = "Rest" then
                tuples.Enqueue(value)
            else
                result.Add(unbox value)

    result

let shape (arr: I_ArrayLike) =
    tupleToList<int> arr.shape
    |> List.ofSeq
    |> List.map nativeint

let shape32 (arr: I_ArrayLike) =
    shape arr
    |> List.map int

let reshape newShape (arr: 'arr when 'arr :> Indarray) =
    arr.reshape (PyList.ofSeq newShape) :?> 'arr
