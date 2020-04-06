using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEnterScene : MonoBehaviour
{
    public string sceneName;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = pos;
            SceneManager.LoadScene(sceneName);
           
        }
    }
}
