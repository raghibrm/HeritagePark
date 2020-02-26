using UnityEngine;
using System.Collections;

public class tigerwalk : MonoBehaviour {
    private Animator anim;
    int random;
    bool forward = true;
    AudioSource roar;
    Vector3 mcamerapos;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        roar= GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99)
        {
            random = Random.Range(0, 6);
            if(random==0 || random == 4 )
            {
                anim.Play("idle", -1, 0.0f);
            }
            else if (random == 1 || random == 2 || random == 5)
            {
                anim.Play("walk", -1, 0.0f);
            }
            else if (random == 3)
            {
                anim.Play("sound", -1, 0.0f);
            }
            

        }
        if (transform.position.z > 210)
        {
            forward = false;
            transform.Rotate(Vector3.up * 180);
        }
        if (transform.position.z < 190)
        {
            forward = true;
            transform.Rotate(Vector3.up * 180);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("walk") && forward)
        {
            transform.position = transform.position + new Vector3(0, 0, 0.13f);

        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("walk") && !forward)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.13f);

        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("sound") && !roar.isPlaying)
        {
            mcamerapos = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
            if (mcamerapos.x < -10 && mcamerapos.x > -70 && mcamerapos.z > 170 && mcamerapos.z < 225)
            {
                roar.volume = 1f;
            }
            else if ((mcamerapos.z < 140) && (mcamerapos.z > 70))
            {
                roar.volume = 0.15f;
            }
            else
            {
                roar.volume = 0.09f;
            }
            roar.Play();
        }




    }
}
