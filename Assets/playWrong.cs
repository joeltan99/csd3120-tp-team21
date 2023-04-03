using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playWrong : MonoBehaviour
{
    public AudioSource wrongSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playWrongSound()
    {
        wrongSound.Play();
    }
}
