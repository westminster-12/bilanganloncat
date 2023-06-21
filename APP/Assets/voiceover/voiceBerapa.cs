using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiceDelay : MonoBehaviour
{

    public float delay;
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
		audioSource.PlayDelayed(delay);
    }

}
