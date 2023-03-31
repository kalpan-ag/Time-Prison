using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerToggleBehaviour : MonoBehaviour
{
    [SerializeField]
    private List<Behaviour> enableList = new List<Behaviour>();
    [SerializeField]
    private List<Behaviour> disableList = new List<Behaviour>();

    private void Start()
    {
        //LevelManager.instance.PlayerDeath += Reset;
    }
    /*
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (var obj in enableList)
               obj.SetActive(true);

            foreach (var obj in disableList)
               obj.SetActive(false);

        }
    }



    public void Reset()
    {
        foreach (var obj in enableList)
           obj.SetActive(false);

        foreach (var obj in disableList)
            obj.SetActive(true);
    }*/
}
