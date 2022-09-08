using NUnit.Framework;

using TestDateFormat;

namespace Test;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ValidatingFormateDate()
    {
       string TestCorrectDate = "10/08/2022" ;
       DateFormatter.ChangeFormat(TestCorrectDate);
       Assert.AreEqual("2022-08-10", DateFormatter.ChangeFormat(TestCorrectDate));
       
    }

    [Test]
    public void ValidatingEmptyDate()
    {
    
       string TestEmptyDate = "" ;
       DateFormatter.ChangeFormat(TestEmptyDate);
       Assert.AreEqual("Error",DateFormatter.ChangeFormat(TestEmptyDate));
       
    }

    [Test]
    public void ValidatingCorrectOrder()
    {
    
       string ValidatingCorrectOrder = "08/2022/10" ;
       DateFormatter.ChangeFormat(ValidatingCorrectOrder);
       Assert.AreEqual("Incorrect Format Order",DateFormatter.ChangeFormat(ValidatingCorrectOrder));
       
    }



    
}