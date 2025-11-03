using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
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
        Debug.Log(other.gameObject.name + " has entered the cube");
    }

    void OnTriggerStay(Collider other) 
    {
        Debug.Log(other.gameObject.name + "is still in the cube"); // other game object name is to identyfy the name of the object that the cube  is interecting with for example the sphere, the name will appear in the console
    }

    void OnTriggerExit(Collider other) 
    {
        Debug.Log(other.gameObject.name + "has left the cube ");
    }



}
