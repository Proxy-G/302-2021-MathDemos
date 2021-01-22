using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Powers_LerpDemo))]
public class Powers_LerpDemoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI(); //draws normal part of editor

        Powers_LerpDemo lerper = (Powers_LerpDemo) target;

        if (GUILayout.Button("PLAY"))
        {
            lerper.PlayTweenAnim();
        }
    }
}
