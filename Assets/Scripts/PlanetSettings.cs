using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlanetSettings", menuName = "Planet Settings", order = 51)]
public class PlanetSettings : ScriptableObject
{
    [SerializeField]
    public Vector2 gravity;
    [SerializeField]
    private Sprite background;

    public Vector2 Gravity { get { return gravity; } }
    public Sprite Background { get { return background; } }
}
