using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class SlimeHP : MonoBehaviour
{
    public Image  hpBar;
    public float hp = 100f;
    


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
        hpBar.fillAmount = (float)hp / 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            hp -= 20f;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
