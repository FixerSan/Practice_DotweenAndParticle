using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DOMove (������ ��ǥ(Vector2 or 3), �����ϴ� �ð�)
        //transform.DOMove(new Vector3(5, -5, 0), 3);

        //DOMoveX (������ X��ǥ, �����ϴ� �ð�)
        //transform.transform.DOMoveX(1, 5);

        //DOJump (������ ��ǥ(Vector2 or 3), ������ ����, ���� Ƚ��, �����ϴ� �ð�, ���� �̵�)
        //transform.DOJump(new Vector3(3, 0, 0), 5, 5, 3, false);

        //DORotate (ȸ���� ��(Vector2 or 3), ȸ���ϴ� �ð�, ȸ�� ���)
        //transform.DORotate(new Vector3(180, 90, 0), 3, RotateMode.Fast);

        //DOLookat (�ٶ� ��ǥ, ȸ���ϴ� �ð�, ȸ�� ���)
        transform.DORotate(new Vector3(70, 50, 0), 3, RotateMode.Fast).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
