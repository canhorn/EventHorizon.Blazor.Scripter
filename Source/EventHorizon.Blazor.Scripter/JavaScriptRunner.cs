using System.Threading.Tasks;

namespace EventHorizon.Blazor.Scripter
{
    public interface JavaScriptRunner
    {
        ValueTask Run(
            string methodName,
            string script,
            object args
        );
    }
}
