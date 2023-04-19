using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE
    {
        PLAYER,
        MONSTER
    }

    public Vector3 launchDirection;                         //�߻� ����

    public PROJECTILETYPE projectileType;
    private void FixedUpdate()
    {
        float moveAmount = 10 * Time.fixedDeltaTime;             //�̵� �ӵ� ����
        transform.Translate(launchDirection * moveAmount);      //Translate �� �̵�
    }
    //private void OnCollisionEnter(Collision collision)          //�浹�� �Ͼ�� ���
    //{
    //    Debug.Log(collision.gameObject.name);
    //    if (collision.gameObject.tag == "Object")               //Tag ���� ������Ʈ �� ���
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    if (collision.gameObject.tag == "Monster")               //Tag ���� ������Ʈ �� ���
    //    {
    //        Destroy(this.gameObject);
    //        collision.gameObject.GetComponent<Monster>().Damaged(1);
    //    }
    //}

    private void OnTriggerEnter(Collider other)                 //Ʈ���� ���� �Լ�
    {
        if (other.CompareTag("Monster") && projectileType == PROJECTILETYPE.PLAYER)                        //Tag �� �˻��Ѵ�.
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<Monster>().Damaged(1);
        }

        if (other.CompareTag("Player") && projectileType == PROJECTILETYPE.MONSTER)                        //Tag �� �˻��Ѵ�.
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<PlayerHp>().Damaged(1);
        }
    }
}