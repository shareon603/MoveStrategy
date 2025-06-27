using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stratcharacter : MonoBehaviour
{
    Color monsterColor = Color.white;
    GameObject characterColor ;
    Sprite[] images;
    SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        images = Resources.LoadAll<Sprite>("Character/character");
        characterColor = GameObject.Find("startCharacter");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        monsterColor = collision.gameObject.GetComponent<Renderer>().material.color;
        if (collision.gameObject.tag == "monster")
        {
            spriterenderer = characterColor.GetComponent<SpriteRenderer>();
            Destroy(collision.gameObject);
            if (monsterColor == new Color(1, 1, 1, 1))
            {
                spriterenderer.sprite = images[2];
            }
            else if (monsterColor == new Color(0, 1, 0, 1))
            {
                spriterenderer.sprite = images[3];
            }
            else if (monsterColor == new Color(0, 0, 1, 1))
            {
                spriterenderer.sprite = images[1];
            }

        }

    }
}
