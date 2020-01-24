using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(0f, 0f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            transform.Rotate(0f, 0f * Time.deltaTime, 0f);
        }
    }
}
