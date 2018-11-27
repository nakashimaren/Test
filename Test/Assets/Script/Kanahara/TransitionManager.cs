using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void LoadGameMain()
    {
        SceneManager.LoadScene("GameMain");
    }

    public void LoadResult()
    {
        SceneManager.LoadScene("Result");
    }
}
