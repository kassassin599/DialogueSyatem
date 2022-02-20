using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatBox : MonoBehaviour
{
    public Side side;

    [Header("Chat UI properties")]
    [SerializeField]
    TextMeshProUGUI dialogueText;

    [SerializeField]
    GameObject dialogue;

    [SerializeField]
    GameObject displayPic;

    [SerializeField]
    GameObject dialogueBGImage;
}
