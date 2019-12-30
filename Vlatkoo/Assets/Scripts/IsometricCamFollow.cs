using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricCamFollow : MonoBehaviour
{
    public GameObject target;

    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Camera.main.transform.rotation = Quaternion.Euler(30, 45, 0);
        Camera.main.transform.position = target.transform.position - (Quaternion.Euler(30, 45, 0) * Vector3.forward * distance);
    }

}
