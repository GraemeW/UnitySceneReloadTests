# Scene-only reload / testCaseCount=0 repro kit

Two minimal PlayMode test setups for reproducing the "tests run once, then `testCaseCount=0` forever" issue when Enter Play Mode Settings is configured to skip domain reload ("Reload Scene Only").

## Contents

- `project-tests/Assets/Tests/PlayMode/` — Case 1: tests live directly in the project
- `package-tests/com.test.playmodereload/` — Case 2: tests live in a standalone package, to be imported into the project

## Repro steps (run for each case)

1. `Edit > Project Settings > Editor > Enter Play Mode Settings` — set the reload behavior to "Reload Scene Only"
2. Open `Window > General > Test Runner`, go to the PlayMode tab
3. Run `UnitySceneReloadTests`
   * Note the reported `testCaseCount` and the `runCount` value logged to the Console
4. Without restarting the editor or touching domain-reload-triggering settings, run it again
   * Tests will not be run, as testCaseCount will register as "0"
