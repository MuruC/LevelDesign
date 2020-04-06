using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnactCannon : MonoBehaviour
{
    public GameObject CannonProjector;
    // Start is called before the first frame update
    void Start()
    {
        CannonProjector.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CannonProjector.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CannonProjector.SetActive(false);
        }
    }
}
