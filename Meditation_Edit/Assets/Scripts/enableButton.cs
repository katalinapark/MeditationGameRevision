using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableButton : MonoBehaviour
{


    public GameObject objectToActivate;
    public GameObject text;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
        objectToActivate.SetActive(false);
    }

    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(12);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
    

        //Game object will turn off

    }
}