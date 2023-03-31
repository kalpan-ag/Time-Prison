using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnableDisable : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enableList = new List<GameObject>();
    [SerializeField]
    private List<GameObject> disableList = new List<GameObject>();

    public bool used = false;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !used)
        {
            foreach (var obj in enableList)
                obj.SetActive(true);

            foreach (var obj in disableList)
                obj.SetActive(false);

            used = !used;
        }
    }

}
