var builder = WebApplication.CreateBuilder(args); // builder → prepare app

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build(); // app = builder.Build() → create app object

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
};

app.UseHttpsRedirection(); // app.UseHttpsRedirection() → force HTTPS

// MapGet Samples
app.MapGet("/hello", () => "Hello Friend"); // Basic Get
app.MapGet("/greet/{name}", (string name) => $"Hello, {name}"); // with route parameter
app.MapGet("/person", () => new {Name = "Sharks", Age = 28}); // return Json
app.MapGet("/sum/{a}/{b}", (int a, int b) => new {Sum = a + b}); // multiple parameters

// MapGet Activities
// exercise 1 – simple text
// create a GET endpoint /welcome that returns:
// Welcome to my API!
app.MapGet("/welcome", () => "Welcome to my API");

// exercise 2 – route parameter
// create a GET endpoint /square/{number} that returns the square of the number.
// example:
// GET /square/4
// response:
// { "result": 16 }
app.MapGet("/square/{n}", (int n) => new {result = n*n});

// exercise 3 – multiple route parameters
// create a GET endpoint /multiply/{a}/{b} that multiplies a and b.
// example:
// GET /multiply/5/6
// response:
// { "result": 30 }
app.MapGet("/multiply/{a}/{b}", (int a, int b) => new {result = a * b});

// exercise 4 – returning JSON object
// create a GET endpoint /book that returns:
// {
//   "Title": "The Alchemist",
//   "Author": "Paulo Coelho",
//   "Pages": 208
// }
app.MapGet("/book", () => new {Title = "The Alchemist", Author = "Paulo Coelho", Pages = 207});

// exercise 5 – optional route parameter
// create a GET endpoint /greet2/{name?} where name is optional.
// if name is provided → "Hello, {name}!"
// if not → "Hello, Guest!"
app.MapGet("/greet2/{name?}", (string? name) => name == null ? "Hello, Guest!" : $"Hello, {name}");

// exercise 6 – query parameter
// create a GET endpoint /add that accepts two query parameters: ?x=5&y=7 and returns their sum.
// example:
// GET /add?x=5&y=7
// response:
// { "sum": 12 }
app.MapGet("/add/{x}/{y}", (int x, int y) => new {sum = x + y});

// exercise 7 – array or list
// create a GET endpoint /colors that returns a list of 5 color names as JSON.
// example response
// ["Red", "Blue", "Green", "Yellow", "Purple"]
app.MapGet("/colors", () => new string[] {"Red", "Blue", "Green", "Yellow", "Purple"});

app.Run(); // app.Run() → start the server (should always be at the end)