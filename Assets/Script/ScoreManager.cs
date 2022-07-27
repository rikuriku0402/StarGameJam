using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{

    [SerializeField] Text _timerWatch = default;
    [SerializeField] float _timer = 0f;


    private void Start()
    {
        
    }
    void Update()
    {
        if (_timer >= 0.00f)
        {
            _timer -= Time.deltaTime;
            _timerWatch.text = _timer.ToString("F2");
        }
        if (_timer <= 0.00f)
        {
            PlayerPrefs.SetInt("SCORE", UIManager.Instance.TotalScore);
            StartCoroutine(Timer());
        }
        IEnumerator Timer()
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene("Score");
        }
    }
}
