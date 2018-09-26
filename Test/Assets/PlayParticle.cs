using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {
    ParticlePooler particlePooler;

    

    // Use this for initialization
    void Start () {

        particlePooler = new ParticlePooler("speed3");
       
        Play("speed1");
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }
    private void Play(string name)
    {
        ParticleManager.PlayParticle(name, new Vector3(0,100.0f,0));
    }
}
