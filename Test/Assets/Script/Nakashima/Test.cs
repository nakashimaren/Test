using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    bool enable = true;
    EffekseerHandle handle;
    int pos = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(enable)
        {
            handle =  EffekseerSystem.PlayEffect("Burst2", new Vector3(0, 0, 0));

            enable = false;
        }
        handle.SetLocation(new Vector3(pos, 0, 0));
        pos++;
    }
}
