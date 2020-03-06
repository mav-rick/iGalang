using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour { 

    public AudioSource button;
    public AudioClip clickbutton;

    public void ClickSound()
    {
        button.PlayOneShot(clickbutton);
    }
}