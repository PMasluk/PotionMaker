using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsRandomizing : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> items = new List<GameObject>();

    private GameObject currentObject;

    private int randomItem;
    public int RandomItem => randomItem;

    private void Start()
    {
        SetNewItem();
    }

    public void SetNewItem()
    {
        if (currentObject != null)
        {
            currentObject.SetActive(false);
        }

        int index = Random.Range(0, 5);
        GameObject obj = items[index];

        obj.SetActive(true);

        randomItem = index;

        currentObject = obj;
    }
}
