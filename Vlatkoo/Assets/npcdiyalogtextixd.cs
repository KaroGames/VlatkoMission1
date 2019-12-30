using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcdiyalogtextixd : MonoBehaviour
{
    public GameObject npcdiyalogu;
    private bool konus = false;

    // Start is called before the first frame update
    void Start()
    {
        npcdiyalogu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && konus == true)
        {
            npcdiyalogu.gameObject.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            konus = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            konus = false;
            npcdiyalogu.gameObject.SetActive(false);
        }
    }
}
