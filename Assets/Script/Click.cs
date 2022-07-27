using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject Effect => _effect;

    [SerializeField]
    GameObject _effect;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 3f;
            GameObject clone = Instantiate(_effect, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);
            Destroy(clone, 0.5f);
        }
    }
}
