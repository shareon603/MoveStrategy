using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character : MonoBehaviour
{
    public float movespeed;
    public int HP, COIN;
    GameObject ch_HP;
    GameObject play_time;
    GameObject ch_COIN;
    public RectTransform LButton;
    public RectTransform RButton;
    GameObject Character;
    Sprite[] images;
    SpriteRenderer spriterenderer;
    public bool blue = false, green = false;
    Color Ghost, Alive;

    // ?? Lava용 추가 변수
    private Vector3 lastPosition;
    private float idleTime = 0f;
    public float idleLimit = 1f;        
    public int lavaDamage = 5;        // 초당 HP 감소
    public bool isInLava = false;

    void Start()
    {
        movespeed = 0.2f;
        HP = 100;
        COIN = 0;
        this.ch_HP = GameObject.Find("ch_HP");
        this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
        this.play_time = GameObject.Find("play_time");
        this.ch_COIN = GameObject.Find("COIN");
        this.ch_COIN.GetComponent<TextMeshProUGUI>().text = COIN.ToString();

        LButton = GameObject.Find("RButton").GetComponent<RectTransform>();
        RButton = GameObject.Find("LButton").GetComponent<RectTransform>();

        images = Resources.LoadAll<Sprite>("Character/character");
        Character = GameObject.Find("character");

        Alive = new Color(1, 1, 1, 1);
        Ghost = new Color(1, 1, 1, 0.5f);

        // Lava 맵 여부 설정
        if (SceneManager.GetActiveScene().name == "LavaBattleScene")
            isInLava = true;

        lastPosition = transform.position;
    }

    void Update()
    {
        this.play_time.GetComponent<TextMeshProUGUI>().text = "TIME : " + TimeManager.Instance.ptime.ToString("F2");
        COIN = int.Parse(ch_COIN.GetComponent<TextMeshProUGUI>().text);

        // Lava 데미지 처리
        if (isInLava && HP > 0)
        {
            if (Vector3.Distance(transform.position, lastPosition) < 0.01f)
            {
                idleTime += Time.deltaTime;
                if (idleTime > idleLimit)
                {
                    HP -= lavaDamage;
                    idleTime = 0;
                    this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + Mathf.CeilToInt(HP).ToString();
                    if (HP <= 0)
                        StartCoroutine(HPZero());
                }
            }
            else
            {
                idleTime = 0f;
            }
            lastPosition = transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            spriterenderer = Character.GetComponent<SpriteRenderer>();
            Color monsterColor = collision.gameObject.GetComponent<Renderer>().material.color;
            Destroy(collision.gameObject);

            if (monsterColor == new Color(1, 1, 1, 1))
            {
                HP -= 20;
                if (HP <= 0)
                    StartCoroutine(HPZero());
                else
                    this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
            }
            else if (monsterColor == new Color(0, 1, 0, 1))
            {
                HP -= 10;
                if (HP <= 0)
                    StartCoroutine(HPZero());
                else
                {
                    StartCoroutine(greenmonster());
                    this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
                }
            }
            else if (monsterColor == new Color(0, 0, 1, 1))
            {
                HP -= 10;
                if (HP <= 0)
                    StartCoroutine(HPZero());
                else
                {
                    StartCoroutine(bluemonster());
                    this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
                }
            }
        }

        if (collision.gameObject.tag == "coin")
        {
            string CoinName = collision.gameObject.name.Replace("(Clone)", "").Trim();
            switch (CoinName)
            {
                case "bronze": COIN += 1; break;
                case "silver": COIN += 3; break;
                case "gold": COIN += 5; break;
            }
            Destroy(collision.gameObject);
            this.ch_COIN.GetComponent<TextMeshProUGUI>().text = COIN.ToString();
        }
    }

    IEnumerator bluemonster()
    {
        if (blue || green) yield break;

        blue = true;
        movespeed /= 2.0f;
        spriterenderer.sprite = images[1];
        yield return new WaitForSeconds(10f);
        movespeed = 0.2f;
        spriterenderer.sprite = images[2];
        blue = false;
    }

    IEnumerator greenmonster()
    {
        if (green) yield break;

        green = true;
        SwapButton();
        spriterenderer.sprite = images[3];
        yield return new WaitForSeconds(10f);
        spriterenderer.sprite = images[2];
        SwapButton();
        green = false;
    }

    IEnumerator HPZero()
    {
        HP = 0;
        this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
        Character.GetComponent<SpriteRenderer>().color = Ghost;
        foreach (var col in GetComponents<Collider2D>())
            col.enabled = false;

        yield return new WaitForSeconds(5f);

        Character.GetComponent<SpriteRenderer>().color = Alive;
        foreach (var col in GetComponents<Collider2D>())
            col.enabled = true;
        HP = 100;
        this.ch_HP.GetComponent<TextMeshProUGUI>().text = "HP : " + HP.ToString();
    }

    public void SwapButton()
    {
        Vector2 tempPosition = LButton.anchoredPosition;
        Vector2 tempAnchorMin = LButton.anchorMin;
        Vector2 tempAnchorMax = LButton.anchorMax;

        LButton.anchoredPosition = RButton.anchoredPosition;
        LButton.anchorMin = RButton.anchorMin;
        LButton.anchorMax = RButton.anchorMax;

        RButton.anchoredPosition = tempPosition;
        RButton.anchorMin = tempAnchorMin;
        RButton.anchorMax = tempAnchorMax;
    }
}
