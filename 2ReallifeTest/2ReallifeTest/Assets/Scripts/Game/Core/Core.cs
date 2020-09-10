using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    /* Главный мозг игры */
    /* Связывает разные логические части */

    public CatController      catController;
    public PlayerController   playerController;
    public ReactionController reactionController;
    public UIController       UIController;
    public TipsController     tipsController;

    public Mood mood;
}
