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
        Debug.Log(Input.GetKeyDown(KeyCode.Escape));
        if (Input.GetKeyDown(KeyCode.Escape)) //go back into menu GetKeyDown(KeyCode.Escape)
        {
            Debug.Log("Here");
            SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        }
    }
}
