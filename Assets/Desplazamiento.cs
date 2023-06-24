using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{
    private Vector3 InitPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InitPos = transform.position;
        FinalPos = InitPos + DestPos * Time.deltaTime * speed;
        transform.position = FinalPos;
    }
}
