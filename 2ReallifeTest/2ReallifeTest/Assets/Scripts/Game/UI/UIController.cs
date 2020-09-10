using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Core core;

    [SerializeField] private GameObject catMoodContainer;
    [SerializeField] private Text moodTextStatus;
    [SerializeField] private Image moodImageStatus;

    public Text tipText;


    public void DoAction(string action)
    {
        /* Получается Action enum бесполезен? */
        var reaction = string.Format(
            "{0}_{1}",
            core.catController.mainMood,
            System.Enum.Parse(typeof(Action.Actions), action));

        core.reactionController.DoReaction(reaction);
    }

    public void ChangeMoodStatus()
    {
        var newMood = core.catController.mainMood;

        foreach (var mood in core.catController.moods)
        {
            if (mood.mood == newMood)
            {
                moodTextStatus.text = mood.mood.ToString();
                moodImageStatus.color = mood.color;

                Instantiate(mood.effect, catMoodContainer.transform);
                StartCoroutine(DestroyEffect());
                break;
            }
        }
    }

    private IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds (1.5f);
        int effectIndex = catMoodContainer.transform.childCount - 1;

        Destroy(catMoodContainer.transform.GetChild(effectIndex).gameObject);
    }
}
