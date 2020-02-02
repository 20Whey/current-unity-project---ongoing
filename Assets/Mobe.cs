using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobe : MonoBehaviour
{
    public KeyCode forwardkey;
    public KeyCode backwardkey;
    public KeyCode turnleftkey;
    public KeyCode turnrightkey;
    public Rigidbody rb;
    public float thrust = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -75f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 75f * Time.deltaTime, 0f); 
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(transform.forward * thrust);
        }
       
    }
}
