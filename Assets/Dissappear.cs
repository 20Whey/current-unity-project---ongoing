using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissappear : MonoBehaviour
{
    public KeyCode exist;
    
    bool SetActive;

    void Update()
    {
       


        if (Input.GetKey(KeyCode.R))
        {
            GameObject(Self).SetActive(true);
        }
        else if (Input.GetKey(KeyCode.R) != true)
        {
            GameObject(Self).SetActive(false);
        }
    }
}
