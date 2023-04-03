using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCorrect : MonoBehaviour
{

    public AudioSource correctSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playCorrectSound()
    {
        correctSound.Play();
    }
}
