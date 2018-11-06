using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupleBlow : MonoBehaviour
{
    //　通常時のぶっ飛ばしスピード
    private float normalBlowSpeed;
    //　遅くした時のぶっ飛ばしスピード
    [SerializeField]
    private float slowBlowSpeed = 0.1f;
    //　時間を遅くしている時間
    [SerializeField]
    private float slowTime = 1f;
    //　経過時間
    private float elapsedTime = 0f;
    //　時間を遅くしているかどうか
    private bool isSlowDown = false;
    public GameObject _player;
    public string _earthTag;         //除外するタグの名前
    public float _forceHeight;       //吹き飛ばす高さ調整値
    public float _forcePower;        //吹き飛ばす強さ調整値
    private bool HitFlag = false;
    Vector3 toVec;
    Collider _Couplecollider;
    Rigidbody _CoupleRigitbody;
    private void Start()
    {

    }
    private void Update()
    {

        if (HitFlag)
        {
            //　スローの時だけ実行
            if (isSlowDown)
            {
                elapsedTime += Time.unscaledDeltaTime;
                if (elapsedTime >= slowTime)
                {


                    _CoupleRigitbody.AddForce(toVec * _forcePower, ForceMode.Impulse);

                    HitFlag = false;

                    isSlowDown = false;
                }
            }

        }
    }
    //何かに触れたときに呼ばれる
    void OnTriggerEnter(Collider _collider)
    {
       
        //除外対象のタグがついたゲームオブジェクトだったら何もしない
        if (_earthTag == _collider.tag)
        {
            return;
        }
        //自分の体は除外
        if (_player && _player == _collider.gameObject)
        {
            return;
        }


        //ぶつかった相手からRigitBodyを取り出す
        Rigidbody otherRigitbody = _collider.GetComponent<Rigidbody>();
        if (!otherRigitbody)
        {
            return;
        }

        //吹き飛ばす方向を求める(プレイヤーから触れたものの方向)
        HitFlag = true;
        _Couplecollider = _collider;
        isSlowDown = true;
        elapsedTime = 0f;
       toVec = GetAngleVec(_player, _Couplecollider.gameObject);
        _CoupleRigitbody = otherRigitbody;

        toVec = toVec + new Vector3(0, _forceHeight, 0);
    }


    Vector3 GetAngleVec(GameObject _from, GameObject _to)
    {
        //高さの概念を入れないベクトルを作る
        Vector3 fromVec = new Vector3(_from.transform.position.x, 0, _from.transform.position.z);
        Vector3 toVec = new Vector3(_to.transform.position.x, 0, _to.transform.position.z);

        return Vector3.Normalize(toVec - fromVec);
    }
}



