using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(menuName = "ChatData/Chats")]
public class ChatData : ScriptableObject
{
    [ReorderableList]
    public List<Chat> chats = new List<Chat>();
}


