using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.EventSystems;

public class AdvScript : MonoBehaviour
{
    float movedownY = 5.0f;
    float sensitivityY = 0.1f;

    public void OnPointerClick (PointerEventData eventData) {
         if (eventData.button == PointerEventData.InputButton.Right) {
            movedownY += Input.GetAxis("Mouse Y") * sensitivityY;
            transform.Translate(Vector3.forward * movedownY);
         }
    }
}
