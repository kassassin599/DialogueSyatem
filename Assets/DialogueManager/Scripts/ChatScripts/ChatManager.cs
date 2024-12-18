﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    [Header("Chat object")]
    public ChatData chat;
    [Header("Character object")]
    //public CharacterProfile[] characters;
    public CharactersList charactersList;

    [Header("Chat UI properties")]
    [SerializeField]
    TextMeshProUGUI rightSideDialogueText;
    [SerializeField]
    TextMeshProUGUI leftSideDialogueText;

    [SerializeField]
    GameObject rightSideDialogue;
    [SerializeField]
    GameObject leftSideDialogue;

    [SerializeField]
    GameObject leftSideDisplayPic;
    [SerializeField]
    GameObject rightSideDisplayPic;

    [SerializeField]
    GameObject leftSideDialogueBGImage;
    [SerializeField]
    GameObject rightSideDialogueBGImage;

    [SerializeField]
    GameObject continueButton;

    [SerializeField]
    Sprite dialogueBG;
    [SerializeField]
    Sprite dialogueCompleteBG;

    int count = 0;

    List<CharacterProfile> characters = new List<CharacterProfile>();

    void Start()
    {
        DisplayNextSentence();

        characters = charactersList.characters;
    }

    public void DisplayNextSentence()
    {
        Debug.Log("Count-------->" + count);
        string sentence;

        if (count >= chat.chats.Count)
        {
            EndDialogue();
            return;
        }

        switch (chat.chats[count].chooseSide)
        {
            case Side.LeftSide:
                rightSideDialogue.SetActive(true);
                leftSideDialogue.SetActive(false);

                CharacterProfile bossSide = chat.chats[count].character;

                leftSideDisplayPic.GetComponent<Image>().sprite = bossSide.characterImage;

                sentence = chat.chats[count].sentence;

                rightSideDialogueText.text = sentence;
                StopAllCoroutines();
                StartCoroutine(TypeSentence(sentence, leftSideDialogueBGImage, rightSideDialogueText));
                break;
            case Side.RightSide:
                rightSideDialogue.SetActive(false);
                leftSideDialogue.SetActive(true);

                CharacterProfile playerSide = chat.chats[count].character;

                rightSideDisplayPic.GetComponent<Image>().sprite = playerSide.characterImage;

                sentence = chat.chats[count].sentence;

                leftSideDialogueText.text = sentence;
                StopAllCoroutines();
                StartCoroutine(TypeSentence(sentence, rightSideDialogueBGImage, leftSideDialogueText));
                break;
            default:
                break;
        }
        count++;
    }

    IEnumerator TypeSentence(string sentence, GameObject dialogueBGImage, TextMeshProUGUI text)
    {

        continueButton.GetComponent<Button>().interactable = false;
        dialogueBGImage.GetComponent<Image>().sprite = dialogueBG;
        text.text = "";

        char[] letters = sentence.ToCharArray();
        int length = 0;
        foreach (char letter in letters)
        {
            yield return new WaitForSecondsRealtime(.05f);
            text.text += letter;
            length++;
            if (letters.Length == length)
            {
                dialogueBGImage.GetComponent<Image>().sprite = dialogueCompleteBG;
                continueButton.GetComponent<Button>().interactable = true;
            }
        }
    }

    void EndDialogue()
    {
        print("End of conversation.");
    }
}
