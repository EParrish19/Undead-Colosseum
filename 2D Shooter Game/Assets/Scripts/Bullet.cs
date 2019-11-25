using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;

    // Start is called before the first frame update
    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
    }

    // Trigger for when bullet hits target
    private void OnTriggerEnter2D(Collider2D other)
    {

        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        gameObject.SetActive(false);

    }

    private void OnBecameInvisible()
    {

        Die();

    }

    private void Die()
    {

        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke("Die");
    }

}
