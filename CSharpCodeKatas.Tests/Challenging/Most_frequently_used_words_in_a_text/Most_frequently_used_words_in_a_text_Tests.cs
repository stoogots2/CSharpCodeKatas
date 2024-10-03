
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Most_frequently_used_words_in_a_text;
public class Most_frequently_used_words_in_a_text_Tests
{

    [Test]
    public void SampleTests()
    {
        Assert.AreEqual(new List<string> { "e", "d", "a" }, TopWords.Top3("a a a  b  c c  d d d d  e e e e e"));
        Assert.AreEqual(new List<string> { "e", "ddd", "aa" }, TopWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
        Assert.AreEqual(new List<string> { "won't", "wont" }, TopWords.Top3("  //wont won't won't "));
        Assert.AreEqual(new List<string> { "e" }, TopWords.Top3("  , e   .. "));
        Assert.AreEqual(new List<string> { }, TopWords.Top3("  ...  "));
        Assert.AreEqual(new List<string> { }, TopWords.Top3("  '  "));
        Assert.AreEqual(new List<string> { }, TopWords.Top3("  '''  "));
    }
}
