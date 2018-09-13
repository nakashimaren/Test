using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoupleController : MonoBehaviour {

    public Transform[] points;
    private int destPoint =0;
   private  NavMeshAgent agent;
    Animation anim;
    Vector3 back;// = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z * -1);

    // Use this for initialization
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        //// updateを自動で行わないように設定する
       agent.updatePosition = false;
        agent.updateRotation = false;

    }
    void Start ()
    {
        anim = this.gameObject.GetComponent<Animation>();
      //  GotoNextPoint();
        
    }
    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;
        agent.destination = points[destPoint].position;
        CarCurve();
        destPoint = (destPoint + 1) % points.Length;
   


    }
        // Update is called once per frame
        void Update ()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();

        // 位置の更新
        transform.position = agent.nextPosition;
    }
    void CarCurve()
    {
        switch(destPoint)
        {
            case 0:
                anim.Play("Car Curve4");
             break;
            case 1:
                anim.Play("Car Curve");
                break;
            case 2:
                anim.Play("Car Curve2");
                break;
            case 3:
                anim.Play("Car Curve3");
                break;
        }
    }
}
