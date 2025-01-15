// Author: Simon.Gockner
// Created: 2024-03-08
// Copyright(c) 2024 SimonG. All Rights Reserved.

using Lib.Tools;
using NUnit.Framework;

namespace Test.Lib.Tools;

[TestFixture]
public class EnumerablesTest
{
    [Test]
    public void TestMaintainNormalUpdate()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["2", "3", "5", "6"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
    
    [Test]
    public void TestMaintainItemsAdded()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["1", "2", "3", "4", "5", "6", "7"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
    
    [Test]
    public void TestMaintainBeginningRemoved()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["3", "4", "5"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
    
    [Test]
    public void TestMaintainMiddleRemoved()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["1", "3", "5"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
    
    [Test]
    public void TestMaintainRemovedAndReordered()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["5", "1", "3"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
    
    [Test]
    public void TestMaintainRemovedReorderedAdded()
    {
        List<string> list = ["1", "2", "3", "4", "5"];
        List<string> updatedList = ["7", "4", "1", "3", "2", "6", "5"];

        list.Maintain(updatedList);
        
        Assert.That(list, Is.EquivalentTo(updatedList));
    }
}