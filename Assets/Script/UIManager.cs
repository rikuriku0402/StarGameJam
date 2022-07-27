using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    public int TotalScore => _totalScore;

    int _totalScore;

    [SerializeField]
    Text _scoreText;

    public void SceneChange(string scene) => SceneManager.LoadScene(scene);
    private void Start()
    {
        _totalScore = PlayerPrefs.GetInt("SCORE");
        _scoreText.text = _totalScore.ToString();
    }

    private void Update()
    {
        _scoreText.text = _totalScore.ToString();
        //PlayerPrefs.SetInt("SCORE", TotalScore);
    }
    public int Score(int score) => _totalScore += score;
}
