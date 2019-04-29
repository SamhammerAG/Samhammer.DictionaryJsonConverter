using System;
using System.Collections.Generic;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Samhammer.DictionaryJsonConverter.Test
{
    public class DictionaryConverterTest
    {
        [Fact]
        public void ValuesAreDeserialized()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Flag = true,
                Number = 1234,
                Date = new DateTime(2018, 12, 31),
            });

            var expected = new Dictionary<string, object>()
            {
                { "Flag", true },
                { "Number", 1234 },
                { "Date", new DateTime(2018, 12, 31) },
            };

            var result = JsonConvert.DeserializeObject<IDictionary<string, object>>(json, new DictionaryConverter());
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ObjectsAreDeserialized()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Child = new
                {
                    Name = "test",
                },
            });

            var expected = new Dictionary<string, object>()
            {
                {
                    "Child", new Dictionary<string, object>()
                    {
                        { "Name", "test" },
                    }
                },
            };

            var result = JsonConvert.DeserializeObject<IDictionary<string, object>>(json, new DictionaryConverter());
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ListsAreDeserialized()
        {
            var json = JsonConvert.SerializeObject(new
            {
                List = new List<object>
                {
                    new { Value = "abc" },
                    new { Value = "def" },
                },
            });

            var expected = new Dictionary<string, object>()
            {
                {
                    "List", new List<object>
                    {
                        new Dictionary<string, object>() { { "Value", "abc" } },
                        new Dictionary<string, object>() { { "Value", "def" } },
                    }
                },
            };

            var result = JsonConvert.DeserializeObject<IDictionary<string, object>>(json, new DictionaryConverter());
            result.Should().BeEquivalentTo(expected);
        }
    }
}
