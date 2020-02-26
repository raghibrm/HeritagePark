using UnityEngine;
using System.Collections;

public class bisonwalk : MonoBehaviour {
    bool forward;
	// Use this for initialization
	void Start () {
        forward = true;
	
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.z>210)
        {
            forward = false;
            transform.Rotate(Vector3.up * 180);
        }
        if(transform.position.z < 180)
        {
            forward = true;
            transform.Rotate(Vector3.up * 180);
        }

        if (forward)
        {
       //     Debug.Log("Got ya");
            transform.position = transform.position + new Vector3(0, 0, 0.13f);
            transform.Rotate(Vector3.right * 10);
            transform.Rotate(-Vector3.right * 10);
        }
        else
        {
         //   Debug.Log("Got yaii");
            transform.position = transform.position + new Vector3(0, 0, -0.13f);
        }
       

    }
    
	
	}

