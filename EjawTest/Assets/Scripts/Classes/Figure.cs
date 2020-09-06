using UnityEngine;

public class Figure : MonoBehaviour
{
    public MeshRenderer mesh;

    /* Имя фигуры */
    public string figureName;

    /* Кол-во кликов на объект */
    public int clicksCount;

    /* Цвет объекта */
    public Color color;

    private void Start()
    {
        clicksCount = 0;
    }

    public void ChangeColor(Color newColor)
    {
        Debug.Log("Target change color");
        color = newColor;
        mesh.material.color = color;
    }
}
