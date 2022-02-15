using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ChatData/CharacterList")]
public class CharactersList : ScriptableObject
{
    public List<CharacterProfile> characters = new List<CharacterProfile>();
}
