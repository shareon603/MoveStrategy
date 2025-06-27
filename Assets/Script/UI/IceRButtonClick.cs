using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRButtonClick : MonoBehaviour
{
    public bool RButton;
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
        float maxX = 7.1f;

        // 오른쪽 경계 체크
        if (transform.position.x > maxX)
        {
            RButton = false;
            velocity.x = 0;
            Vector3 pos = transform.position;
            pos.x = maxX;
            transform.position = pos;
        }

        if (RButton)
        {
            transform.localScale = new Vector3(1, 1, 1);

            // 반대 방향으로 미끄러지는 중이면 정지
            if (velocity.x < 0)
                velocity.x = 0;

            float targetSpeed = movespeed / Time.deltaTime;
            velocity.x = Mathf.Lerp(velocity.x, targetSpeed, 0.2f);
        }
        else
        {
            velocity.x *= iceDrag;

            if (Mathf.Abs(velocity.x) < 0.05f)
                velocity.x = 0;
        }

        // 경계를 넘지 않는 경우에만 이동
        if (transform.position.x + velocity.x * Time.deltaTime <= maxX)
            transform.Translate(velocity * Time.deltaTime);
    }

    public void PointerDown()
    {
        RButton = true;
    }

    public void PointerUp()
    {
        RButton = false;
    }
}
