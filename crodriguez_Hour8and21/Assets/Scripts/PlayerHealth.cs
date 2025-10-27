using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    int healthpoints = 3992;
    
    

    // Start is called before the first frame update
    void Start()
    {
        healthpoints = UsePoint(healthpoints);   // tried int newHealth = usePoints(healthpoints); but the format  did work when i tried to  copy  and paste multiple times 
        healthpoints = UsePoint(healthpoints);   // simple is better to copy and paste
        healthpoints = UsePoint(healthpoints);
        healthpoints = UsePoint(healthpoints);


        Debug.Log("Health: " + healthpoints);


       // UsePoint(healthpoints,4); experiment with for / numloops inside the new function but it did not work


        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    int UsePoint(int health) // new function 
    {
        
        return health + 400;  // this returns the health value to the called code and added 400 to the new health... check
        

    }


}
