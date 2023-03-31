using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggUnfreezRigidbody : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Rigidbody2D rb;
    private Vector3 InitialPosition = new Vector3();
    public bool used = false;
    public float MassAfterUnFreez=100f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !used)
        {
            rb.isKinematic = false;
            rb.mass = MassAfterUnFreez;
            used = !used;
        }
    }

}
