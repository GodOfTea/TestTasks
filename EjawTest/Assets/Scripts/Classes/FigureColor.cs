using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "ScriptableObjects/NewColor", order = 1)]
public class FigureColor : ScriptableObject
{
    public string name;

    public Color color;

    public int cubeClick;
    public int sphereClick;
    public int capsuleClisk;
}
