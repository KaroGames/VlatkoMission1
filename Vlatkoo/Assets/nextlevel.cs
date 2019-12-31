using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public GameObject pressqtodrive;

    private bool suruyomu = false;

    // Start is called before the first frame update
    void Start()
    {
        pressqtodrive.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.F)&& suruyomu==true)
            {
                //pressqtodrive.gameObject.SetActive(true);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("next");
            }
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pressqtodrive.gameObject.SetActive(true);
            suruyomu = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pressqtodrive.gameObject.SetActive(false);
            suruyomu = false;
        }
    }
}
