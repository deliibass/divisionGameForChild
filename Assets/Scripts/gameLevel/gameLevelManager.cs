using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gameLevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;

    void Start()
    {
        panel.GetComponent<CanvasGroup>().DOFade(0, 0.8f);
    }

}
