using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    public Image hpBar;
    public float hp = 100f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

 

    void UpdateUI()
    {
        hpBar.fillAmount = (float)hp / 100f;
    }

    public void OnTriggerEnter(Collider other)
    {
        hp -= 10f;
        if (other.CompareTag("Sword"))
        {
            hp -= 10f;
            if (hp < 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
