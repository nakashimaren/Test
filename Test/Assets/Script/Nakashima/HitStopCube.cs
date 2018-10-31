using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStopCube : MonoBehaviour {

    private Vector3 defaultPos;
    // Use this for initialization
    void Start () {
        defaultPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = defaultPos + new Vector3(3f * Mathf.Sin(3f * Time.time), 0f, 0f);
    }
}
