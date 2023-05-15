using System.Collections;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public TurretBlueprint standardTurret;
    public TurretBlueprint misseleLauncher;
    public TurretBlueprint laserBeamer;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandartTurret()
    {
        Debug.Log("Standart Turret selected!");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissleTurret()
    {
        Debug.Log("Missle Turret selected!");
        buildManager.SelectTurretToBuild(misseleLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("LaserBeamer Turret selected!");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
