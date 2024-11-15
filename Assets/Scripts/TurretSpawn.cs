using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawn : MonoBehaviour
{
    [SerializeField] private Camera PlayerCam;

    private GameObject turretPlacement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turretPlacement != null)
        {
            Ray camRay = PlayerCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(camRay, out RaycastHit hitInfo, 100f))
            {
                turretPlacement.transform.position = hitInfo.point;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            turretPlacement = null;
        }
    }

    public void SetTurretPlacement(GameObject turret)
    {
        turretPlacement = Instantiate(turret, Vector3.zero, Quaternion.identity);
    }
}
