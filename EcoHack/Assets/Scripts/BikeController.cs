using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    //public Transform road;
    public Transform wheel1;
    public Transform wheel2;
    public Transform pedals;
    public Transform pedal1;
    public Transform pedal2;
    public float speed;
    public float pedalSpeed;
    public float wheelSpeed;
    public float distance;
    public UIManager uIManager;
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //road.localScale = new Vector3(distance, 1, 1);
        //road.position = Vector3.right * distance / 2;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        pedal1.eulerAngles = Vector3.up * 90;
        pedal2.eulerAngles = Vector3.up * 90;
    }
    public void StartBike()
    {
        StopAllCoroutines();
        StartCoroutine(MoveBike());
    }
    IEnumerator MoveBike()
    {
        transform.position = Vector3.up;
        distance = uIManager.miles;
        while (transform.position.x < distance * 10)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //rb.MovePosition(Vector3.forward * Time.deltaTime * speed);
            wheel1.Rotate(Vector3.right * Time.deltaTime * wheelSpeed);
            wheel2.Rotate(Vector3.right * Time.deltaTime * wheelSpeed);
            pedals.Rotate(Vector3.right * Time.deltaTime * pedalSpeed);
            yield return null;
        }

        
    }
}
