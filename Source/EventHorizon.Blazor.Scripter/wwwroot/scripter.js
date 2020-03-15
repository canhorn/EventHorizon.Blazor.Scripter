// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

((_window) => {
    const methodCache = {};

    _window.scripter = {
        runScript: (methodRunner) => {
            methodCache[methodRunner.methodName] = new Function(
                "$args",
                methodRunner.script
            );
            methodCache[methodRunner.methodName](methodRunner.args);
        },
    };

})(window);
