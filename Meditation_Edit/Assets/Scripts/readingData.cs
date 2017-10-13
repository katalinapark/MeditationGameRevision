using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Ports;

public class readingData : MonoBehaviour {
	SerialPort floraSP = new SerialPort ("COM8", 9600);

	public float GSRValue;
	public float floatingForce = 6f; 
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		floraSP.Open ();
		floraSP.ReadTimeout = 1;
		rb = GameObject.Find ("MeditatingMan").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		GSRValue = float.Parse (floraSP.ReadLine ());
		try{
			//print (floraSP.ReadLine());
		}
		catch(System.Exception){
		}

		if (Mathf.Abs(GSRValue)>5) {
			rb.AddForce (Vector2.down * floatingForce);
            rb.isKinematic = false;
            
		}
        else if (Mathf.Abs(GSRValue) <20)
        {
            rb.isKinematic = true;
        
            rb.velocity = Vector3.zero;
                
                }
	}
}
