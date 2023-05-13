/*
 Firearm Firing Mode Transition Script
 Version: 1.0
 Unity: 2018.3 or later
 
 Description:
 This script allows a firearm in a game to transition between full auto and burst fire firing modes.
 It provides a customizable burst fire functionality with adjustable burst count and delay between shots.
 
 Usage:
 1. Attach this script to the GameObject representing your firearm in the Unity Editor.
 2. Set up the appropriate input bindings for firing in the Unity Input Manager.
 3. Customize the Fire() method to implement the actual firing logic for your firearm.
 
 Author: CireWire
 GitHub: https://github.com/CireWire
 
 */

// This script assumes you have already set up the necessary input bindings for switching between modes.

using UnityEngine;
using System.Collections;

public class Firearm : MonoBehaviour
{
    public enum FirearmFiringMode
    {
        FullAuto,
        Burst
    }

    public FiringMode currentFiringMode = FiringMode.FullAuto;
    public int burstFireCount = 3;
    public float burstFireDelay = 0.1f;

    private bool isFiring;
    private float fireTimer;
    private int shotsFired;

    private void Update()
    {
        // Check for firing input
        if (Input.GetButtonDown("Fire1"))
        {
            isFiring = true;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            isFiring = false;
        }

        // Handle firing based on firing mode
        switch (currentFiringMode)
        {
            case FiringMode.FullAuto:
                HandleFullAutoFire();
                break;
            case FiringMode.Burst:
                HandleBurstFire();
                break;
        }
    }

    private void HandleFullAutoFire()
    {
        if (isFiring)
        {
            // Fire continuously while the Fire button is held down
            Fire();
        }
    }

    private void HandleBurstFire()
    if (isFiring && shotsFired < burstFireCount)
    {
        // Fire in bursts with a delay between each shot
        fireTimer += Time.deltaTime;
        if (fireTimer >= burstFireDelay)
        {
            Fire();
            shotsFired++;
            fireTimer = 0f;
        }
    }
    else if (shotsFired >= burstFireCount)
    {
        isFiring = false; // Stop firing after the burst is complete
    }

    private void Fire()
    {
        // Insert your firing code here
        Debug.Log("Firing!");
    }
}
