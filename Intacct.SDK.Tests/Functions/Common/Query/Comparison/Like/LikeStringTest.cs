﻿/*
 * Copyright 2022 Sage Intacct, Inc.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * or in the "LICENSE" file accompanying this file. This file is distributed on 
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
 * express or implied. See the License for the specific language governing 
 * permissions and limitations under the License.
 */

using Intacct.SDK.Functions.Common.Query.Comparison.Like;
using Xunit;

namespace Intacct.SDK.Tests.Functions.Common.Query.Comparison.Like
{
    public class LikeStringTest
    {
        [Fact]
        public void ToStringTest()
        {
            LikeString condition = new LikeString()
            {
                Field = "VENDORID",
                Value = "%123%",
            };
            
            Assert.Equal("VENDORID LIKE '%123%'", condition.ToString());
        }
        
        [Fact]
        public void ToStringNotTest()
        {
            LikeString condition = new LikeString()
            {
                Negate = true,
                Field = "VENDORID",
                Value = "%123%",
            };
            
            Assert.Equal("NOT VENDORID LIKE '%123%'", condition.ToString());
        }
        
        [Fact]
        public void ToStringEscapeQuotesTest()
        {
            LikeString condition = new LikeString()
            {
                Field = "VENDORNAME",
                Value = "%ob's Pizza%",
            };
            
            Assert.Equal("VENDORNAME LIKE '%ob\'s Pizza%'", condition.ToString());
        }
    }
}