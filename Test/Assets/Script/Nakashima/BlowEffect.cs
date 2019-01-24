using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowEffect : MonoBehaviour
{
    Vector3 HitPos;
    GameObject _Couple;
    bool Hit = false;
    EffekseerHandle Handle;
    EffekseerEmitter Burst;
    public CameraShake shake;
    Score score;
    // Use this for initialization
    void Start()
    {
        Burst = new EffekseerEmitter();
        GameObject temp = GameObject.Find("Main Camera");
        shake = temp.GetComponent<CameraShake>();
        score = GameObject.Find("Score").GetComponent<Score>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Hit)
        {
            //画面揺らし
            shake.Shake(0.25f, 0.1f);
            ParticleManager.PlayParticle("Blow System", new Vector3(HitPos.x, HitPos.y + 9, HitPos.z));
            ParticleManager.PlayParticle("Blow System2", new Vector3(HitPos.x, HitPos.y + 9 , HitPos.z));
            Hit = false;
            score.Add(200);
        }
    }
    void OnTriggerEnter(Collider _collider)
    {
        if (_collider.tag == "Couple")
        {
            HitPos = _collider.transform.position;
            Hit = true;
        }

    }
}

