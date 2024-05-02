using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour
{
    public float speed = 5f;
    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving){
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    public void StartMovement(){
        isMoving = true;
        StartCoroutine(MoveTime());
    }

    public void StopMoving(){
        isMoving = false;
    }

    IEnumerator MoveTime(){
        yield return new WaitForSeconds(5.1f);
        StopMoving();
    }
}
