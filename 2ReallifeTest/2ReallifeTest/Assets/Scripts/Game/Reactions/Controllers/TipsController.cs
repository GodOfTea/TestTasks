using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsController : MonoBehaviour
{
    public Core core;


    public void ShowTip(string reaction)
    {
        core.UIController.tipText.text = reaction;
    }
}
