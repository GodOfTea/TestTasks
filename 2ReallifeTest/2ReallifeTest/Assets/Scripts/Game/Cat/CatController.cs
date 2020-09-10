using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatController : MonoBehaviour
{
    public enum Moods
    {
        bad,
        good,
        perfect
    }

    public string catNickname;

    public Moods mainMood;

    public UnityEvent OnUIMoodStatus;

    public List<Mood> moods;

    /* Пока так */
    private void Awake()
    {
        ChangeCatMood(Moods.good);
    }

    public void ChangeCatMood(Moods newMood)
    {
        mainMood = newMood;
        OnUIMoodStatus.Invoke();
    }
}
