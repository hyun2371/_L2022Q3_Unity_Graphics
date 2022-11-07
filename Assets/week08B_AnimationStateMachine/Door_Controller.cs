using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject Pivot;

    ////isTrigger unchecked
    //private void OnCollisionEnter(Collision collision)
    //{
    //    print(collision.gameObject.name);  //충돌한 계임 오브젝트 이름 출력

    //}

    private void OnTriggerEnter(Collider other)
    {
        print("enter "+other.name);
        //Pivot.GetComponent<Animator>().SetInteger("State",1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit "+other.name);
        //Pivot.GetComponent<Animator>().SetInteger("State", 0);
    }
}
