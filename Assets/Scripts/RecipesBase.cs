using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipesBase : Singleton<RecipesBase>
{
    [SerializeField]
    private List<Recipe> recipies = new List<Recipe>();
    [SerializeField]
    private DragAndDrop[] dragsAndDrops;

    [SerializeField]
    private ItemsRandomizing randomizerItems;

    [SerializeField]
    private ParticleSystem potParticleNeutral;
    [SerializeField]
    private ParticleSystem potParticleGood;
    [SerializeField]
    private ParticleSystem potParticleBad;

    private int currentRecipeIndex = 0;

    private void Start()
    {
        potParticleBad.Stop();
        potParticleGood.Stop();
    }


    public void CompareIngradientWithRecipe(int ingradientIndex)
    {
        if (recipies[randomizerItems.RandomItem].ingradients[currentRecipeIndex] == ingradientIndex)
        {
            potParticleGood.Play();
            currentRecipeIndex++;
            if (currentRecipeIndex >= recipies[randomizerItems.RandomItem].ingradients.Count)
            {
                randomizerItems.SetNewItem();
                currentRecipeIndex = 0;
                StartCoroutine(ResetAllDragsAndDrops());
            }
        }
        else
        {
            potParticleBad.Play();
            currentRecipeIndex = 0;
            StartCoroutine(ResetAllDragsAndDrops());
        }
        
    }

    private IEnumerator ResetAllDragsAndDrops()
    {
        yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
        foreach (DragAndDrop dragAndDrop in dragsAndDrops)
        {
            dragAndDrop.Restart();
        }
    }
    
}

[Serializable]
public class Recipe
{
    public List<int> ingradients = new List<int>();
}


//ITEMS

//A
//niebieski 4
//zielony 3
//żółty 0

//B
//fiolet 2
//czerwony 1
//rozowy 5

//C
//zielony 3
//niebieski 4

//D
//zielony 3
//fioletowy 2
//niebieski 4

//E
//fioletowy 2
//rozowy 5
//zotly 0
//czerwony 1
