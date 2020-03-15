using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace EventHorizon.Blazor.Scripter
{
    public class JavaScriptInteropRunner : JavaScriptRunner
    {
        readonly IJSRuntime _runtime;

        public JavaScriptInteropRunner(
            IJSRuntime runtime
        )
        {
            _runtime = runtime;
        }

        public ValueTask Run(
            string methodName,
            string script,
            object args
        )
        {
            return _runtime.InvokeVoidAsync(
                "scripter.runScript",
                new JavaScriptMethodRunner
                {
                    MethodName = methodName,
                    Script = script,
                    Args = args
                }
            );
        }
    }

    public struct JavaScriptMethodRunner
    {
        public string MethodName { get; set; }
        public string Script { get; set; }
        public object Args { get; set; }
    }
}
