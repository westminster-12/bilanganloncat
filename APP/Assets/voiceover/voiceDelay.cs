using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiceBerapa : MonoBehaviour
{

    public float delay;
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
		audioSource.PlayDelayed(delay);
    }

}
