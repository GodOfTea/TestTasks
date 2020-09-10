using UnityEngine;

public class GoodReactions : Reactions
{
    /* Хорошее настроение */

    /* Поиграть */
    public void ChasingBall()
    {
        core.tipsController.ShowTip("Медленно бегает за мячиком");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Накормить */
    public void FastEats()
    {
        core.tipsController.ShowTip("Быстро все съедает");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Погладить */
    public void Purrs()
    {
        core.tipsController.ShowTip("Мурлычет");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Пинок */
    public void RunAndPee()
    {
        core.tipsController.ShowTip("Убегает на ковер и писает. Теперь вам это убирать");
        ChangeMood(CatController.Moods.bad);
    }
}
