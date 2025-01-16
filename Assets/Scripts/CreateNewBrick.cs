using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBrick : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject table;
    public Material thisMaterial;
    public Vector3 offset;
    private Vector3 brickPosition;
    
    void Start()
    {
        brickPosition = table.transform.position + offset;
        GetComponent<MeshRenderer> ().material = thisMaterial;
    }
    
     public void CreateBrick()
     {
        GameObject thisBrick = Instantiate(brickPrefab, brickPosition, Quaternion.identity);
        thisBrick.GetComponent<MeshRenderer> ().material = thisMaterial;
     }
}
