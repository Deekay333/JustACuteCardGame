using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class cardMove : MonoBehaviour
{
    new Vector3 mousePos = Vector3.zero;
    private void Update()
    {
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;
        mousePos.z = 0;
        Debug.Log("pos" + transform.position);
        Debug.Log("mouse" +  mousePos);
        Vector2.MoveTowards(transform.position, mousePos, 1000);
    }
    public void holdCard()
    {
        Vector2.MoveTowards(transform.position, mousePos, 1);
    }
}
