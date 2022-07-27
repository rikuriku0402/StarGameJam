using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    SpriteRenderer _sr;
    int _randomColor = 0;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _randomColor = Random.Range(0, 5);//0����Q�܂ł̐����������_���Ŏ擾
        if (_randomColor == 0)//������0�Ȃ�Έȉ������s����
        {
            _sr.color = Color.red;
            tag = "red";
            Destroy(gameObject, 5f);
        }
        if (_randomColor == 1)//������1�Ȃ�Έȉ������s����
        {
            _sr.color = Color.blue;
            tag = "blue";
            Destroy(gameObject, 5f);
        }
        if (_randomColor == 2)//������2�Ȃ�Έȉ������s����
        {
            _sr.color = Color.green;
            tag = "green";
            Destroy(gameObject, 5f);
        }
        if (_randomColor == 3)//������3�Ȃ�Έȉ������s����
        {
            _sr.color = Color.yellow;
            tag = "Yellow";
            Destroy(gameObject, 5f);
        }
        if (_randomColor == 4)//������4�Ȃ�Έȉ������s����
        {
            _sr.color = Color.black;
            Destroy(gameObject, 5f);
            tag = "black";
        }
    }
    public void OnClick()
    {
        if (tag == "red"){ UIManager.Instance.Score(50); }
        if (tag == "blue") { UIManager.Instance.Score(30); }
        if (tag == "green") { UIManager.Instance.Score(20); }
        if (tag == "Yellow") { UIManager.Instance.Score(10); }
        if (tag == "black"){ UIManager.Instance.Score(-50); }
        Destroy(this.gameObject);
    }
    //public void Opp()
    //{
    //    if (tag == "OPP") { UIManager.Instance.Score(-1000); }
    //    print(UIManager.Instance.TotalScore);
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "fin")
        {
            SceneManager.LoadScene("");
        }
    }
}
