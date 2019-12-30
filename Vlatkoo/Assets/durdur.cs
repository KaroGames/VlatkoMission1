using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;  

public class durdur : MonoBehaviour
{

    private bool kesisme;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kesisme)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GetComponentInParent<NavMeshAgent>().enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            kesisme = true;
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("durdu");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        kesisme = false;
        GetComponentInParent<NavMeshAgent>().enabled = true;
    }
}
