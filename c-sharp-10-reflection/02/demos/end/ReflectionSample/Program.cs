using System.Reflection;

Console.Title = "Learning Reflection";

//string name = "Kevin";
//var stringType = name.GetType();
//var stringType = typeof(string);
//Console.WriteLine(stringType);

var currentAssembly = Assembly.GetExecutingAssembly();
var typesFromCurrentAssembly = currentAssembly.GetTypes();
foreach (var type in typesFromCurrentAssembly)
{
    Console.WriteLine(type.Name);
}

var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionSample.Person");

foreach (var constructor in oneTypeFromCurrentAssembly.GetConstructors())
{
    Console.WriteLine(constructor);
}
foreach (var method in oneTypeFromCurrentAssembly.GetMethods(
    BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($"{method}, public: {method.IsPublic}");
}

foreach (var field in oneTypeFromCurrentAssembly.GetFields(
    BindingFlags.Instance | BindingFlags.NonPublic))
{
    Console.WriteLine(field);
}


//var externalAssembly = Assembly.Load("System.Text.Json");
//var typesFromExternalAssembly = externalAssembly.GetTypes();
//var oneTypeFromExternalAssembly = externalAssembly.GetType("System.Text.Json.JsonProperty");

//var modulesFromExternalAssembly = externalAssembly.GetModules();
//var oneModuleFromExternalAssembly = externalAssembly.GetModule("System.Text.Json.dll");

//var typesFromModuleFromExternalAssembly = oneModuleFromExternalAssembly?.GetTypes();
//var oneTypeFromModuleFromExternalAssembly = oneModuleFromExternalAssembly
//    .GetType("System.Text.Json.JsonProperty");


Console.ReadLine();