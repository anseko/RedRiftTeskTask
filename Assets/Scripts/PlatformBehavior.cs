using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformBehavior : MonoBehaviour
{
    private SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        renderer.color = Random.ColorHSV();
        GameState.Counter += 1;
    }
}
