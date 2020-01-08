using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehavior : MonoBehaviour
{
    void Awake()
    {
        GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite
            = GameState.CurrentPlanet.Background;
        Physics2D.gravity = GameState.CurrentPlanet.Gravity;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        }
    }
}
