﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class CharacterClothes : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    public SelectModel selectModel;
    public Dictionary<string, DnaSetter> dna;
    private string currentSlot;
    private string currentRecipe;

    public void SetSlot(string slot)
    {
        currentSlot = slot;
    }

    public void SetRecipe(string recipe)
    {
        currentRecipe = recipe;
        UpdateClothes();
    }

    public void UpdateClothes()
    {
        character = selectModel.character;
        if (currentSlot == "Body")
        {
            character.ClearSlot("Chest");
            character.ClearSlot("Legs");
        }
        else
        {
            character.ClearSlot("Body");
            character.ClearSlot(currentSlot);
        }

        if (currentRecipe != "Remove")
        {
            character.SetSlot(currentSlot, currentRecipe);
        }
        character.BuildCharacter();
    }
}
