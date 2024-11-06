using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class movecamera : MonoBehaviour
{
    public GameObject knifeCloneTemplate;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));
        transform.Rotate(transform.right, Input.GetAxis("Horizontal"), Space.World);

        if (Input.GetKey(KeyCode.S))

        {
            Instantiate(knifeCloneTemplate);

        }







    }
}
