using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour
{
    public int batastanda;
    [SerializeField] Sprite[] sprites;
    [SerializeField] Pengendara pengendara;
    public Sign signRef;
    int rand;
    public RoadSpawner roadSpawner;



    private void Start() {
        SpawnSign();
    }
    public Sprite getRandomSprite(){
        rand = UnityEngine.Random.Range(0, batastanda - 1);

        return sprites[rand];
    }

    public int getJawabanBenar(){
        return rand;
    }

    public void SpawnSign(){
        Sign newSign = Instantiate(signRef);
        newSign.gameObject.SetActive(true);
        newSign.transform.position = transform.position;
    }
}
