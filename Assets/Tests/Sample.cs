using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Sample
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SampleSimplePasses()
        {
            Assert.AreEqual(true, true);
        }

        
    }
}
