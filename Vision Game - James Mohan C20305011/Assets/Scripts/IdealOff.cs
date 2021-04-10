using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdealOff : MonoBehaviour
{

    public GameObject CubeA;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            CubeA.SetActive(false);
        }
        else
        {
            CubeA.SetActive(true);
        }
    }
}
