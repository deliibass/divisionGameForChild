using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class menuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startBtn, exitBtn;

    private void Start()
    {
        FadeOut();
    }
    void FadeOut()
    {
        startBtn.GetComponent<CanvasGroup>().DOFade(1, 0.8f);
        exitBtn.GetComponent<CanvasGroup>().DOFade(1, 0.8f);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGameLevel()
    {
        SceneManager.LoadScene("gameLevel");
    }
}
