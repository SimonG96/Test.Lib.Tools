// Author: Simon Gockner
// Created: 2022-11-11
// Copyright(c) 2022 SimonG. All Rights Reserved.

using Lib.Tools;
using NUnit.Framework;

namespace Test.Lib.Tools;

[TestFixture]
public class DatesTest
{
    [Test]
    public void TestGetDatesOfWeekStartMonday()
    {
        DateTime dateTime = new(2022, 11, 7);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartTuesday()
    {
        DateTime dateTime = new(2022, 11, 8);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartWednesday()
    {
        DateTime dateTime = new(2022, 11, 9);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartThursday()
    {
        DateTime dateTime = new(2022, 11, 10);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartFriday()
    {
        DateTime dateTime = new(2022, 11, 11);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartSaturday()
    {
        DateTime dateTime = new(2022, 11, 12);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekStartSunday()
    {
        DateTime dateTime = new(2022, 11, 13);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(7));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(8));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(9));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(10));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(11));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(12));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(13));
        });
    }
    
    [Test]
    public void TestGetDatesOfWeekWeekOverlappingMonths()
    {
        DateTime dateTime = new(2022, 11, 2);
        List<DateTime> datesOfWeek = dateTime.GetDatesOfWeek();
        
        Assert.Multiple(() =>
        {
            Assert.That(datesOfWeek[0].Day, Is.EqualTo(31));
            Assert.That(datesOfWeek[1].Day, Is.EqualTo(1));
            Assert.That(datesOfWeek[2].Day, Is.EqualTo(2));
            Assert.That(datesOfWeek[3].Day, Is.EqualTo(3));
            Assert.That(datesOfWeek[4].Day, Is.EqualTo(4));
            Assert.That(datesOfWeek[5].Day, Is.EqualTo(5));
            Assert.That(datesOfWeek[6].Day, Is.EqualTo(6));
        });
    }
}