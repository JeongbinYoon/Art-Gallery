using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   
    Camera _camera;
    public Transform objectTofollow;
    public float followSpeed = 10f;
    public float sensitivity = 100f;
    public float clampAngle = 70f;

    private float rotX;
    private float rotY;

    public Transform realCamera;
    public Vector3 dirNormalized;
    public Vector3 finalDir;
    public float minDistance;
    public float maxDistance;
    public float finalDistance;
    public float smoothness = 10f;



    public Transform spPoint; // SpawnPoint 

    float moveSpeed = 1f;
    float rotSpeed = 120f;
    void Start()
    {
        
    }

    void Update()
    {
        // 현재 프레임에서 이동할 거리
        float amount = moveSpeed * Time.deltaTime ;

        // 현재 프레임에서 회전할 각도
        float amountRot = rotSpeed * Time.deltaTime ;

        // 전후진 이동 키 ( W or S)
        float vert = Input.GetAxis("Vertical");

        // 좌우 이동 키 (A or D)
        float horz = Input.GetAxis("Horizontal");

        // 키보드 방향으로 이동
        transform.Translate(Vector3.forward * amount * vert);

        // 좌우로 회전
        transform.Rotate(Vector3.up * amountRot * horz);
    }

    void LateUpdate()
    {
         transform.position = Vector3.MoveTowards(transform.position, objectTofollow.position, followSpeed * Time.deltaTime)    ;

        finalDir = transform.TransformPoint(dirNormalized * maxDistance);

        RaycastHit hit;

        if(Physics.Linecast(transform.position, finalDir, out hit))
        {
            finalDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
        }
        else{
            finalDistance = maxDistance;
        }
        realCamera.localPosition = Vector3.Lerp(realCamera.localPosition, dirNormalized * finalDistance, Time.deltaTime * smoothness);
        
    }
}
