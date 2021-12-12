using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpriteOnStart : MonoBehaviour
{
    [SerializeField] private List<Sprite> Sprites;
    void Awake()
    {
        if (Sprites.Count != 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0, Sprites.Count)];
        }
    }
}
