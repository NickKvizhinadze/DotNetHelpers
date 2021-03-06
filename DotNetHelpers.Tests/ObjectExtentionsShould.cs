﻿using System;
using Xunit;
using DotNetHelpers.Extentions;

namespace DotNetHelpers.Tests
{
    public class ObjectExtentionsShould
    {
        [Fact]
        public void ThrowArgumentNullExceptionWhenObjectIsNull()
        {
            string obj = null;

            void action() => obj.ThrowIfNull(nameof(obj));

            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
