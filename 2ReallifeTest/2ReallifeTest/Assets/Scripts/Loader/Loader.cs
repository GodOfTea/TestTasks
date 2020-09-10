using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    [Header("ID следующей сцены")]
    [SerializeField] private int sceneID;

    [Header("UI элементы")]
    [SerializeField] private Text progressText;
    [SerializeField] private Image progressImage;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneID);

        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            progressImage.fillAmount = progress;
            progressText.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
    }
}
