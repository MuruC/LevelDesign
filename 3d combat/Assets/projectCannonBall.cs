using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectCannonBall : MonoBehaviour
{
    public GameObject ball;
    public float t1;
    private float t2 = 1.0f;
    bool bDestroy = false;
    public float speed;
    void Start()
    {

        InvokeRepeating("CloneSphere", t1, t2); //调用更简洁的实例化方法：重复运行一个方法，起始时间：几秒后开始行； 几秒发射一个

    }

    void Update()
    {
        if (bDestroy == true)
        {
            Destroy(gameObject);
        }
    }
    void CloneSphere()
    {
        Instantiate(ball);
        ball.GetComponent<cannonBall>().speed = speed;
        ball.transform.position = gameObject.transform.position;
    }

    public void setDestroy()
    {
        bDestroy = true;
    }
}
