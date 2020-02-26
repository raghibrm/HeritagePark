using UnityEngine;
using System.Collections;

public class dinowalk : MonoBehaviour {
    private Animator anim;
    int random;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99)
        {
            random = Random.Range(0, 3);
            if (random == 0)
            {
                anim.Play("Comp|StandA", -1, 0.0f);
                Debug.Log("d0");
            }
            else if (random == 1)
            {
                anim.Play("Comp|StandB", -1, 0.0f);
                Debug.Log("d1");
            }
            else if (random == 2)
            {
                anim.Play("Comp|StandC", -1, 0.0f);
                Debug.Log("d2");
            }


        }
       
       

    }
}
