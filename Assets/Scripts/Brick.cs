using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public int maxHits;
    private int hits;

    // Use this for initialization

    void Start()
    {
        hits = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        hits = hits + 1;
        if (hits >= maxHits) {
            Destroy(gameObject);
        }
    }
}