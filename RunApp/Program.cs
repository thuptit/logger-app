using RealPattern.Logger;
using RealPattern.Middleware;

var logger = LoggerFactory.CreateLogger("FILE");
logger.Log("RealPattern","Hello", "Run Program");

var app = new PipelineMiddleware();
app.AddMiddleware(new FirstMiddleware());
app.AddMiddleware(new RoutingMiddleware());
app.AddMiddleware(new CustomMiddleware());
app.Run();