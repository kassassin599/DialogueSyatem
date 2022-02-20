using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ChatData/Character")]
public class CharacterProfile : ScriptableObject
{
    public string characterName;

    public Sprite characterImage;

    public CharactersList charactersList;

    public void SaveProfile()
    {
        characterName = this.name;
        if (charactersList != null && !charactersList.characters.Contains(this))
        {
            charactersList.characters.Add(this);

        }
        else
        {
            Debug.LogError("Please provide characters list or the character already present in the list.");
        }
    }
}
