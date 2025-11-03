using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       


    }


    int collisionCount = 0; // this has to be outside the collision method to work .. this is data of the factory

    void OnCollisionEnter(Collision collision) 
    {
        collisionCount++;
        Debug.Log(collision.gameObject.name + " collided with " + this.gameObject.name +" : " + collisionCount );
        //Debug.Log(collisionCount); this was added to the varible above
        
        
        //Debug.Log(collision.contactCount); it works but it only shows 1 value

        


    }


    /*void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name + " has entered the " + this.gameObject.name); // other is the name of the collider or sphere is this case
    }*/

}
