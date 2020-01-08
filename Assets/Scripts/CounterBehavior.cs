using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterBehavior : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Text>().text = "Jumps: " + GameState.Counter;
    }
}
