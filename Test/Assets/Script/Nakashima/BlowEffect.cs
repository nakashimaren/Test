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
    // Use this for initialization
    void Start()
    {
        Burst = new EffekseerEmitter();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit)
        {
            EffekseerSystem.PlayEffect("Burst2", HitPos);


             Hit = false;
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

