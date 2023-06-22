using CodeChallenge.Challenges;

//--------------Two Numbers--------------
var exm1 = TwoNumbers.TwoSum(new[] { 2, 7, 11, 15 }, 9);
Console.WriteLine($"[{string.Join(",", exm1)}]");


var exm2 = TwoNumbers.TwoSum(new[] { 3, 2, 4 }, 6);
Console.WriteLine($"[{string.Join(",", exm2)}]");

var exm3 = TwoNumbers.TwoSum(new[] { 3, 3 }, 6);
Console.WriteLine($"[{string.Join(",", exm3)}]");

//--------------Two Numbers--------------
Console.ReadKey();