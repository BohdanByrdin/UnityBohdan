using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assume : MonoBehaviour
{
    Rigidbody ink;
    // Start is called before the first frame update
    void Start()
    {
        ink = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ink.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }
}
