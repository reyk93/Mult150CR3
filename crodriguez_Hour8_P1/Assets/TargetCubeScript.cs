using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;

    void Start()
    {
        target = GameObject.Find("Cube");
    }




    
    // Update is called once per frame
    void Update()
    {

        target.transform.Translate(.05f, 0f, 0f);  // recall 0f means 0 as a float or decimal numbers//
        target.transform.Rotate(0f, 0f, 1f);
        target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

        


    }
}
