using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : MonoBehaviour
{
    // Use this for initialization
    public float speed = 0.0f;
    void Start()
    {
        Destroy(gameObject, 0.70f);                      //消失
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.right * Time.deltaTime * 2);    //移动    

    }
}
