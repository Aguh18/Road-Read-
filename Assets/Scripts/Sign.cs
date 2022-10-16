using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MoveLeft
{
    [SerializeField] SpriteRenderer spriteSign;
    [SerializeField] private SignSpawner signSpawner;

    
    private void Start() {
        spriteSign = GetComponent<SpriteRenderer>();
        spriteSign.sprite = signSpawner.getRandomSprite();
        QuizManager.Instance.setJawabanBenar(signSpawner.getJawabanBenar());
        QuizManager.Instance.GenerateQuiz();
    }
    private void Update() {
        Move();
    }

}
