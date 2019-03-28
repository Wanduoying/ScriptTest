using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    
    void HelloName(int name)
    {
    Debug.Log("Hello," + name);
    }

    void Start()
    {
    HelloName(1);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
