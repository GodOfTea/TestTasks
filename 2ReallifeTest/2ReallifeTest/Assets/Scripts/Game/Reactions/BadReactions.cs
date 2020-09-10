using UnityEngine;

public class BadReactions : Reactions
{
    /* Плохое настроение */

    /* Поиграть */
    public void Sits()
    {
        core.tipsController.ShowTip("Просто сидит");
        ChangeMood(CatController.Moods.bad);
    }

    /* Накормить */
    public void EatCanScratch()
    {
        int rand = Random.Range(0, 2);

        string reaction = rand == 0 ?
            "Все съел" : "Пока котик ел вы попытались подойти и он вас поцарапал";

        core.tipsController.ShowTip(reaction);
        ChangeMood(CatController.Moods.good);
    }

    /* Погладить */
    public void Scratch()
    {
        core.tipsController.ShowTip("Поцарапал вас");
        ChangeMood(CatController.Moods.bad);
    }

    /* Пинок */
    public void JumpAndBite()
    {
        core.tipsController.ShowTip("Вы промахиваетесь, в ответ кот укусил вас за правое ухо");
        ChangeMood(CatController.Moods.bad);
    }
}
