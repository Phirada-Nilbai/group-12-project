using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundfx : MonoBehaviour
{
    public AudioSource source;
    public AudioClip song;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(song);
        }
    }
}
