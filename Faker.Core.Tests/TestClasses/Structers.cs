﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Core.Tests.TestClasses
{
    public struct TestCtorStruct
    {
        public int Int { get; }
        public string String { get; set; }

        public TestCtorStruct(int intValue, string stringValue)
        {
            Int = intValue;
            String = stringValue;
        }
    }

    public struct TestInitStruct
    {
        public decimal Decimal { get; set; }
        public bool Bool { get; set; }
    }
}
