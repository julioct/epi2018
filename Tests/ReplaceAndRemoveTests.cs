using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class ReplaceAndRemoveTests
    {
        [Fact]
        public void CanReplaceAndRemove()
        {
            var s = "abac ";
            var A = s.ToCharArray();
            var size = 4;

            char[] expected = {'d','d','d','d','c'};
            ReplaceAndRemoveSolution.ReplaceAndRemove(A, size);
            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], A[i]);
            }
        }

        [Fact]
        public void CanReplace(){
            var s = "acaa   ";
            var A = s.ToCharArray();
            var size = 4;

            char[] expected = {'d','d','c','d','d','d','d'};
            ReplaceAndRemoveSolution.ReplaceAndRemove(A, size);
            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], A[i]);
            }            
        }
    }
}
