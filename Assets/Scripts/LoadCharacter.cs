﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class LoadCharacter : MonoBehaviour
{
    private DynamicCharacterAvatar avatar;
    public int characterNumber;
    private string characterRecipe;

    void Start()
    {
        if (characterNumber == 0)
        {
            characterRecipe = SavedCharacters.savedCharacter0;
        }
        else if (characterNumber == 1)
        {
            characterRecipe = SavedCharacters.savedCharacter1;
        }
        else if (characterNumber == 2)
        {
            characterRecipe = SavedCharacters.savedCharacter2;
        }

        if (characterRecipe != null)
        {
            avatar = GetComponent<DynamicCharacterAvatar>();
            avatar.ClearSlots();
            avatar.LoadFromRecipeString(characterRecipe);
        }
    }
}
