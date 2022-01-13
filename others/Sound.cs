using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    public float maxImpulse;
    public float minImpulse;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        float newVolume = 1f;
        float impulse = other.impulse.magnitude;

        Debug.Log(impulse);

        if (impulse >= maxImpulse)
        {
            newVolume = 1f;
        }
        else
        {
            if (impulse >= minImpulse)
                newVolume = impulse / maxImpulse;
            else
                newVolume = 0f;
        }

        audioSource.volume = newVolume;
        audioSource.Play();
    }
}
