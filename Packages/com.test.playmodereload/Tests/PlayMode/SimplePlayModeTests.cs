using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SceneReloadRepro.Package
{
    // Case 2: tests live in a separate package, imported into the project
    
    public class SimplePlayModeTests
    {
        private static int _runCount = 0;

        [UnityTest]
        public IEnumerator SimplePlayModeTestPasses()
        {
            _runCount++;
            Debug.Log($"[SimplePlayModeTests] (package) runCount = {_runCount}");
            yield return null;
            Assert.Pass();
        }
    }
}
