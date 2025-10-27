using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  //very important to make  the code below to work
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (audioSource.isPlaying == true) 
            {
                audioSource.Stop();
                //Debug.Log("Z key is in use"); This extra code makes the text to appear in the Console box
            } 
            else 
            {
                audioSource.Play();
            }
        }
    }
}
