using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");


        if (hVal != 0)           // for A and D keys or arrows
            //Debug.Log("Horizontal movement in action:" + hVal);
        if (hVal > 0)
            transform.Translate(.01f, 0f, 0f); // the bigger the decimal number = the faster the sphere moves in the scene
        if (hVal < 0)
            transform.Translate(-.01f, 0f, 0f );


        if (vVal != 0)    // for W and S key or arrows
            //Debug.Log("Vertical movement in action:"  + vVal);
        if (vVal > 0)
            transform.Translate(0f,.01f, 0f);  // important to include the F after the value
        if (vVal < 0)
            transform.Translate(0f, -.01f, 0f);

        


    }
}
