using UnityEngine;

public class PerfectReactions : Reactions
{
    /* Отличное настроение */

    /* Поиграть */
    public void Run()
    {
        core.tipsController.ShowTip("Носится, как угорелая");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Накормить */
    public void FastEats()
    {
        core.tipsController.ShowTip("Быстро все съедает");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Погладить */
    public void PurrsAndFawn()
    {
        core.tipsController.ShowTip("Мурлычет и виляет хвостом");
        ChangeMood(CatController.Moods.perfect);
    }

    /* Пинок */
    public void RunInOtherRoom()
    {
        core.tipsController.ShowTip("Убегает в другую комнату, с новыми обоями");
        ChangeMood(CatController.Moods.bad);
    }
}
