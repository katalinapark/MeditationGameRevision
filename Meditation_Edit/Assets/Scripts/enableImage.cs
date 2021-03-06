﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enableImage : MonoBehaviour
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
        yield return new WaitForSeconds(25);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

        
        //Turn the Game Oject back off after 1 sec.
        yield return new WaitForSeconds(2);

        //Game object will turn off
        objectToActivate.SetActive(false);
    }
}