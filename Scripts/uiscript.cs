using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class uiscript : MonoBehaviour {
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if((Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)))
        {
            SceneManager.LoadScene("site");
        }
	
	}
}
