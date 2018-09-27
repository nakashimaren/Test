using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {
    ParticlePooler particlePooler;
    Coroutine coroutine;
   

    // Use this for initialization
    void Start () {

        particlePooler = new ParticlePooler("speed3");

        StartCoroutine("Time");

       
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }
    private void Play(string name)
    {
        ParticleManager.PlayParticle(name, new Vector3(0,100.0f,0));
    }
    private IEnumerator Time()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);

            Play("speed1");

            yield return new WaitForSeconds(1.0f);

            Play("speed2");

            yield return new WaitForSeconds(1.0f);

            Play("speed3");
        }


    

    }
}
