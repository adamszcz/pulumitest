using System.Threading;
using System.Threading.Tasks;
using Pulumi.Experimental.Provider;
using Pulumi;


public static class Program {
    public static Task Main(string[] args) {
        return Provider.Serve(args, "0.0.1", host => new TestProvider(host), CancellationToken.None);
    }
}
