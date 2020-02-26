using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(CharacterController))]
public class vrcamerawalk : MonoBehaviour
{
    public float speed = 15.0f;
    public bool moveforward;
    private CharacterController controller;
    //private GvrViewer gvrViewer;
    private Transform vrHead;
    Touch touch;
    float lastTapTime;
    float tapSpeed;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //gvrViewer = transform.GetChild(0).GetComponent<GvrViewer>();
        vrHead = Camera.main.transform;
        lastTapTime=-2f;
        tapSpeed = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(1 / Time.deltaTime);
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            moveforward = !moveforward;
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            if ((Time.time - lastTapTime) < tapSpeed)
            {
                SceneManager.LoadScene("mainui");
            }
            lastTapTime = Time.time;
        }

        /*
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                moveforward = !moveforward;
            }
        }
        */
        if (moveforward)
        {
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }
       

    }
}