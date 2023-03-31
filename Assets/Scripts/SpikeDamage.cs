using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    bool status = false;
    public float DestroyMagnitude=2f;
    public GameObject DestroyEffect;


    private void Start()
    {
        this.GetComponent<Collider2D>().isTrigger = false;
        if (DestroyEffect == null) DestroyEffect = Resources.Load<GameObject>("DestroyEffect");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && !status)
        {
            PlayerHealth.instance.Death();
            status = !status;
        }
        else if (collision.relativeVelocity.magnitude >= DestroyMagnitude)
        {
            if(DestroyEffect!=null) Instantiate(DestroyEffect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
