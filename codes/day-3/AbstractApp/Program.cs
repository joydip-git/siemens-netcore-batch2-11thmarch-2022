using AbstractApp;

//up-casting
//you can call only explicitly interface members implemented in the class
//You can't invoke any explicit member of the child class (Except the implemented members of the interace)
IOperations operations = new Operations();
operations.Add(12, 13);
Console.WriteLine(operations.Result);

//up-casting
//you can call only explicitly abstract as well as non-abstract members either inherited or implemented in the child class
//You can't invoke any explicit member of the child class (Except the overriden members)
Contract contract = new Implementation();
contract.Name = "joydip";
contract.Foo();

//created an instance of child class of base abstract class Array
int[] numbers = new int[3];
Console.WriteLine(numbers.GetType()?.BaseType?.Name);