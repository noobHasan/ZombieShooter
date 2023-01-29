using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // check if collision is with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(MoneyManager.Instance.GetMoney());
            collision.gameObject.GetComponent<AIController>().isDead = true;
            collision.gameObject.GetComponent<AIController>().animator.SetBool("isDead", true);

            collision.gameObject.tag = "Untagged";
            // destroy both bullet and enemy
            Destroy(collision.gameObject,3f);
            Destroy(gameObject);
        }
    }
}
