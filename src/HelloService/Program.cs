using ClassLibrary;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new MessageService().GetMessage(MessageKind.Hello));

app.Run();
