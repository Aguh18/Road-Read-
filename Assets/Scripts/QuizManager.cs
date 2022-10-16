using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    #region singleton
    public static QuizManager Instance;
    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
    }
    #endregion


    public int indexjawabanbenar = -1;
    public String[] jawaban;
    [SerializeField] int[] jawabanbutton;

    public Transform quizPanel;
    public GameObject truecuy;
    public SignSpawner signSpawner;
    public Pengendara pengendara;

    
    public void setJawabanBenar(int x){
        indexjawabanbenar = x;
    }

    public void GenerateQuiz(){

        quizPanel.gameObject.SetActive(true);

        //Set jawaban untuk yang benar
        jawabanbutton[UnityEngine.Random.Range(0, 2)] = indexjawabanbenar;

        for(int i = 0; i < 3; i++){
            Transform button = quizPanel.GetChild(i);

            if(jawabanbutton[i] != -1){
                button.GetChild(0).GetComponent<Text>().text = jawaban[indexjawabanbenar];
                continue;
            }

            //Set jawaban yang salah
            jawabanbutton[i] = UnityEngine.Random.Range(0, jawaban.Length);
            button.GetChild(0).GetComponent<Text>().text = jawaban[jawabanbutton[i]];

        }
    }

    public void buttonclick(int idx){
        if(indexjawabanbenar == jawabanbutton[idx]){
            Debug.Log("Jawaban anda benar");
            quizPanel.gameObject.SetActive(false);
            indexjawabanbenar = -1;
            StartCoroutine(Benar());
        }
        else{
            Debug.Log("tidak benar");
            quizPanel.gameObject.SetActive(false);
            indexjawabanbenar = -1;
            pengendara.nyawaBerkurang();
        }

        
        int rand = UnityEngine.Random.Range(3,5);
        StartCoroutine(SpawnWait(rand));

        //set semua nilai menjadi -1
        for(int i = 0; i < 3; i++){
            jawabanbutton[i] = -1;
        }
    }

    IEnumerator Benar(){
        truecuy.SetActive(true);
        yield return new WaitForSeconds(.2f);
        truecuy.SetActive(false);
    }

    IEnumerator SpawnWait(int second){
        Debug.Log("spawn");
        yield return new WaitForSeconds(second);
        signSpawner.SpawnSign();
    }
}
