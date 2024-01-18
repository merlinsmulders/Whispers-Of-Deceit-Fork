using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterApproaching : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "App")
        {
            Debug.Log("EventStart");
            StartCoroutine(MonsterWalkstoPlayer());
        }
    }
    public IEnumerator MonsterWalkstoPlayer()
    {
        yield return new WaitForSeconds(10);

    }
}
