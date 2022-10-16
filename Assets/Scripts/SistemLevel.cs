using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemLevel : MonoBehaviour
{
    [SerializeField] private Pengendara pengendara;
    [SerializeField] private SignSpawner signSpawner;
    public float cooldown;
    int rand;

    private void Update() {
        if(pengendara.jarakTempuh > 200){
            signSpawner.batastanda = 6;

        }
        cooldown += Time.deltaTime;

        if(cooldown > 10){
            rand = UnityEngine.Random.Range(0, 100);
            Debug.Log(rand + " Randomize");
            cooldown = 0;
        }

        if(rand > 80 && pengendara.jarakTempuh > 500){
            pengendara.kecepatan = 10;
        }

        else if(rand > 80 && pengendara.jarakTempuh > 300){
            pengendara.kecepatan = 9;
        }
        else if(rand > 80 && pengendara.jarakTempuh > 100){
            pengendara.kecepatan = 8;
        }

    }
}
