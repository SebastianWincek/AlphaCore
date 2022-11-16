using UnityEngine;
using System.Collections;
public class Med : MonoBehaviour
{

    public int hp = 40;
    [SerializeField] private string itemName;
    void OnTriggerEnter(Collider other)
    {

        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player.currentHealth < 100)
        {
            if (player != null)
            {
                player.Healing(hp);
            }

            Debug.Log("Item collected: " + itemName);
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Masz maksymalny poziom zdrowia");
        }
    }
}