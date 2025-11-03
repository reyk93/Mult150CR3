using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
       
        Debug.Log(other.gameObject.name + " has entered the "+ this.gameObject.name); // other is the name of the collider or sphere is this case
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + "is still in the " + this.gameObject.name); // this refers to the name of the triggered object like the Ltrigger and R trigger
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "has left the " + this.gameObject.name);
    }


    



}
