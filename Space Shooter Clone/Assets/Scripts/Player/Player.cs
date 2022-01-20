using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
    public static double hp;
    public static double hp_stable;
    public Text hp_;
    public static int health;
    public static int health1;
    //public int spaceship2 = -1;
    public int numofHearts;
    public Image[] hearts;
    public Sprite fullheart;
    public Sprite darkHeart;
    Rigidbody2D rb;
    float dirX, dirY;

    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;
    void Start()
    {
        health = 4;
        hp_stable = 50 + hp;
        if (PlayerPrefs.GetInt("selectedOption") == 0)
        {
            PlayerShoot._attack = PlayerShoot._attack * 1;
        }
        if (PlayerPrefs.GetInt("selectedOption") == 1)
        {
            PlayerShoot._attack = PlayerShoot._attack * 1.75;
        }
        if (health > numofHearts)
        {
            health = numofHearts;
        }
        rb = GetComponent<Rigidbody2D>();

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
        for (int i = 0; i <= hearts.Length; i++)
        {
            if (PlayerPrefs.GetInt("selectedOption") == 0)
            {
                health = 4;
            }
            if (PlayerPrefs.GetInt("selectedOption") == 1)
            {
                health = 3;
            }
        }
    }
    private void Update()

    {
        hp_.text = hp_stable.ToString();
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = darkHeart;
            }
            if (i < numofHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (hp_stable <= 0)
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);

            }
            hp_stable = 50 + hp;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = moveSpeed* new Vector2(dirX, dirY).normalized;
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
    public void TakeDamage(double attack)
    {
        hp_stable -= attack;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            hp_stable -= 20;
            rb.velocity += new Vector2(-15f, 0);
        }
    }
}
