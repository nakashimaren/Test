using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutinAnim : MonoBehaviour {
    Animation CutIn;
    GameObject Canvas;
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Couple")
        {
            Canvas.SetActive(true);
            CutIn.Play();
        }
    }
    void Start () {
        CutIn = GameObject.Find("Image").gameObject.GetComponent<Animation>();
        Canvas = GameObject.Find("Canvas");
        Canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

}
