using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public double hp;
    public float maxHp;
    public static List<Destroy> allDestructables = new List<Destroy>();

    // Start is called before the first frame update
    void Start()
    {
        allDestructables.Add(this);
    }

    // Update is called once per frame


    void OnDestroy()
    {
        allDestructables.Remove(this);
    }
    public void TakeDmg()
    {
        hp = hp = 25f;
        if (hp <= 0f)
        {
            Destroy(gameObject);
        }
    }

}