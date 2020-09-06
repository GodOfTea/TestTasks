using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Отслеживание кликов */
public class ClickerListner : MonoBehaviour
{
    /* Raycast по пустому = спавн нового объекта */
    /* Raycast по объекту = кол-во кликов ++ */

    public Core core;

    [SerializeField] private Camera mainCamera;

    [SerializeField] private float range = 100;

    private RaycastHit hit;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, range))
            {
                var isHit = hit.transform.name == "BackPanel" ?
                    false : true;
                CheckHit(isHit, hit.point);
            }
        }
    }

    public void CheckHit(bool isHit, Vector3 pos)
    {
        /* Создать объект */
        if (!isHit)
        {
            core.gameManager.SpawnObject(pos);
        }
        else /* менять цвет в зависимости от объекта */
        {
            core.gameManager.ChangeColorOnObject(hit.transform.gameObject);
        }
    }
}
