using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DOMove (도착할 좌표(Vector2 or 3), 도달하는 시간)
        //transform.DOMove(new Vector3(5, -5, 0), 3);

        //DOMoveX (도착할 X좌표, 도달하는 시간)
        //transform.transform.DOMoveX(1, 5);

        //DOJump (도달할 좌표(Vector2 or 3), 점프의 세기, 점프 횟수, 도달하는 시간, 정수 이동)
        //transform.DOJump(new Vector3(3, 0, 0), 5, 5, 3, false);

        //DORotate (회전할 값(Vector2 or 3), 회전하는 시간, 회전 모드)
        //transform.DORotate(new Vector3(180, 90, 0), 3, RotateMode.Fast);

        //DOLookat (바라볼 좌표, 회전하는 시간, 회전 모드)
        transform.DORotate(new Vector3(70, 50, 0), 3, RotateMode.Fast).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
