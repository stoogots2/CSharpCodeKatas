
using NUnit.Framework;
using System;

namespace Basic.Convert_a_string_to_an_array;

[TestFixture]
public class Convert_a_string_to_an_array_Tests
{
    [Test]
    public void _1_Example()
    {
        Assert.AreEqual(new string[] { "Robin", "Singh" }, Convert_a_string_to_an_array.StringToArray("Robin Singh"));
    }

    [Test]
    public void _2_Example()
    {
        Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, Convert_a_string_to_an_array.StringToArray("I love arrays they are my favorite"));
    }
}
 