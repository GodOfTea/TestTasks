using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mood", menuName = "Mood")]
public class Mood : ScriptableObject
{
    public CatController.Moods mood;
    public Color color;
    public ParticleSystem effect;
}
