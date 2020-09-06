using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Core core;

    public Figure[] figures;
    public List<FigureColor> figureColors;

    public Transform parentForFigures;
    public Plane backPlane;

    [SerializeField] private Text figureNameText;
    [SerializeField] private Text figureClicksCount;
    [SerializeField] private GameObject infoPanel;

    private string clicksCountTemplate = "Clicks on object: {0}";

    /* public int maxObjectsInScene = 5; */


    public void SpawnObject(Vector3 pos)
    {
        if (parentForFigures.transform.childCount == 0)
        {
            int rnd = Random.Range(0, figures.Length);
            var figure = figures[rnd];

            Instantiate(figure.gameObject, pos, Quaternion.identity, parentForFigures);
            infoPanel.SetActive(true);

            figureNameText.text = core.saveSystem.LoadData(figure.name);
            figureClicksCount.text = string.Format(clicksCountTemplate, 0);
        }
        else { Debug.LogWarning("Только один объект"); }
    }

    public void ChangeColorOnObject(GameObject figure)
    {
        var target = figure.GetComponent<Figure>();
        Color newColor = new Color();
        target.clicksCount++;

        figureClicksCount.text = string.Format(clicksCountTemplate, target.clicksCount);

        if (target.clicksCount < 10)
        {
            switch (target.figureName)
            {
                case "Capsule":
                    newColor = (from item in figureColors
                                where target.clicksCount <= item.capsuleClisk
                                orderby item.capsuleClisk
                                select item.color).First();
                    break;
                case "Cube":
                    newColor = (from item in figureColors
                                where target.clicksCount <= item.cubeClick
                                orderby item.cubeClick
                                select item.color).First();
                    break;
                case "Sphere":
                    newColor = (from item in figureColors
                                where target.clicksCount <= item.sphereClick
                                orderby item.sphereClick
                                select item.color).First();
                    break;
                default:
                    Debug.LogError("Такого объекта не существет");
                    break;
            }

            target.ChangeColor(newColor);
        }
    }
}
