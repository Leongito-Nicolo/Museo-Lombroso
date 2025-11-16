using System.Collections.Generic;
using UnityEngine;

public class ChangeActivePage : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages;

    public void ChangePage(GameObject newPage)
    {
        for (int i = 0; i < pages.Count; i++)
        {
            if (pages[i].activeSelf && pages[i] != newPage)
            {
                pages[i].SetActive(false);
                newPage.SetActive(true);
            }
        }
    }
}
