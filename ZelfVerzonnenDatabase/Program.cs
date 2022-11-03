using Microsoft.EntityFrameworkCore.Design;
using ZelfVerzonnenDatabase.Common;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Business bussiness = new Business();

bussiness.GetTeacherAsync();