using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissappear : MonoBehaviour
{
    public KeyCode exist;
    
    
    public GameObject Shield;
    void Start()
    {

    }
    void Update()
    {
       


        if (Input.GetKeyDown(exist))
        {
            Shield.SetActive(true);
        }
        else if (Input.GetKeyUp(exist))
        {
            Shield.SetActive(false);
        }
    }
}
