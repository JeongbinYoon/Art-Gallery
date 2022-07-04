using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Photon.Pun; 

public class PlayerMovementPun : MonoBehaviourPun
{
    Animator _animator;
    Camera _camera;
    CharacterController _controller;

    public float speed = 5f;
    public float runSpeed = 8f;
    public float finalSpeed;
    public bool toggleCameraRotation;
    public bool run;

    public float smoothness = 10f;

    // public VideoPlayer video;

    void Start()
    {
        _animator = this.GetComponent<Animator>();
        _camera = Camera.main;
        _controller = this.GetComponent<CharacterController>();

        // video.GetComponent<VideoPlayer>();

    }

    void Update()
    {
        

        // 로컬 플레이어만 직접 위치 변경 가능
        if (!photonView.IsMine)
        {
            return;
        }

        if(Input.GetKey(KeyCode.LeftAlt)){
            toggleCameraRotation = true; // 둘러보기 활성화
        }
        else
        {
            toggleCameraRotation = false; // 둘러보기 비활성화
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }


        InputMovement();
    }

    void LateUpdate()
    {
        // 로컬 플레이어만 직접 회전 변경 가능
        if (!photonView.IsMine)
        {
            return;
        }
        if(toggleCameraRotation != true)
        {
            Vector3 playerRotate = Vector3.Scale(_camera.transform.forward, new Vector3(1, 0, 1));
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
        }
    }
    void InputMovement() 
    {
        finalSpeed = (run) ? runSpeed : speed;

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical");
        // Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxisRaw("Horizontal");

        _controller.Move(moveDirection.normalized * finalSpeed * Time.deltaTime);

        
        // 입력값에 따라 애니메이터의 Move 파라미터 값을 변경

        float percent = ((run) ? 1 : 0.5f) * moveDirection.magnitude;
        _animator.SetFloat("Blend", percent, 0.1f, Time.deltaTime);
    }

    // private void OnTriggerEnter (Collider other)
    // {
    //     if (other.tag == "VideoPlayer")
    //     {
    //         video.Play();
    //     }

    //     if(other.tag == "VideoPlayer_stopBtn")
    //     {
    //         video.Stop();
    //     }

    // }
    // private void OnTriggerExit (Collider other)
    // {
    //     if (other.tag == "VideoPlayer")
    //     {
    //         video.Pause();
    //     }

    // }

}
