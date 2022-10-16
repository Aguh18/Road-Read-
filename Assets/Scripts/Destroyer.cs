using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Pengendara pengendara;
    public SignSpawner signSpawner;
    private void OnTriggerEnter2D(Collider2D other) {
        Sign sign = other.GetComponent<Sign>();

        if(sign){
            int rand = UnityEngine.Random.Range(3,5);
            SpawnWait(rand);
        }
        Destroy(other.gameObject);
    }

    IEnumerator SpawnWait(int second){
        yield return new WaitForSeconds(second);
        signSpawner.SpawnSign();
        pengendara.nyawaBerkurang();    
    }
}
