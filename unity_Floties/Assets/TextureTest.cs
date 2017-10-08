using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDance : MonoBehaviour {
    public void GetJiggy()
    { 
        transform.Translate(Vector3.forward * 3000);
    }
}
