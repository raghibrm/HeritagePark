using UnityEngine;
using System.Collections;

public class winstonwalk : MonoBehaviour {
    Animator anim;
    int random;
    bool forward = true;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99)
        {
            random = Random.Range(0, 2);
            if (random == 0 )
            {
                anim.Play("Idle", -1, 0.0f);
            }
            else 
            {
                anim.Play("Walk", -1, 0.0f);
            }
           

        }
        if (transform.position.z > 145)
        {
            forward = false;
            transform.Rotate(Vector3.up * 180);
        }
        if (transform.position.z < 125)
        {
            forward = true;
            transform.Rotate(Vector3.up * 180);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walk") && forward)
        {
            transform.position = transform.position + new Vector3(0, 0, 0.13f);

        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walk") && !forward)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.13f);

        }

    }
}
