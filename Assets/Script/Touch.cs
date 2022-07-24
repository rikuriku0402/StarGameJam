using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public int Score => _score;

    [SerializeField]
    int _score;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("ƒNƒŠƒbƒN");
            _score += 50;
            print(Score);
        }   
    }
}
