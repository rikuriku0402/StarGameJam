using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] Transform[] _ballMuzzle;//配列で宣言
    bool _random = false;
    int _randomMuzzle = 0;
    void Start()
    {
        
    }
    void Update()
    {
        if(!_random)
        {
            StartCoroutine(RandomBall());
        }
    }
    IEnumerator RandomBall()
    {
        _random = true;
        yield return new WaitForSeconds(0.5f);//インターバル
        _randomMuzzle = Random.Range(0, 4);//muzzleの座標をランダムにする
        GameObject _ballInstantiate = Instantiate(_ball);//ボールをインスタンス化
        _ballInstantiate.transform.position = _ballMuzzle[_randomMuzzle].position;//muzzleの座標にボールをインスタンスする
        _random = false;
    }
}
