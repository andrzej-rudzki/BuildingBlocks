// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Xunit;
using Hypar.Functions.Execution;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Hypar.Functions.Execution.Local;
using System;
using System.Collections.Generic;

namespace ColumnsByFloors.Tests
{
    public class FunctionTests
    {
        private readonly ITestOutputHelper output;

        public FunctionTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async Task InvokeFunction()
        {
            var root = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "../../../../");
            var config = Hypar.Functions.Function.FromJson(File.ReadAllText(Path.Combine(root, "hypar.json")));

            var store = new FileModelStore<ColumnsByFloorsInputs>(root, true);

            // Create an input object with default values.
            var input = new ColumnsByFloorsInputs();

            // Read local input files to populate incoming test data.
            if (config.ModelDependencies != null)
            {
                var modelInputKeys = new Dictionary<string, string>();
                foreach (var dep in config.ModelDependencies)
                {
                    modelInputKeys.Add(dep.Name, $"{dep.Name}.json");
                }
                input.ModelInputKeys = modelInputKeys;
            }

            // Invoke the function.
            // The function invocation uses a FileModelStore
            // which will write the resulting model to disk.
            // You'll find the model at "./model.gltf"
            var l = new InvocationWrapper<ColumnsByFloorsInputs, ColumnsByFloorsOutputs>(store, ColumnsByFloors.Execute);
            await l.InvokeAsync(input);
        }
    }
}