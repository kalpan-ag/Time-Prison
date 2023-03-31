using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestLevel : MonoBehaviour
{
    public GameObject CurrectTraps;
    public float waitToRespaw =1f;
    public GameObject TrapPrefab;
    // Start is called before the first frame update
    private void Start()
    {
        LevelManager.instance.PlayerDeath += Reset;
        if(TrapPrefab==null) TrapPrefab = Resources.Load<GameObject>("Traps/Traps1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        StartCoroutine(RespawnCo());
    }

    private IEnumerator RespawnCo()
    {
        yield return new WaitForSeconds(waitToRespaw);
        Destroy(CurrectTraps);
        CurrectTraps = Instantiate(TrapPrefab);
    }
}
