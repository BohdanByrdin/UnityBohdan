using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutor : MonoBehaviour
{
    Rigidbody ink;
    // Start is called before the first frame update
    void Start()
    {
        
     
            ink = GetComponent<Rigidbody>();
            ink.AddForce(100 * transform.forward, ForceMode.Impulse);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
