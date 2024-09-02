using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
   [Header("Sensitivity")]
   public float sensX;
   public float sensY;

   public Transform orientation;

   float yRot;
   float xRot;

   private void Start()
   {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
   }

   private void Update()
   {
    float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
    float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

    yRot += mouseX;
    xRot -= mouseY;
    xRot = Mathf.Clamp(xRot, -90f, 90f);

    transform.rotation = Quaternion.Euler(xRot,yRot,0);
    orientation.rotation = Quaternion.Euler(0,yRot,0);

   }
}
