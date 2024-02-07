using System;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using FluentAssertions;

namespace netcore.template
{
    public class StepImplementation
    {
        [Step("Add to store")]
        public void AddToStore()
        {
           ScenarioDataStore.Add("test", "test_value");
        }

        [Step("Get from store")]
        public void GetFromStore()
        {
            var value = ScenarioDataStore.Get("test");
            value.Should().NotBeNull();
        }
    }
}
