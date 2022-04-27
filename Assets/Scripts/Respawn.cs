using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform trans;
    public GameObject gobj;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            GameObject car=GameObject.Find("Car(Clone)");
            Instantiate instantiation=car.GetComponent<Instantiate>();
            Destroy(car);
            car=Instantiate(gobj,trans.position,Quaternion.identity);
        }
    }
}
