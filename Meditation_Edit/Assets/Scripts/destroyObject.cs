using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class destroyObject : MonoBehaviour
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
                Destroy(hit.collider.gameObject);
            }
        }
    }
}