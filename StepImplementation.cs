using System;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using FluentAssertions;

namespace netcore.template
{
    public class StepImplementation
    {
        /// <summary>
        /// This step will execute.
        /// </summary>
        [Step("Test")]
        public void Test()
        {
           ScenarioDataStore.Add("test", "test_value");
        }

        /// <summary>
        /// This step will freeze.
        /// </summary>
        [Step("Test async")]
        public void TestAsync()
        {
            var value = ScenarioDataStore.Get("test");
            value.Should().NotBeNull();
        }
    }
}
