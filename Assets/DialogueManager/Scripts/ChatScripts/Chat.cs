using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Chat
{
    public CharacterProfile character;


    public Side chooseSide = Side.LeftSide;

    [TextArea(3, 10)]
    public string sentence;
}
public enum Side { LeftSide, RightSide }
