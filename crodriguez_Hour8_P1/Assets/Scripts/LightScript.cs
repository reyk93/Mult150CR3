using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

    Light _lightbulb;

    // Start is called before the first frame update
    void Start()
    {
        _lightbulb = gameObject.GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L)) 
        {
            Debug.Log("The 'L' key is pressed down");
            _lightbulb.enabled = !_lightbulb.enabled;   // = ! this means opositive of the first, this allow to enable and disable an object in unity 

        
        }

    }
}
