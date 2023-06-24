using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private AudioSource spaceShipEngine;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigiBody;
    private float boolSound = 0;

    private void OnEnable(){
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigiBody = gameObject.GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate(){
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, yVal);
        rigiBody.velocity = movement * speed;
        

        if(xVal !=0 && yVal !=0){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal)*Mathf.Rad2Deg, transform.eulerAngles.z);
            boolSound++;
            PlaySound();
        }
        else{
            spaceShipEngine.Stop();
            boolSound = 0;
        }
        
    }

    private void PlaySound(){
        if(boolSound == 1){
            spaceShipEngine.Play();
            //Debug.Log(boolSound);
        }
            

    }
}
