using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseBook : MonoBehaviour
{
    [SerializeField]
    private GameObject book;
    [SerializeField]
    private GameObject exit;

    private void OnMouseDown()
    {
        if (book.activeSelf)
        {
            book.SetActive(false);
        }
        else
        {
            book.SetActive(true);
        }
    }
    
}
