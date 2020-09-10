using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionController : MonoBehaviour
{
    public PerfectReactions perfectReactions;
    public GoodReactions goodReactions;
    public BadReactions badReactions;

    public delegate void reactionFunc();

    public Dictionary<string, reactionFunc> reactionsList = new Dictionary<string, reactionFunc>();

    private void OnEnable()
    {
        InitReactionsList();
    }

    public void DoReaction(string reaction)
    {
        reactionFunc func = reactionsList[reaction];
        func();
    }

    /* Сюда добовлять новые реакции */
    private void InitReactionsList()
    {
        /* Плохое */
        #region BadReactions

        reactionsList.Add("bad_play", badReactions.Sits);
        reactionsList.Add("bad_feed", badReactions.EatCanScratch);
        reactionsList.Add("bad_pat",  badReactions.Scratch);
        reactionsList.Add("bad_kick", badReactions.JumpAndBite);
        #endregion
        /* Хорошее */
        #region GoodReactions

        reactionsList.Add("good_play", goodReactions.ChasingBall);
        reactionsList.Add("good_feed", goodReactions.FastEats);
        reactionsList.Add("good_pat",  goodReactions.Purrs);
        reactionsList.Add("good_kick", goodReactions.RunAndPee);
        #endregion
        /* Отличное */
        #region PerfectReactions

        reactionsList.Add("perfect_play", perfectReactions.Run);
        reactionsList.Add("perfect_feed", perfectReactions.FastEats);
        reactionsList.Add("perfect_pat",  perfectReactions.PurrsAndFawn);
        reactionsList.Add("perfect_kick", perfectReactions.RunInOtherRoom);
        #endregion
    }
}
