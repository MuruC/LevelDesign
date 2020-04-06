using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Load(string sceneName_) {
        sceneName = sceneName_;
        SceneManager.LoadScene(sceneName);
        Vector3 pos = new Vector3(0, 0, 0);
        if (sceneName == "1N-1Floor")
        {
            pos = new Vector3(44f, 0.096f, -3.74f);
        }
        else if (sceneName == "top")
        {
            pos = new Vector3(25f, 0f, 25f);
        }
        else if (sceneName == "-3warehouse")
        {
            pos = new Vector3(25f, 0.77f, 25f);
        }

        GameObject.FindGameObjectWithTag("Player").transform.position = pos;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Vector3 pos = new Vector3(0,0,0);
        if (scene.ToString() == "1N-1Floor")
        {
            pos = new Vector3(42.4f, 6.2f, 34.74f);
        }
        else if(scene.ToString() == "top")
        {
            pos = new Vector3(25f, 0f, 25f);
        }
        GameObject.FindGameObjectWithTag("Player").transform.position = pos;
    }
    public void setPlayerLocation(Vector3 pos) {
        GameObject.FindGameObjectWithTag("Player").transform.position = pos;
    }


}
