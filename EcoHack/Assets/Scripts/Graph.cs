using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Dictionary<string, float> graphValues = new Dictionary<string, float>();
    public UIManager uI;
    public Transform cube;
    float index = -2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddGraph()
    {
        if (index <= 2)
        {
            graphValues.Add(uI.dateInput.text, uI.miles);
            Transform cubeInstance = Instantiate(cube, transform.position + Vector3.right * index * 2 + graphValues[uI.dateInput.text] / 2 * Vector3.up, Quaternion.identity);
            cubeInstance.localScale = new Vector3(2, graphValues[uI.dateInput.text], 2);
            index++;
        }
    }
}
