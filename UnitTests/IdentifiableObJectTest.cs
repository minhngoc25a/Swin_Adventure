using NUnit.Framework;
using SwinAdventure;

namespace UnitTests;

[TestFixture]
public class IdentifiableObjectTest
{
    [Test]
    public void TestAreYou()
    {
        var id = new IdentifiableObject(new[] { "fred", "bob" });
        Assert.IsTrue(id.AreYou("fred"));
    }

    [Test]
    public void TestNotAreYou()
    {
        var id = new IdentifiableObject(new[] { "fred", "bob" });
        Assert.IsFalse(id.AreYou("wilma"));
    }

    [Test]
    public void TestCaseSensitive()
    {
        var id = new IdentifiableObject(new[] { "fred", "bob" });
        Assert.IsTrue(id.AreYou("fReD"));
    }

    [Test]
    public void TestFirstId()
    {
        var id = new IdentifiableObject(new[] { "fred", "bob" });
        id.AddIdentifier("wilma");
        Assert.IsTrue(id.AreYou("fred"));
    }

    [Test]
    public void TestAddId()
    {
        var id = new IdentifiableObject(new[] { "fred", "bob" });
        id.AddIdentifier("wilma");
        Assert.IsTrue(id.AreYou("wilma"));
    }
}