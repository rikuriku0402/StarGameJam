using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] Transform[] _ballMuzzle;//�z��Ő錾
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
        yield return new WaitForSeconds(0.5f);//�C���^�[�o��
        _randomMuzzle = Random.Range(0, 4);//muzzle�̍��W�������_���ɂ���
        GameObject _ballInstantiate = Instantiate(_ball);//�{�[�����C���X�^���X��
        _ballInstantiate.transform.position = _ballMuzzle[_randomMuzzle].position;//muzzle�̍��W�Ƀ{�[�����C���X�^���X����
        _random = false;
    }
}
