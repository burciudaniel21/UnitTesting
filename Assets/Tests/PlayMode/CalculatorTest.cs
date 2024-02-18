using NUnit.Framework;

public class CalculatorTest
{
    [Test]
    public void TestIncrement()
    {
        //Assign
        var counter = new BasicCounter(0);
        //Act
        counter.Increment();
        //Assert
        Assert.AreEqual(1, counter.Count);
    }

    [Test]
    public void TestMaxCount() { var counter = new BasicCounter(10); counter.Increment(); Assert.AreEqual(10, counter.Count); }
}
