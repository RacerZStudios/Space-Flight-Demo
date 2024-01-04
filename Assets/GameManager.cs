using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject[] hideObjects;
    private int i; 
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            panel.SetActive(true);
            return; 
        }

        if(Input.GetKeyDown(KeyCode.H) && i <= 0)
        {
            i += 1; 
            hideObjects[0].SetActive(false);
            hideObjects[1].SetActive(false);
            hideObjects[2].SetActive(false);
            hideObjects[3].SetActive(false);
            hideObjects[4].SetActive(false);
            hideObjects[5].SetActive(false);
            i = 1; 
        }
        else if (Input.GetKeyDown(KeyCode.H) && i >= 1)
        {
            i -= 1; 
            hideObjects[0].SetActive(true);
            hideObjects[1].SetActive(true);
            hideObjects[2].SetActive(true);
            hideObjects[3].SetActive(true);
            hideObjects[4].SetActive(true);
            hideObjects[5].SetActive(true);
            i = 0;
        }
    }
}
