using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceLButtonClick : MonoBehaviour
{
    public bool LButton;
    public float movespeed = 0.2f;
    public float iceDrag = 0.98f;

    private Vector2 velocity;
    private character player;

    void Start()
    {
        player = GameObject.Find("character").GetComponent<character>();
        movespeed = player.movespeed;
    }

    void Update()
    {
        movespeed = player.movespeed;
        float minX = -8.51f;

        // 화면 밖 방지
        if (transform.position.x < minX)
        {
            LButton = false;
            velocity.x = 0;
            Vector3 pos = transform.position;
            pos.x = minX;
            transform.position = pos;
        }

        if (LButton)
        {
            transform.localScale = new Vector3(-1, 1, 1);

            // 반대 방향 속도 제거
            if (velocity.x > 0)
                velocity.x = 0;

            float targetSpeed = -movespeed / Time.deltaTime;
            velocity.x = Mathf.Lerp(velocity.x, targetSpeed, 0.2f);
        }
        else
        {
            velocity.x *= iceDrag;

            if (Mathf.Abs(velocity.x) < 0.05f)
                velocity.x = 0;
        }

        // 정상 이동
        if (transform.position.x + velocity.x * Time.deltaTime >= minX)
            transform.Translate(velocity * Time.deltaTime);
    }

    public void PointerDown()
    {
        LButton = true;
    }

    public void PointerUp()
    {
        LButton = false;
    }
}
