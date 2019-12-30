using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textpopup : MonoBehaviour
{

    public GameObject buitemintexti;
    private bool islem = false;

    // Start is called before the first frame update
    void Start()
    {
        buitemintexti.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && islem==true)
        {
            buitemintexti.gameObject.SetActive(true);
            
        }

    }

    private void OnTriggerStay(Collider other)
    {            
        if(other.gameObject.tag == "Player")
        
        {     
            islem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {           
        if (other.gameObject.tag == "Player")
        { 
          islem = false;
            buitemintexti.gameObject.SetActive(false);
        }
    }
}
