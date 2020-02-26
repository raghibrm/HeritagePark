using UnityEngine;
using System.Collections;

public class elewalk : MonoBehaviour
{
    private Animator anim;
    int random;
    bool forward = true;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99)
        {
            random = Random.Range(0,3);
            if (random == 1)
            {
                anim.Play("Take 001", -1, 0.0f);
            }
            anim.speed = 0.5f;
            

        }
        if (transform.position.z > 220)
        {
            forward = false;
            transform.Rotate(Vector3.up * 180);
        }
        if (transform.position.z < 180)
        {
            forward = true;
            transform.Rotate(Vector3.up * 180);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Take 001") && forward)
        {
            transform.position = transform.position + new Vector3(0, 0, 0.23f);

        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Take 001") && !forward)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.23f);

        }


    }
}
