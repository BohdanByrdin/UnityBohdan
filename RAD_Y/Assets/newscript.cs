using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour
{
    float runningSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { 
        transform.position += transform.forward * Time.deltaTime;
         }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position +=  Vector3.right * Time.deltaTime;
        }
            if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up,45* Time.deltaTime);
        }
        
            if (Input.GetKey(KeyCode.Space))
        {
            transform.position += runningSpeed * transform.up * Time.deltaTime;
        }
    }
}
