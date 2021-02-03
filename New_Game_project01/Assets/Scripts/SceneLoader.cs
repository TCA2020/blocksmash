using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    string SceneName;
    public void OnClickStartButton()
    {
        SceneManager.LoadScene(SceneName);
    }
}
