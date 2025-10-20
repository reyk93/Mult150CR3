using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update

    Light myLight;

   
    void Start()
    {

        myLight = GetComponent<Light>();
        //bool isOn = false; --- other option in progress


    }

    

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode. L)) 
        {
           
            Debug.Log("The 'L' key is pressed down");
            myLight.enabled = !myLight.enabled;
            
        }

            //  other option below using if /else 

       
        
        

    }

    




}
