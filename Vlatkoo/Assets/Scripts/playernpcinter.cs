using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class playernpcinter : MonoBehaviour
{

    public GameObject interactNPCTEXT;
    ///public GameObject DialogueTEXT;

    private GameObject interactingNPC;
    private bool eyebastim = false;
    private bool kesisiyolar = false;

    // Start is called before the first frame update
    void Start()
    {
        interactNPCTEXT.SetActive(false);
        ///DialogueTEXT.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (kesisiyolar)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ///DialogueTEXT.SetActive(true);
                interactNPCTEXT.SetActive(false);
                eyebastim = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            kesisiyolar = true;
            interactNPCTEXT.SetActive(true);
            interactingNPC = other.gameObject;
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                Debug.Log("diasdasdasd");
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        kesisiyolar = false;

        interactNPCTEXT.SetActive(false);
        ///DialogueTEXT.SetActive(false);


        
    }
}
