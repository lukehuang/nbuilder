﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace FizzWare.NBuilder.Tests.Unit.Picking
{
    
    public class UniqueRandomPickerTests
    {
        [Fact]
        public void UniqueRandomPickerShouldBeAbleToPickEntireList()
        {
            var testInput = new[] { 1, 2, 3, 4 };

            var results = Pick<int>.UniqueRandomList(testInput.Length).From(testInput);

            results.Count.ShouldBe(testInput.Length);
        }
    }
}