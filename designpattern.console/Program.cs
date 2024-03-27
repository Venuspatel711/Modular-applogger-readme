using designpatterns.Factory;

Console.WriteLine("please type a command: (read, write)");
String Console.ReadLine();

var opration = FileOperationFactory.CreateOperation(command);
Console.WriteLine("please enter a filepath");
String file = Console.ReadLine();

operation.Execute(file);

