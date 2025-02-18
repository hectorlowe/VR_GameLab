using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class VRPlayerWeaponsManager : MonoBehaviour
{
    public WeaponController ActiveWeapon;

    public InputActionProperty inputActionReference_Fire;
    public InputActionProperty inputActionReference_Reload;

    private bool m_shouldFire;

    private int m_currentAmmo;

    [SerializeField]
    private int clipSize = 10;

    private void OnEnable()
    {
        inputActionReference_Fire.action.performed += ActivateFire;
        inputActionReference_Reload.action.performed += ActivateReload;
    }

    private void ActivateFire(InputAction.CallbackContext obj)
    {
        if (m_currentAmmo > 0)
        {
            m_shouldFire = true;
            m_currentAmmo--;
        }
    }

    public int GetCurrentAmmo()
    {
        return m_currentAmmo;
    }

    private void ActivateReload(InputAction.CallbackContext obj)
    {
        ActiveWeapon.StartReloadAnimation();
        m_currentAmmo = clipSize;
    }

    void Start()
    {
        m_currentAmmo = clipSize;
    }

    void Update()
    {
        if (ActiveWeapon != null)
        {
            bool tempShouldFire = m_shouldFire;
            m_shouldFire = false;

            ActiveWeapon.HandleShootInputs(tempShouldFire, tempShouldFire, false);
        }
    }


}
