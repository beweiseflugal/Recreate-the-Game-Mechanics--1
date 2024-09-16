using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleRotate : MonoBehaviour
{
    public float degreesPerSec = 360f;
    bool isLeft = true;

    void Update()
    {
        float rotation = degreesPerSec * Time.deltaTime;
        float currentRotation = transform.localRotation.eulerAngles.z;

        if (Input.GetMouseButtonDown(0)){
            isLeft = !isLeft;
        }

        if (isLeft){
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRotation + rotation));
        }

        else{
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRotation - rotation));
        }
    }
}
