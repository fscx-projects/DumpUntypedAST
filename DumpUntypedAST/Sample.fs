open System

type AspectContext() =
  member __.Leave(result: 'T) =
    Console.WriteLine("Result={0}", result)
    result
  member __.Caught(ex: exn) =
    Console.WriteLine("Exception={0}", ex)

type Aspect() =
  static member Enter(name: string, line: int, column: int, args: obj[]) =
    Console.WriteLine("{0}({1},{2}): {3}", name, line, column, String.Join(",", args))
    new AspectContext()

let original = 
  System.String.Format("ABC", 123, 456, 789)

let filtered =
  let arg0 = "ABC"
  let arg1 = 123
  let arg2 = 456
  let arg3 = 789
  let context = Aspect.Enter("Sample.fs", 12, 34, [|arg0;arg1;arg2;arg3|])
  try
    context.Leave(System.String.Format(arg0, arg1, arg2, arg3))
  with
  | ex ->
    context.Caught(ex)
    reraise()
