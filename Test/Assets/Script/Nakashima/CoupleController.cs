using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoupleController : MonoBehaviour {

    public Transform[] points;
    private int destPoint = 0;
   private  NavMeshAgent agent;


    // Use this for initialization
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        //// updateを自動で行わないように設定する
        //agent.updatePosition = false;
        //agent.updateRotation = false;


        //agent.destination = points[destPoint].position;
    }
    void Start ()
    {
        GotoNextPoint();
    }
    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }
        // Update is called once per frame
        void Update ()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
        //// 次の位置への方向を求める
        //var dir = agent.nextPosition - transform.position;

        //// 方向と現在の前方との角度を計算（スムーズに回転するように係数を掛ける）
        //float smooth = Mathf.Min(1.0f, Time.deltaTime / 0.15f);
        //var angle = Mathf.Acos(Vector3.Dot(transform.forward, dir.normalized)) * Mathf.Rad2Deg * smooth;

        //// 回転軸を計算
        //var axis = Vector3.Cross(transform.forward, dir);

        //// 回転の更新
        //var rot = Quaternion.AngleAxis(angle, axis);
        //transform.forward = rot * transform.forward;

        //// 位置の更新
        //transform.position = agent.nextPosition;
    }
}
