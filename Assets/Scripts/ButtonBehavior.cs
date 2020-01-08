using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField]
    private PlanetSettings planetSettings;
    
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadScene);        
    }

    void LoadScene()
    {
        GameState.CurrentPlanet = planetSettings;
        SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);
        transform.parent.gameObject.SetActive(false);
    }



}
