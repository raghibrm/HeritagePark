using UnityEngine;
using System.Collections;

public class musicplay : MonoBehaviour
{
    AudioSource[] allaudio;
    // Use this for initialization
    void Start()
    {
        allaudio = GetComponents<AudioSource>();

    }
    void stopothers(int id)
    {
        for(int i=1;i<=6;i++)
        {
            if(allaudio[i].isPlaying && i!=id)
            {
                allaudio[i].Stop();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > 18 && transform.position.x < 65) && (transform.position.z > 170 && transform.position.z < 225) && !allaudio[1].isPlaying)
        {
            allaudio[1].Play();
            stopothers(1);
          
        }
        if ((transform.position.x > 110 && transform.position.x < 150) && (transform.position.z > 170 && transform.position.z < 225) && !allaudio[2].isPlaying)
        {
            allaudio[2].Play();
            stopothers(2);
           
        }
        if (transform.position.x < -10 && transform.position.x > -70 && transform.position.z > 170 && transform.position.z < 225 && !allaudio[3].isPlaying)
        {
            allaudio[3].Play();
            stopothers(3);
           
        }
        if (transform.position.x < 95 && transform.position.x > 70 && transform.position.z > 14 && transform.position.z < 52 && !allaudio[4].isPlaying)
        {
            allaudio[4].Play();
            stopothers(4);
           
        }
        if (transform.position.x <44 && transform.position.x > 5 && transform.position.z >10 && transform.position.z < 40 && !allaudio[5].isPlaying)
        {
            allaudio[5].Play();
            stopothers(5);
           
        }
        if (transform.position.x < -35 && transform.position.x > -90 && transform.position.z > 90 && transform.position.z < 160 && !allaudio[6].isPlaying)
        {
            allaudio[6].Play();
            stopothers(6);
            
        }
    }
}
