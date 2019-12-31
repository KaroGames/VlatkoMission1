using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerandItemInteraction : MonoBehaviour
{
    
    public Text interact;
    
    public bool textgozuksun = false;
    public bool textpopupciksin = false;
    bool icerdevetusabasili = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && textgozuksun==true)
        {
            textpopupciksin = true;
            interact.gameObject.SetActive(false);
            
           // Debug.Log("sa vlatkonun hikayesine hg");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            textgozuksun = true;
            interact.gameObject.SetActive(true);
            interact.text = string.Format("Press E to examine " + other.gameObject.name);
        }




    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            textgozuksun = false;
            interact.gameObject.SetActive(false);
        }
    }

}
