using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    const string SCENE_NAME = "GameScene";
    public void Retry() => SceneManager.LoadScene(SCENE_NAME);
    
}
