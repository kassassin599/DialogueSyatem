using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CharacterProfile))]
public class CharacterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var script = (CharacterProfile)target;

        if (GUILayout.Button("Save Profile", GUILayout.Height(30), GUILayout.Width(120)))
        {
            script.SaveProfile();
        }
    }
}
