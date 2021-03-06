using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaleBlue
{
    public class PlayerManager : MonoBehaviour
    {
        InputManager inputManager;
        CameraManager cameraManager;
        PlayerLocomotion playerLocomotion;

        public void Awake()
        {
            inputManager = GetComponent<InputManager>(); //check for object with input manager comp
            cameraManager = FindObjectOfType<CameraManager>(); //find camera manager
            playerLocomotion = GetComponent<PlayerLocomotion>(); //check for object with locomotion comp

            Cursor.visible = false;
        }

        private void Update()
        {
            inputManager.HandleAllInput();
        }

        private void FixedUpdate()
        {
            playerLocomotion.HandleAllMovement();
        }

        private void LateUpdate() //lateUpdate = recommended when using fixedUpdate on rb, calls update after frame ended
        {
            cameraManager.HandleAllCameramovement(); //follow player
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Abyss") //if collision with object with Abyss tag
            {
                transform.position = new Vector3(0, 1.81f, -8.879506f); //respawn @ start
            }
        }
    }
}