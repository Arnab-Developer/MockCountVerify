using MockCountVerify.ConsoleApp;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MockCountVerify.ConsoleAppTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

ILogger logger = new Logger();
Worker worker = new(logger);
worker.DoWork();