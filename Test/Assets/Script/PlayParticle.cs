using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {
    Coroutine coroutine;
    PlayerController PlayerScript;
    GameObject Player;
    ParticlePooler spped1;

    string nowSpeedEffect = "null";
    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player");
        PlayerScript = Player.GetComponent<PlayerController>();
        spped1 = new ParticlePooler("speed1");


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerScript._speed <= 5 && nowSpeedEffect != "speed1")
        {
            ParticleManager.PlayParticle("speed1", new Vector3(0, 500.0f, 0));
            nowSpeedEffect = "speed1";
          
        }
        else if(PlayerScript._speed >= 6 && PlayerScript._speed <= 9 && nowSpeedEffect != "speed2")
        {
            ParticleManager.PlayParticle("speed2", new Vector3(0, 500.0f, 0));
            nowSpeedEffect = "speed2";
        }


    }
    private void Play(string name)
    {
        ParticleManager.PlayParticle(name, new Vector3(0,100.0f,0));
    }

}
