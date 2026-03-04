// Author: Simon.Gockner
// Created: 2026-03-04
// Copyright(c) 2026 SimonG. All Rights Reserved.

using Lib.Tools;
using NUnit.Framework;

namespace Test.Lib.Tools;

[TestFixture]
public class EnumsTest
{
    [Test]
    public void TestGetAttribute()
    {
        string description = TestEnum.FirstValue.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description;
        Assert.That(description, Is.EqualTo("First Value"));
    }

    [Test]
    public void TestGetAttributeForAllValues()
    {
        Type enumType = typeof(TestEnum);

        List<string> descriptions = [];
        foreach (Enum value in enumType.GetEnumValues().OfType<Enum>())
        {
            string description = value.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description;
            descriptions.Add(description);
        }

        using (Assert.EnterMultipleScope())
        {
            Assert.That(descriptions[0], Is.EqualTo("First Value"));
            Assert.That(descriptions[1], Is.EqualTo("Second Value"));
            Assert.That(descriptions[2], Is.EqualTo("Third Value"));
        }
    }
}

internal enum TestEnum
{
    [System.ComponentModel.Description("First Value")]
    FirstValue,
    
    [System.ComponentModel.Description("Second Value")]
    SecondValue,
    
    [System.ComponentModel.Description("Third Value")]
    ThirdValue
}