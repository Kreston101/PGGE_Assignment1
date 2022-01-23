using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGGE
{
    // The base class for all third-person camera controllers
    public abstract class TPCBase
    {
        protected Transform mCameraTransform;
        protected Transform mPlayerTransform;

        public Transform CameraTransform
        {
            get
            {
                return mCameraTransform;
            }
        }
        public Transform PlayerTransform
        {
            get
            {
                return mPlayerTransform;
            }
        }

        public TPCBase(Transform cameraTransform, Transform playerTransform)
        {
            mCameraTransform = cameraTransform;
            mPlayerTransform = playerTransform;
        }

        public void RepositionCamera()
        {
            //-------------------------------------------------------------------
            // Implement here.
            //-------------------------------------------------------------------
            //-------------------------------------------------------------------
            // Hints:
            //-------------------------------------------------------------------
            // check collision between camera and the player.
            // find the nearest collision point to the player
            // shift the camera position to the nearest intersected point
            //-------------------------------------------------------------------

            //raycast distance, since we dont need the racast to intersect a faraway wall
            //on accident
            float dist = 3;
            //vector from the players approximated head height to camera
            //this ensures that the camera looks at the players head and
            //not their feet
            Vector3 playerHeightPadding = mPlayerTransform.position + Vector3.up * 2;
            Vector3 playerToCamVector = mCameraTransform.position - playerHeightPadding;

            //raycast to check for obstructionsS
            if (Physics.Raycast(playerHeightPadding, playerToCamVector, out RaycastHit hit, dist))
            {
                Debug.DrawRay(playerHeightPadding, playerToCamVector * hit.distance, Color.blue);
                //shifts camera to the intersected position
                mCameraTransform.position = hit.point;
            }
        }

        public abstract void Update();
    }
}
