using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        Vector2 inputDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = inputDirection;
    }
}
