using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            
            var speed = -GameState.CurrentPlanet.Gravity;
            speed.y += 5;
            speed.x = 5;
            Vector2 touchPosition = Input.touchCount > 0 ? Input.GetTouch(0).position
                                                        : new Vector2(Input.mousePosition.x,
                                                                      Input.mousePosition.y);
            var c = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GetComponent<Rigidbody2D>().AddForce(new Vector2(c.x - transform.position.x,
                                                             c.y - transform.position.y).normalized * speed,
                                                 ForceMode2D.Force);
        }
    }
}
