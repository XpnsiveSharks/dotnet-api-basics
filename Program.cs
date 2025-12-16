var builder = WebApplication.CreateBuilder(args); // builder → prepare app

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(); // register controllers in our services
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build(); // app = builder.Build() → create app object

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
};

app.UseHttpsRedirection(); // app.UseHttpsRedirection() → force HTTPS
app.MapControllers(); // maps all our controllers
app.Run(); // app.Run() → start the server (should always be at the end)