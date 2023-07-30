using System.Collections.Generic;
using UnityEngine;

public class PotionListMaker : Singleton<PotionListMaker>
{
    [SerializeField]
    private List<int> potionInPot = new List<int>();

    public void AddToList(int index)
    {
        potionInPot.Add(index);
    }

    public List<int> GettingList()
    {
        return potionInPot;
    }
    
}
