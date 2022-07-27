using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(-1, -4);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(1, -4);
        }
    }
}
