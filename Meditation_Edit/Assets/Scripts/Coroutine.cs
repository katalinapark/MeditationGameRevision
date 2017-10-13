using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class Coroutine : MonoBehaviour
{

    public AudioClip music;
    AudioSource audioSource;


    IEnumerator WaitandPlay()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(12);
        print("PlaySound " + Time.time);
    }

    IEnumerator Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitandPlay");
        print("Done " + Time.time);
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(music, 0.7F);
            

    }
}