using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrea : MonoBehaviour
{
    private Vector3 cameratarget;
    private Transform target;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").transform;
    }
    void Update()
    {
        cameratarget = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.position = Vector3.Lerp(transform.position, cameratarget, Time.deltaTime * 8);
    }
}