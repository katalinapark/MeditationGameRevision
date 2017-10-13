using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadLevel : MonoBehaviour
{

    public GameObject myobject;
    public bool isHit = true;

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                isHit = false;
                SceneManager.LoadScene("MeditationMan", LoadSceneMode.Single);
            }
        }
    }
}