using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState
{
    [SerializeField]
    public static int Counter { get; set; }

    [SerializeField]
    public static PlanetSettings CurrentPlanet { get; set; }
}
