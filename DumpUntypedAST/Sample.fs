let output1 (a: int, b: string, c: double) =
  System.Console.WriteLine("output1: {0}:{1}:{2}", a, b, c)

let output2 (a: int) (b: string) (c: double) =
  System.Console.WriteLine("output2: {0}:{1}:{2}", a, b, c)

let sample() =
  output1 (123, "ABC", 456.789)
  output2 123 "ABC" 456.789
