using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    public float mouseSpeed = 100f;
    
    public Transform playerBody;

    private float xRotation = 0f;
    private float degree;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //playerBody.Rotate(Vector3.up * Time.deltaTime * );
    }
    public void LockMouse()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        StopAllCoroutines();
        StartCoroutine(SpinCamera());
        
    }
    IEnumerator SpinCamera()
    {
        yield return new WaitForSeconds(1);
        degree = 0;
        do
        {
            playerBody.Rotate(Vector3.up * Time.deltaTime * 20);
            degree += Time.deltaTime * 20;
            yield return null;
        }
        while (degree <= 360);
    }
}
