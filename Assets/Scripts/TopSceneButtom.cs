using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopSceneButtom : MonoBehaviour
{
    public void OnClickToGameSceneButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
