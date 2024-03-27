namespace designpatterns.Factory;
using System;

Public class FilereadOperation : IFileoperations
{
    Public void Execute(String filepath)
    {
        String content  = File.ReadAllText(filepath);
    }
}
