using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    public string name; //attribute
    public int hp; //attribute
    public Character(string n, int h) //function, constructor
    {
        name = n;
        hp = h;
    }
}

public class Gameplay : MonoBehaviour
{
    public Character player; // ตัวละครผู้เล่น
    TextMeshProUGUI playerName;
    Image hpBar;

    void Start()
    {
        player = new Character("PicoChan", 100); // กำหนด HP สูงสุดเป็น 100
        playerName = GameObject.Find("PlayerName").GetComponent<TextMeshProUGUI>();
        hpBar = GameObject.Find("HPBar").GetComponent<Image>();
        playerName.text = player.name;

        // ตั้งค่า HP Bar ให้เต็มในตอนเริ่มเกม
        hpBar.fillAmount = 1.0f; // 100% เต็ม
    }

    void Update()
    {
        hpBar.fillAmount = (float)player.hp / 100;
    }

    // Function to reduce player's HP
    public void ReducePlayerHP(int damage)
    {
        player.hp -= damage;

        // Ensure HP does not go below 0
        if (player.hp < 0)
        {
            player.hp = 0;
        }

        Debug.Log($"Player HP reduced! Current HP: {player.hp}");
    }
}
