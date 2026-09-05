using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SceneReloadRepro
{
    // Case 1: tests live directly in the project (Assets/Tests/PlayMode)
    
    public class SimplePlayModeTests
    {
        private static int _runCount = 0;

        [UnityTest]
        public IEnumerator SimplePlayModeTestPasses()
        {
            _runCount++;
            Debug.Log($"[SimplePlayModeTests] (project) runCount = {_runCount}");
            yield return null;
            Assert.Pass();
        }
    }
}
