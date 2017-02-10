using System;
using NUnit.Framework;

[TestFixture]
public class SqInRectTests
{

    [Test]
    public void Test1()
    {
        int[] r = new int[] { 3, 2, 1, 1 };
        Assert.AreEqual(r, SqInRect.sqInRect(5, 3));
    }
    [Test]
    public void Test3()
    {
        Assert.AreEqual(null, SqInRect.sqInRect(5, 5));
    }
}

