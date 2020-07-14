using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UniRx;
using UniRx.Triggers;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using UnityEngine;
using UnityEditor;
using Rand = UnityEngine.Random;

public class EditorRestartUnity {
  [MenuItem("File/Restart")]
  static void RestartUnity() {
    var filename = EditorApplication.applicationPath;
    var arguments = "-projectPath " + Application.dataPath.Replace("/Assets", string.Empty);
    var startInfo = new ProcessStartInfo {
      FileName = filename,
      Arguments = arguments,
    };
    Process.Start(startInfo);
    EditorApplication.Exit(0);
  }
}
