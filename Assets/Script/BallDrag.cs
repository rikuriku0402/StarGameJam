using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrag : MonoBehaviour
{
    GameObject _ball;
    bool isDragging;
    public void OnClick()
    {
        Destroy(_ball);
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    OnDragBegin();
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    OnDragEnd();
        //}
        //else if (isDragging)
        //{
        //    OnDragging();
        //}
    }
    //void OnDragBegin()
    //{
    //    Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
    //    if (hit)
    //    {
    //        print("�I�u�W�F�N�g��Hit������");
    //    }
    //}
    //void OnDragging()
    //{
    //    print("�h���b�O��");
    //}
    //void OnDragEnd()
    //{
    //    print("�h���b�O�I��");
    //}
}
