// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    
    
// Null - conditional operator (?.)
// If 'message' is null, 'length' will be null; otherwise, it will be the length of 'message'.
string? message = null;
int? length = message?.Length;
Console.WriteLine(length); // Output: 

// Null-coalescing operator (??)
// If 'name' is null, 'displayName' will be "Default Name"; otherwise, it will be the value of 'name'.
string? name = null;
string displayName = name ?? "Default Name";
Console.WriteLine(displayName); // Output: Default Name

// Null-coalescing assignment operator (??=)
// If 'greeting' is null, it will be assigned "Hello, World!"; otherwise, it retains its original value.
string? greeting = null;
greeting ??= "Hello, World!";
Console.WriteLine(greeting); // Output: Hello, World!