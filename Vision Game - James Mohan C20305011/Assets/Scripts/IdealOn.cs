using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdealOn : MonoBehaviour
{

    public GameObject CubeB;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            CubeB.SetActive(true);
        }
        else
        {
            CubeB.SetActive(false);
        }
    }
}