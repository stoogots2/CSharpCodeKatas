
using System;
using NUnit.Framework;
namespace Basic.Vowel_Count;

[TestFixture]
public class Vowel_Count_Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Vowel_Count.GetVowelCount("abracadabra"));
    }
}

