using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactions : MonoBehaviour
{
    /* Возможно будут общие поля или методы */
    public Core core;

    private void Awake()
    {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<Core>();
    }

    protected void ChangeMood(CatController.Moods newMood)
    {
        core.catController.ChangeCatMood(newMood);
    }
}
