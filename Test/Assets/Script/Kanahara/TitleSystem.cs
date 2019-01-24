using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("GameMain");
        }
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("GameMain");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            SceneManager.LoadScene("GameMain");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            SceneManager.LoadScene("GameMain");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            SceneManager.LoadScene("GameMain");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            SceneManager.LoadScene("GameMain");

        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            SceneManager.LoadScene("GameMain");

        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            SceneManager.LoadScene("GameMain");

        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            SceneManager.LoadScene("GameMain");

        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            SceneManager.LoadScene("GameMain");

        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            SceneManager.LoadScene("GameMain");

        }
    }
}
