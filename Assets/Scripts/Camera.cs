using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Vectores para limitar la camara
    public Vector2 limitX;
    public Vector2 limitY;

    public float interpolationRatio;


    // Start is called before the first frame update
    void LateUpdate()
    {
        if(target != null && gameManager.isGameOver == false)
        {
            //posicion deseada de la camara
        Vector3 desiredPosition = target.position + offset;

        float clampX = Mathf.Clamp(desiredPosition.x, limitX.x , limitX.y);

        float clampY = Mathf.Clamp(desiredPosition.y, limitY.x , limitY.y);

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

        Vector3 lerpedPosition = Vector3.Lerp(transform.position, clampedPosition, interpolationRatio); 

        transform.position = lerpedPosition;
    }
       
    }

    
    
}
