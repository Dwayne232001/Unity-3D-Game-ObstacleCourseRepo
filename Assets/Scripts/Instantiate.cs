using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Transform trans;
    public GameObject gobj;
    // Start is called before the first frame update
    void Start()
    {
        GameObject car=(GameObject)Instantiate(gobj,trans.position,Quaternion.identity);
    }
}
