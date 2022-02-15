using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatSpawner : MonoBehaviour
{
    [Header("Chat object")]
    public ChatData chat;

    public GameObject leftChatBoxPrefab;
    public GameObject rightChatBoxPrefab;


    [SerializeField]
    GameObject continueButton;

    [SerializeField]
    Sprite dialogueBG;
    [SerializeField]
    Sprite dialogueCompleteBG;
}
