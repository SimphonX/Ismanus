using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

[System.Serializable]
public class Data : ScriptableObject
{
    public Data data = null;

    public string Name;
    public double score;
}
