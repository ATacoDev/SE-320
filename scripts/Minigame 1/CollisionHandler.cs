using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GamePlayLoop gamePlayLoop;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Apple"))
        {
            gamePlayLoop.incrementScore(1);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Orange"))
        {
            gamePlayLoop.incrementScore(2);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Lemon"))
        {
            gamePlayLoop.incrementScore(3);
            Destroy(other.gameObject);
        }
    }
}
