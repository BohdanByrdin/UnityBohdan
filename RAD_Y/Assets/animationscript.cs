using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class animationscript : MonoBehaviour
{
    Animator edanimator;
    float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        edanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edanimator.SetBool("running", false);

        if (Input.GetKey(KeyCode.W))
        {
         // make Ed walk backwards with animation
         edanimator.SetBool("running", true);
            transform.position += speed * transform.forward * Time.deltaTime;

        }





    }
}
