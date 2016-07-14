using UnityEngine;
using System.Collections;

public class CollectObjects : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Collectible collectible = other.GetComponent<Collectible>();

        if (collectible != null)
        {
            PlayerHUD.Instance.AdjustScore(collectible.score);
            //if(collectible.type == Collectible.Type.Death)
            //{
            //   Destroy(this.gameObject);
            //}
            other.gameObject.SetActive(false);
        }
    }
}
