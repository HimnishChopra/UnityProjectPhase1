using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int CurrentOption = 0;
    
    public void NextOption()
    {
        CurrentOption++;
        if(CurrentOption >= options.Count)
        {
            CurrentOption = 0;
        }
        bodyPart.sprite = options[CurrentOption];
    }

    public void PreviousOption()
    {
        CurrentOption--;
        if (CurrentOption >= options.Count)
        {
            CurrentOption = options.Count -1;
        }
        bodyPart.sprite = options[CurrentOption];
    }
}
