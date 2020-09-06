using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Core core;

    [SerializeField] private float secondsBetweenChangeColor;

    private CompositeDisposable disposables;
    private Transform parent;

    [SerializeField] private Text timerText;
    [SerializeField] private string timerTextTemplate = "Change color: {0} sec";

    private float timer;

    private void Start()
    {
        /* Настройки */
        parent = core.gameManager.parentForFigures;
        timer = secondsBetweenChangeColor;
        timerText.text = string.Format(timerTextTemplate, timer);

        /* Подписки */
        /* Расскоментить для динамического таймера */
        /* Со временем начинает отстовать */
        /*Observable.Timer(System.TimeSpan.FromSeconds(1f))
        .Repeat()
        .Subscribe(_ => {
            UpdateTimer();
        }).AddTo(disposables);*/

        Observable.Timer(System.TimeSpan.FromSeconds(secondsBetweenChangeColor))
        .Repeat()
        .Subscribe(_ => {
            ChangeColorTimer();
        }).AddTo(disposables);
    }

    private void UpdateTimer()
    {
        if (parent.childCount > 0)
        {
            timer -= 1f;
            timerText.text = string.Format(timerTextTemplate, timer.ToString("0"));

            if (timer <= 0)
                timer = secondsBetweenChangeColor;
        }
    }

    private void ChangeColorTimer()
    {
        if (parent.childCount > 0)
        {

            parent.GetChild(0).GetComponent<Figure>().
                ChangeColor(new Color(Random.value, Random.value, Random.value, 1));
        }
    }

    private void OnEnable()
    {
        disposables = new CompositeDisposable();
    }

    void OnDisable()
    {
        if (disposables != null)
        {
            disposables.Dispose();
        }
    }

}
